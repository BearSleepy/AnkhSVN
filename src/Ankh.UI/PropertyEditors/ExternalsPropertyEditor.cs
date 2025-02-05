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
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using SharpSvn;
using System.Collections.Generic;
using System.Text;

namespace Ankh.UI.PropertyEditors
{
	/// <summary>
	/// Editor for externals properties.
	/// </summary>
	partial class ExternalsPropertyEditor : PropertyEditControl
	{
		string originalValue;

		public ExternalsPropertyEditor()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			this.components = new System.ComponentModel.Container();
		}

		/// <summary>
		/// Indicates whether the property item is valid.
		/// </summary>
		public override bool Valid
		{
			get
			{
				return true;
			}
		}

		SortedList<string, SvnExternalItem> _originals = new SortedList<string, SvnExternalItem>();
		SortedList<string, SvnExternalItem> _externals = new SortedList<string, SvnExternalItem>();
		string _originalText;
		public string ExternalsText
		{
			get
			{
				bool foundChanges = false;
				SortedList<string, SvnExternalItem> nw = new SortedList<string, SvnExternalItem>();

				foreach (DataGridViewRow r in externalGrid.Rows)
				{
					SvnExternalItem ei = r.Tag as SvnExternalItem;
					if (ei == null)
						continue;

					nw[ei.Target] = ei;
				}

				foreach (SvnExternalItem i in _originals.Values)
				{
					SvnExternalItem other;
					if (nw.TryGetValue(i.Target, out other))
					{
						if (i.Equals(other))
							continue;
					}

					foundChanges = true;
					break;
				}

				if (!foundChanges)
					foreach (SvnExternalItem i in nw.Values)
					{
						SvnExternalItem other;
						if (_originals.TryGetValue(i.Target, out other))
						{
							if (i.Equals(other))
								continue;
						}

						foundChanges = true;
						break;
					}

				if (!foundChanges)
					return _originalText;

				StringBuilder sb = new StringBuilder();
				foreach (DataGridViewRow r in externalGrid.Rows)
				{
					SvnExternalItem ei = r.Tag as SvnExternalItem;
					if (ei == null)
						continue;

					ei.WriteTo(sb, true);
					sb.AppendLine();
				}

				return sb.ToString();
			}
			set
			{
				_originalText = value;
				_externals.Clear();
				if (value == null)
				{
					return;
				}
				SvnExternalItem[] items;
				if (SvnExternalItem.TryParse(value, out items))
				{
					foreach (SvnExternalItem i in items)
					{
						_originals[i.Target] = i;
						_externals[i.Target] = i;
					}
				}
				Rebind(items);
			}
		}

		private void Rebind(SvnExternalItem[] items)
		{
			externalGrid.Rows.Clear();

			foreach (SvnExternalItem i in items)
			{
				int n = externalGrid.Rows.Add();
				externalGrid.Rows[n].Tag = i;
			}

			foreach (DataGridViewRow r in externalGrid.Rows)
			{
				SvnExternalItem ii = r.Tag as SvnExternalItem;

				if (ii != null)
					RowRefresh(r, ii);

			}
		}

		private void RowRefresh(DataGridViewRow r, SvnExternalItem ii)
		{
			r.SetValues(
				ii.Reference,
				null,
				ii.Revision.ToString(),
				null,
				ii.Target);
		}

		/// <summary>
		/// Sets and gets the property item.
		/// </summary>
		public override SvnPropertyValue PropertyItem
		{
			get
			{
				if (!this.Valid)
				{
					throw new InvalidOperationException(
						"Can not get a property item when valid is false");
				}

				return new SvnPropertyValue(SvnPropertyNames.SvnExternals, ExternalsText);
			}

			set
			{
				if (value != null)
				{
					ExternalsText = originalValue = value.StringValue;
				}
				else
					ExternalsText = originalValue = "";
			}
		}

		/// <summary>
		/// Indicates the type of property.
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			return SvnPropertyNames.SvnExternals;
		}

		public override bool AllowNodeKind(SvnNodeKind kind)
		{
			return kind == SvnNodeKind.Directory;
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				if (components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}

		private void externalGrid_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
		{
			DataGridViewRow r = externalGrid.Rows[e.RowIndex];
			string url = r.Cells[0].Value as string;
			string target = r.Cells[4].Value as string;
			string rev = r.Cells[2].Value as string;

			if (r.IsNewRow &&
				string.IsNullOrEmpty(url) &&
				string.IsNullOrEmpty(target) &&
				string.IsNullOrEmpty(rev))
				return;

			long v = 0;
			if (string.IsNullOrEmpty(url))
			{
				e.Cancel = true;
				MessageBox.Show(this, "Url is not set", "Property Editor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			else if (string.IsNullOrEmpty(target))
			{
				e.Cancel = true;
				MessageBox.Show(this, "Target is not set", "Property Editor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

			}
			else if (!string.IsNullOrEmpty(rev) && !long.TryParse(rev, out v))
			{
				e.Cancel = true;
				MessageBox.Show(this, "Revision is not valid", "Property Editor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}

			if (e.Cancel)
				return;

			SvnExternalItem ei;
			if (!TryCreateItemFromRow(r, out ei))
			{
				e.Cancel = true;
				MessageBox.Show(this, "External definition generates invalid definition", "Property Editor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}

			r.Tag = ei;
		}

		private void externalGrid_RowValidated(object sender, DataGridViewCellEventArgs e)
		{
			DataGridViewRow r = externalGrid.Rows[e.RowIndex];

			if (r.IsNewRow)
				return;

			// Validated in RowValidating!

			SvnExternalItem ei;
			if (TryCreateItemFromRow(r, out ei))
			{
				r.Tag = ei;
				RowRefresh(r, ei);
			}
			else
			{
				r.Tag = null;
				r.Cells.Clear();
			}
		}

		private static bool TryCreateItemFromRow(DataGridViewRow r, out SvnExternalItem item)
		{
			if (r == null)
				throw new ArgumentNullException("r");

			string url = r.Cells[0].Value as string;
			string target = r.Cells[4].Value as string;
			string rev = r.Cells[2].Value as string;
			SvnRevision rr = string.IsNullOrEmpty(rev) ? SvnRevision.None : long.Parse(rev);

			if (url.Contains("://"))
			{
				Uri uri;

				if (!Uri.TryCreate(url, UriKind.Absolute, out uri))
				{
					item = null;
					return false;
				}

				url = uri.AbsoluteUri;
			}

			SvnExternalItem ei = new SvnExternalItem(target, url, rr, rr);
			SvnExternalItem p;

			if (!SvnExternalItem.TryParse(ei.ToString(), out p) || !p.Equals(ei))
			{
				item = null;
				return false;
			}
			item = ei;
			return true;
		}

		private void externalGrid_CellContentClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
		{
			DataGridViewRow row = externalGrid.Rows[e.RowIndex];

			// if the column is the Url selection column
			if (e.ColumnIndex == this.buttonColumn.Index)
			{
				SelectRepositoryFolder(row);
			}
			// if the column is the revision selection column
			else if (e.ColumnIndex == this.revButtonColumn.Index)
			{
				SelectRevision(row);
			}
		}

		/// <summary>
		/// Shows the repository folder browser and sets URL cell value to the selected url
		/// </summary>
		/// <param name="row"></param>
		private void SelectRepositoryFolder(DataGridViewRow row)
		{
			IAnkhServiceProvider context = Context;
			if (context != null)
			{
				using (RepositoryExplorer.RepositoryFolderBrowserDialog rfbd = new RepositoryExplorer.RepositoryFolderBrowserDialog())
				{
					// do not show files in repo browser
					rfbd.ShowFiles = false;

					string selectedUriString = row.Cells[0].Value as string;

					// set the current URL value as the initial selection
					Uri selectedUri;
					if (!string.IsNullOrEmpty(selectedUriString)
						&& Uri.TryCreate(selectedUriString, UriKind.Absolute, out selectedUri)
						)
					{
						rfbd.SelectedUri = selectedUri;
					}
					if (DialogResult.OK == rfbd.ShowDialog(context))
					{
						Uri uri = rfbd.SelectedUri;
						// set the Url cell value to the selected Url
						row.Cells[0].Value = uri == null ? string.Empty : uri.AbsoluteUri;
					}
				}
			}
		}

		private string _lastUsedUriString = null;
		private Uri _lastRepositoryRoot = null;

		/// <summary>
		/// Shows the log viewer and sets the revision cell value to the selected revision
		/// </summary>
		/// <param name="row"></param>
		private void SelectRevision(DataGridViewRow row)
		{
			IAnkhServiceProvider context = Context;
			if (context != null)
			{
				string selectedUriString = row.Cells[0].Value as string;

				Uri selectedUri;
				if (!string.IsNullOrEmpty(selectedUriString)
					&& Uri.TryCreate(selectedUriString, UriKind.Absolute, out selectedUri)
					)
				{
					Uri repoRoot = string.Equals(_lastUsedUriString, selectedUriString) ? _lastRepositoryRoot : null;
					if (repoRoot == null)
					{
						if (context.GetService<IProgressRunner>().RunModal(
							Resources.RetrievingRepositoryRoot,
							delegate(object sender, ProgressWorkerArgs a)
							{
								repoRoot = a.Client.GetRepositoryRoot(selectedUri);

							}).Succeeded)
						{
							//cache the last used repo uri string and the fetched repository root uri
							_lastRepositoryRoot = repoRoot;
							_lastUsedUriString = selectedUriString;
						}
					}
					if (repoRoot != null)
					{
						try
						{
							// set the current revision value as the initial selection
							string rev = row.Cells[2].Value as string;
							SvnRevision rr = string.IsNullOrEmpty(rev) ? SvnRevision.None : long.Parse(rev);
							SvnUriTarget svnTarget = new SvnUriTarget(selectedUri, rr);
							Ankh.Scc.SvnOrigin origin = new Ankh.Scc.SvnOrigin(svnTarget, repoRoot);
							using (Ankh.UI.SvnLog.LogViewerDialog dlg = new Ankh.UI.SvnLog.LogViewerDialog(origin))
							{
								if (dlg.ShowDialog(Context) == DialogResult.OK)
								{
									Ankh.Scc.ISvnLogItem li = EnumTools.GetSingle(dlg.SelectedItems);
									rev = li == null ? null : li.Revision.ToString();
									//set the revision cell value to the selection revision
									row.Cells[2].Value = rev ?? string.Empty;
								}
							}
						}
						catch
						{
							// clear cache in case of error
							_lastUsedUriString = null;
							_lastRepositoryRoot = null;
						}
					}
				}
			}
		}
	}
}

