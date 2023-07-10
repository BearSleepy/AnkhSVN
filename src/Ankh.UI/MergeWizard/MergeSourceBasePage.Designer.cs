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

namespace Ankh.UI.MergeWizard
{
	partial class MergeSourceBasePage
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

		#region Component Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.mergeFromComboBox = new System.Windows.Forms.ComboBox();
			this.selectButton = new System.Windows.Forms.Button();
			this.mergeFromLabel = new System.Windows.Forms.Label();
			this.wcBox = new System.Windows.Forms.GroupBox();
			this.wcUri = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.wcHistoryBtn = new System.Windows.Forms.Button();
			this.wcPath = new System.Windows.Forms.TextBox();
			this.dirLabel = new System.Windows.Forms.Label();
			this.wcBox.SuspendLayout();
			this.SuspendLayout();
			//
			// mergeFromComboBox
			//
			this.mergeFromComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.mergeFromComboBox.FormattingEnabled = true;
			this.mergeFromComboBox.Location = new System.Drawing.Point(63, 6);
			this.mergeFromComboBox.Margin = new System.Windows.Forms.Padding(0);
			this.mergeFromComboBox.MaxDropDownItems = 10;
			this.mergeFromComboBox.Name = "mergeFromComboBox";
			this.mergeFromComboBox.Size = new System.Drawing.Size(404, 21);
			this.mergeFromComboBox.TabIndex = 1;
			//
			// selectButton
			//
			this.selectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.selectButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.selectButton.Location = new System.Drawing.Point(470, 5);
			this.selectButton.Margin = new System.Windows.Forms.Padding(0);
			this.selectButton.Name = "selectButton";
			this.selectButton.Size = new System.Drawing.Size(25, 23);
			this.selectButton.TabIndex = 2;
			this.selectButton.Text = "...";
			this.selectButton.UseVisualStyleBackColor = true;
			this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
			//
			// mergeFromLabel
			//
			this.mergeFromLabel.AutoSize = true;
			this.mergeFromLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.mergeFromLabel.Location = new System.Drawing.Point(0, 10);
			this.mergeFromLabel.Margin = new System.Windows.Forms.Padding(0);
			this.mergeFromLabel.Name = "mergeFromLabel";
			this.mergeFromLabel.Size = new System.Drawing.Size(63, 13);
			this.mergeFromLabel.TabIndex = 0;
			this.mergeFromLabel.Text = "&Merge from:";
			//
			// wcBox
			//
			this.wcBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.wcBox.Controls.Add(this.wcUri);
			this.wcBox.Controls.Add(this.label1);
			this.wcBox.Controls.Add(this.wcHistoryBtn);
			this.wcBox.Controls.Add(this.wcPath);
			this.wcBox.Controls.Add(this.dirLabel);
			this.wcBox.Location = new System.Drawing.Point(5, 330);
			this.wcBox.Name = "wcBox";
			this.wcBox.Size = new System.Drawing.Size(490, 70);
			this.wcBox.TabIndex = 3;
			this.wcBox.TabStop = false;
			this.wcBox.Text = "Working Copy";
			//
			// wcUri
			//
			this.wcUri.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.wcUri.Location = new System.Drawing.Point(44, 38);
			this.wcUri.Name = "wcUri";
			this.wcUri.ReadOnly = true;
			this.wcUri.Size = new System.Drawing.Size(376, 20);
			this.wcUri.TabIndex = 4;
			//
			// label1
			//
			this.label1.AutoSize = true;
			this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.label1.Location = new System.Drawing.Point(6, 41);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(23, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Url:";
			//
			// wcHistoryBtn
			//
			this.wcHistoryBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.wcHistoryBtn.Location = new System.Drawing.Point(423, 14);
			this.wcHistoryBtn.Name = "wcHistoryBtn";
			this.wcHistoryBtn.Size = new System.Drawing.Size(61, 23);
			this.wcHistoryBtn.TabIndex = 2;
			this.wcHistoryBtn.Text = "&History";
			this.wcHistoryBtn.UseVisualStyleBackColor = true;
			this.wcHistoryBtn.Click += new System.EventHandler(this.wcHistoryBtn_Click);
			//
			// wcPath
			//
			this.wcPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.wcPath.Location = new System.Drawing.Point(44, 16);
			this.wcPath.Name = "wcPath";
			this.wcPath.ReadOnly = true;
			this.wcPath.Size = new System.Drawing.Size(376, 20);
			this.wcPath.TabIndex = 1;
			//
			// dirLabel
			//
			this.dirLabel.AutoSize = true;
			this.dirLabel.Location = new System.Drawing.Point(6, 19);
			this.dirLabel.Name = "dirLabel";
			this.dirLabel.Size = new System.Drawing.Size(32, 13);
			this.dirLabel.TabIndex = 0;
			this.dirLabel.Text = "&Path:";
			//
			// MergeSourceBasePage
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.wcBox);
			this.Controls.Add(this.mergeFromComboBox);
			this.Controls.Add(this.selectButton);
			this.Controls.Add(this.mergeFromLabel);
			this.Margin = new System.Windows.Forms.Padding(0);
			this.Name = "MergeSourceBasePage";
			this.Size = new System.Drawing.Size(500, 405);
			this.wcBox.ResumeLayout(false);
			this.wcBox.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		protected System.Windows.Forms.ComboBox mergeFromComboBox;
		private System.Windows.Forms.Button selectButton;
		private System.Windows.Forms.Label mergeFromLabel;
		private System.Windows.Forms.GroupBox wcBox;
		private System.Windows.Forms.Button wcHistoryBtn;
		private System.Windows.Forms.TextBox wcPath;
		private System.Windows.Forms.Label dirLabel;
		private System.Windows.Forms.TextBox wcUri;
		private System.Windows.Forms.Label label1;
	}
}
