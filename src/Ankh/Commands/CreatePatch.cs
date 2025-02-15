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
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Forms;
using Ankh.Scc;
using Ankh.VS;
using Ankh.UI.PathSelector;

namespace Ankh.Commands
{
	[SvnCommand(AnkhCommand.CreatePatch)]
	class CreatePatch : CommandBase
	{
		public override void OnUpdate(CommandUpdateEventArgs e)
		{
			PendingChange.RefreshContext rc = null;
			foreach (SvnItem i in e.Selection.GetSelectedSvnItems(true))
			{
				if (PendingChange.IsPending(i))
				{
					PendingChange pc;

					if (rc == null)
						rc = new PendingChange.RefreshContext(e.Context);

					if (PendingChange.CreateIfPending(rc, i, out pc))
					{
						if (pc.IsNoChangeForPatching())
							continue;
					}
					return;
				}
			}
			e.Enabled = false;
		}

		public override void OnExecute(CommandEventArgs e)
		{
			IPendingChangesManager pcm = e.GetService<IPendingChangesManager>();

			PendingChange.RefreshContext rc = new PendingChange.RefreshContext(e.Context);
			Dictionary<string, PendingChange> selectedChanges = new Dictionary<string, PendingChange>(StringComparer.OrdinalIgnoreCase);
			List<SvnItem> resources = new List<SvnItem>();
			foreach (SvnItem item in e.Selection.GetSelectedSvnItems(true))
			{
				PendingChange pc;

				if (PendingChange.CreateIfPending(rc, item, out pc))
				{
					if (!pc.IsNoChangeForPatching())
					{
						selectedChanges.Add(pc.FullPath, pc);
						resources.Add(pc.SvnItem);
					}
				}
			}

			if (resources.Count == 0)
				return;

			using (PendingChangeSelector pcs = new PendingChangeSelector())
			{
				pcs.Text = Resources.CreatePatchTitle;
				pcs.PreserveWindowPlacement = true;
				pcs.LoadItems(resources);

				DialogResult dr = pcs.ShowDialog(e.Context);

				if (dr != DialogResult.OK)
					return;

				string fileName = GetFileName(e.Context.DialogOwner);
				if (string.IsNullOrEmpty(fileName))
				{
					return;
				}

				PendingChangeCreatePatchArgs pca = new PendingChangeCreatePatchArgs();
				pca.FileName = fileName;
				IAnkhSolutionSettings ss = e.GetService<IAnkhSolutionSettings>();
				pca.RelativeToPath = ss.ProjectRoot;
				pca.AddUnversionedFiles = true;

				List<PendingChange> patchChanges = new List<PendingChange>(pcs.GetSelection());
				e.GetService<IPendingChangeHandler>().CreatePatch(patchChanges, pca);
			}
		}

		private static string GetFileName(IWin32Window dialogOwner)
		{
			string fileName = null;
			using (SaveFileDialog dlg = new SaveFileDialog())
			{
				dlg.Filter = "Patch files( *.patch)|*.patch|Diff files (*.diff)|*.diff|" +
					"Text files (*.txt)|*.txt|All files (*.*)|*";
				dlg.AddExtension = true;

				if (dlg.ShowDialog(dialogOwner) == DialogResult.OK)
				{
					fileName = dlg.FileName;
				}
			}
			return fileName;
		}
	}
}
