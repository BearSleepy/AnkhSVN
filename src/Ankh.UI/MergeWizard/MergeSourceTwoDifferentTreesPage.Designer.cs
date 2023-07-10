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
	partial class MergeSourceTwoDifferentTreesPage
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
			this.fromGroupBox = new System.Windows.Forms.GroupBox();
			this.fromRevisionSelectButton = new System.Windows.Forms.Button();
			this.fromRevisionTextBox = new System.Windows.Forms.TextBox();
			this.fromRevisionRadioButton = new System.Windows.Forms.RadioButton();
			this.fromHEADRevisionRadioButton = new System.Windows.Forms.RadioButton();
			this.fromURLTextBox = new System.Windows.Forms.TextBox();
			this.fromURLSelectButton = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.useFromURLCheckBox = new System.Windows.Forms.CheckBox();
			this.toRevisionSelectButton = new System.Windows.Forms.Button();
			this.toRevisionTextBox = new System.Windows.Forms.TextBox();
			this.toRevisionRadioButton = new System.Windows.Forms.RadioButton();
			this.toHEADRevisionRadioButton = new System.Windows.Forms.RadioButton();
			this.toURLTextBox = new System.Windows.Forms.TextBox();
			this.toURLSelectButton = new System.Windows.Forms.Button();
			this.wcBox = new System.Windows.Forms.GroupBox();
			this.wcUri = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.wcHistoryBtn = new System.Windows.Forms.Button();
			this.wcPath = new System.Windows.Forms.TextBox();
			this.dirLabel = new System.Windows.Forms.Label();
			this.fromGroupBox.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.wcBox.SuspendLayout();
			this.SuspendLayout();
			//
			// fromGroupBox
			//
			this.fromGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.fromGroupBox.Controls.Add(this.fromRevisionSelectButton);
			this.fromGroupBox.Controls.Add(this.fromRevisionTextBox);
			this.fromGroupBox.Controls.Add(this.fromRevisionRadioButton);
			this.fromGroupBox.Controls.Add(this.fromHEADRevisionRadioButton);
			this.fromGroupBox.Controls.Add(this.fromURLTextBox);
			this.fromGroupBox.Controls.Add(this.fromURLSelectButton);
			this.fromGroupBox.Location = new System.Drawing.Point(5, 5);
			this.fromGroupBox.Margin = new System.Windows.Forms.Padding(0);
			this.fromGroupBox.Name = "fromGroupBox";
			this.fromGroupBox.Padding = new System.Windows.Forms.Padding(0);
			this.fromGroupBox.Size = new System.Drawing.Size(490, 67);
			this.fromGroupBox.TabIndex = 0;
			this.fromGroupBox.TabStop = false;
			this.fromGroupBox.Text = "&From: (start URL and revision of the range to merge)";
			//
			// fromRevisionSelectButton
			//
			this.fromRevisionSelectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.fromRevisionSelectButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.fromRevisionSelectButton.Location = new System.Drawing.Point(460, 39);
			this.fromRevisionSelectButton.Margin = new System.Windows.Forms.Padding(0);
			this.fromRevisionSelectButton.Name = "fromRevisionSelectButton";
			this.fromRevisionSelectButton.Size = new System.Drawing.Size(25, 23);
			this.fromRevisionSelectButton.TabIndex = 5;
			this.fromRevisionSelectButton.Text = "...";
			this.fromRevisionSelectButton.UseVisualStyleBackColor = true;
			this.fromRevisionSelectButton.Click += new System.EventHandler(this.fromRevisionSelectButton_Click);
			//
			// fromRevisionTextBox
			//
			this.fromRevisionTextBox.Location = new System.Drawing.Point(175, 40);
			this.fromRevisionTextBox.Margin = new System.Windows.Forms.Padding(0);
			this.fromRevisionTextBox.Name = "fromRevisionTextBox";
			this.fromRevisionTextBox.Size = new System.Drawing.Size(283, 20);
			this.fromRevisionTextBox.TabIndex = 4;
			this.fromRevisionTextBox.TextChanged += new System.EventHandler(this.fromRevisionTextBox_TextChanged);
			//
			// fromRevisionRadioButton
			//
			this.fromRevisionRadioButton.AutoSize = true;
			this.fromRevisionRadioButton.Checked = true;
			this.fromRevisionRadioButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.fromRevisionRadioButton.Location = new System.Drawing.Point(109, 41);
			this.fromRevisionRadioButton.Margin = new System.Windows.Forms.Padding(0);
			this.fromRevisionRadioButton.Name = "fromRevisionRadioButton";
			this.fromRevisionRadioButton.Size = new System.Drawing.Size(66, 17);
			this.fromRevisionRadioButton.TabIndex = 3;
			this.fromRevisionRadioButton.TabStop = true;
			this.fromRevisionRadioButton.Text = "&Revision";
			this.fromRevisionRadioButton.UseVisualStyleBackColor = true;
			this.fromRevisionRadioButton.CheckedChanged += new System.EventHandler(this.fromRevisionRadioButton_CheckedChanged);
			//
			// fromHEADRevisionRadioButton
			//
			this.fromHEADRevisionRadioButton.AutoSize = true;
			this.fromHEADRevisionRadioButton.Location = new System.Drawing.Point(10, 41);
			this.fromHEADRevisionRadioButton.Margin = new System.Windows.Forms.Padding(0);
			this.fromHEADRevisionRadioButton.Name = "fromHEADRevisionRadioButton";
			this.fromHEADRevisionRadioButton.Size = new System.Drawing.Size(92, 17);
			this.fromHEADRevisionRadioButton.TabIndex = 2;
			this.fromHEADRevisionRadioButton.Text = "&Latest Version";
			this.fromHEADRevisionRadioButton.UseVisualStyleBackColor = true;
			this.fromHEADRevisionRadioButton.CheckedChanged += new System.EventHandler(this.fromHeadRevisionRadioButton_CheckedChanged);
			//
			// fromURLTextBox
			//
			this.fromURLTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.fromURLTextBox.Location = new System.Drawing.Point(10, 15);
			this.fromURLTextBox.Margin = new System.Windows.Forms.Padding(0);
			this.fromURLTextBox.Name = "fromURLTextBox";
			this.fromURLTextBox.Size = new System.Drawing.Size(448, 20);
			this.fromURLTextBox.TabIndex = 0;
			this.fromURLTextBox.TextChanged += new System.EventHandler(this.fromURLTextBox_TextChanged);
			//
			// fromURLSelectButton
			//
			this.fromURLSelectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.fromURLSelectButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.fromURLSelectButton.Location = new System.Drawing.Point(460, 14);
			this.fromURLSelectButton.Margin = new System.Windows.Forms.Padding(0);
			this.fromURLSelectButton.Name = "fromURLSelectButton";
			this.fromURLSelectButton.Size = new System.Drawing.Size(25, 23);
			this.fromURLSelectButton.TabIndex = 1;
			this.fromURLSelectButton.Text = "...";
			this.fromURLSelectButton.UseVisualStyleBackColor = true;
			this.fromURLSelectButton.Click += new System.EventHandler(this.fromURLSelectButton_Click);
			//
			// groupBox1
			//
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.useFromURLCheckBox);
			this.groupBox1.Controls.Add(this.toRevisionSelectButton);
			this.groupBox1.Controls.Add(this.toRevisionTextBox);
			this.groupBox1.Controls.Add(this.toRevisionRadioButton);
			this.groupBox1.Controls.Add(this.toHEADRevisionRadioButton);
			this.groupBox1.Controls.Add(this.toURLTextBox);
			this.groupBox1.Controls.Add(this.toURLSelectButton);
			this.groupBox1.Location = new System.Drawing.Point(5, 77);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(0);
			this.groupBox1.Size = new System.Drawing.Size(490, 87);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "&To: (end URL and revision of the range to merge)";
			//
			// useFromURLCheckBox
			//
			this.useFromURLCheckBox.AutoSize = true;
			this.useFromURLCheckBox.Checked = true;
			this.useFromURLCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.useFromURLCheckBox.Location = new System.Drawing.Point(10, 15);
			this.useFromURLCheckBox.Margin = new System.Windows.Forms.Padding(0);
			this.useFromURLCheckBox.Name = "useFromURLCheckBox";
			this.useFromURLCheckBox.Size = new System.Drawing.Size(106, 17);
			this.useFromURLCheckBox.TabIndex = 0;
			this.useFromURLCheckBox.Text = "Use \"From\" URL";
			this.useFromURLCheckBox.UseVisualStyleBackColor = true;
			this.useFromURLCheckBox.CheckedChanged += new System.EventHandler(this.useFromURLCheckBox_CheckedChanged);
			//
			// toRevisionSelectButton
			//
			this.toRevisionSelectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.toRevisionSelectButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.toRevisionSelectButton.Location = new System.Drawing.Point(460, 59);
			this.toRevisionSelectButton.Margin = new System.Windows.Forms.Padding(0);
			this.toRevisionSelectButton.Name = "toRevisionSelectButton";
			this.toRevisionSelectButton.Size = new System.Drawing.Size(25, 23);
			this.toRevisionSelectButton.TabIndex = 6;
			this.toRevisionSelectButton.Text = "...";
			this.toRevisionSelectButton.UseVisualStyleBackColor = true;
			this.toRevisionSelectButton.Click += new System.EventHandler(this.toRevisionSelectButton_Click);
			//
			// toRevisionTextBox
			//
			this.toRevisionTextBox.Location = new System.Drawing.Point(175, 60);
			this.toRevisionTextBox.Margin = new System.Windows.Forms.Padding(0);
			this.toRevisionTextBox.Name = "toRevisionTextBox";
			this.toRevisionTextBox.Size = new System.Drawing.Size(283, 20);
			this.toRevisionTextBox.TabIndex = 5;
			this.toRevisionTextBox.TextChanged += new System.EventHandler(this.toRevisionTextBox_TextChanged);
			//
			// toRevisionRadioButton
			//
			this.toRevisionRadioButton.AutoSize = true;
			this.toRevisionRadioButton.Checked = true;
			this.toRevisionRadioButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.toRevisionRadioButton.Location = new System.Drawing.Point(109, 61);
			this.toRevisionRadioButton.Margin = new System.Windows.Forms.Padding(0);
			this.toRevisionRadioButton.Name = "toRevisionRadioButton";
			this.toRevisionRadioButton.Size = new System.Drawing.Size(66, 17);
			this.toRevisionRadioButton.TabIndex = 4;
			this.toRevisionRadioButton.TabStop = true;
			this.toRevisionRadioButton.Text = "Revi&sion";
			this.toRevisionRadioButton.UseVisualStyleBackColor = true;
			this.toRevisionRadioButton.CheckedChanged += new System.EventHandler(this.toRevisionRadioButton_CheckedChanged);
			//
			// toHEADRevisionRadioButton
			//
			this.toHEADRevisionRadioButton.AutoSize = true;
			this.toHEADRevisionRadioButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.toHEADRevisionRadioButton.Location = new System.Drawing.Point(10, 61);
			this.toHEADRevisionRadioButton.Margin = new System.Windows.Forms.Padding(0);
			this.toHEADRevisionRadioButton.Name = "toHEADRevisionRadioButton";
			this.toHEADRevisionRadioButton.Size = new System.Drawing.Size(92, 17);
			this.toHEADRevisionRadioButton.TabIndex = 3;
			this.toHEADRevisionRadioButton.Text = "Latest &Version";
			this.toHEADRevisionRadioButton.UseVisualStyleBackColor = true;
			this.toHEADRevisionRadioButton.CheckedChanged += new System.EventHandler(this.toHEADRevisionRadioButton_CheckedChanged);
			//
			// toURLTextBox
			//
			this.toURLTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.toURLTextBox.Enabled = false;
			this.toURLTextBox.Location = new System.Drawing.Point(10, 35);
			this.toURLTextBox.Margin = new System.Windows.Forms.Padding(0);
			this.toURLTextBox.Name = "toURLTextBox";
			this.toURLTextBox.Size = new System.Drawing.Size(448, 20);
			this.toURLTextBox.TabIndex = 1;
			this.toURLTextBox.Visible = false;
			this.toURLTextBox.TextChanged += new System.EventHandler(this.toURLTextBox_TextChanged);
			//
			// toURLSelectButton
			//
			this.toURLSelectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.toURLSelectButton.Enabled = false;
			this.toURLSelectButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.toURLSelectButton.Location = new System.Drawing.Point(460, 34);
			this.toURLSelectButton.Margin = new System.Windows.Forms.Padding(0);
			this.toURLSelectButton.Name = "toURLSelectButton";
			this.toURLSelectButton.Size = new System.Drawing.Size(25, 23);
			this.toURLSelectButton.TabIndex = 2;
			this.toURLSelectButton.Text = "...";
			this.toURLSelectButton.UseVisualStyleBackColor = true;
			this.toURLSelectButton.Visible = false;
			this.toURLSelectButton.Click += new System.EventHandler(this.toURLSelectButton_Click);
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
			this.wcBox.TabIndex = 2;
			this.wcBox.TabStop = false;
			this.wcBox.Text = "Working Copy";
			//
			// wcUri
			//
			this.wcUri.Location = new System.Drawing.Point(44, 38);
			this.wcUri.Name = "wcUri";
			this.wcUri.ReadOnly = true;
			this.wcUri.Size = new System.Drawing.Size(361, 20);
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
			this.wcHistoryBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.wcHistoryBtn.Location = new System.Drawing.Point(409, 14);
			this.wcHistoryBtn.Name = "wcHistoryBtn";
			this.wcHistoryBtn.Size = new System.Drawing.Size(75, 23);
			this.wcHistoryBtn.TabIndex = 2;
			this.wcHistoryBtn.Text = "&History";
			this.wcHistoryBtn.UseVisualStyleBackColor = true;
			this.wcHistoryBtn.Click += new System.EventHandler(this.wcHistoryBtn_Click);
			//
			// wcPath
			//
			this.wcPath.Location = new System.Drawing.Point(44, 16);
			this.wcPath.Name = "wcPath";
			this.wcPath.ReadOnly = true;
			this.wcPath.Size = new System.Drawing.Size(361, 20);
			this.wcPath.TabIndex = 1;
			//
			// dirLabel
			//
			this.dirLabel.AutoSize = true;
			this.dirLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.dirLabel.Location = new System.Drawing.Point(6, 19);
			this.dirLabel.Name = "dirLabel";
			this.dirLabel.Size = new System.Drawing.Size(32, 13);
			this.dirLabel.TabIndex = 0;
			this.dirLabel.Text = "&Path:";
			//
			// MergeSourceTwoDifferentTreesPage
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.wcBox);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.fromGroupBox);
			this.Margin = new System.Windows.Forms.Padding(0);
			this.Name = "MergeSourceTwoDifferentTreesPage";
			this.Size = new System.Drawing.Size(500, 405);
			this.Load += new System.EventHandler(this.MergeSourceTwoDifferentTreesPage_Load);
			this.fromGroupBox.ResumeLayout(false);
			this.fromGroupBox.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.wcBox.ResumeLayout(false);
			this.wcBox.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox fromGroupBox;
		private System.Windows.Forms.Button fromURLSelectButton;
		private System.Windows.Forms.TextBox fromURLTextBox;
		private System.Windows.Forms.RadioButton fromHEADRevisionRadioButton;
		private System.Windows.Forms.RadioButton fromRevisionRadioButton;
		private System.Windows.Forms.TextBox fromRevisionTextBox;
		private System.Windows.Forms.Button fromRevisionSelectButton;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.CheckBox useFromURLCheckBox;
		private System.Windows.Forms.Button toRevisionSelectButton;
		private System.Windows.Forms.TextBox toRevisionTextBox;
		private System.Windows.Forms.RadioButton toRevisionRadioButton;
		private System.Windows.Forms.RadioButton toHEADRevisionRadioButton;
		private System.Windows.Forms.TextBox toURLTextBox;
		private System.Windows.Forms.Button toURLSelectButton;
		private System.Windows.Forms.GroupBox wcBox;
		private System.Windows.Forms.TextBox wcUri;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button wcHistoryBtn;
		private System.Windows.Forms.TextBox wcPath;
		private System.Windows.Forms.Label dirLabel;
	}
}
