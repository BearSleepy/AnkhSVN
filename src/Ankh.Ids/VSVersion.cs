// Copyright 2009 The AnkhSVN Project
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
#if AS_BUILD_REPLACED
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.IO;
using Microsoft.VisualStudio.Shell.Interop;
using System.Text.RegularExpressions;
#endif // AS_BUILD_REPLACED

namespace Ankh
{
	public static class AnkhVersion
	{
		public static string AssemblyVersion
		{
			get { return AnkhId.AssemblyVersion; }
		}

		public static Version FullVersion
		{
			// dont try to cache this value, it wont be up very often
			get { return System.Version.Parse(AnkhId.AssemblyVersion); }
		}
	}


	public static class VSVersion
	{
#if VS_17_ENV
		internal const int major = 17;
#elif VS_15_ENV
		internal const int major = 15;
#elif VS_12_ENV
		internal const int major = 12;
#elif VS_11_ENV
		internal const int major = 11;
#elif VS_10_ENV
		internal const int major = 10;
#endif
#if VS_17_ENV
		internal const string smajor = "17";
#elif VS_15_ENV
		internal const string smajor = "15";
#elif VS_12_ENV
		internal const string smajor = "12";
#elif VS_11_ENV
		internal const string smajor = "11";
#elif VS_10_ENV
		internal const string smajor = "10";
#endif

#if VS_17_ENV
		internal const string nameVersion = "2022";
#elif VS_15_ENV
		internal const string nameVersion = "2017";
#elif VS_12_ENV
		internal const string nameVersion = "2013";
#elif VS_11_ENV
		internal const string nameVersion = "2012";
#elif VS_10_ENV
		internal const string nameVersion = "2010";
#endif
		internal const string majorMinor = smajor + ".0";

		internal const string name = "Visual Studio " + nameVersion;

		public static int Major
		{
			get { return major; }
		}

		public static Version FullVersion
		{
			get { return new Version(major, 0); }
		}

		public static bool VS2013OrLater
		{
			get { return major >= 12; }
		}

		public static bool VS2012OrLater
		{
			get { return major >= 11; }
		}

		public static bool VS2010OrLater
		{
			get { return major >= 10; }
		}

#if AS_BUILD_REPLACED
		static Version _vsVersion;
		static Version _osVersion;

		public static Version OSVersion
		{
			get { return _osVersion ?? (_osVersion = Environment.OSVersion.Version); }
		}

		public static bool VS2013OrLater
		{
			get { return FullVersion.Major >= 12; }
		}

		public static bool VS2012OrLater
		{
			get { return FullVersion.Major >= 11; }
		}

		public static bool VS2010OrLater
		{
			get { return FullVersion.Major >= 10; }
		}

		public static Version FullVersion
		{
			get
			{
				return _vsVersion ?? (_vsVersion = GetFullVersion());
			}
		}


		const int VSSPROPID_ReleaseVersion = -9068; // VS 12+

		public static void Ensure(IServiceProvider context)
		{
			if (FullVersion.Major == 0)
			{
				// Use the old DTE api in an attempt to get the version
				Version ver;
				if (TryGetDteVersion(context, out ver))
					_vsVersion = ver;
			}

			if (FullVersion.Major == 0)
			{
				string versionStr = null;

				// VS 2012 has a shell property
				IVsShell shell = context.GetService(typeof(SVsShell)) as IVsShell;
				if (shell != null)
				{
					object v;
					if (VSErr.Succeeded(shell.GetProperty(VSSPROPID_ReleaseVersion, out v)))
						versionStr = v as string;
				}

				if (!string.IsNullOrEmpty(versionStr))
					ParseVersion(versionStr);
			}
		}

		static bool TryGetDteVersion(IServiceProvider context, out Version version)
		{
			version = null;
			Type dteType = Type.GetType("EnvDTE._DTE, EnvDTE, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", false);

			if (dteType == null)
				return false;

			Object dte = context.GetService(typeof(SDTE));

			if (dte == null)
				return false;

			System.Reflection.MethodInfo method = dteType.GetMethod("get_Version");

			if (method == null)
				return false;

			string verStr = method.Invoke(dte, null) as string;

			if (verStr != null)
			{
				version = new Version(verStr);
				return true;
			}

			return false;
		}

		static void ParseVersion(string value)
		{
			if (string.IsNullOrEmpty(value))
				return;

			value = value.Trim();

			Regex re = new Regex("^[0-9]+(\\.[0-9]+){0,3}"); // Avoid suffix. No compilation necessary
			Match m = re.Match(value);
			if (m.Success)
				_vsVersion = new Version(m.Value);
		}


		static Version GetFullVersion()
		{
			var vsVersion = new Version(0, 0);	// Assume not running inside Visual Studio!

			string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "msenv.dll");

			if (File.Exists(path))
			{
				FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(path);
				string verName = null;

				if (fvi != null)
					verName = fvi.ProductVersion ?? fvi.FileVersion;

				if (!string.IsNullOrEmpty(verName))
				{
					for (int i = 0; i < verName.Length; i++)
					{
						if (!char.IsDigit(verName, i) && verName[i] != '.')
						{
							verName = verName.Substring(0, i);
							break;
						}
					}

					vsVersion = new Version(verName);
				}
			}

			return vsVersion;
		}
#endif // AS_BUILD_REPLACED
	}
}
