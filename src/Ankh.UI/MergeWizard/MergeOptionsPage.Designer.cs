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
	partial class MergeOptionsPage
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
			this.conflictsGroupBox = new System.Windows.Forms.GroupBox();
			this.binaryConflictsGroupBox = new System.Windows.Forms.GroupBox();
			this.binaryConflictsBaseRadioButton = new System.Windows.Forms.RadioButton();
			this.binaryConflictsRepositoryRadioButton = new System.Windows.Forms.RadioButton();
			this.binaryConflictsMyRadioButton = new System.Windows.Forms.RadioButton();
			this.binaryConflictsMarkRadioButton = new System.Windows.Forms.RadioButton();
			this.binaryConflictsPromptRadioButton = new System.Windows.Forms.RadioButton();
			this.textConflictsGroupBox = new System.Windows.Forms.GroupBox();
			this.textConflictsBaseRadioButton = new System.Windows.Forms.RadioButton();
			this.textConflictsRepositoryRadioButton = new System.Windows.Forms.RadioButton();
			this.textConflictsMyRadioButton = new System.Windows.Forms.RadioButton();
			this.textConflictsMarkRadioButton = new System.Windows.Forms.RadioButton();
			this.textConflictsPromptRadioButton = new System.Windows.Forms.RadioButton();
			this.mergeOptionsGroupBox = new System.Windows.Forms.GroupBox();
			this.depthLabel = new System.Windows.Forms.Label();
			this.depthComboBox = new System.Windows.Forms.ComboBox();
			this.unversionedCheckBox = new System.Windows.Forms.CheckBox();
			this.ignoreAncestryCheckBox = new System.Windows.Forms.CheckBox();
			this.conflictsGroupBox.SuspendLayout();
			this.binaryConflictsGroupBox.SuspendLayout();
			this.textConflictsGroupBox.SuspendLayout();
			this.mergeOptionsGroupBox.SuspendLayout();
			this.SuspendLayout();
			//
			// conflictsGroupBox
			//
			this.conflictsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.conflictsGroupBox.Controls.Add(this.binaryConflictsGroupBox);
			this.conflictsGroupBox.Controls.Add(this.textConflictsGroupBox);
			this.conflictsGroupBox.Location = new System.Drawing.Point(5, 5);
			this.conflictsGroupBox.Margin = new System.Windows.Forms.Padding(0);
			this.conflictsGroupBox.Name = "conflictsGroupBox";
			this.conflictsGroupBox.Size = new System.Drawing.Size(490, 268);
			this.conflictsGroupBox.TabIndex = 0;
			this.conflictsGroupBox.TabStop = false;
			this.conflictsGroupBox.Text = "Conflict Handling";
			//
			// binaryConflictsGroupBox
			//
			this.binaryConflictsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.binaryConflictsGroupBox.Controls.Add(this.binaryConflictsBaseRadioButton);
			this.binaryConflictsGroupBox.Controls.Add(this.binaryConflictsRepositoryRadioButton);
			this.binaryConflictsGroupBox.Controls.Add(this.binaryConflictsMyRadioButton);
			this.binaryConflictsGroupBox.Controls.Add(this.binaryConflictsMarkRadioButton);
			this.binaryConflictsGroupBox.Controls.Add(this.binaryConflictsPromptRadioButton);
			this.binaryConflictsGroupBox.Location = new System.Drawing.Point(8, 139);
			this.binaryConflictsGroupBox.Margin = new System.Windows.Forms.Padding(0);
			this.binaryConflictsGroupBox.Name = "binaryConflictsGroupBox";
			this.binaryConflictsGroupBox.Padding = new System.Windows.Forms.Padding(0);
			this.binaryConflictsGroupBox.Size = new System.Drawing.Size(474, 119);
			this.binaryConflictsGroupBox.TabIndex = 1;
			this.binaryConflictsGroupBox.TabStop = false;
			this.binaryConflictsGroupBox.Text = "Binary Conflicts";
			//
			// binaryConflictsBaseRadioButton
			//
			this.binaryConflictsBaseRadioButton.AutoSize = true;
			this.binaryConflictsBaseRadioButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.binaryConflictsBaseRadioButton.Location = new System.Drawing.Point(10, 97);
			this.binaryConflictsBaseRadioButton.Margin = new System.Windows.Forms.Padding(0);
			this.binaryConflictsBaseRadioButton.Name = "binaryConflictsBaseRadioButton";
			this.binaryConflictsBaseRadioButton.Size = new System.Drawing.Size(321, 17);
			this.binaryConflictsBaseRadioButton.TabIndex = 9;
			this.binaryConflictsBaseRadioButton.Text = "Resolve the conflict with the pre-merge base &version of the file.";
			this.binaryConflictsBaseRadioButton.UseVisualStyleBackColor = true;
			this.binaryConflictsBaseRadioButton.CheckedChanged += new System.EventHandler(this.binaryConflictsBaseRadioButton_CheckedChanged);
			//
			// binaryConflictsRepositoryRadioButton
			//
			this.binaryConflictsRepositoryRadioButton.AutoSize = true;
			this.binaryConflictsRepositoryRadioButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.binaryConflictsRepositoryRadioButton.Location = new System.Drawing.Point(10, 77);
			this.binaryConflictsRepositoryRadioButton.Margin = new System.Windows.Forms.Padding(0);
			this.binaryConflictsRepositoryRadioButton.Name = "binaryConflictsRepositoryRadioButton";
			this.binaryConflictsRepositoryRadioButton.Size = new System.Drawing.Size(296, 17);
			this.binaryConflictsRepositoryRadioButton.TabIndex = 8;
			this.binaryConflictsRepositoryRadioButton.Text = "Reso&lve the conflict using the repository version of the file";
			this.binaryConflictsRepositoryRadioButton.UseVisualStyleBackColor = true;
			this.binaryConflictsRepositoryRadioButton.CheckedChanged += new System.EventHandler(this.binaryConflictsRepositoryRadioButton_CheckedChanged);
			//
			// binaryConflictsMyRadioButton
			//
			this.binaryConflictsMyRadioButton.AutoSize = true;
			this.binaryConflictsMyRadioButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.binaryConflictsMyRadioButton.Location = new System.Drawing.Point(10, 57);
			this.binaryConflictsMyRadioButton.Margin = new System.Windows.Forms.Padding(0);
			this.binaryConflictsMyRadioButton.Name = "binaryConflictsMyRadioButton";
			this.binaryConflictsMyRadioButton.Size = new System.Drawing.Size(246, 17);
			this.binaryConflictsMyRadioButton.TabIndex = 7;
			this.binaryConflictsMyRadioButton.Text = "Re&solve the conflict using my version of the file";
			this.binaryConflictsMyRadioButton.UseVisualStyleBackColor = true;
			this.binaryConflictsMyRadioButton.CheckedChanged += new System.EventHandler(this.binaryConflictsMyRadioButton_CheckedChanged);
			//
			// binaryConflictsMarkRadioButton
			//
			this.binaryConflictsMarkRadioButton.AutoSize = true;
			this.binaryConflictsMarkRadioButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.binaryConflictsMarkRadioButton.Location = new System.Drawing.Point(10, 37);
			this.binaryConflictsMarkRadioButton.Margin = new System.Windows.Forms.Padding(0);
			this.binaryConflictsMarkRadioButton.Name = "binaryConflictsMarkRadioButton";
			this.binaryConflictsMarkRadioButton.Size = new System.Drawing.Size(225, 17);
			this.binaryConflictsMarkRadioButton.TabIndex = 6;
			this.binaryConflictsMarkRadioButton.Text = "M&ark each conflict and let me resolve later";
			this.binaryConflictsMarkRadioButton.UseVisualStyleBackColor = true;
			this.binaryConflictsMarkRadioButton.CheckedChanged += new System.EventHandler(this.binaryConflictsMarkRadioButton_CheckedChanged);
			//
			// binaryConflictsPromptRadioButton
			//
			this.binaryConflictsPromptRadioButton.AutoSize = true;
			this.binaryConflictsPromptRadioButton.Checked = true;
			this.binaryConflictsPromptRadioButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.binaryConflictsPromptRadioButton.Location = new System.Drawing.Point(10, 17);
			this.binaryConflictsPromptRadioButton.Margin = new System.Windows.Forms.Padding(0);
			this.binaryConflictsPromptRadioButton.Name = "binaryConflictsPromptRadioButton";
			this.binaryConflictsPromptRadioButton.Size = new System.Drawing.Size(241, 17);
			this.binaryConflictsPromptRadioButton.TabIndex = 5;
			this.binaryConflictsPromptRadioButton.TabStop = true;
			this.binaryConflictsPromptRadioButton.Text = "Pr&ompt me for each conflict and let me decide";
			this.binaryConflictsPromptRadioButton.UseVisualStyleBackColor = true;
			this.binaryConflictsPromptRadioButton.CheckedChanged += new System.EventHandler(this.binaryConflictsPromptRadioButton_CheckedChanged);
			//
			// textConflictsGroupBox
			//
			this.textConflictsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.textConflictsGroupBox.Controls.Add(this.textConflictsBaseRadioButton);
			this.textConflictsGroupBox.Controls.Add(this.textConflictsRepositoryRadioButton);
			this.textConflictsGroupBox.Controls.Add(this.textConflictsMyRadioButton);
			this.textConflictsGroupBox.Controls.Add(this.textConflictsMarkRadioButton);
			this.textConflictsGroupBox.Controls.Add(this.textConflictsPromptRadioButton);
			this.textConflictsGroupBox.Location = new System.Drawing.Point(8, 15);
			this.textConflictsGroupBox.Margin = new System.Windows.Forms.Padding(0);
			this.textConflictsGroupBox.Name = "textConflictsGroupBox";
			this.textConflictsGroupBox.Padding = new System.Windows.Forms.Padding(0);
			this.textConflictsGroupBox.Size = new System.Drawing.Size(474, 119);
			this.textConflictsGroupBox.TabIndex = 0;
			this.textConflictsGroupBox.TabStop = false;
			this.textConflictsGroupBox.Text = "Text Conflicts";
			//
			// textConflictsBaseRadioButton
			//
			this.textConflictsBaseRadioButton.AutoSize = true;
			this.textConflictsBaseRadioButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.textConflictsBaseRadioButton.Location = new System.Drawing.Point(10, 97);
			this.textConflictsBaseRadioButton.Margin = new System.Windows.Forms.Padding(0);
			this.textConflictsBaseRadioButton.Name = "textConflictsBaseRadioButton";
			this.textConflictsBaseRadioButton.Size = new System.Drawing.Size(321, 17);
			this.textConflictsBaseRadioButton.TabIndex = 5;
			this.textConflictsBaseRadioButton.Text = "Resolve the conflict with the pre-merge &base version of the file.";
			this.textConflictsBaseRadioButton.UseVisualStyleBackColor = true;
			this.textConflictsBaseRadioButton.CheckedChanged += new System.EventHandler(this.textConflictsBaseRadioButton_CheckedChanged);
			//
			// textConflictsRepositoryRadioButton
			//
			this.textConflictsRepositoryRadioButton.AutoSize = true;
			this.textConflictsRepositoryRadioButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.textConflictsRepositoryRadioButton.Location = new System.Drawing.Point(10, 77);
			this.textConflictsRepositoryRadioButton.Margin = new System.Windows.Forms.Padding(0);
			this.textConflictsRepositoryRadioButton.Name = "textConflictsRepositoryRadioButton";
			this.textConflictsRepositoryRadioButton.Size = new System.Drawing.Size(296, 17);
			this.textConflictsRepositoryRadioButton.TabIndex = 4;
			this.textConflictsRepositoryRadioButton.Text = "R&esolve the conflict using the repository version of the file";
			this.textConflictsRepositoryRadioButton.UseVisualStyleBackColor = true;
			this.textConflictsRepositoryRadioButton.CheckedChanged += new System.EventHandler(this.textConflictsRepositoryRadioButton_CheckedChanged);
			//
			// textConflictsMyRadioButton
			//
			this.textConflictsMyRadioButton.AutoSize = true;
			this.textConflictsMyRadioButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.textConflictsMyRadioButton.Location = new System.Drawing.Point(10, 57);
			this.textConflictsMyRadioButton.Margin = new System.Windows.Forms.Padding(0);
			this.textConflictsMyRadioButton.Name = "textConflictsMyRadioButton";
			this.textConflictsMyRadioButton.Size = new System.Drawing.Size(246, 17);
			this.textConflictsMyRadioButton.TabIndex = 3;
			this.textConflictsMyRadioButton.Text = "&Resolve the conflict using my version of the file";
			this.textConflictsMyRadioButton.UseVisualStyleBackColor = true;
			this.textConflictsMyRadioButton.CheckedChanged += new System.EventHandler(this.textConflictsMyRadioButton_CheckedChanged);
			//
			// textConflictsMarkRadioButton
			//
			this.textConflictsMarkRadioButton.AutoSize = true;
			this.textConflictsMarkRadioButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.textConflictsMarkRadioButton.Location = new System.Drawing.Point(10, 37);
			this.textConflictsMarkRadioButton.Margin = new System.Windows.Forms.Padding(0);
			this.textConflictsMarkRadioButton.Name = "textConflictsMarkRadioButton";
			this.textConflictsMarkRadioButton.Size = new System.Drawing.Size(225, 17);
			this.textConflictsMarkRadioButton.TabIndex = 2;
			this.textConflictsMarkRadioButton.Text = "&Mark each conflict and let me resolve later";
			this.textConflictsMarkRadioButton.UseVisualStyleBackColor = true;
			this.textConflictsMarkRadioButton.CheckedChanged += new System.EventHandler(this.textConflictsMarkRadioButton_CheckedChanged);
			//
			// textConflictsPromptRadioButton
			//
			this.textConflictsPromptRadioButton.AutoSize = true;
			this.textConflictsPromptRadioButton.Checked = true;
			this.textConflictsPromptRadioButton.Location = new System.Drawing.Point(10, 17);
			this.textConflictsPromptRadioButton.Margin = new System.Windows.Forms.Padding(0);
			this.textConflictsPromptRadioButton.Name = "textConflictsPromptRadioButton";
			this.textConflictsPromptRadioButton.Size = new System.Drawing.Size(241, 17);
			this.textConflictsPromptRadioButton.TabIndex = 1;
			this.textConflictsPromptRadioButton.TabStop = true;
			this.textConflictsPromptRadioButton.Text = "&Prompt me for each conflict and let me decide";
			this.textConflictsPromptRadioButton.UseVisualStyleBackColor = true;
			this.textConflictsPromptRadioButton.CheckedChanged += new System.EventHandler(this.textConflictsPromptRadioButton_CheckedChanged);
			//
			// mergeOptionsGroupBox
			//
			this.mergeOptionsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.mergeOptionsGroupBox.Controls.Add(this.depthLabel);
			this.mergeOptionsGroupBox.Controls.Add(this.depthComboBox);
			this.mergeOptionsGroupBox.Controls.Add(this.unversionedCheckBox);
			this.mergeOptionsGroupBox.Controls.Add(this.ignoreAncestryCheckBox);
			this.mergeOptionsGroupBox.Location = new System.Drawing.Point(5, 278);
			this.mergeOptionsGroupBox.Margin = new System.Windows.Forms.Padding(0);
			this.mergeOptionsGroupBox.Name = "mergeOptionsGroupBox";
			this.mergeOptionsGroupBox.Padding = new System.Windows.Forms.Padding(0);
			this.mergeOptionsGroupBox.Size = new System.Drawing.Size(490, 84);
			this.mergeOptionsGroupBox.TabIndex = 0;
			this.mergeOptionsGroupBox.TabStop = false;
			this.mergeOptionsGroupBox.Text = "Merge Options";
			//
			// depthLabel
			//
			this.depthLabel.AutoSize = true;
			this.depthLabel.Location = new System.Drawing.Point(7, 58);
			this.depthLabel.Margin = new System.Windows.Forms.Padding(0);
			this.depthLabel.Name = "depthLabel";
			this.depthLabel.Size = new System.Drawing.Size(39, 13);
			this.depthLabel.TabIndex = 10;
			this.depthLabel.Text = "Depth:";
			//
			// depthComboBox
			//
			this.depthComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.depthComboBox.FormattingEnabled = true;
			this.depthComboBox.Location = new System.Drawing.Point(49, 55);
			this.depthComboBox.Margin = new System.Windows.Forms.Padding(0);
			this.depthComboBox.Name = "depthComboBox";
			this.depthComboBox.Size = new System.Drawing.Size(175, 21);
			this.depthComboBox.TabIndex = 11;
			this.depthComboBox.SelectedIndexChanged += new System.EventHandler(this.depthComboBox_SelectedIndexChanged);
			//
			// unversionedCheckBox
			//
			this.unversionedCheckBox.AutoSize = true;
			this.unversionedCheckBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.unversionedCheckBox.Location = new System.Drawing.Point(10, 37);
			this.unversionedCheckBox.Margin = new System.Windows.Forms.Padding(0);
			this.unversionedCheckBox.Name = "unversionedCheckBox";
			this.unversionedCheckBox.Size = new System.Drawing.Size(172, 17);
			this.unversionedCheckBox.TabIndex = 10;
			this.unversionedCheckBox.Text = "Allo&w unversioned obstructions";
			this.unversionedCheckBox.UseVisualStyleBackColor = true;
			this.unversionedCheckBox.CheckedChanged += new System.EventHandler(this.unversionedCheckBox_CheckedChanged);
			//
			// ignoreAncestryCheckBox
			//
			this.ignoreAncestryCheckBox.AutoSize = true;
			this.ignoreAncestryCheckBox.Location = new System.Drawing.Point(10, 17);
			this.ignoreAncestryCheckBox.Margin = new System.Windows.Forms.Padding(0);
			this.ignoreAncestryCheckBox.Name = "ignoreAncestryCheckBox";
			this.ignoreAncestryCheckBox.Size = new System.Drawing.Size(99, 17);
			this.ignoreAncestryCheckBox.TabIndex = 9;
			this.ignoreAncestryCheckBox.Text = "&Ignore ancestry";
			this.ignoreAncestryCheckBox.UseVisualStyleBackColor = true;
			this.ignoreAncestryCheckBox.CheckedChanged += new System.EventHandler(this.ignoreAncestryCheckBox_CheckedChanged);
			//
			// MergeOptionsPage
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.mergeOptionsGroupBox);
			this.Controls.Add(this.conflictsGroupBox);
			this.Margin = new System.Windows.Forms.Padding(0);
			this.Name = "MergeOptionsPage";
			this.Size = new System.Drawing.Size(500, 405);
			this.Load += new System.EventHandler(this.MergeOptionsPage_Load);
			this.conflictsGroupBox.ResumeLayout(false);
			this.binaryConflictsGroupBox.ResumeLayout(false);
			this.binaryConflictsGroupBox.PerformLayout();
			this.textConflictsGroupBox.ResumeLayout(false);
			this.textConflictsGroupBox.PerformLayout();
			this.mergeOptionsGroupBox.ResumeLayout(false);
			this.mergeOptionsGroupBox.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox conflictsGroupBox;
		private System.Windows.Forms.GroupBox textConflictsGroupBox;
		private System.Windows.Forms.RadioButton textConflictsPromptRadioButton;
		private System.Windows.Forms.RadioButton textConflictsMarkRadioButton;
		private System.Windows.Forms.GroupBox binaryConflictsGroupBox;
		private System.Windows.Forms.RadioButton binaryConflictsMarkRadioButton;
		private System.Windows.Forms.RadioButton binaryConflictsPromptRadioButton;
		private System.Windows.Forms.RadioButton binaryConflictsMyRadioButton;
		private System.Windows.Forms.RadioButton binaryConflictsRepositoryRadioButton;
		private System.Windows.Forms.GroupBox mergeOptionsGroupBox;
		private System.Windows.Forms.CheckBox unversionedCheckBox;
		private System.Windows.Forms.CheckBox ignoreAncestryCheckBox;
		private System.Windows.Forms.ComboBox depthComboBox;
		private System.Windows.Forms.Label depthLabel;
		private System.Windows.Forms.RadioButton textConflictsRepositoryRadioButton;
		private System.Windows.Forms.RadioButton textConflictsMyRadioButton;
		private System.Windows.Forms.RadioButton textConflictsBaseRadioButton;
		private System.Windows.Forms.RadioButton binaryConflictsBaseRadioButton;
	}
}
