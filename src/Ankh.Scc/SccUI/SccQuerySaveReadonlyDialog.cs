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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Ankh.UI;

namespace Ankh.Scc.SccUI
{
	public partial class SccQuerySaveReadonlyDialog : VSDialogForm
	{
		string _file;

		public SccQuerySaveReadonlyDialog()
		{
			InitializeComponent();
		}

		public string File
		{
			get { return _file; }
			set { _file = value; }
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);

			lblFile.Text = string.Format(Resources.ReadonlyFileXCannotBeSaved, Path.GetFileName(File));
		}
	}
}
