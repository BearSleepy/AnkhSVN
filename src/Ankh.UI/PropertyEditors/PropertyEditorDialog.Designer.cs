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

namespace Ankh.UI.PropertyEditors
{
	partial class PropertyEditorDialog
	{
		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.editButton = new System.Windows.Forms.Button();
			this.deleteButton = new System.Windows.Forms.Button();
			this.okButton = new System.Windows.Forms.Button();
			this.cancelButton = new System.Windows.Forms.Button();
			this.addButton = new System.Windows.Forms.Button();
			this.propGroupBox = new System.Windows.Forms.GroupBox();
			this.svnItemLabel = new System.Windows.Forms.Label();
			this.revertButton = new System.Windows.Forms.Button();
			this.propListView = new Ankh.UI.VSSelectionControls.SmartListView();
			this.nameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.stateColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.originalValueColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.valueColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.propGroupBox.SuspendLayout();
			this.SuspendLayout();
			//
			// editButton
			//
			this.editButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.editButton.Enabled = false;
			this.editButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.editButton.Location = new System.Drawing.Point(93, 259);
			this.editButton.Name = "editButton";
			this.editButton.Size = new System.Drawing.Size(75, 23);
			this.editButton.TabIndex = 3;
			this.editButton.Text = "&Edit...";
			this.editButton.Click += new System.EventHandler(this.editButton_Click);
			//
			// deleteButton
			//
			this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.deleteButton.Enabled = false;
			this.deleteButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.deleteButton.Location = new System.Drawing.Point(174, 259);
			this.deleteButton.Name = "deleteButton";
			this.deleteButton.Size = new System.Drawing.Size(75, 23);
			this.deleteButton.TabIndex = 4;
			this.deleteButton.Text = "&Delete";
			this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
			//
			// okButton
			//
			this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.okButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.okButton.Location = new System.Drawing.Point(442, 303);
			this.okButton.Name = "okButton";
			this.okButton.Size = new System.Drawing.Size(75, 23);
			this.okButton.TabIndex = 6;
			this.okButton.Text = "OK";
			//
			// cancelButton
			//
			this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cancelButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.cancelButton.Location = new System.Drawing.Point(523, 303);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(75, 23);
			this.cancelButton.TabIndex = 7;
			this.cancelButton.Text = "Cancel";
			//
			// addButton
			//
			this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.addButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.addButton.Location = new System.Drawing.Point(12, 259);
			this.addButton.Name = "addButton";
			this.addButton.Size = new System.Drawing.Size(75, 23);
			this.addButton.TabIndex = 2;
			this.addButton.Text = "&Add...";
			this.addButton.Click += new System.EventHandler(this.addButton_Click);
			//
			// propGroupBox
			//
			this.propGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.propGroupBox.Controls.Add(this.svnItemLabel);
			this.propGroupBox.Location = new System.Drawing.Point(12, 12);
			this.propGroupBox.Name = "propGroupBox";
			this.propGroupBox.Size = new System.Drawing.Size(586, 36);
			this.propGroupBox.TabIndex = 0;
			this.propGroupBox.TabStop = false;
			this.propGroupBox.Text = "Properties for";
			//
			// svnItemLabel
			//
			this.svnItemLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.svnItemLabel.AutoEllipsis = true;
			this.svnItemLabel.AutoSize = true;
			this.svnItemLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.svnItemLabel.Location = new System.Drawing.Point(6, 16);
			this.svnItemLabel.Name = "svnItemLabel";
			this.svnItemLabel.Size = new System.Drawing.Size(94, 13);
			this.svnItemLabel.TabIndex = 0;
			this.svnItemLabel.Text = "Selected Svn Item";
			//
			// revertButton
			//
			this.revertButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.revertButton.Enabled = false;
			this.revertButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.revertButton.Location = new System.Drawing.Point(255, 259);
			this.revertButton.Name = "revertButton";
			this.revertButton.Size = new System.Drawing.Size(75, 23);
			this.revertButton.TabIndex = 5;
			this.revertButton.Text = "&Revert";
			this.revertButton.Click += new System.EventHandler(this.revertButton_Click);
			//
			// propListView
			//
			this.propListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
			| System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.propListView.AutoArrange = false;
			this.propListView.GridLines = true;
			this.propListView.HideSelection = false;
			this.propListView.Location = new System.Drawing.Point(12, 54);
			this.propListView.Name = "propListView";
			this.propListView.Size = new System.Drawing.Size(586, 199);
			this.propListView.TabIndex = 1;
			this.propListView.SelectedIndexChanged += new System.EventHandler(this.propListView_SelectedIndexChanged);
			this.propListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.propListView_MouseDoubleClick);
			//
			// nameColumn
			//
			this.nameColumn.Text = "Name";
			this.nameColumn.Width = 120;
			//
			// stateColumn
			//
			this.stateColumn.Text = "State";
			this.stateColumn.Width = 80;
			//
			// originalValueColumn
			//
			this.originalValueColumn.Text = "Original Value";
			this.originalValueColumn.Width = 130;
			//
			// valueColumn
			//
			this.valueColumn.Text = "Current Value";
			this.valueColumn.Width = 130;
			//
			// PropertyEditorDialog
			//
			this.AcceptButton = this.okButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.CancelButton = this.cancelButton;
			this.ClientSize = new System.Drawing.Size(610, 338);
			this.Controls.Add(this.propGroupBox);
			this.Controls.Add(this.propListView);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.addButton);
			this.Controls.Add(this.okButton);
			this.Controls.Add(this.revertButton);
			this.Controls.Add(this.deleteButton);
			this.Controls.Add(this.editButton);
			this.Name = "PropertyEditorDialog";
			this.Text = "SVN Properties";
			this.propGroupBox.ResumeLayout(false);
			this.propGroupBox.PerformLayout();
			this.ResumeLayout(false);

		}
		#endregion

		private System.Windows.Forms.ColumnHeader nameColumn;
		private System.Windows.Forms.ColumnHeader originalValueColumn;
		private System.Windows.Forms.Button okButton;
		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.Button deleteButton;
		private Ankh.UI.VSSelectionControls.SmartListView propListView;
		private System.Windows.Forms.Button editButton;
		private System.Windows.Forms.Button addButton;

		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.GroupBox propGroupBox;
		private System.Windows.Forms.Label svnItemLabel;
		private System.Windows.Forms.ColumnHeader stateColumn;
		private System.Windows.Forms.ColumnHeader valueColumn;
		private System.Windows.Forms.Button revertButton;
	}
}
