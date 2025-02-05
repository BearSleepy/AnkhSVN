// Copyright 2003-2009 The AnkhSVN Project
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
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using Microsoft.VisualStudio;
using SharpSvn;
using SharpSvn.Remote;

using Ankh.Commands;
using Ankh.Configuration;
using Ankh.Scc;
using Ankh.UI.VSSelectionControls;
using Ankh.VS;


namespace Ankh.UI.RepositoryExplorer
{
	/// <summary>
	/// Gives a tree view of the repository based on revision.
	/// </summary>
	public partial class RepositoryExplorerControl : AnkhToolWindowControl
	{
		IAnkhConfigurationService _configurationService;
		protected IAnkhConfigurationService ConfigurationService
		{
			get { return _configurationService ?? (_configurationService = Context.GetService<IAnkhConfigurationService>()); }
		}

		public RepositoryExplorerControl()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			this.components = new Container();
			treeView.RetrieveItems = SvnDirEntryItems.Kind | SvnDirEntryItems.LastAuthor | SvnDirEntryItems.Revision | SvnDirEntryItems.Size | SvnDirEntryItems.Time;
		}

		protected override void OnFrameCreated(EventArgs e)
		{
			base.OnFrameCreated(e);

			ToolWindowHost.CommandContext = AnkhId.SccExplorerContextGuid;
			ToolWindowHost.KeyboardContext = AnkhId.SccExplorerContextGuid;

			VSCommandHandler.Install(Context, this, new CommandID(VSConstants.GUID_VSStandardCommandSet97, (int)VSConstants.VSStd97CmdID.Delete), OnDelete, OnUpdateDelete);
			VSCommandHandler.Install(Context, this, new CommandID(VSConstants.GUID_VSStandardCommandSet97, (int)VSConstants.VSStd97CmdID.Rename), OnRename, OnUpdateRename);
			VSCommandHandler.Install(Context, this, new CommandID(VSConstants.GUID_VSStandardCommandSet97, (int)VSConstants.VSStd97CmdID.Open), OnOpen, OnUpdateOpen);
			VSCommandHandler.Install(Context, this, AnkhCommand.ExplorerUp, OnUp, OnUpdateUp);

			IUIService ui = Context.GetService<IUIService>();

			if (ui != null)
			{
				ToolStripRenderer renderer = ui.Styles["VsToolWindowRenderer"] as ToolStripRenderer;

				if (renderer != null)
					toolFolders.Renderer = renderer;
			}
		}

		CommandMapper _mapper;
		CommandMapper CommandMapper
		{
			get
			{
				if (_mapper == null && Context != null)
					_mapper = Context.GetService<CommandMapper>();

				return _mapper;
			}
		}

		void OnUpdateDelete(object sender, CommandUpdateEventArgs e)
		{
			CommandMapper mapper = CommandMapper;

			if (mapper != null)
				mapper.PerformUpdate(AnkhCommand.SvnNodeDelete, e);
			else
				e.Enabled = false;
		}

		void OnDelete(object sender, CommandEventArgs e)
		{
			e.GetService<IAnkhCommandService>().PostExecCommand(AnkhCommand.SvnNodeDelete);
		}

		void OnUpdateRename(object sender, CommandUpdateEventArgs e)
		{
			CommandMapper mapper = CommandMapper;

			if (mapper != null)
				mapper.PerformUpdate(AnkhCommand.RenameRepositoryItem, e);
			else
				e.Enabled = false;
		}

		void OnRename(object sender, CommandEventArgs e)
		{
			e.GetService<IAnkhCommandService>().PostExecCommand(AnkhCommand.RenameRepositoryItem);
		}

		protected override void OnLoad(EventArgs e)
		{
			IServiceContainer container = Context.GetService<IServiceContainer>();

			if (container != null)
			{
				if (null == container.GetService(typeof(RepositoryExplorerControl)))
					container.AddService(typeof(RepositoryExplorerControl), this);
			}

			base.OnLoad(e);
			treeView.Context = Context;
			fileView.Context = Context;
			treeView.SelectionPublishServiceProvider = Context;
			fileView.SelectionPublishServiceProvider = Context;

			fileView.ColumnWidthChanged += new ColumnWidthChangedEventHandler(fileView_ColumnWidthChanged);
			IDictionary<string, int> widths = ConfigurationService.GetColumnWidths(GetType());
			fileView.SetColumnWidths(widths);
		}

		protected void fileView_ColumnWidthChanged(object sender, ColumnWidthChangedEventArgs e)
		{
			IDictionary<string, int> widths = fileView.GetColumnWidths();
			ConfigurationService.SaveColumnsWidths(GetType(), widths);
		}

		/// <summary>
		/// Add a new URL root to the tree.
		/// </summary>
		/// <param name="text"></param>
		/// <param name="node"></param>
		public void AddRoot(Uri uri)
		{
			this.treeView.AddRoot(uri);
		}

		/// <summary>
		/// Remove the root(server) of the node identified by the <paramref name="uri"/>
		/// </summary>
		/// <param name="uri">URI of the tree node</param>
		public void RemoveRootOf(Uri uri)
		{
			this.treeView.RemoveRootOf(uri);
		}

		/// <summary>
		/// Reloads the node identified by the <paramref name="uri"/><br/>
		/// </summary>
		/// <param name="uri">URI of the tree node</param>
		public void Reload(Uri uri)
		{
			this.treeView.Reload(uri);
		}

		/// <summary>
		/// Get the URI of the selected node
		/// </summary>
		public Uri SelectedUri
		{
			get
			{
				RepositoryTreeNode selected = this.treeView.SelectedNode;
				return selected == null ? null : selected.RawUri;
			}
		}

		protected override void OnThemeChanged(EventArgs e)
		{
#if VS_11_ENV
			// Remove the chrome
			toolFolders.Visible = toolFolders.Enabled = false;
			treeView.BorderStyle = BorderStyle.None;
			fileView.BorderStyle = BorderStyle.None;
#endif // VS_11_ENV
			base.OnThemeChanged(e);
		}

		private void OnTreeViewShowContextMenu(object sender, MouseEventArgs e)
		{
			if (Context == null)
				return;

			Point screen;
			if (e.X == -1 && e.Y == -1)
			{
				screen = treeView.GetSelectionPoint();
				if (screen.IsEmpty)
					return;
			}
			else
			{
				screen = e.Location;
			}

			IAnkhCommandService cs = Context.GetService<IAnkhCommandService>();

			cs.ShowContextMenu(AnkhCommandMenu.RepositoryExplorerContextMenu, screen.X, screen.Y);
		}

		IFileIconMapper _iconMapper;
		IFileIconMapper IconMapper
		{
			get
			{
				if (_iconMapper == null && Context != null)
					_iconMapper = Context.GetService<IFileIconMapper>();

				return _iconMapper;
			}
		}

		private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
		{
			RefreshFileList();
		}

		void RefreshFileList()
		{
			fileView.Items.Clear();

			RepositoryTreeNode tn = treeView.SelectedNode as RepositoryTreeNode;

			if (tn != null && tn.Origin != null)
			{
				foreach (RepositoryTreeNode sn in tn.Nodes)
				{
					if (sn.FolderItems.Contains(sn.RawUri))
					{
						ISvnRepositoryListItem ea = sn.FolderItems[sn.RawUri];
						RepositoryListItem item = new RepositoryListItem(fileView, ea, tn.Origin, IconMapper);

						fileView.Items.Add(item);
					}
				}
				foreach (ISvnRepositoryListItem ee in tn.FolderItems)
				{
					if (ee.Uri != tn.RawUri)
					{
						RepositoryListItem item = new RepositoryListItem(fileView, ee, tn.Origin, IconMapper);

						fileView.Items.Add(item);
					}
				}

				if (fileView.Items.Count > 0)
				{
					SmartColumn fileColumn = fileView.AllColumns[0];

					if (fileColumn.DisplayIndex >= 0)
						fileColumn.AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
				}
			}
		}

		BusyOverlay _bo;
		private void treeView_RetrievingChanged(object sender, EventArgs e)
		{
			if (treeView.Retrieving)
			{
				if (_bo == null)
					_bo = new BusyOverlay(treeView, AnchorStyles.Top | AnchorStyles.Right);

				_bo.Show();
			}
			else
			{
				if (_bo != null)
				{
					_bo.Hide();
					_bo.Dispose();
					_bo = null;
				}
			}
		}

		private void treeView_SelectedNodeRefresh(object sender, EventArgs e)
		{
			RefreshFileList();
		}

		private void fileView_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			ListViewHitTestInfo ht = fileView.HitTest(e.X, e.Y);

			RepositoryListItem li = ht.Item as RepositoryListItem;

			if (ht.Location == ListViewHitTestLocations.None || li == null)
				return;

			if (!li.Selected)
			{
				fileView.SelectedIndices.Clear();
				li.Selected = true;
			}

			Context.GetService<IAnkhCommandService>().PostExecCommand(new CommandID(VSConstants.GUID_VSStandardCommandSet97, (int)VSConstants.VSStd97CmdID.Open));
		}


		void OnUpdateOpen(object sender, CommandUpdateEventArgs e)
		{
			RepositoryExplorerItem item = EnumTools.GetSingle(e.Selection.GetSelection<RepositoryExplorerItem>());

			if (item == null || item.Uri == null)
				e.Enabled = false;
		}

		void OnOpen(object sender, CommandEventArgs e)
		{
			RepositoryExplorerItem item = EnumTools.GetSingle(e.Selection.GetSelection<RepositoryExplorerItem>());

			if (item.Entry == null || item.Entry.NodeKind == SvnNodeKind.Directory || item.Origin == null)
			{
				treeView.BrowseTo(item.Uri);
				return;
			}

			AutoOpenCommand(e, item.Origin);
		}

		private static void AutoOpenCommand(CommandEventArgs e, SvnOrigin origin)
		{
			IAnkhCommandService svc = e.GetService<IAnkhCommandService>();
			IAnkhSolutionSettings solutionSettings = e.GetService<IAnkhSolutionSettings>();

			if (svc == null || solutionSettings == null)
				return;

			// Ok, we can assume we have a file
			string filename = origin.Target.FileName;
			string ext = Path.GetExtension(filename);

			if (string.IsNullOrEmpty(ext))
			{
				// No extension -> Open as text
				svc.PostExecCommand(AnkhCommand.ViewInVsText);
				return;
			}

			foreach (string projectExt in solutionSettings.AllProjectExtensionsFilter.Split(';'))
			{
				if (projectExt.TrimStart('*').Trim().Equals(ext, StringComparison.OrdinalIgnoreCase))
				{
					// We found a project or solution, use Open from Subversion to create a checkout

					svc.PostExecCommand(AnkhCommand.FileFileOpenFromSubversion, origin);
					return;
				}
			}

			bool odd = false;
			foreach (string block in solutionSettings.OpenFileFilter.Split('|'))
			{
				odd = !odd;
				if (odd)
					continue;

				foreach (string itemExt in block.Split(';'))
				{
					if (itemExt.TrimStart('*').Trim().Equals(ext, StringComparison.OrdinalIgnoreCase))
					{
						svc.PostExecCommand(AnkhCommand.ViewInVsNet);
						return;
					}
				}
			}

			// Ultimate fallback: Just ask the user what to do (don't trust the repository!)
			svc.PostExecCommand(AnkhCommand.ViewInWindowsWith);
		}

		void OnUpdateUp(object sender, CommandUpdateEventArgs e)
		{
			if (treeView.SelectedNode == null
				|| treeView.Nodes.Count == 0
				|| treeView.SelectedNode == treeView.Nodes[0])
			{
				e.Enabled = false;
			}
		}

		void OnUp(object sender, CommandEventArgs e)
		{
			treeView.SelectedNode = treeView.SelectedNode.Parent as RepositoryTreeNode;
		}
	}
}
