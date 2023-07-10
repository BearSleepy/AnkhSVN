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

namespace Ankh.UI.MergeWizard
{
	partial class MergeResultsDialog
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
			this.horizontalDividerLabel = new System.Windows.Forms.Label();
			this.headerDescription = new System.Windows.Forms.Label();
			this.headerTitle = new System.Windows.Forms.Label();
			this.controlPanel = new System.Windows.Forms.Panel();
			this.okButton = new System.Windows.Forms.Button();
			this.headerImage = new System.Windows.Forms.PictureBox();
			this.headerPanel = new System.Windows.Forms.Panel();
			this.fileStatisticsGroupBox = new System.Windows.Forms.GroupBox();
			this.fileSkippedFilesValueLabel = new System.Windows.Forms.Label();
			this.fileSkippedDirectoriesValueLabel = new System.Windows.Forms.Label();
			this.fileResolvedValueLabel = new System.Windows.Forms.Label();
			this.fileConflictedValueLabel = new System.Windows.Forms.Label();
			this.fileMergedValueLabel = new System.Windows.Forms.Label();
			this.fileDeletedValueLabel = new System.Windows.Forms.Label();
			this.fileExistedValueLabel = new System.Windows.Forms.Label();
			this.fileAddedValueLabel = new System.Windows.Forms.Label();
			this.fileUpdatedValueLabel = new System.Windows.Forms.Label();
			this.fileSkippedFilesLabel = new System.Windows.Forms.Label();
			this.filesSkipedDirectoriesLabel = new System.Windows.Forms.Label();
			this.fileResolvedLabel = new System.Windows.Forms.Label();
			this.fileConflictedLabel = new System.Windows.Forms.Label();
			this.fileMergedLabel = new System.Windows.Forms.Label();
			this.fileDeletedLabel = new System.Windows.Forms.Label();
			this.fileExistedLabel = new System.Windows.Forms.Label();
			this.fileAddedLabel = new System.Windows.Forms.Label();
			this.fileUpdatedLabel = new System.Windows.Forms.Label();
			this.propertyStatisticsGroupBox = new System.Windows.Forms.GroupBox();
			this.propertyResolvedValueLabel = new System.Windows.Forms.Label();
			this.propertyConflictedValueLabel = new System.Windows.Forms.Label();
			this.propertyMergedValueLabel = new System.Windows.Forms.Label();
			this.propertyUpdatedValueLabel = new System.Windows.Forms.Label();
			this.propertyResolvedLabel = new System.Windows.Forms.Label();
			this.propertyConflictedLabel = new System.Windows.Forms.Label();
			this.propertyMergedLabel = new System.Windows.Forms.Label();
			this.propertyUpdatedLabel = new System.Windows.Forms.Label();
			this.modifiedPathsListView = new System.Windows.Forms.ListView();
			this.changedPathColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.contentColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.propertiesColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.controlPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.headerImage)).BeginInit();
			this.headerPanel.SuspendLayout();
			this.fileStatisticsGroupBox.SuspendLayout();
			this.propertyStatisticsGroupBox.SuspendLayout();
			this.SuspendLayout();
			//
			// horizontalDividerLabel
			//
			this.horizontalDividerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.horizontalDividerLabel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.horizontalDividerLabel.ForeColor = System.Drawing.SystemColors.ControlText;
			this.horizontalDividerLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.horizontalDividerLabel.Location = new System.Drawing.Point(0, 0);
			this.horizontalDividerLabel.Margin = new System.Windows.Forms.Padding(0);
			this.horizontalDividerLabel.Name = "horizontalDividerLabel";
			this.horizontalDividerLabel.Size = new System.Drawing.Size(540, 1);
			this.horizontalDividerLabel.TabIndex = 0;
			//
			// headerDescription
			//
			this.headerDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.headerDescription.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.headerDescription.Location = new System.Drawing.Point(26, 24);
			this.headerDescription.Name = "headerDescription";
			this.headerDescription.Size = new System.Drawing.Size(449, 38);
			this.headerDescription.TabIndex = 2;
			this.headerDescription.Text = "Below are the results of the merge you just performed.";
			//
			// headerTitle
			//
			this.headerTitle.AutoSize = true;
			this.headerTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
			this.headerTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.headerTitle.Location = new System.Drawing.Point(5, 5);
			this.headerTitle.Margin = new System.Windows.Forms.Padding(0);
			this.headerTitle.Name = "headerTitle";
			this.headerTitle.Size = new System.Drawing.Size(88, 13);
			this.headerTitle.TabIndex = 1;
			this.headerTitle.Text = "Merge Results";
			this.headerTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			// controlPanel
			//
			this.controlPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.controlPanel.Controls.Add(this.okButton);
			this.controlPanel.Controls.Add(this.horizontalDividerLabel);
			this.controlPanel.Location = new System.Drawing.Point(0, 416);
			this.controlPanel.Margin = new System.Windows.Forms.Padding(0);
			this.controlPanel.Name = "controlPanel";
			this.controlPanel.Size = new System.Drawing.Size(542, 50);
			this.controlPanel.TabIndex = 3;
			//
			// okButton
			//
			this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.okButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.okButton.Location = new System.Drawing.Point(458, 16);
			this.okButton.Margin = new System.Windows.Forms.Padding(0);
			this.okButton.Name = "okButton";
			this.okButton.Size = new System.Drawing.Size(75, 23);
			this.okButton.TabIndex = 1;
			this.okButton.Text = "OK";
			this.okButton.UseVisualStyleBackColor = true;
			//
			// headerImage
			//
			this.headerImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.headerImage.ErrorImage = null;
			this.headerImage.Image = global::Ankh.UI.ResourcesMergeImage.MergeWizardHeader;
			this.headerImage.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.headerImage.Location = new System.Drawing.Point(478, 2);
			this.headerImage.Margin = new System.Windows.Forms.Padding(0);
			this.headerImage.MaximumSize = new System.Drawing.Size(64, 64);
			this.headerImage.MinimumSize = new System.Drawing.Size(64, 64);
			this.headerImage.Name = "headerImage";
			this.headerImage.Size = new System.Drawing.Size(64, 64);
			this.headerImage.TabIndex = 0;
			this.headerImage.TabStop = false;
			//
			// headerPanel
			//
			this.headerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.headerPanel.BackColor = System.Drawing.Color.White;
			this.headerPanel.Controls.Add(this.headerDescription);
			this.headerPanel.Controls.Add(this.headerTitle);
			this.headerPanel.Controls.Add(this.headerImage);
			this.headerPanel.Location = new System.Drawing.Point(0, 0);
			this.headerPanel.Margin = new System.Windows.Forms.Padding(0);
			this.headerPanel.Name = "headerPanel";
			this.headerPanel.Size = new System.Drawing.Size(542, 66);
			this.headerPanel.TabIndex = 5;
			//
			// fileStatisticsGroupBox
			//
			this.fileStatisticsGroupBox.Controls.Add(this.fileSkippedFilesValueLabel);
			this.fileStatisticsGroupBox.Controls.Add(this.fileSkippedDirectoriesValueLabel);
			this.fileStatisticsGroupBox.Controls.Add(this.fileResolvedValueLabel);
			this.fileStatisticsGroupBox.Controls.Add(this.fileConflictedValueLabel);
			this.fileStatisticsGroupBox.Controls.Add(this.fileMergedValueLabel);
			this.fileStatisticsGroupBox.Controls.Add(this.fileDeletedValueLabel);
			this.fileStatisticsGroupBox.Controls.Add(this.fileExistedValueLabel);
			this.fileStatisticsGroupBox.Controls.Add(this.fileAddedValueLabel);
			this.fileStatisticsGroupBox.Controls.Add(this.fileUpdatedValueLabel);
			this.fileStatisticsGroupBox.Controls.Add(this.fileSkippedFilesLabel);
			this.fileStatisticsGroupBox.Controls.Add(this.filesSkipedDirectoriesLabel);
			this.fileStatisticsGroupBox.Controls.Add(this.fileResolvedLabel);
			this.fileStatisticsGroupBox.Controls.Add(this.fileConflictedLabel);
			this.fileStatisticsGroupBox.Controls.Add(this.fileMergedLabel);
			this.fileStatisticsGroupBox.Controls.Add(this.fileDeletedLabel);
			this.fileStatisticsGroupBox.Controls.Add(this.fileExistedLabel);
			this.fileStatisticsGroupBox.Controls.Add(this.fileAddedLabel);
			this.fileStatisticsGroupBox.Controls.Add(this.fileUpdatedLabel);
			this.fileStatisticsGroupBox.Location = new System.Drawing.Point(5, 70);
			this.fileStatisticsGroupBox.Margin = new System.Windows.Forms.Padding(0);
			this.fileStatisticsGroupBox.Name = "fileStatisticsGroupBox";
			this.fileStatisticsGroupBox.Padding = new System.Windows.Forms.Padding(0);
			this.fileStatisticsGroupBox.Size = new System.Drawing.Size(262, 177);
			this.fileStatisticsGroupBox.TabIndex = 6;
			this.fileStatisticsGroupBox.TabStop = false;
			this.fileStatisticsGroupBox.Text = "File Statistics";
			//
			// fileSkippedFilesValueLabel
			//
			this.fileSkippedFilesValueLabel.AutoSize = true;
			this.fileSkippedFilesValueLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.fileSkippedFilesValueLabel.Location = new System.Drawing.Point(105, 159);
			this.fileSkippedFilesValueLabel.Margin = new System.Windows.Forms.Padding(0);
			this.fileSkippedFilesValueLabel.Name = "fileSkippedFilesValueLabel";
			this.fileSkippedFilesValueLabel.Size = new System.Drawing.Size(13, 13);
			this.fileSkippedFilesValueLabel.TabIndex = 17;
			this.fileSkippedFilesValueLabel.Text = "0";
			//
			// fileSkippedDirectoriesValueLabel
			//
			this.fileSkippedDirectoriesValueLabel.AutoSize = true;
			this.fileSkippedDirectoriesValueLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.fileSkippedDirectoriesValueLabel.Location = new System.Drawing.Point(105, 141);
			this.fileSkippedDirectoriesValueLabel.Margin = new System.Windows.Forms.Padding(0);
			this.fileSkippedDirectoriesValueLabel.Name = "fileSkippedDirectoriesValueLabel";
			this.fileSkippedDirectoriesValueLabel.Size = new System.Drawing.Size(13, 13);
			this.fileSkippedDirectoriesValueLabel.TabIndex = 16;
			this.fileSkippedDirectoriesValueLabel.Text = "0";
			//
			// fileResolvedValueLabel
			//
			this.fileResolvedValueLabel.AutoSize = true;
			this.fileResolvedValueLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.fileResolvedValueLabel.Location = new System.Drawing.Point(105, 123);
			this.fileResolvedValueLabel.Margin = new System.Windows.Forms.Padding(0);
			this.fileResolvedValueLabel.Name = "fileResolvedValueLabel";
			this.fileResolvedValueLabel.Size = new System.Drawing.Size(13, 13);
			this.fileResolvedValueLabel.TabIndex = 15;
			this.fileResolvedValueLabel.Text = "0";
			//
			// fileConflictedValueLabel
			//
			this.fileConflictedValueLabel.AutoSize = true;
			this.fileConflictedValueLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.fileConflictedValueLabel.Location = new System.Drawing.Point(105, 105);
			this.fileConflictedValueLabel.Margin = new System.Windows.Forms.Padding(0);
			this.fileConflictedValueLabel.Name = "fileConflictedValueLabel";
			this.fileConflictedValueLabel.Size = new System.Drawing.Size(13, 13);
			this.fileConflictedValueLabel.TabIndex = 14;
			this.fileConflictedValueLabel.Text = "0";
			//
			// fileMergedValueLabel
			//
			this.fileMergedValueLabel.AutoSize = true;
			this.fileMergedValueLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.fileMergedValueLabel.Location = new System.Drawing.Point(105, 87);
			this.fileMergedValueLabel.Margin = new System.Windows.Forms.Padding(0);
			this.fileMergedValueLabel.Name = "fileMergedValueLabel";
			this.fileMergedValueLabel.Size = new System.Drawing.Size(13, 13);
			this.fileMergedValueLabel.TabIndex = 13;
			this.fileMergedValueLabel.Text = "0";
			//
			// fileDeletedValueLabel
			//
			this.fileDeletedValueLabel.AutoSize = true;
			this.fileDeletedValueLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.fileDeletedValueLabel.Location = new System.Drawing.Point(105, 69);
			this.fileDeletedValueLabel.Margin = new System.Windows.Forms.Padding(0);
			this.fileDeletedValueLabel.Name = "fileDeletedValueLabel";
			this.fileDeletedValueLabel.Size = new System.Drawing.Size(13, 13);
			this.fileDeletedValueLabel.TabIndex = 12;
			this.fileDeletedValueLabel.Text = "0";
			//
			// fileExistedValueLabel
			//
			this.fileExistedValueLabel.AutoSize = true;
			this.fileExistedValueLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.fileExistedValueLabel.Location = new System.Drawing.Point(105, 51);
			this.fileExistedValueLabel.Margin = new System.Windows.Forms.Padding(0);
			this.fileExistedValueLabel.Name = "fileExistedValueLabel";
			this.fileExistedValueLabel.Size = new System.Drawing.Size(13, 13);
			this.fileExistedValueLabel.TabIndex = 11;
			this.fileExistedValueLabel.Text = "0";
			//
			// fileAddedValueLabel
			//
			this.fileAddedValueLabel.AutoSize = true;
			this.fileAddedValueLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.fileAddedValueLabel.Location = new System.Drawing.Point(105, 33);
			this.fileAddedValueLabel.Margin = new System.Windows.Forms.Padding(0);
			this.fileAddedValueLabel.Name = "fileAddedValueLabel";
			this.fileAddedValueLabel.Size = new System.Drawing.Size(13, 13);
			this.fileAddedValueLabel.TabIndex = 10;
			this.fileAddedValueLabel.Text = "0";
			//
			// fileUpdatedValueLabel
			//
			this.fileUpdatedValueLabel.AutoSize = true;
			this.fileUpdatedValueLabel.Location = new System.Drawing.Point(105, 15);
			this.fileUpdatedValueLabel.Margin = new System.Windows.Forms.Padding(0);
			this.fileUpdatedValueLabel.Name = "fileUpdatedValueLabel";
			this.fileUpdatedValueLabel.Size = new System.Drawing.Size(13, 13);
			this.fileUpdatedValueLabel.TabIndex = 9;
			this.fileUpdatedValueLabel.Text = "0";
			//
			// fileSkippedFilesLabel
			//
			this.fileSkippedFilesLabel.AutoSize = true;
			this.fileSkippedFilesLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.fileSkippedFilesLabel.Location = new System.Drawing.Point(34, 159);
			this.fileSkippedFilesLabel.Margin = new System.Windows.Forms.Padding(0);
			this.fileSkippedFilesLabel.Name = "fileSkippedFilesLabel";
			this.fileSkippedFilesLabel.Size = new System.Drawing.Size(73, 13);
			this.fileSkippedFilesLabel.TabIndex = 8;
			this.fileSkippedFilesLabel.Text = "Skipped Files:";
			//
			// filesSkipedDirectoriesLabel
			//
			this.filesSkipedDirectoriesLabel.AutoSize = true;
			this.filesSkipedDirectoriesLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.filesSkipedDirectoriesLabel.Location = new System.Drawing.Point(5, 141);
			this.filesSkipedDirectoriesLabel.Margin = new System.Windows.Forms.Padding(0);
			this.filesSkipedDirectoriesLabel.Name = "filesSkipedDirectoriesLabel";
			this.filesSkipedDirectoriesLabel.Size = new System.Drawing.Size(102, 13);
			this.filesSkipedDirectoriesLabel.TabIndex = 7;
			this.filesSkipedDirectoriesLabel.Text = "Skipped Directories:";
			//
			// fileResolvedLabel
			//
			this.fileResolvedLabel.AutoSize = true;
			this.fileResolvedLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.fileResolvedLabel.Location = new System.Drawing.Point(52, 123);
			this.fileResolvedLabel.Margin = new System.Windows.Forms.Padding(0);
			this.fileResolvedLabel.Name = "fileResolvedLabel";
			this.fileResolvedLabel.Size = new System.Drawing.Size(55, 13);
			this.fileResolvedLabel.TabIndex = 6;
			this.fileResolvedLabel.Text = "Resolved:";
			//
			// fileConflictedLabel
			//
			this.fileConflictedLabel.AutoSize = true;
			this.fileConflictedLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.fileConflictedLabel.Location = new System.Drawing.Point(50, 105);
			this.fileConflictedLabel.Margin = new System.Windows.Forms.Padding(0);
			this.fileConflictedLabel.Name = "fileConflictedLabel";
			this.fileConflictedLabel.Size = new System.Drawing.Size(57, 13);
			this.fileConflictedLabel.TabIndex = 5;
			this.fileConflictedLabel.Text = "Conflicted:";
			//
			// fileMergedLabel
			//
			this.fileMergedLabel.AutoSize = true;
			this.fileMergedLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.fileMergedLabel.Location = new System.Drawing.Point(61, 87);
			this.fileMergedLabel.Margin = new System.Windows.Forms.Padding(0);
			this.fileMergedLabel.Name = "fileMergedLabel";
			this.fileMergedLabel.Size = new System.Drawing.Size(46, 13);
			this.fileMergedLabel.TabIndex = 4;
			this.fileMergedLabel.Text = "Merged:";
			//
			// fileDeletedLabel
			//
			this.fileDeletedLabel.AutoSize = true;
			this.fileDeletedLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.fileDeletedLabel.Location = new System.Drawing.Point(60, 69);
			this.fileDeletedLabel.Margin = new System.Windows.Forms.Padding(0);
			this.fileDeletedLabel.Name = "fileDeletedLabel";
			this.fileDeletedLabel.Size = new System.Drawing.Size(47, 13);
			this.fileDeletedLabel.TabIndex = 3;
			this.fileDeletedLabel.Text = "Deleted:";
			//
			// fileExistedLabel
			//
			this.fileExistedLabel.AutoSize = true;
			this.fileExistedLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.fileExistedLabel.Location = new System.Drawing.Point(63, 51);
			this.fileExistedLabel.Margin = new System.Windows.Forms.Padding(0);
			this.fileExistedLabel.Name = "fileExistedLabel";
			this.fileExistedLabel.Size = new System.Drawing.Size(44, 13);
			this.fileExistedLabel.TabIndex = 2;
			this.fileExistedLabel.Text = "Existed:";
			//
			// fileAddedLabel
			//
			this.fileAddedLabel.AutoSize = true;
			this.fileAddedLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.fileAddedLabel.Location = new System.Drawing.Point(66, 33);
			this.fileAddedLabel.Margin = new System.Windows.Forms.Padding(0);
			this.fileAddedLabel.Name = "fileAddedLabel";
			this.fileAddedLabel.Size = new System.Drawing.Size(41, 13);
			this.fileAddedLabel.TabIndex = 1;
			this.fileAddedLabel.Text = "Added:";
			//
			// fileUpdatedLabel
			//
			this.fileUpdatedLabel.AutoSize = true;
			this.fileUpdatedLabel.Location = new System.Drawing.Point(56, 15);
			this.fileUpdatedLabel.Margin = new System.Windows.Forms.Padding(0);
			this.fileUpdatedLabel.Name = "fileUpdatedLabel";
			this.fileUpdatedLabel.Size = new System.Drawing.Size(51, 13);
			this.fileUpdatedLabel.TabIndex = 0;
			this.fileUpdatedLabel.Text = "Updated:";
			//
			// propertyStatisticsGroupBox
			//
			this.propertyStatisticsGroupBox.Controls.Add(this.propertyResolvedValueLabel);
			this.propertyStatisticsGroupBox.Controls.Add(this.propertyConflictedValueLabel);
			this.propertyStatisticsGroupBox.Controls.Add(this.propertyMergedValueLabel);
			this.propertyStatisticsGroupBox.Controls.Add(this.propertyUpdatedValueLabel);
			this.propertyStatisticsGroupBox.Controls.Add(this.propertyResolvedLabel);
			this.propertyStatisticsGroupBox.Controls.Add(this.propertyConflictedLabel);
			this.propertyStatisticsGroupBox.Controls.Add(this.propertyMergedLabel);
			this.propertyStatisticsGroupBox.Controls.Add(this.propertyUpdatedLabel);
			this.propertyStatisticsGroupBox.Location = new System.Drawing.Point(272, 70);
			this.propertyStatisticsGroupBox.Margin = new System.Windows.Forms.Padding(0);
			this.propertyStatisticsGroupBox.Name = "propertyStatisticsGroupBox";
			this.propertyStatisticsGroupBox.Padding = new System.Windows.Forms.Padding(0);
			this.propertyStatisticsGroupBox.Size = new System.Drawing.Size(265, 177);
			this.propertyStatisticsGroupBox.TabIndex = 7;
			this.propertyStatisticsGroupBox.TabStop = false;
			this.propertyStatisticsGroupBox.Text = "Property Statistics";
			//
			// propertyResolvedValueLabel
			//
			this.propertyResolvedValueLabel.AutoSize = true;
			this.propertyResolvedValueLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.propertyResolvedValueLabel.Location = new System.Drawing.Point(60, 69);
			this.propertyResolvedValueLabel.Margin = new System.Windows.Forms.Padding(0);
			this.propertyResolvedValueLabel.Name = "propertyResolvedValueLabel";
			this.propertyResolvedValueLabel.Size = new System.Drawing.Size(13, 13);
			this.propertyResolvedValueLabel.TabIndex = 23;
			this.propertyResolvedValueLabel.Text = "0";
			//
			// propertyConflictedValueLabel
			//
			this.propertyConflictedValueLabel.AutoSize = true;
			this.propertyConflictedValueLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.propertyConflictedValueLabel.Location = new System.Drawing.Point(60, 51);
			this.propertyConflictedValueLabel.Margin = new System.Windows.Forms.Padding(0);
			this.propertyConflictedValueLabel.Name = "propertyConflictedValueLabel";
			this.propertyConflictedValueLabel.Size = new System.Drawing.Size(13, 13);
			this.propertyConflictedValueLabel.TabIndex = 22;
			this.propertyConflictedValueLabel.Text = "0";
			//
			// propertyMergedValueLabel
			//
			this.propertyMergedValueLabel.AutoSize = true;
			this.propertyMergedValueLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.propertyMergedValueLabel.Location = new System.Drawing.Point(60, 33);
			this.propertyMergedValueLabel.Margin = new System.Windows.Forms.Padding(0);
			this.propertyMergedValueLabel.Name = "propertyMergedValueLabel";
			this.propertyMergedValueLabel.Size = new System.Drawing.Size(13, 13);
			this.propertyMergedValueLabel.TabIndex = 21;
			this.propertyMergedValueLabel.Text = "0";
			//
			// propertyUpdatedValueLabel
			//
			this.propertyUpdatedValueLabel.AutoSize = true;
			this.propertyUpdatedValueLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.propertyUpdatedValueLabel.Location = new System.Drawing.Point(60, 15);
			this.propertyUpdatedValueLabel.Margin = new System.Windows.Forms.Padding(0);
			this.propertyUpdatedValueLabel.Name = "propertyUpdatedValueLabel";
			this.propertyUpdatedValueLabel.Size = new System.Drawing.Size(13, 13);
			this.propertyUpdatedValueLabel.TabIndex = 20;
			this.propertyUpdatedValueLabel.Text = "0";
			//
			// propertyResolvedLabel
			//
			this.propertyResolvedLabel.AutoSize = true;
			this.propertyResolvedLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.propertyResolvedLabel.Location = new System.Drawing.Point(7, 69);
			this.propertyResolvedLabel.Margin = new System.Windows.Forms.Padding(0);
			this.propertyResolvedLabel.Name = "propertyResolvedLabel";
			this.propertyResolvedLabel.Size = new System.Drawing.Size(55, 13);
			this.propertyResolvedLabel.TabIndex = 19;
			this.propertyResolvedLabel.Text = "Resolved:";
			//
			// propertyConflictedLabel
			//
			this.propertyConflictedLabel.AutoSize = true;
			this.propertyConflictedLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.propertyConflictedLabel.Location = new System.Drawing.Point(5, 51);
			this.propertyConflictedLabel.Margin = new System.Windows.Forms.Padding(0);
			this.propertyConflictedLabel.Name = "propertyConflictedLabel";
			this.propertyConflictedLabel.Size = new System.Drawing.Size(57, 13);
			this.propertyConflictedLabel.TabIndex = 18;
			this.propertyConflictedLabel.Text = "Conflicted:";
			//
			// propertyMergedLabel
			//
			this.propertyMergedLabel.AutoSize = true;
			this.propertyMergedLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.propertyMergedLabel.Location = new System.Drawing.Point(16, 33);
			this.propertyMergedLabel.Margin = new System.Windows.Forms.Padding(0);
			this.propertyMergedLabel.Name = "propertyMergedLabel";
			this.propertyMergedLabel.Size = new System.Drawing.Size(46, 13);
			this.propertyMergedLabel.TabIndex = 17;
			this.propertyMergedLabel.Text = "Merged:";
			//
			// propertyUpdatedLabel
			//
			this.propertyUpdatedLabel.AutoSize = true;
			this.propertyUpdatedLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.propertyUpdatedLabel.Location = new System.Drawing.Point(11, 15);
			this.propertyUpdatedLabel.Margin = new System.Windows.Forms.Padding(0);
			this.propertyUpdatedLabel.Name = "propertyUpdatedLabel";
			this.propertyUpdatedLabel.Size = new System.Drawing.Size(51, 13);
			this.propertyUpdatedLabel.TabIndex = 16;
			this.propertyUpdatedLabel.Text = "Updated:";
			//
			// modifiedPathsListView
			//
			this.modifiedPathsListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
			| System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.modifiedPathsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
			this.changedPathColumn,
			this.contentColumn,
			this.propertiesColumn});
			this.modifiedPathsListView.FullRowSelect = true;
			this.modifiedPathsListView.GridLines = true;
			this.modifiedPathsListView.HideSelection = false;
			this.modifiedPathsListView.Location = new System.Drawing.Point(5, 251);
			this.modifiedPathsListView.Margin = new System.Windows.Forms.Padding(0);
			this.modifiedPathsListView.MultiSelect = false;
			this.modifiedPathsListView.Name = "modifiedPathsListView";
			this.modifiedPathsListView.Size = new System.Drawing.Size(532, 160);
			this.modifiedPathsListView.TabIndex = 2;
			this.modifiedPathsListView.UseCompatibleStateImageBehavior = false;
			this.modifiedPathsListView.View = System.Windows.Forms.View.Details;
			//
			// changedPathColumn
			//
			this.changedPathColumn.Text = "Changed Path";
			this.changedPathColumn.Width = 348;
			//
			// contentColumn
			//
			this.contentColumn.Text = "Content";
			this.contentColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.contentColumn.Width = 90;
			//
			// propertiesColumn
			//
			this.propertiesColumn.Text = "Properties";
			this.propertiesColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.propertiesColumn.Width = 90;
			//
			// MergeResultsDialog
			//
			this.AcceptButton = this.okButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.ClientSize = new System.Drawing.Size(542, 466);
			this.Controls.Add(this.modifiedPathsListView);
			this.Controls.Add(this.propertyStatisticsGroupBox);
			this.Controls.Add(this.fileStatisticsGroupBox);
			this.Controls.Add(this.controlPanel);
			this.Controls.Add(this.headerPanel);
			this.Icon = global::Ankh.UI.ResourcesMergeImage.MergeWizard;
			this.Name = "MergeResultsDialog";
			this.Text = "Merge Results";
			this.Load += new System.EventHandler(this.MergeResultsDialog_Load);
			this.Resize += new System.EventHandler(this.MergeResultsDialog_Resize);
			this.controlPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.headerImage)).EndInit();
			this.headerPanel.ResumeLayout(false);
			this.headerPanel.PerformLayout();
			this.fileStatisticsGroupBox.ResumeLayout(false);
			this.fileStatisticsGroupBox.PerformLayout();
			this.propertyStatisticsGroupBox.ResumeLayout(false);
			this.propertyStatisticsGroupBox.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label horizontalDividerLabel;
		private System.Windows.Forms.Label headerDescription;
		private System.Windows.Forms.Label headerTitle;
		private System.Windows.Forms.Panel controlPanel;
		private System.Windows.Forms.PictureBox headerImage;
		private System.Windows.Forms.Panel headerPanel;
		private System.Windows.Forms.Button okButton;
		private System.Windows.Forms.GroupBox fileStatisticsGroupBox;
		private System.Windows.Forms.GroupBox propertyStatisticsGroupBox;
		private System.Windows.Forms.Label fileUpdatedLabel;
		private System.Windows.Forms.Label fileExistedLabel;
		private System.Windows.Forms.Label fileAddedLabel;
		private System.Windows.Forms.Label fileResolvedLabel;
		private System.Windows.Forms.Label fileConflictedLabel;
		private System.Windows.Forms.Label fileMergedLabel;
		private System.Windows.Forms.Label fileDeletedLabel;
		private System.Windows.Forms.Label fileSkippedFilesLabel;
		private System.Windows.Forms.Label filesSkipedDirectoriesLabel;
		private System.Windows.Forms.Label fileUpdatedValueLabel;
		private System.Windows.Forms.Label fileExistedValueLabel;
		private System.Windows.Forms.Label fileAddedValueLabel;
		private System.Windows.Forms.Label fileSkippedFilesValueLabel;
		private System.Windows.Forms.Label fileSkippedDirectoriesValueLabel;
		private System.Windows.Forms.Label fileResolvedValueLabel;
		private System.Windows.Forms.Label fileConflictedValueLabel;
		private System.Windows.Forms.Label fileMergedValueLabel;
		private System.Windows.Forms.Label fileDeletedValueLabel;
		private System.Windows.Forms.Label propertyResolvedValueLabel;
		private System.Windows.Forms.Label propertyConflictedValueLabel;
		private System.Windows.Forms.Label propertyMergedValueLabel;
		private System.Windows.Forms.Label propertyUpdatedValueLabel;
		private System.Windows.Forms.Label propertyResolvedLabel;
		private System.Windows.Forms.Label propertyConflictedLabel;
		private System.Windows.Forms.Label propertyMergedLabel;
		private System.Windows.Forms.Label propertyUpdatedLabel;
		private System.Windows.Forms.ListView modifiedPathsListView;
		private System.Windows.Forms.ColumnHeader changedPathColumn;
		private System.Windows.Forms.ColumnHeader contentColumn;
		private System.Windows.Forms.ColumnHeader propertiesColumn;
	}
}
