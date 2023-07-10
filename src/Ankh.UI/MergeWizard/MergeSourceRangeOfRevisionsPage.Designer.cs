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
	partial class MergeSourceRangeOfRevisionsPage
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
			this.revisionsGroupBox = new System.Windows.Forms.GroupBox();
			this.selectRevisionsRadioButton = new System.Windows.Forms.RadioButton();
			this.allRevisionsRadioButton = new System.Windows.Forms.RadioButton();
			this.revisionsGroupBox.SuspendLayout();
			this.SuspendLayout();
			//
			// revisionsGroupBox
			//
			this.revisionsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.revisionsGroupBox.Controls.Add(this.selectRevisionsRadioButton);
			this.revisionsGroupBox.Controls.Add(this.allRevisionsRadioButton);
			this.revisionsGroupBox.Location = new System.Drawing.Point(5, 30);
			this.revisionsGroupBox.Margin = new System.Windows.Forms.Padding(0);
			this.revisionsGroupBox.Name = "revisionsGroupBox";
			this.revisionsGroupBox.Padding = new System.Windows.Forms.Padding(0);
			this.revisionsGroupBox.Size = new System.Drawing.Size(490, 65);
			this.revisionsGroupBox.TabIndex = 7;
			this.revisionsGroupBox.TabStop = false;
			this.revisionsGroupBox.Text = "Revisions";
			//
			// selectRevisionsRadioButton
			//
			this.selectRevisionsRadioButton.AutoSize = true;
			this.selectRevisionsRadioButton.Checked = true;
			this.selectRevisionsRadioButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.selectRevisionsRadioButton.Location = new System.Drawing.Point(10, 40);
			this.selectRevisionsRadioButton.Margin = new System.Windows.Forms.Padding(0);
			this.selectRevisionsRadioButton.Name = "selectRevisionsRadioButton";
			this.selectRevisionsRadioButton.Size = new System.Drawing.Size(182, 17);
			this.selectRevisionsRadioButton.TabIndex = 4;
			this.selectRevisionsRadioButton.TabStop = true;
			this.selectRevisionsRadioButton.Text = "&Select revisions on the next page";
			this.selectRevisionsRadioButton.UseVisualStyleBackColor = true;
			this.selectRevisionsRadioButton.CheckedChanged += new System.EventHandler(this.selectRevisionsRadioButton_CheckedChanged);
			//
			// allRevisionsRadioButton
			//
			this.allRevisionsRadioButton.AutoSize = true;
			this.allRevisionsRadioButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.allRevisionsRadioButton.Location = new System.Drawing.Point(10, 20);
			this.allRevisionsRadioButton.Margin = new System.Windows.Forms.Padding(0);
			this.allRevisionsRadioButton.Name = "allRevisionsRadioButton";
			this.allRevisionsRadioButton.Size = new System.Drawing.Size(115, 17);
			this.allRevisionsRadioButton.TabIndex = 3;
			this.allRevisionsRadioButton.Text = "&All eligible revisions";
			this.allRevisionsRadioButton.UseVisualStyleBackColor = true;
			this.allRevisionsRadioButton.CheckedChanged += new System.EventHandler(this.allRevisionsRadioButton_CheckedChanged);
			//
			// MergeSourceRangeOfRevisionsPage
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.revisionsGroupBox);
			this.Name = "MergeSourceRangeOfRevisionsPage";
			this.Controls.SetChildIndex(this.mergeFromComboBox, 0);
			this.Controls.SetChildIndex(this.revisionsGroupBox, 0);
			this.revisionsGroupBox.ResumeLayout(false);
			this.revisionsGroupBox.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox revisionsGroupBox;
		private System.Windows.Forms.RadioButton selectRevisionsRadioButton;
		private System.Windows.Forms.RadioButton allRevisionsRadioButton;

	}
}
