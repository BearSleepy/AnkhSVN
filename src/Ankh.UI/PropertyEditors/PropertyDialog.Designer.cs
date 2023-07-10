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

namespace Ankh.UI.PropertyEditors
{
	partial class PropertyDialog
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
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
			this.nameLabel = new System.Windows.Forms.Label();
			this.nameComboBox = new System.Windows.Forms.ComboBox();
			this.editorPanel = new System.Windows.Forms.Panel();
			this.okButton = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.loadButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			//
			// nameLabel
			//
			this.nameLabel.AutoSize = true;
			this.nameLabel.Location = new System.Drawing.Point(9, 19);
			this.nameLabel.Name = "nameLabel";
			this.nameLabel.Size = new System.Drawing.Size(80, 13);
			this.nameLabel.TabIndex = 0;
			this.nameLabel.Text = "Property &Name:";
			//
			// nameComboBox
			//
			this.nameComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.nameComboBox.Location = new System.Drawing.Point(98, 16);
			this.nameComboBox.Name = "nameComboBox";
			this.nameComboBox.Size = new System.Drawing.Size(311, 21);
			this.nameComboBox.Sorted = true;
			this.nameComboBox.TabIndex = 1;
			this.nameComboBox.SelectedValueChanged += new System.EventHandler(this.nameComboBox_SelectedValueChanged);
			this.nameComboBox.TextChanged += new System.EventHandler(this.nameComboBox_TextChanged);
			//
			// editorPanel
			//
			this.editorPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
			| System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.editorPanel.Location = new System.Drawing.Point(12, 52);
			this.editorPanel.Name = "editorPanel";
			this.editorPanel.Size = new System.Drawing.Size(396, 206);
			this.editorPanel.TabIndex = 2;
			//
			// okButton
			//
			this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.okButton.Enabled = false;
			this.okButton.Location = new System.Drawing.Point(253, 306);
			this.okButton.Name = "okButton";
			this.okButton.Size = new System.Drawing.Size(75, 23);
			this.okButton.TabIndex = 6;
			this.okButton.Text = "OK";
			this.okButton.UseVisualStyleBackColor = true;
			//
			// buttonCancel
			//
			this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonCancel.CausesValidation = false;
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(334, 306);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 7;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			//
			// label1
			//
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.label1.Location = new System.Drawing.Point(12, 306);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(234, 32);
			this.label1.TabIndex = 5;
			this.label1.Text = "Type your own property name to add a custom property.";
			//
			// loadButton
			//
			this.loadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.loadButton.Location = new System.Drawing.Point(333, 264);
			this.loadButton.Name = "loadButton";
			this.loadButton.Size = new System.Drawing.Size(75, 23);
			this.loadButton.TabIndex = 4;
			this.loadButton.Text = "&Load...";
			this.loadButton.UseVisualStyleBackColor = true;
			this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
			//
			// PropertyDialog
			//
			this.AcceptButton = this.okButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.CancelButton = this.buttonCancel;
			this.ClientSize = new System.Drawing.Size(420, 341);
			this.Controls.Add(this.loadButton);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.okButton);
			this.Controls.Add(this.editorPanel);
			this.Controls.Add(this.nameComboBox);
			this.Controls.Add(this.nameLabel);
			this.Name = "PropertyDialog";
			this.Text = "Add/Edit Property";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label nameLabel;
		private System.Windows.Forms.ComboBox nameComboBox;
		private System.Windows.Forms.Panel editorPanel;
		private System.Windows.Forms.Button okButton;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button loadButton;
	}
}
