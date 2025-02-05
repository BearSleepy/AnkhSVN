﻿// Copyright 2008-2009 The AnkhSVN Project
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
using Ankh.UI.VSSelectionControls;
using Ankh.VS;
using System.Windows.Forms;
using System.Drawing;
using Ankh.Commands;
using System.ComponentModel;
using Ankh.Scc;

namespace Ankh.UI.RepositoryExplorer
{
	class RepositoryListView : ListViewWithSelection<RepositoryListItem>
	{
		IAnkhServiceProvider _context;

		public RepositoryListView()
		{
			InitializeColumns();
		}

		private void InitializeColumns()
		{
			SmartColumn name = new SmartColumn(this, Resources.NameColumn, 120, "Name");
			SmartColumn type = new SmartColumn(this, Resources.TypeColumn, 100, "Type");
			SmartColumn revision = new SmartColumn(this, Resources.RevisionColumn, 60, "Revision");
			SmartColumn author = new SmartColumn(this, Resources.AuthorColumn, 60, "Author");
			SmartColumn size = new SmartColumn(this, Resources.SizeColumn, 60, "Size");
			SmartColumn date = new SmartColumn(this, Resources.DateColumn, 100, "Date");
			SmartColumn lockOwner = new SmartColumn(this, Resources.LockOwnerColumn, 100, "LockOwner");

			name.Sorter = new SortWrapper(
				delegate(RepositoryListItem x, RepositoryListItem y)
				{
					if (x.IsFolder ^ y.IsFolder)
					{
						return x.IsFolder ? -1 : 1;
					}

					return StringComparer.OrdinalIgnoreCase.Compare(x.Text, y.Text);
				});
			size.Sorter = new SortWrapper(
				delegate(RepositoryListItem x, RepositoryListItem y)
				{
					if (x.IsFolder ^ y.IsFolder)
					{
						return x.IsFolder ? -1 : 1;
					}

					long lx = x.Entry.FileSize;
					long ly = y.Entry.FileSize;

					if (lx < ly)
						return -1;
					else if (lx > ly)
						return 1;
					else
						return 0;
				});
			date.Sorter = new SortWrapper(
				delegate(RepositoryListItem x, RepositoryListItem y)
				{
					return x.Entry.Time.CompareTo(y.Entry.Time);
				});

			AllColumns.Add(name);
			AllColumns.Add(type);
			AllColumns.Add(revision);
			AllColumns.Add(author);
			AllColumns.Add(size);
			AllColumns.Add(date);
			AllColumns.Add(lockOwner);

			Columns.AddRange(new ColumnHeader[]
			{
				name,
				date,
				type,
				revision,
				author,
				size,
				lockOwner
			});

			SortColumns.Add(name);
			FinalSortColumn = name;
			UpdateSortGlyphs();

			FinalSortColumn = name;
			AllowColumnReorder = true;
		}

		protected override string GetCanonicalName(RepositoryListItem item)
		{
			SvnOrigin origin = item.Origin;

			if (origin != null)
				return origin.Uri.AbsoluteUri;
			else
				return null;
		}

		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public IAnkhServiceProvider Context
		{
			get { return _context; }
			set
			{
				_context = value;
				if (value != null)
					OnContextChanged(EventArgs.Empty);
			}
		}

		RepositoryTreeView _tv;
		[DefaultValue(false)]
		public RepositoryTreeView RepositoryTreeView
		{
			get { return _tv; }
			set { _tv = value; UpdateTreeView(); }
		}

		void UpdateTreeView()
		{
			if (RepositoryTreeView != null)
				LabelEdit = RepositoryTreeView.LabelEdit;
		}

		RepositoryExplorerItem _editItem;
		protected override void OnBeforeLabelEdit(LabelEditEventArgs e)
		{
			base.OnBeforeLabelEdit(e);

			_editItem = null;
			RepositoryListItem item = Items[e.Item] as RepositoryListItem;
			if (RepositoryTreeView == null || item == null)
				e.CancelEdit = true;
			else
			{
				CancelEventArgs ce = new CancelEventArgs(e.CancelEdit);
				RepositoryTreeView.OnItemEdit(_editItem = new RepositoryExplorerItem(Context, item.Origin, item), ce);

				if (ce.Cancel)
					e.CancelEdit = true;
			}
		}

		protected override void OnAfterLabelEdit(LabelEditEventArgs e)
		{
			base.OnAfterLabelEdit(e);

			try
			{
				RepositoryListItem item = Items[e.Item] as RepositoryListItem;
				if (RepositoryTreeView != null && _editItem != null && _editItem.ListViewItem == item)
				{
					CancelEventArgs c = new CancelEventArgs();
					RepositoryTreeView.OnAfterEdit(_editItem, e.Label, c);

					if (c.Cancel)
						e.CancelEdit = true;
				}
			}
			finally
			{
				_editItem = null;
			}
		}

		public override void OnShowContextMenu(MouseEventArgs e)
		{
			base.OnShowContextMenu(e);

			bool isHeaderContextMenu = false;
			Point screen;
			if (e.X == -1 && e.Y == -1)
			{
				if (SelectedItems.Count > 0)
				{
					screen = PointToScreen(SelectedItems[SelectedItems.Count - 1].Position);
				}
				else
				{
					screen = PointToScreen(new Point(0, 0));
					isHeaderContextMenu = true;
				}
			}
			else
			{
				screen = e.Location;
				isHeaderContextMenu = PointToClient(e.Location).Y < HeaderHeight;
			}

			IAnkhCommandService sc = Context.GetService<IAnkhCommandService>();

			AnkhCommandMenu menu;
			if (isHeaderContextMenu)
			{
				Select(); // Must be the active control for the menu to work
				menu = AnkhCommandMenu.ListViewHeader;
			}
			else
				menu = AnkhCommandMenu.RepositoryExplorerContextMenu;

			sc.ShowContextMenu(menu, screen);
		}

		private void OnContextChanged(EventArgs eventArgs)
		{
			IFileIconMapper fim = Context.GetService<IFileIconMapper>();

			if (fim != null)
				SmallImageList = fim.ImageList;
		}

		protected override void OnResolveItem(ResolveItemEventArgs e)
		{
			e.Item = ((RepositoryExplorerItem)e.SelectionItem).ListViewItem;
			base.OnResolveItem(e);
		}

		protected override void OnRetrieveSelection(RetrieveSelectionEventArgs e)
		{
			e.SelectionItem = new RepositoryExplorerItem(Context, e.Item.Origin, e.Item);
			base.OnRetrieveSelection(e);
		}

		internal SharpSvn.SvnLockInfo GetLockInfo(Uri entryUri)
		{
			return null;
		}
	}
}
