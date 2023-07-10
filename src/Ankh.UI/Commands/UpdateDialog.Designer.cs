// Copyright 2008 The AnkhSVN Project
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

namespace Ankh.UI.Commands
{
	partial class UpdateDialog
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
			this.projectRootLabel = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.projectRootBox = new System.Windows.Forms.TextBox();
			this.urlBox = new System.Windows.Forms.TextBox();
			this.versionBox = new Ankh.UI.PathSelector.VersionSelector();
			this.ignoreExternals = new System.Windows.Forms.CheckBox();
			this.allowObstructions = new System.Windows.Forms.CheckBox();
			this.okButton = new System.Windows.Forms.Button();
			this.cancelButton = new System.Windows.Forms.Button();
			this.makeDepthInfinity = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			//
			// projectRootLabel
			//
			this.projectRootLabel.AutoSize = true;
			this.projectRootLabel.Location = new System.Drawing.Point(12, 9);
			this.projectRootLabel.Name = "projectRootLabel";
			this.projectRootLabel.Size = new System.Drawing.Size(69, 13);
			this.projectRootLabel.TabIndex = 6;
			this.projectRootLabel.Text = "&Project Root:";
			//
			// label4
			//
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 35);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(23, 13);
			this.label4.TabIndex = 8;
			this.label4.Text = "&Url:";
			//
			// projectRootBox
			//
			this.projectRootBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.projectRootBox.Location = new System.Drawing.Point(87, 6);
			this.projectRootBox.Name = "projectRootBox";
			this.projectRootBox.ReadOnly = true;
			this.projectRootBox.Size = new System.Drawing.Size(379, 20);
			this.projectRootBox.TabIndex = 7;
			//
			// urlBox
			//
			this.urlBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.urlBox.Location = new System.Drawing.Point(87, 32);
			this.urlBox.Name = "urlBox";
			this.urlBox.ReadOnly = true;
			this.urlBox.Size = new System.Drawing.Size(379, 20);
			this.urlBox.TabIndex = 9;
			//
			// versionBox
			//
			this.versionBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.versionBox.Location = new System.Drawing.Point(87, 58);
			this.versionBox.Name = "versionBox";
			this.versionBox.Size = new System.Drawing.Size(379, 25);
			this.versionBox.SvnOrigin = null;
			this.versionBox.TabIndex = 0;
			//
			// ignoreExternals
			//
			this.ignoreExternals.AutoSize = true;
			this.ignoreExternals.Location = new System.Drawing.Point(87, 93);
			this.ignoreExternals.Name = "ignoreExternals";
			this.ignoreExternals.Size = new System.Drawing.Size(102, 17);
			this.ignoreExternals.TabIndex = 1;
			this.ignoreExternals.Text = "Ignore E&xternals";
			this.ignoreExternals.UseVisualStyleBackColor = true;
			//
			// allowObstructions
			//
			this.allowObstructions.AutoSize = true;
			this.allowObstructions.Location = new System.Drawing.Point(87, 116);
			this.allowObstructions.Name = "allowObstructions";
			this.allowObstructions.Size = new System.Drawing.Size(176, 17);
			this.allowObstructions.TabIndex = 2;
			this.allowObstructions.Text = "Allow Unversioned O&bstructions";
			this.allowObstructions.UseVisualStyleBackColor = true;
			//
			// okButton
			//
			this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.okButton.Location = new System.Drawing.Point(310, 161);
			this.okButton.Name = "okButton";
			this.okButton.Size = new System.Drawing.Size(75, 23);
			this.okButton.TabIndex = 4;
			this.okButton.Text = "OK";
			this.okButton.UseVisualStyleBackColor = true;
			//
			// cancelButton
			//
			this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cancelButton.Location = new System.Drawing.Point(391, 161);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(75, 23);
			this.cancelButton.TabIndex = 5;
			this.cancelButton.Text = "Cancel";
			this.cancelButton.UseVisualStyleBackColor = true;
			//
			// makeDepthInfinity
			//
			this.makeDepthInfinity.AutoSize = true;
			this.makeDepthInfinity.Location = new System.Drawing.Point(87, 139);
			this.makeDepthInfinity.Name = "makeDepthInfinity";
			this.makeDepthInfinity.Size = new System.Drawing.Size(141, 17);
			this.makeDepthInfinity.TabIndex = 3;
			this.makeDepthInfinity.Text = "Retrieve Exc&luded Items";
			this.makeDepthInfinity.UseVisualStyleBackColor = true;
			//
			// UpdateDialog
			//
			this.AcceptButton = this.okButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.CancelButton = this.cancelButton;
			this.ClientSize = new System.Drawing.Size(478, 196);
			this.Controls.Add(this.makeDepthInfinity);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.okButton);
			this.Controls.Add(this.allowObstructions);
			this.Controls.Add(this.ignoreExternals);
			this.Controls.Add(this.versionBox);
			this.Controls.Add(this.urlBox);
			this.Controls.Add(this.projectRootBox);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.projectRootLabel);
			this.Name = "UpdateDialog";
			this.Text = "Update Solution";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label projectRootLabel;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox projectRootBox;
		private System.Windows.Forms.TextBox urlBox;
		private Ankh.UI.PathSelector.VersionSelector versionBox;
		private System.Windows.Forms.CheckBox ignoreExternals;
		private System.Windows.Forms.CheckBox allowObstructions;
		private System.Windows.Forms.Button okButton;
		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.CheckBox makeDepthInfinity;
	}
}