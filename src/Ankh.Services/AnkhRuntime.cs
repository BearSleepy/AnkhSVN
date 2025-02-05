// Copyright 2008-2009 The AnkhSVN Project
//
//  Licensed under the Apache License, Version 2.0 (the "License");
//  you may not use this file except in compliance with the License.
//  You may obtain a copy of the License at
//
//    http://www.apache.org/licenses/LICENSE-2.0
//
//  Unless required by applicable law or agreed to in writing, software
//  distributed under the License is distributed on an "AS IS" BASIS,
//  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//  See the License for the specific language governing permissions and
//  limitations under the License.

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.Design;
using Ankh.Commands;
using System.Diagnostics;
using System.Reflection;
using Ankh.UI;
using System.Threading;
using System.Runtime.InteropServices;

namespace Ankh
{
	public class AnkhRuntime : IAnkhServiceProvider
	{
		readonly IServiceContainer _container;
		readonly CommandMapper _commandMapper;
		readonly AnkhContext _context;
		readonly List<IAnkhServiceImplementation> _services = new List<IAnkhServiceImplementation>();
		bool _ensureServices;
		bool _servicesLoaded;
		static AnkhRuntime _runtimeInstance;

		public AnkhRuntime(IServiceContainer parentContainer)
		{
			if (parentContainer == null)
				throw new ArgumentNullException("parentContainer");

			_container = parentContainer;

			_commandMapper = GetService<CommandMapper>();
			if (_commandMapper == null)
				_container.AddService(typeof(CommandMapper), _commandMapper = new CommandMapper(this));

			_context = GetService<AnkhContext>();
			if (_context == null)
				_container.AddService(typeof(AnkhContext), _context = AnkhContext.Create(this));

			InitializeServices();

			if (_runtimeInstance == null)
				_runtimeInstance = this;
		}

		public AnkhRuntime(IServiceProvider parentProvider)
			: this((parentProvider as IServiceContainer) ?? new AnkhServiceContainer(parentProvider))
		{
			if (parentProvider == null)
				throw new ArgumentNullException("parentProvider");
		}

#if AS_BUILD_REPLACED
		public void PreLoad()
		{
			VSVersion.Ensure(this);
		}
#endif // AS_BUILD_REPLACED

		void InitializeServices()
		{
			if (_servicesLoaded)
				return;

			if (GetService<AnkhRuntime>() == null)
			{
				_container.AddService(typeof(AnkhRuntime), this, true);

				if (_container.GetService(typeof(IAnkhServiceProvider)) == null)
					_container.AddService(typeof(IAnkhServiceProvider), this);
			}

			if (GetService<AnkhServiceEvents>() == null)
			{
				AnkhServiceEvents se = new AnkhServiceEvents(Context);
				_container.AddService(typeof(AnkhServiceEvents), se);
				_container.AddService(typeof(IAnkhServiceEvents), se);
			}

			if(GetService<SynchronizationContext>() == null)
				_container.AddService(typeof(SynchronizationContext), new System.Windows.Forms.WindowsFormsSynchronizationContext());

#if DEBUG
			PreloadServicesViaEnsure = true;
#endif
			// If the parent container is not hooked up yet, we have to reinitialize later!
			_servicesLoaded = (GetService<AnkhRuntime>() != null);
		}

		/// <summary>
		/// Gets or sets a value indicating whether all modules must preload their services
		/// </summary>
		/// <value><c>true</c> if all services should preload their required services, otherwise <c>false</c>.</value>
		public bool PreloadServicesViaEnsure
		{
			get { return _ensureServices; }
			set { _ensureServices = value; }
		}

		#region IAnkhServiceProvider Members

		/// <summary>
		/// Gets the service.
		/// </summary>
		/// <typeparam name="T">The type of service to get</typeparam>
		/// <returns>
		/// A service object of type <typeparamref name="T"/>.-or- null if there is no service object of type <typeparamref name="T"/>.
		/// </returns>
		[DebuggerStepThrough]
		public T GetService<T>()
			where T : class
		{
			return GetService<T>(typeof(T));
		}

		/// <summary>
		/// Gets the service of the specified type safely casted to T
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="type">The type.</param>
		/// <returns></returns>
		[DebuggerStepThrough]
		public T GetService<T>(Type type)
			where T : class
		{
			return GetService(type) as T;
		}

		#endregion

		#region IServiceProvider Members

		/// <summary>
		/// Gets the service object of the specified type.
		/// </summary>
		/// <param name="serviceType">An object that specifies the type of service object to get.</param>
		/// <returns>
		/// A service object of type <paramref name="serviceType"/>.-or- null if there is no service object of type <paramref name="serviceType"/>.
		/// </returns>
		[DebuggerStepThrough]
		public object GetService(Type serviceType)
		{
			return _container.GetService(serviceType);
		}

		#endregion

		/// <summary>
		/// Gets the command mapper.
		/// </summary>
		/// <value>The command mapper.</value>
		public CommandMapper CommandMapper
		{
			get { return _commandMapper; }
		}

		/// <summary>
		/// Gets the single context instance
		/// </summary>
		/// <value>The context.</value>
		public AnkhContext Context
		{
			get { return _context; }
		}

		readonly List<Module> _modules = new List<Module>();

		public void AddModule(Module module)
		{
			InitializeServices();

			_modules.Add(module);

			module.OnPreInitialize();
		}

		public void Start()
		{
			InitializeServices();

			foreach (Module module in _modules)
			{
				module.OnInitialize();
			}

			foreach (IAnkhServiceImplementation service in _services)
			{
				service.OnInitialize();
			}

			AnkhServiceEvents events = GetService<AnkhServiceEvents>();
			if (events != null)
			{
				events.OnRuntimeLoaded(EventArgs.Empty);
				events.OnRuntimeStarted(EventArgs.Empty);
			}
		}

		public static AnkhRuntime Get(IServiceProvider serviceProvider)
		{
			if (serviceProvider == null)
				throw new ArgumentNullException("serviceProvider");

			return serviceProvider.GetService(typeof(AnkhRuntime)) as AnkhRuntime;
		}

		readonly static Type[] _serviceConstructorParams = new Type[] { typeof(IAnkhServiceProvider) };

		/// <summary>
		/// Loads the services from the specified assembly and adds them to the container
		/// </summary>
		/// <param name="container">The container.</param>
		/// <param name="assembly">The assembly.</param>
		public void LoadServices(IServiceContainer container, System.Reflection.Assembly assembly)
		{
			LoadServices(container, assembly, Context);
		}

		/// <summary>
		/// Loads the services from the specified assembly and adds them to the specified container; pass context to the services
		/// </summary>
		/// <param name="container">The container.</param>
		/// <param name="assembly">The assembly.</param>
		/// <param name="context">The context.</param>
		public void LoadServices(IServiceContainer container, System.Reflection.Assembly assembly, IAnkhServiceProvider context)
		{
			if (assembly == null)
				throw new ArgumentNullException("assembly");
			else if (context == null)
				throw new ArgumentNullException("context");

			IAnkhStaticServiceRegistry staticContainer = container as IAnkhStaticServiceRegistry;

			object[] constructorArgs = null;
			foreach (Type type in assembly.GetTypes())
			{
				if (!type.IsClass || type.IsAbstract || type.IsNested || !Attribute.IsDefined(type, typeof(GlobalServiceAttribute), false))
					continue;

				if (!typeof(IAnkhServiceImplementation).IsAssignableFrom(type))
				{
#if DEBUG
					Debug.WriteLine(string.Format("Ignoring AnkhGlobalServiceAttribute on {0} as it does not implement IAnkhServiceImplementation", type.AssemblyQualifiedName));
#endif
					continue;
				}

				IAnkhServiceImplementation instance = null;

				foreach (GlobalServiceAttribute attr in type.GetCustomAttributes(typeof(GlobalServiceAttribute), false))
				{
					Type serviceType = attr.ServiceType;
#if DEBUG
					if (!serviceType.IsAssignableFrom(type))
						throw new InvalidOperationException(string.Format("{0} does not implement global service {1} but has an attribute that says it does", type.AssemblyQualifiedName, serviceType.FullName));
#endif
					if (!attr.Applies())
						continue;

					if (attr.AllowPreRegistered && null != (container.GetService(serviceType)))
						continue;

					if (instance == null)
					{
						try
						{
							ConstructorInfo ci = type.GetConstructor(
								BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.CreateInstance | BindingFlags.ExactBinding,
								null, _serviceConstructorParams, null);

							if (ci == null)
							{
								string msg = string.Format("Servicetype {0} has no valid contructor", type.AssemblyQualifiedName);
								Trace.WriteLine(msg);

								throw new InvalidOperationException(msg);
							}

							if (constructorArgs == null)
								constructorArgs = new object[] { context };

							instance = (IAnkhServiceImplementation)ci.Invoke(constructorArgs);
						}
						catch (Exception e)
						{
							AnkhMessageBox mb = new AnkhMessageBox(Context);

							mb.Show(e.ToString());
							continue;
						}
					}
#if DEBUG
					if (attr.PublicService && !Marshal.IsTypeVisibleFromCom(serviceType))
						Trace.WriteLine(string.Format("ServiceType {0} is not visible from com, but promoted", serviceType.AssemblyQualifiedName));
#endif
					if (staticContainer != null)
						staticContainer.AddStaticService(serviceType, instance, attr.PublicService);
					else
						container.AddService(serviceType, instance, attr.PublicService);
				}

				if (instance != null)
				{
					_services.Add(instance);
					instance.OnPreInitialize();
				}
			}
		}

		internal static IAnkhServiceProvider StaticContext
		{
			get { return _runtimeInstance; }
		}
	}
}
