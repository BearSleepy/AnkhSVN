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
using SharpSvn;
using Ankh.UI.WizardFramework;

namespace Ankh.UI.MergeWizard
{
	internal class MergeUtils
	{
		public static readonly WizardMessage INVALID_FROM_REVISION = new WizardMessage(ResourcesMerge.InvalidFromRevision,
			WizardMessage.MessageType.Error);
		public static readonly WizardMessage INVALID_TO_REVISION = new WizardMessage(ResourcesMerge.InvalidToRevision,
			WizardMessage.MessageType.Error);
		public static readonly WizardMessage INVALID_FROM_URL = new WizardMessage(ResourcesMerge.InvalidFromUrl,
			WizardMessage.MessageType.Error);
		public static readonly WizardMessage INVALID_TO_URL = new WizardMessage(ResourcesMerge.InvalidToUrl,
			WizardMessage.MessageType.Error);
		public static readonly WizardMessage NO_FROM_URL = new WizardMessage(ResourcesMerge.NoFromUrl,
			WizardMessage.MessageType.Error);

		private IAnkhServiceProvider _context;
		private Dictionary<SvnDepth, string> _mergeDepths;
		ISvnClientPool _pool;

		/// <summary>
		/// Constructor.
		/// </summary>
		/// <param name="context">The context.</param>
		public MergeUtils(IAnkhServiceProvider context)
		{
			Context = context;
			_pool = Context.GetService<ISvnClientPool>();
			_pool?.EnsureClient();
		}

		/// <summary>
		/// Returns a key/value pairing of <code>SharpSvn.SvnDepth</code> as the key
		/// and a string description of the depth key.
		/// </summary>
		public Dictionary<SvnDepth, string> MergeDepths
		{
			get
			{
				if (_mergeDepths == null)
				{
					_mergeDepths = new Dictionary<SvnDepth, string>();

					_mergeDepths.Add(SvnDepth.Unknown, ResourcesMerge.SvnDepthUnknown);
					_mergeDepths.Add(SvnDepth.Infinity, ResourcesMerge.SvnDepthInfinity);
					_mergeDepths.Add(SvnDepth.Children, ResourcesMerge.SvnDepthChildren);
					_mergeDepths.Add(SvnDepth.Files, ResourcesMerge.SvnDepthFiles);
					_mergeDepths.Add(SvnDepth.Empty, ResourcesMerge.SvnDepthEmpty);
				}

				return _mergeDepths;
			}
		}

		/// <summary>
		/// Returns a list of strings for the suggested merge sources.
		/// </summary>
		internal SvnMergeSourcesCollection GetSuggestedMergeSources(SvnItem target)
		{
			using (SvnClient client = GetClient())
			{
				SvnMergeSourcesCollection mergeSources = null;
				SvnGetSuggestedMergeSourcesArgs args = new SvnGetSuggestedMergeSourcesArgs();

				args.ThrowOnError = false;

				client.GetSuggestedMergeSources(target.FullPath, args, out mergeSources);

				return mergeSources ?? new SvnMergeSourcesCollection();
			}
		}


		internal SvnMergeItemCollection GetAppliedMerges(SvnItem target)
		{
			using (SvnClient client = GetClient())
			{
				SvnGetAppliedMergeInfoArgs args = new SvnGetAppliedMergeInfoArgs();
				SvnAppliedMergeInfo mergeInfo;

				args.ThrowOnError = false;

				if (!client.GetAppliedMergeInfo(target.Uri, args, out mergeInfo))
					return null;

				return mergeInfo.AppliedMerges;
			}
		}

		/// <summary>
		/// Returns an instance of <code>SharpSvn.SvnClient</code> from the pool.
		/// </summary>
		public SvnClient GetClient()
		{
			if (_pool != null)
				return _pool.GetClient();
			else
				return new SvnClient();
		}

		public SvnWorkingCopyClient GetWcClient()
		{
			if(_pool != null)
				return _pool.GetWcClient();
			else
				return new SvnWorkingCopyClient();
		}

		/// <summary>
		/// Gets or sets the context.
		/// </summary>
		/// <value>The context.</value>
		public IAnkhServiceProvider Context
		{
			get { return _context; }
			set { _context = value; }
		}
	}
}
