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

namespace Ankh.UI.SccManagement
{
	partial class LockDialog
	{
		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.suppressLabel = new System.Windows.Forms.Label();
			this.btnCancel = new System.Windows.Forms.Button();
			this.okButton = new System.Windows.Forms.Button();
			this.stealLocksCheckBox = new System.Windows.Forms.CheckBox();
			this.splitContainer1 = new Ankh.UI.VSSelectionControls.SmartSplitContainer(this.components);
			this.pendingList = new Ankh.UI.PendingChanges.Commits.PendingCommitsView(this.components);
			this.logMessage = new Ankh.UI.PendingChanges.LogMessageEditor(this.components);
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.SuspendLayout();
			//
			// suppressLabel
			//
			this.suppressLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.suppressLabel.AutoSize = true;
			this.suppressLabel.Location = new System.Drawing.Point(12, 354);
			this.suppressLabel.Name = "suppressLabel";
			this.suppressLabel.Size = new System.Drawing.Size(284, 13);
			this.suppressLabel.TabIndex = 1;
			this.suppressLabel.Text = "You can suppress this dialog by holding down the Shift key";
			this.suppressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			//
			// btnCancel
			//
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(537, 365);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 24);
			this.btnCancel.TabIndex = 4;
			this.btnCancel.Text = "Cancel";
			//
			// okButton
			//
			this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.okButton.Location = new System.Drawing.Point(456, 365);
			this.okButton.Name = "okButton";
			this.okButton.Size = new System.Drawing.Size(75, 24);
			this.okButton.TabIndex = 3;
			this.okButton.Text = "OK";
			//
			// stealLocksCheckBox
			//
			this.stealLocksCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.stealLocksCheckBox.AutoSize = true;
			this.stealLocksCheckBox.Location = new System.Drawing.Point(12, 372);
			this.stealLocksCheckBox.Name = "stealLocksCheckBox";
			this.stealLocksCheckBox.Size = new System.Drawing.Size(82, 17);
			this.stealLocksCheckBox.TabIndex = 2;
			this.stealLocksCheckBox.Text = "&Steal Locks";
			//
			// splitContainer1
			//
			this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
			| System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.splitContainer1.Location = new System.Drawing.Point(12, 12);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			//
			// splitContainer1.Panel1
			//
			this.splitContainer1.Panel1.Controls.Add(this.pendingList);
			//
			// splitContainer1.Panel2
			//
			this.splitContainer1.Panel2.Controls.Add(this.logMessage);
			this.splitContainer1.Panel2.Controls.Add(this.label1);
			this.splitContainer1.Size = new System.Drawing.Size(600, 336);
			this.splitContainer1.SplitterDistance = 183;
			this.splitContainer1.TabIndex = 0;
			//
			// pendingList
			//
			this.pendingList.AllowColumnReorder = true;
			this.pendingList.CheckBoxes = true;
			this.pendingList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pendingList.HideSelection = false;
			this.pendingList.Location = new System.Drawing.Point(0, 0);
			this.pendingList.Name = "pendingList";
			this.pendingList.ShowSelectAllCheckBox = true;
			this.pendingList.Size = new System.Drawing.Size(600, 183);
			this.pendingList.TabIndex = 0;
			this.pendingList.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.pendingList_ItemChecked);
			//
			// logMessage
			//
			this.logMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
			| System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.logMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.logMessage.Location = new System.Drawing.Point(0, 23);
			this.logMessage.Name = "logMessage";
			this.logMessage.PendingChangeUI = this.pendingList;
			this.logMessage.Size = new System.Drawing.Size(600, 126);
			this.logMessage.TabIndex = 1;
			//
			// label1
			//
			this.label1.AutoSize = true;
			this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.label1.Location = new System.Drawing.Point(-3, 7);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Lock &Message:";
			//
			// LockDialog
			//
			this.AcceptButton = this.okButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(624, 400);
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.suppressLabel);
			this.Controls.Add(this.stealLocksCheckBox);
			this.Controls.Add(this.okButton);
			this.Controls.Add(this.btnCancel);
			this.EnableTheming = true;
			this.MinimumSize = new System.Drawing.Size(100, 39);
			this.Name = "LockDialog";
			this.Text = "Lock";
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		#endregion


		protected System.Windows.Forms.Label suppressLabel;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		protected System.Windows.Forms.Button btnCancel;
		protected System.Windows.Forms.Button okButton;
		private System.Windows.Forms.CheckBox stealLocksCheckBox;
		private Ankh.UI.VSSelectionControls.SmartSplitContainer splitContainer1;
		private PendingChanges.Commits.PendingCommitsView pendingList;
		private PendingChanges.LogMessageEditor logMessage;
		private System.Windows.Forms.Label label1;
	}
}
