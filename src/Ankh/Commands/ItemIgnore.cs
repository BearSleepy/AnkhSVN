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
using Ankh.UI;
using SharpSvn;
using Ankh.Scc;

namespace Ankh.Commands
{
	[SvnCommand(AnkhCommand.ItemIgnoreFile)]
	[SvnCommand(AnkhCommand.ItemIgnoreFileType)]
	[SvnCommand(AnkhCommand.ItemIgnoreFilesInFolder)]
	[SvnCommand(AnkhCommand.ItemIgnoreFolder)]
	class ItemIgnore : CommandBase
	{
		static bool Skip(SvnItem item)
		{
			return (item.IsVersioned || item.IsIgnored || !item.IsVersionable || !item.Exists);
		}

		public override void OnUpdate(CommandUpdateEventArgs e)
		{
			SvnItem foundOne = null;

			foreach (SvnItem item in e.Selection.GetSelectedSvnItems(false))
			{
				if (Skip(item))
					continue;

				SvnItem parent;

				switch (e.Command)
				{
					case AnkhCommand.ItemIgnoreFileType:
						if (string.IsNullOrEmpty(item.Extension))
							continue;
						goto case AnkhCommand.ItemIgnoreFile;
					case AnkhCommand.ItemIgnoreFile:
					case AnkhCommand.ItemIgnoreFilesInFolder:
						parent = item.Parent;
						if (parent == null || !parent.IsVersioned)
							continue;
						break;
					case AnkhCommand.ItemIgnoreFolder:
						parent = item.Parent;
						if (parent != null && (parent.IsVersioned || item.ParentDirectory.NeedsWorkingCopyUpgrade))
						{
							e.Enabled = false;
							return;
						}
						break;
					default:
						throw new InvalidOperationException();
				}

				if (foundOne == null)
					foundOne = item;
			}

			if (foundOne == null)
			{
				e.Enabled = false;
				return;
			}

			if (e.TextQueryType == TextQueryType.Name)
				switch (e.Command)
				{
					case AnkhCommand.ItemIgnoreFile:
						e.Text = string.Format(foundOne.IsDirectory
							? Resources.IgnoreFolder : Resources.IgnoreFile, foundOne.Name);
						break;
					case AnkhCommand.ItemIgnoreFileType:
						e.Text = string.Format(Resources.IgnoreFileType, foundOne.Extension);
						break;
					case AnkhCommand.ItemIgnoreFolder:
						SvnItem pp;
						SvnItem p = foundOne.Parent;

						while (p != null && (pp = p.Parent) != null && !pp.IsVersioned)
							p = pp;

						e.Text = string.Format(Resources.IgnoreFolder, (p != null) ? p.Name : "");
						break;
				}
		}

		public override void OnExecute(CommandEventArgs e)
		{
			Dictionary<string, List<string>> add = new Dictionary<string, List<string>>(StringComparer.OrdinalIgnoreCase);
			List<string> refresh = new List<string>();

			foreach (SvnItem i in e.Selection.GetSelectedSvnItems(false))
			{
				if (Skip(i))
					continue;
				refresh.Add(i.FullPath);
				switch (e.Command)
				{
					case AnkhCommand.ItemIgnoreFile:
						AddIgnore(add, i.Parent, i.Name);
						break;
					case AnkhCommand.ItemIgnoreFileType:
						AddIgnore(add, i.Parent, "*" + i.Extension);
						break;
					case AnkhCommand.ItemIgnoreFilesInFolder:
						AddIgnore(add, i.Parent, "*");
						break;
					case AnkhCommand.ItemIgnoreFolder:
						SvnItem p = i.Parent;
						SvnItem pp = null;

						while (null != p && null != (pp = p.Parent) && !pp.IsVersioned)
							p = pp;

						if (p != null && pp != null)
							AddIgnore(add, pp, p.Name);
						break;
				}
			}

			try
			{

				AnkhMessageBox mb = new AnkhMessageBox(e.Context);
				foreach (KeyValuePair<string, List<string>> k in add)
				{
					if (k.Value.Count == 0)
						continue;

					string text;

					if (k.Value.Count == 1)
						text = "'" + k.Value[0] + "'";
					else
					{
						StringBuilder sb = new StringBuilder();

						for (int i = 0; i < k.Value.Count; i++)
						{
							if (i == 0)
								sb.AppendFormat("'{0}'", k.Value[i]);
							else if (i == k.Value.Count - 1)
								sb.AppendFormat(" and '{0}'", k.Value[i]);
							else
								sb.AppendFormat(", '{0}'", k.Value[i]);
						}
						text = sb.ToString();
					}

					switch (mb.Show(string.Format(Resources.WouldYouLikeToAddXToTheIgnorePropertyOnY,
						text,
						k.Key), Resources.IgnoreCaption, System.Windows.Forms.MessageBoxButtons.YesNoCancel))
					{
						case System.Windows.Forms.DialogResult.Yes:
							AddIgnores(e.Context, k.Key, k.Value);
							break;
						case System.Windows.Forms.DialogResult.No:
							continue;
						default:
							return;
					}
				}
			}
			finally
			{
				e.GetService<IFileStatusMonitor>().ScheduleSvnStatus(refresh);
			}
		}

		private static void AddIgnores(IAnkhServiceProvider context, string path, List<string> ignores)
		{
			try
			{
				context.GetService<IProgressRunner>().RunModal(Resources.IgnoreCaption,
					delegate(object sender, ProgressWorkerArgs e)
					{
						SvnGetPropertyArgs pa = new SvnGetPropertyArgs();
						pa.ThrowOnError = false;
						SvnTargetPropertyCollection tpc;
						if (e.Client.GetProperty(path, SvnPropertyNames.SvnIgnore, pa, out tpc))
						{
							SvnPropertyValue pv;
							if (tpc.Count > 0 && null != (pv = tpc[0]) && pv.StringValue != null)
							{
								int n = 0;
								foreach (string oldItem in pv.StringValue.Split('\n'))
								{
									string item = oldItem.TrimEnd('\r');

									if (item.Trim().Length == 0)
										continue;

									// Don't add duplicates
									while (n < ignores.Count && ignores.IndexOf(item, n) >= 0)
										ignores.RemoveAt(ignores.IndexOf(item, n));

									if (ignores.Contains(item))
										continue;

									ignores.Insert(n++, item);
								}
							}

							StringBuilder sb = new StringBuilder();
							bool next = false;
							foreach (string item in ignores)
							{
								if (next)
									sb.Append('\n'); // Subversion wants only newlines
								else
									next = true;

								sb.Append(item);
							}

							e.Client.SetProperty(path, SvnPropertyNames.SvnIgnore, sb.ToString());
						}
					});

				// Make sure a changed directory is visible in the PC Window
				context.GetService<IFileStatusMonitor>().ScheduleMonitor(path);
			}
			finally
			{
				// Ignore doesn't bubble
				context.GetService<ISvnStatusCache>().MarkDirtyRecursive(path);
			}
		}

		private static void AddIgnore(Dictionary<string, List<string>> add, SvnItem item, string name)
		{
			if (item == null)
				return;
			if (!item.IsVersioned)
				return;
			List<string> toAdd;

			if (!add.TryGetValue(item.FullPath, out toAdd))
			{
				toAdd = new List<string>();
				add.Add(item.FullPath, toAdd);
			}

			if (!toAdd.Contains(name))
				toAdd.Add(name);
		}
	}
}
