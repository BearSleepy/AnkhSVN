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
	partial class MergeTypePage
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
			this.mergeTypeGroupBox = new System.Windows.Forms.GroupBox();
			this.manuallyRemoveRadioButton = new System.Windows.Forms.RadioButton();
			this.manuallyRecordRadioButton = new System.Windows.Forms.RadioButton();
			this.twoDifferentTreesRadioButton = new System.Windows.Forms.RadioButton();
			this.reintegrateABranchRadioButton = new System.Windows.Forms.RadioButton();
			this.rangeOfRevisionsRadioButton = new System.Windows.Forms.RadioButton();
			this.mergeTypeDescriptionGroupBox = new System.Windows.Forms.GroupBox();
			this.mergeTypeDescriptionLabel = new System.Windows.Forms.Label();
			this.mergeTypePictureBox = new System.Windows.Forms.PictureBox();
			this.showBestPracticesPageCheckbox = new System.Windows.Forms.CheckBox();
			this.disclaimerLabel = new System.Windows.Forms.Label();
			this.mergeTypeGroupBox.SuspendLayout();
			this.mergeTypeDescriptionGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.mergeTypePictureBox)).BeginInit();
			this.SuspendLayout();
			//
			// mergeTypeGroupBox
			//
			this.mergeTypeGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.mergeTypeGroupBox.Controls.Add(this.manuallyRemoveRadioButton);
			this.mergeTypeGroupBox.Controls.Add(this.manuallyRecordRadioButton);
			this.mergeTypeGroupBox.Controls.Add(this.twoDifferentTreesRadioButton);
			this.mergeTypeGroupBox.Controls.Add(this.reintegrateABranchRadioButton);
			this.mergeTypeGroupBox.Controls.Add(this.rangeOfRevisionsRadioButton);
			this.mergeTypeGroupBox.Location = new System.Drawing.Point(5, 5);
			this.mergeTypeGroupBox.Margin = new System.Windows.Forms.Padding(0);
			this.mergeTypeGroupBox.Name = "mergeTypeGroupBox";
			this.mergeTypeGroupBox.Size = new System.Drawing.Size(490, 125);
			this.mergeTypeGroupBox.TabIndex = 0;
			this.mergeTypeGroupBox.TabStop = false;
			this.mergeTypeGroupBox.Text = "Merge Input";
			//
			// manuallyRemoveRadioButton
			//
			this.manuallyRemoveRadioButton.AutoSize = true;
			this.manuallyRemoveRadioButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.manuallyRemoveRadioButton.Location = new System.Drawing.Point(10, 100);
			this.manuallyRemoveRadioButton.Margin = new System.Windows.Forms.Padding(0);
			this.manuallyRemoveRadioButton.Name = "manuallyRemoveRadioButton";
			this.manuallyRemoveRadioButton.Size = new System.Drawing.Size(345, 17);
			this.manuallyRemoveRadioButton.TabIndex = 5;
			this.manuallyRemoveRadioButton.Text = "Ma&nually remove merge information (unblock one or more revisions)*";
			this.manuallyRemoveRadioButton.UseVisualStyleBackColor = true;
			this.manuallyRemoveRadioButton.CheckedChanged += new System.EventHandler(this.manuallyRemoveRadioButton_CheckedChanged);
			//
			// manuallyRecordRadioButton
			//
			this.manuallyRecordRadioButton.AutoSize = true;
			this.manuallyRecordRadioButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.manuallyRecordRadioButton.Location = new System.Drawing.Point(10, 80);
			this.manuallyRecordRadioButton.Margin = new System.Windows.Forms.Padding(0);
			this.manuallyRecordRadioButton.Name = "manuallyRecordRadioButton";
			this.manuallyRecordRadioButton.Size = new System.Drawing.Size(328, 17);
			this.manuallyRecordRadioButton.TabIndex = 4;
			this.manuallyRecordRadioButton.Text = "M&anually record merge information (block one or more revisions)*";
			this.manuallyRecordRadioButton.UseVisualStyleBackColor = true;
			this.manuallyRecordRadioButton.CheckedChanged += new System.EventHandler(this.manuallyRecordMergeRadioButton_CheckedChanged);
			//
			// twoDifferentTreesRadioButton
			//
			this.twoDifferentTreesRadioButton.AutoSize = true;
			this.twoDifferentTreesRadioButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.twoDifferentTreesRadioButton.Location = new System.Drawing.Point(10, 60);
			this.twoDifferentTreesRadioButton.Margin = new System.Windows.Forms.Padding(0);
			this.twoDifferentTreesRadioButton.Name = "twoDifferentTreesRadioButton";
			this.twoDifferentTreesRadioButton.Size = new System.Drawing.Size(142, 17);
			this.twoDifferentTreesRadioButton.TabIndex = 3;
			this.twoDifferentTreesRadioButton.Text = "Merge &two different trees";
			this.twoDifferentTreesRadioButton.UseVisualStyleBackColor = true;
			this.twoDifferentTreesRadioButton.CheckedChanged += new System.EventHandler(this.twoDifferentTreesRadioButton_CheckedChanged);
			//
			// reintegrateABranchRadioButton
			//
			this.reintegrateABranchRadioButton.AutoSize = true;
			this.reintegrateABranchRadioButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.reintegrateABranchRadioButton.Location = new System.Drawing.Point(10, 40);
			this.reintegrateABranchRadioButton.Margin = new System.Windows.Forms.Padding(0);
			this.reintegrateABranchRadioButton.Name = "reintegrateABranchRadioButton";
			this.reintegrateABranchRadioButton.Size = new System.Drawing.Size(129, 17);
			this.reintegrateABranchRadioButton.TabIndex = 1;
			this.reintegrateABranchRadioButton.Text = "&Reintegrate a branch*";
			this.reintegrateABranchRadioButton.UseVisualStyleBackColor = true;
			this.reintegrateABranchRadioButton.CheckedChanged += new System.EventHandler(this.reintegrateABranchRadioButton_CheckedChanged);
			//
			// rangeOfRevisionsRadioButton
			//
			this.rangeOfRevisionsRadioButton.AutoSize = true;
			this.rangeOfRevisionsRadioButton.Checked = true;
			this.rangeOfRevisionsRadioButton.Location = new System.Drawing.Point(10, 20);
			this.rangeOfRevisionsRadioButton.Margin = new System.Windows.Forms.Padding(0);
			this.rangeOfRevisionsRadioButton.Name = "rangeOfRevisionsRadioButton";
			this.rangeOfRevisionsRadioButton.Size = new System.Drawing.Size(154, 17);
			this.rangeOfRevisionsRadioButton.TabIndex = 0;
			this.rangeOfRevisionsRadioButton.TabStop = true;
			this.rangeOfRevisionsRadioButton.Text = "&Merge a range of revisions*";
			this.rangeOfRevisionsRadioButton.UseVisualStyleBackColor = true;
			this.rangeOfRevisionsRadioButton.CheckedChanged += new System.EventHandler(this.rangeofRevisionsRadioButton_CheckedChanged);
			//
			// mergeTypeDescriptionGroupBox
			//
			this.mergeTypeDescriptionGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
			| System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.mergeTypeDescriptionGroupBox.Controls.Add(this.mergeTypeDescriptionLabel);
			this.mergeTypeDescriptionGroupBox.Controls.Add(this.mergeTypePictureBox);
			this.mergeTypeDescriptionGroupBox.Location = new System.Drawing.Point(5, 135);
			this.mergeTypeDescriptionGroupBox.Margin = new System.Windows.Forms.Padding(0);
			this.mergeTypeDescriptionGroupBox.Name = "mergeTypeDescriptionGroupBox";
			this.mergeTypeDescriptionGroupBox.Size = new System.Drawing.Size(490, 245);
			this.mergeTypeDescriptionGroupBox.TabIndex = 1;
			this.mergeTypeDescriptionGroupBox.TabStop = false;
			this.mergeTypeDescriptionGroupBox.Text = "Merge Description";
			//
			// mergeTypeDescriptionLabel
			//
			this.mergeTypeDescriptionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.mergeTypeDescriptionLabel.Location = new System.Drawing.Point(10, 170);
			this.mergeTypeDescriptionLabel.Margin = new System.Windows.Forms.Padding(0);
			this.mergeTypeDescriptionLabel.Name = "mergeTypeDescriptionLabel";
			this.mergeTypeDescriptionLabel.Size = new System.Drawing.Size(470, 70);
			this.mergeTypeDescriptionLabel.TabIndex = 0;
			this.mergeTypeDescriptionLabel.Text = "Use this method to catch-up a feature branch with the changes in trunk or another" +
	" branch.  You can merge a specific set of revisions or all eligible revisions.";
			this.mergeTypeDescriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			// mergeTypePictureBox
			//
			this.mergeTypePictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.mergeTypePictureBox.Image = global::Ankh.UI.ResourcesMergeImage.RangeOfRevisions;
			this.mergeTypePictureBox.Location = new System.Drawing.Point(45, 14);
			this.mergeTypePictureBox.Margin = new System.Windows.Forms.Padding(0);
			this.mergeTypePictureBox.Name = "mergeTypePictureBox";
			this.mergeTypePictureBox.Size = new System.Drawing.Size(400, 140);
			this.mergeTypePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.mergeTypePictureBox.TabIndex = 0;
			this.mergeTypePictureBox.TabStop = false;
			//
			// showBestPracticesPageCheckbox
			//
			this.showBestPracticesPageCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.showBestPracticesPageCheckbox.AutoSize = true;
			this.showBestPracticesPageCheckbox.Checked = true;
			this.showBestPracticesPageCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.showBestPracticesPageCheckbox.Location = new System.Drawing.Point(5, 385);
			this.showBestPracticesPageCheckbox.Margin = new System.Windows.Forms.Padding(0);
			this.showBestPracticesPageCheckbox.Name = "showBestPracticesPageCheckbox";
			this.showBestPracticesPageCheckbox.Size = new System.Drawing.Size(214, 17);
			this.showBestPracticesPageCheckbox.TabIndex = 2;
			this.showBestPracticesPageCheckbox.Text = "Perform pre-merge best practices check";
			this.showBestPracticesPageCheckbox.UseVisualStyleBackColor = true;
			//
			// disclaimerLabel
			//
			this.disclaimerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.disclaimerLabel.AutoSize = true;
			this.disclaimerLabel.Location = new System.Drawing.Point(316, 385);
			this.disclaimerLabel.Name = "disclaimerLabel";
			this.disclaimerLabel.Size = new System.Drawing.Size(179, 13);
			this.disclaimerLabel.TabIndex = 3;
			this.disclaimerLabel.Text = "* Requires Subversion 1.5.x+ server.";
			//
			// MergeTypePage
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.disclaimerLabel);
			this.Controls.Add(this.showBestPracticesPageCheckbox);
			this.Controls.Add(this.mergeTypeDescriptionGroupBox);
			this.Controls.Add(this.mergeTypeGroupBox);
			this.Margin = new System.Windows.Forms.Padding(0);
			this.Name = "MergeTypePage";
			this.Size = new System.Drawing.Size(500, 405);
			this.mergeTypeGroupBox.ResumeLayout(false);
			this.mergeTypeGroupBox.PerformLayout();
			this.mergeTypeDescriptionGroupBox.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.mergeTypePictureBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox mergeTypeGroupBox;
		private System.Windows.Forms.RadioButton rangeOfRevisionsRadioButton;
		private System.Windows.Forms.RadioButton reintegrateABranchRadioButton;
		private System.Windows.Forms.RadioButton twoDifferentTreesRadioButton;
		private System.Windows.Forms.RadioButton manuallyRecordRadioButton;
		private System.Windows.Forms.RadioButton manuallyRemoveRadioButton;
		private System.Windows.Forms.GroupBox mergeTypeDescriptionGroupBox;
		private System.Windows.Forms.PictureBox mergeTypePictureBox;
		private System.Windows.Forms.Label mergeTypeDescriptionLabel;
		private System.Windows.Forms.CheckBox showBestPracticesPageCheckbox;
		private System.Windows.Forms.Label disclaimerLabel;
	}
}
