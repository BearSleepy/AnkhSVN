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

namespace Ankh.UI.PathSelector
{
	partial class CommonFileSelectorDialog
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

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

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.okButton = new System.Windows.Forms.Button();
			this.cancelButton = new System.Windows.Forms.Button();
			this.suppressLabel = new System.Windows.Forms.Label();
			this.bottomPanel = new System.Windows.Forms.Panel();
			this.fromLabel = new System.Windows.Forms.Label();
			this.toLabel = new System.Windows.Forms.Label();
			this.fromPanel = new System.Windows.Forms.Panel();
			this.revisionPickerStart = new Ankh.UI.PathSelector.VersionSelector();
			this.toPanel = new System.Windows.Forms.Panel();
			this.revisionPickerEnd = new Ankh.UI.PathSelector.VersionSelector();
			this.pendingList = new Ankh.UI.PendingChanges.Commits.PendingCommitsView(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.bottomPanel.SuspendLayout();
			this.fromPanel.SuspendLayout();
			this.toPanel.SuspendLayout();
			this.SuspendLayout();
			//
			// okButton
			//
			this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.okButton.Location = new System.Drawing.Point(375, 0);
			this.okButton.Name = "okButton";
			this.okButton.Size = new System.Drawing.Size(75, 23);
			this.okButton.TabIndex = 1;
			this.okButton.Text = "OK";
			//
			// cancelButton
			//
			this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cancelButton.Location = new System.Drawing.Point(456, 0);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(75, 23);
			this.cancelButton.TabIndex = 2;
			this.cancelButton.Text = "Cancel";
			//
			// suppressLabel
			//
			this.suppressLabel.AutoSize = true;
			this.suppressLabel.Location = new System.Drawing.Point(3, 5);
			this.suppressLabel.Name = "suppressLabel";
			this.suppressLabel.Size = new System.Drawing.Size(284, 13);
			this.suppressLabel.TabIndex = 0;
			this.suppressLabel.Text = "You can suppress this dialog by holding down the Shift key";
			this.suppressLabel.Click += new System.EventHandler(this.suppressLabel_Click);
			//
			// bottomPanel
			//
			this.bottomPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.bottomPanel.Controls.Add(this.suppressLabel);
			this.bottomPanel.Controls.Add(this.okButton);
			this.bottomPanel.Controls.Add(this.cancelButton);
			this.bottomPanel.Location = new System.Drawing.Point(9, 292);
			this.bottomPanel.Margin = new System.Windows.Forms.Padding(0);
			this.bottomPanel.Name = "bottomPanel";
			this.bottomPanel.Size = new System.Drawing.Size(531, 23);
			this.bottomPanel.TabIndex = 1;
			//
			// fromLabel
			//
			this.fromLabel.AutoSize = true;
			this.fromLabel.Location = new System.Drawing.Point(0, 0);
			this.fromLabel.Name = "fromLabel";
			this.fromLabel.Size = new System.Drawing.Size(33, 13);
			this.fromLabel.TabIndex = 0;
			this.fromLabel.Text = "&From:";
			//
			// toLabel
			//
			this.toLabel.AutoSize = true;
			this.toLabel.Location = new System.Drawing.Point(0, 0);
			this.toLabel.Name = "toLabel";
			this.toLabel.Size = new System.Drawing.Size(23, 13);
			this.toLabel.TabIndex = 0;
			this.toLabel.Text = "&To:";
			//
			// fromPanel
			//
			this.fromPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.fromPanel.Controls.Add(this.revisionPickerStart);
			this.fromPanel.Controls.Add(this.fromLabel);
			this.fromPanel.Location = new System.Drawing.Point(9, 213);
			this.fromPanel.Margin = new System.Windows.Forms.Padding(0);
			this.fromPanel.Name = "fromPanel";
			this.fromPanel.Size = new System.Drawing.Size(531, 38);
			this.fromPanel.TabIndex = 1;
			//
			// revisionPickerStart
			//
			this.revisionPickerStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.revisionPickerStart.Location = new System.Drawing.Point(4, 11);
			this.revisionPickerStart.Name = "revisionPickerStart";
			this.revisionPickerStart.Size = new System.Drawing.Size(524, 24);
			this.revisionPickerStart.SvnOrigin = null;
			this.revisionPickerStart.TabIndex = 1;
			//
			// toPanel
			//
			this.toPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.toPanel.Controls.Add(this.revisionPickerEnd);
			this.toPanel.Controls.Add(this.toLabel);
			this.toPanel.Location = new System.Drawing.Point(9, 251);
			this.toPanel.Margin = new System.Windows.Forms.Padding(0);
			this.toPanel.Name = "toPanel";
			this.toPanel.Size = new System.Drawing.Size(531, 38);
			this.toPanel.TabIndex = 2;
			//
			// revisionPickerEnd
			//
			this.revisionPickerEnd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.revisionPickerEnd.Location = new System.Drawing.Point(4, 11);
			this.revisionPickerEnd.Name = "revisionPickerEnd";
			this.revisionPickerEnd.Size = new System.Drawing.Size(524, 24);
			this.revisionPickerEnd.SvnOrigin = null;
			this.revisionPickerEnd.TabIndex = 0;
			//
			// pendingList
			//
			this.pendingList.AllowColumnReorder = true;
			this.pendingList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
			| System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.pendingList.CheckBoxes = true;
			this.pendingList.HideSelection = false;
			this.pendingList.Location = new System.Drawing.Point(9, 12);
			this.pendingList.Name = "pendingList";
			this.pendingList.ShowSelectAllCheckBox = true;
			this.pendingList.Size = new System.Drawing.Size(531, 198);
			this.pendingList.TabIndex = 0;
			this.pendingList.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.pendingList_ItemChecked);
			//
			// label1
			//
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(33, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "&From:";
			//
			// CommonFileSelectorDialog
			//
			this.AcceptButton = this.okButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.CancelButton = this.cancelButton;
			this.ClientSize = new System.Drawing.Size(552, 324);
			this.Controls.Add(this.pendingList);
			this.Controls.Add(this.toPanel);
			this.Controls.Add(this.fromPanel);
			this.Controls.Add(this.bottomPanel);
			this.MinimumSize = new System.Drawing.Size(100, 39);
			this.Name = "CommonFileSelectorDialog";
			this.Text = "PathSelector";
			this.bottomPanel.ResumeLayout(false);
			this.bottomPanel.PerformLayout();
			this.fromPanel.ResumeLayout(false);
			this.fromPanel.PerformLayout();
			this.toPanel.ResumeLayout(false);
			this.toPanel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button okButton;
		private System.Windows.Forms.Button cancelButton;
		private Ankh.UI.PathSelector.VersionSelector revisionPickerStart;
		private Ankh.UI.PathSelector.VersionSelector revisionPickerEnd;
		private System.Windows.Forms.Label suppressLabel;
		private System.Windows.Forms.Panel bottomPanel;
		private System.Windows.Forms.Label fromLabel;
		private System.Windows.Forms.Label toLabel;
		private System.Windows.Forms.Panel fromPanel;
		private System.Windows.Forms.Panel toPanel;
		private PendingChanges.Commits.PendingCommitsView pendingList;
		private System.Windows.Forms.Label label1;
	}
}
