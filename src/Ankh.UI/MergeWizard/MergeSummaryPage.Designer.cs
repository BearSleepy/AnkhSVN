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
	partial class MergeSummaryPage
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
			this.mergeDetailsGroupBox = new System.Windows.Forms.GroupBox();
			this.revisionsTextBox = new System.Windows.Forms.TextBox();
			this.mergeSource2TextBox = new System.Windows.Forms.TextBox();
			this.mergeSource1TextBox = new System.Windows.Forms.TextBox();
			this.mergeTargetTextBox = new System.Windows.Forms.TextBox();
			this.revisionsLabel = new System.Windows.Forms.Label();
			this.mergeSource2Label = new System.Windows.Forms.Label();
			this.mergeSource1Label = new System.Windows.Forms.Label();
			this.mergeTargetLabel = new System.Windows.Forms.Label();
			this.binaryConflictsLabel = new System.Windows.Forms.Label();
			this.textConflictsLabel = new System.Windows.Forms.Label();
			this.depthLabel = new System.Windows.Forms.Label();
			this.ignoreAncestryLabel = new System.Windows.Forms.Label();
			this.unversionedObstructionsLabel = new System.Windows.Forms.Label();
			this.mergeOptionsGroupBox = new System.Windows.Forms.GroupBox();
			this.performDryRunCheckBox = new System.Windows.Forms.CheckBox();
			this.performDryRunLabel = new System.Windows.Forms.Label();
			this.unversionedObstructionsTextBox = new System.Windows.Forms.TextBox();
			this.ignoreAncestryTextBox = new System.Windows.Forms.TextBox();
			this.depthTextBox = new System.Windows.Forms.TextBox();
			this.textConflictsTextBox = new System.Windows.Forms.TextBox();
			this.binaryConflictsTextBox = new System.Windows.Forms.TextBox();
			this.mergeDetailsGroupBox.SuspendLayout();
			this.mergeOptionsGroupBox.SuspendLayout();
			this.SuspendLayout();
			//
			// mergeDetailsGroupBox
			//
			this.mergeDetailsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.mergeDetailsGroupBox.Controls.Add(this.revisionsTextBox);
			this.mergeDetailsGroupBox.Controls.Add(this.mergeSource2TextBox);
			this.mergeDetailsGroupBox.Controls.Add(this.mergeSource1TextBox);
			this.mergeDetailsGroupBox.Controls.Add(this.mergeTargetTextBox);
			this.mergeDetailsGroupBox.Controls.Add(this.revisionsLabel);
			this.mergeDetailsGroupBox.Controls.Add(this.mergeSource2Label);
			this.mergeDetailsGroupBox.Controls.Add(this.mergeSource1Label);
			this.mergeDetailsGroupBox.Controls.Add(this.mergeTargetLabel);
			this.mergeDetailsGroupBox.Location = new System.Drawing.Point(5, 5);
			this.mergeDetailsGroupBox.Margin = new System.Windows.Forms.Padding(0);
			this.mergeDetailsGroupBox.Name = "mergeDetailsGroupBox";
			this.mergeDetailsGroupBox.Padding = new System.Windows.Forms.Padding(0);
			this.mergeDetailsGroupBox.Size = new System.Drawing.Size(490, 117);
			this.mergeDetailsGroupBox.TabIndex = 0;
			this.mergeDetailsGroupBox.TabStop = false;
			this.mergeDetailsGroupBox.Text = "Merge Details";
			//
			// revisionsTextBox
			//
			this.revisionsTextBox.Location = new System.Drawing.Point(93, 90);
			this.revisionsTextBox.Margin = new System.Windows.Forms.Padding(0);
			this.revisionsTextBox.Name = "revisionsTextBox";
			this.revisionsTextBox.ReadOnly = true;
			this.revisionsTextBox.Size = new System.Drawing.Size(390, 20);
			this.revisionsTextBox.TabIndex = 4;
			//
			// mergeSource2TextBox
			//
			this.mergeSource2TextBox.Location = new System.Drawing.Point(93, 65);
			this.mergeSource2TextBox.Margin = new System.Windows.Forms.Padding(0);
			this.mergeSource2TextBox.Name = "mergeSource2TextBox";
			this.mergeSource2TextBox.ReadOnly = true;
			this.mergeSource2TextBox.Size = new System.Drawing.Size(390, 20);
			this.mergeSource2TextBox.TabIndex = 3;
			//
			// mergeSource1TextBox
			//
			this.mergeSource1TextBox.Location = new System.Drawing.Point(93, 40);
			this.mergeSource1TextBox.Margin = new System.Windows.Forms.Padding(0);
			this.mergeSource1TextBox.Name = "mergeSource1TextBox";
			this.mergeSource1TextBox.ReadOnly = true;
			this.mergeSource1TextBox.Size = new System.Drawing.Size(390, 20);
			this.mergeSource1TextBox.TabIndex = 2;
			//
			// mergeTargetTextBox
			//
			this.mergeTargetTextBox.Location = new System.Drawing.Point(93, 15);
			this.mergeTargetTextBox.Margin = new System.Windows.Forms.Padding(0);
			this.mergeTargetTextBox.Name = "mergeTargetTextBox";
			this.mergeTargetTextBox.ReadOnly = true;
			this.mergeTargetTextBox.Size = new System.Drawing.Size(390, 20);
			this.mergeTargetTextBox.TabIndex = 1;
			//
			// revisionsLabel
			//
			this.revisionsLabel.AutoSize = true;
			this.revisionsLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.revisionsLabel.Location = new System.Drawing.Point(29, 93);
			this.revisionsLabel.Name = "revisionsLabel";
			this.revisionsLabel.Size = new System.Drawing.Size(62, 13);
			this.revisionsLabel.TabIndex = 3;
			this.revisionsLabel.Text = "Revision(s):";
			//
			// mergeSource2Label
			//
			this.mergeSource2Label.AutoSize = true;
			this.mergeSource2Label.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.mergeSource2Label.Location = new System.Drawing.Point(5, 68);
			this.mergeSource2Label.Name = "mergeSource2Label";
			this.mergeSource2Label.Size = new System.Drawing.Size(86, 13);
			this.mergeSource2Label.TabIndex = 2;
			this.mergeSource2Label.Text = "Merge Source 2:";
			//
			// mergeSource1Label
			//
			this.mergeSource1Label.AutoSize = true;
			this.mergeSource1Label.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.mergeSource1Label.Location = new System.Drawing.Point(5, 43);
			this.mergeSource1Label.Name = "mergeSource1Label";
			this.mergeSource1Label.Size = new System.Drawing.Size(86, 13);
			this.mergeSource1Label.TabIndex = 1;
			this.mergeSource1Label.Text = "Merge Source 1:";
			//
			// mergeTargetLabel
			//
			this.mergeTargetLabel.AutoSize = true;
			this.mergeTargetLabel.Location = new System.Drawing.Point(17, 18);
			this.mergeTargetLabel.Name = "mergeTargetLabel";
			this.mergeTargetLabel.Size = new System.Drawing.Size(74, 13);
			this.mergeTargetLabel.TabIndex = 0;
			this.mergeTargetLabel.Text = "Merge Target:";
			//
			// binaryConflictsLabel
			//
			this.binaryConflictsLabel.AutoSize = true;
			this.binaryConflictsLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.binaryConflictsLabel.Location = new System.Drawing.Point(54, 18);
			this.binaryConflictsLabel.Name = "binaryConflictsLabel";
			this.binaryConflictsLabel.Size = new System.Drawing.Size(82, 13);
			this.binaryConflictsLabel.TabIndex = 4;
			this.binaryConflictsLabel.Text = "Binary Conflicts:";
			//
			// textConflictsLabel
			//
			this.textConflictsLabel.AutoSize = true;
			this.textConflictsLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.textConflictsLabel.Location = new System.Drawing.Point(62, 43);
			this.textConflictsLabel.Name = "textConflictsLabel";
			this.textConflictsLabel.Size = new System.Drawing.Size(74, 13);
			this.textConflictsLabel.TabIndex = 5;
			this.textConflictsLabel.Text = "Text Conflicts:";
			//
			// depthLabel
			//
			this.depthLabel.AutoSize = true;
			this.depthLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.depthLabel.Location = new System.Drawing.Point(97, 68);
			this.depthLabel.Name = "depthLabel";
			this.depthLabel.Size = new System.Drawing.Size(39, 13);
			this.depthLabel.TabIndex = 6;
			this.depthLabel.Text = "Depth:";
			//
			// ignoreAncestryLabel
			//
			this.ignoreAncestryLabel.AutoSize = true;
			this.ignoreAncestryLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.ignoreAncestryLabel.Location = new System.Drawing.Point(52, 93);
			this.ignoreAncestryLabel.Name = "ignoreAncestryLabel";
			this.ignoreAncestryLabel.Size = new System.Drawing.Size(84, 13);
			this.ignoreAncestryLabel.TabIndex = 7;
			this.ignoreAncestryLabel.Text = "Ignore Ancestry:";
			//
			// unversionedObstructionsLabel
			//
			this.unversionedObstructionsLabel.AutoSize = true;
			this.unversionedObstructionsLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.unversionedObstructionsLabel.Location = new System.Drawing.Point(4, 118);
			this.unversionedObstructionsLabel.Name = "unversionedObstructionsLabel";
			this.unversionedObstructionsLabel.Size = new System.Drawing.Size(132, 13);
			this.unversionedObstructionsLabel.TabIndex = 8;
			this.unversionedObstructionsLabel.Text = "Unversioned Obstructions:";
			//
			// mergeOptionsGroupBox
			//
			this.mergeOptionsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.mergeOptionsGroupBox.Controls.Add(this.performDryRunCheckBox);
			this.mergeOptionsGroupBox.Controls.Add(this.performDryRunLabel);
			this.mergeOptionsGroupBox.Controls.Add(this.unversionedObstructionsTextBox);
			this.mergeOptionsGroupBox.Controls.Add(this.ignoreAncestryTextBox);
			this.mergeOptionsGroupBox.Controls.Add(this.depthTextBox);
			this.mergeOptionsGroupBox.Controls.Add(this.textConflictsTextBox);
			this.mergeOptionsGroupBox.Controls.Add(this.binaryConflictsTextBox);
			this.mergeOptionsGroupBox.Controls.Add(this.unversionedObstructionsLabel);
			this.mergeOptionsGroupBox.Controls.Add(this.binaryConflictsLabel);
			this.mergeOptionsGroupBox.Controls.Add(this.ignoreAncestryLabel);
			this.mergeOptionsGroupBox.Controls.Add(this.textConflictsLabel);
			this.mergeOptionsGroupBox.Controls.Add(this.depthLabel);
			this.mergeOptionsGroupBox.Location = new System.Drawing.Point(5, 127);
			this.mergeOptionsGroupBox.Margin = new System.Windows.Forms.Padding(0);
			this.mergeOptionsGroupBox.Name = "mergeOptionsGroupBox";
			this.mergeOptionsGroupBox.Size = new System.Drawing.Size(490, 165);
			this.mergeOptionsGroupBox.TabIndex = 1;
			this.mergeOptionsGroupBox.TabStop = false;
			this.mergeOptionsGroupBox.Text = "Merge Options";
			//
			// performDryRunCheckBox
			//
			this.performDryRunCheckBox.AutoSize = true;
			this.performDryRunCheckBox.Location = new System.Drawing.Point(139, 144);
			this.performDryRunCheckBox.Name = "performDryRunCheckBox";
			this.performDryRunCheckBox.Size = new System.Drawing.Size(15, 14);
			this.performDryRunCheckBox.TabIndex = 11;
			this.performDryRunCheckBox.UseVisualStyleBackColor = true;
			this.performDryRunCheckBox.CheckedChanged += new System.EventHandler(this.performDryRunCheckBox_CheckedChanged);
			//
			// performDryRunLabel
			//
			this.performDryRunLabel.AutoSize = true;
			this.performDryRunLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.performDryRunLabel.Location = new System.Drawing.Point(48, 143);
			this.performDryRunLabel.Name = "performDryRunLabel";
			this.performDryRunLabel.Size = new System.Drawing.Size(88, 13);
			this.performDryRunLabel.TabIndex = 10;
			this.performDryRunLabel.Text = "Perform Dry-Run:";
			//
			// unversionedObstructionsTextBox
			//
			this.unversionedObstructionsTextBox.Location = new System.Drawing.Point(139, 115);
			this.unversionedObstructionsTextBox.Margin = new System.Windows.Forms.Padding(0);
			this.unversionedObstructionsTextBox.Name = "unversionedObstructionsTextBox";
			this.unversionedObstructionsTextBox.ReadOnly = true;
			this.unversionedObstructionsTextBox.Size = new System.Drawing.Size(44, 20);
			this.unversionedObstructionsTextBox.TabIndex = 9;
			//
			// ignoreAncestryTextBox
			//
			this.ignoreAncestryTextBox.Location = new System.Drawing.Point(139, 90);
			this.ignoreAncestryTextBox.Margin = new System.Windows.Forms.Padding(0);
			this.ignoreAncestryTextBox.Name = "ignoreAncestryTextBox";
			this.ignoreAncestryTextBox.ReadOnly = true;
			this.ignoreAncestryTextBox.Size = new System.Drawing.Size(44, 20);
			this.ignoreAncestryTextBox.TabIndex = 8;
			//
			// depthTextBox
			//
			this.depthTextBox.Location = new System.Drawing.Point(139, 65);
			this.depthTextBox.Margin = new System.Windows.Forms.Padding(0);
			this.depthTextBox.Name = "depthTextBox";
			this.depthTextBox.ReadOnly = true;
			this.depthTextBox.Size = new System.Drawing.Size(344, 20);
			this.depthTextBox.TabIndex = 7;
			//
			// textConflictsTextBox
			//
			this.textConflictsTextBox.Location = new System.Drawing.Point(139, 40);
			this.textConflictsTextBox.Margin = new System.Windows.Forms.Padding(0);
			this.textConflictsTextBox.Name = "textConflictsTextBox";
			this.textConflictsTextBox.ReadOnly = true;
			this.textConflictsTextBox.Size = new System.Drawing.Size(344, 20);
			this.textConflictsTextBox.TabIndex = 6;
			//
			// binaryConflictsTextBox
			//
			this.binaryConflictsTextBox.Location = new System.Drawing.Point(139, 15);
			this.binaryConflictsTextBox.Margin = new System.Windows.Forms.Padding(0);
			this.binaryConflictsTextBox.Name = "binaryConflictsTextBox";
			this.binaryConflictsTextBox.ReadOnly = true;
			this.binaryConflictsTextBox.Size = new System.Drawing.Size(344, 20);
			this.binaryConflictsTextBox.TabIndex = 5;
			//
			// MergeSummaryPage
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.mergeOptionsGroupBox);
			this.Controls.Add(this.mergeDetailsGroupBox);
			this.Margin = new System.Windows.Forms.Padding(0);
			this.Name = "MergeSummaryPage";
			this.Size = new System.Drawing.Size(500, 405);
			this.Load += new System.EventHandler(this.MergeSummaryPage_Load);
			this.mergeDetailsGroupBox.ResumeLayout(false);
			this.mergeDetailsGroupBox.PerformLayout();
			this.mergeOptionsGroupBox.ResumeLayout(false);
			this.mergeOptionsGroupBox.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox mergeDetailsGroupBox;
		private System.Windows.Forms.Label revisionsLabel;
		private System.Windows.Forms.Label mergeSource2Label;
		private System.Windows.Forms.Label mergeSource1Label;
		private System.Windows.Forms.Label mergeTargetLabel;
		private System.Windows.Forms.Label textConflictsLabel;
		private System.Windows.Forms.Label binaryConflictsLabel;
		private System.Windows.Forms.Label depthLabel;
		private System.Windows.Forms.Label ignoreAncestryLabel;
		private System.Windows.Forms.Label unversionedObstructionsLabel;
		private System.Windows.Forms.GroupBox mergeOptionsGroupBox;
		private System.Windows.Forms.TextBox mergeTargetTextBox;
		private System.Windows.Forms.TextBox revisionsTextBox;
		private System.Windows.Forms.TextBox mergeSource2TextBox;
		private System.Windows.Forms.TextBox mergeSource1TextBox;
		private System.Windows.Forms.TextBox unversionedObstructionsTextBox;
		private System.Windows.Forms.TextBox ignoreAncestryTextBox;
		private System.Windows.Forms.TextBox depthTextBox;
		private System.Windows.Forms.TextBox textConflictsTextBox;
		private System.Windows.Forms.TextBox binaryConflictsTextBox;
		private System.Windows.Forms.Label performDryRunLabel;
		private System.Windows.Forms.CheckBox performDryRunCheckBox;
	}
}
