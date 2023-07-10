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
	partial class MergeBestPracticesPage
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
			this.noUncommitedModificationsLabel = new System.Windows.Forms.Label();
			this.noUncommittedModificationsDescriptionLabel = new System.Windows.Forms.Label();
			this.noUncommitedModificationsPanel = new System.Windows.Forms.Panel();
			this.singleRevisionLabel = new System.Windows.Forms.Label();
			this.singleRevisionDescriptionLabel = new System.Windows.Forms.Label();
			this.singleRevisionPanel = new System.Windows.Forms.Panel();
			this.noSwitchedChildrenLabel = new System.Windows.Forms.Label();
			this.noSwitchedChildrenDescriptionLabel = new System.Windows.Forms.Label();
			this.noSwitchedChildrenPanel = new System.Windows.Forms.Panel();
			this.dividerLabel = new System.Windows.Forms.Label();
			this.completeWorkingCopyPanel = new System.Windows.Forms.Panel();
			this.completeWorkingCopyDescriptionLabel = new System.Windows.Forms.Label();
			this.completeWorkingCopyLabel = new System.Windows.Forms.Label();
			this.validRevisionPanel = new System.Windows.Forms.Panel();
			this.validRevisionDescriptionLabel = new System.Windows.Forms.Label();
			this.validRevisionLabel = new System.Windows.Forms.Label();
			this.notCheckedLabel = new System.Windows.Forms.Label();
			this.completeWorkingCopyPictureBox = new System.Windows.Forms.PictureBox();
			this.noSwitchedChildrenPictureBox = new System.Windows.Forms.PictureBox();
			this.singleRevisionPictureBox = new System.Windows.Forms.PictureBox();
			this.noUncommitedModificationsPictureBox = new System.Windows.Forms.PictureBox();
			this.noUncommitedModificationsPanel.SuspendLayout();
			this.singleRevisionPanel.SuspendLayout();
			this.noSwitchedChildrenPanel.SuspendLayout();
			this.completeWorkingCopyPanel.SuspendLayout();
			this.validRevisionPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.completeWorkingCopyPictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.noSwitchedChildrenPictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.singleRevisionPictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.noUncommitedModificationsPictureBox)).BeginInit();
			this.SuspendLayout();
			//
			// noUncommitedModificationsLabel
			//
			this.noUncommitedModificationsLabel.AutoSize = true;
			this.noUncommitedModificationsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
			this.noUncommitedModificationsLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.noUncommitedModificationsLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.noUncommitedModificationsLabel.Location = new System.Drawing.Point(21, 7);
			this.noUncommitedModificationsLabel.Margin = new System.Windows.Forms.Padding(0);
			this.noUncommitedModificationsLabel.Name = "noUncommitedModificationsLabel";
			this.noUncommitedModificationsLabel.Size = new System.Drawing.Size(176, 13);
			this.noUncommitedModificationsLabel.TabIndex = 0;
			this.noUncommitedModificationsLabel.Text = "No uncommitted modifications";
			this.noUncommitedModificationsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			// noUncommittedModificationsDescriptionLabel
			//
			this.noUncommittedModificationsDescriptionLabel.AutoSize = true;
			this.noUncommittedModificationsDescriptionLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.noUncommittedModificationsDescriptionLabel.Location = new System.Drawing.Point(21, 25);
			this.noUncommittedModificationsDescriptionLabel.Margin = new System.Windows.Forms.Padding(0);
			this.noUncommittedModificationsDescriptionLabel.Name = "noUncommittedModificationsDescriptionLabel";
			this.noUncommittedModificationsDescriptionLabel.Size = new System.Drawing.Size(283, 26);
			this.noUncommittedModificationsDescriptionLabel.TabIndex = 2;
			this.noUncommittedModificationsDescriptionLabel.Text = "The working copy should not have any local modifications.\nCommit or revert any lo" +
	"cal changes before merging.";
			//
			// noUncommitedModificationsPanel
			//
			this.noUncommitedModificationsPanel.AutoSize = true;
			this.noUncommitedModificationsPanel.Controls.Add(this.noUncommitedModificationsPictureBox);
			this.noUncommitedModificationsPanel.Controls.Add(this.noUncommittedModificationsDescriptionLabel);
			this.noUncommitedModificationsPanel.Controls.Add(this.noUncommitedModificationsLabel);
			this.noUncommitedModificationsPanel.Location = new System.Drawing.Point(0, 0);
			this.noUncommitedModificationsPanel.Margin = new System.Windows.Forms.Padding(0);
			this.noUncommitedModificationsPanel.Name = "noUncommitedModificationsPanel";
			this.noUncommitedModificationsPanel.Size = new System.Drawing.Size(500, 55);
			this.noUncommitedModificationsPanel.TabIndex = 3;
			//
			// singleRevisionLabel
			//
			this.singleRevisionLabel.AutoSize = true;
			this.singleRevisionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
			this.singleRevisionLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.singleRevisionLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.singleRevisionLabel.Location = new System.Drawing.Point(21, 7);
			this.singleRevisionLabel.Margin = new System.Windows.Forms.Padding(0);
			this.singleRevisionLabel.Name = "singleRevisionLabel";
			this.singleRevisionLabel.Size = new System.Drawing.Size(196, 13);
			this.singleRevisionLabel.TabIndex = 0;
			this.singleRevisionLabel.Text = "Working copy at a single revision";
			this.singleRevisionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			// singleRevisionDescriptionLabel
			//
			this.singleRevisionDescriptionLabel.AutoSize = true;
			this.singleRevisionDescriptionLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.singleRevisionDescriptionLabel.Location = new System.Drawing.Point(21, 25);
			this.singleRevisionDescriptionLabel.Margin = new System.Windows.Forms.Padding(0);
			this.singleRevisionDescriptionLabel.Name = "singleRevisionDescriptionLabel";
			this.singleRevisionDescriptionLabel.Size = new System.Drawing.Size(195, 13);
			this.singleRevisionDescriptionLabel.TabIndex = 2;
			this.singleRevisionDescriptionLabel.Text = "The working copy is at a single revision.";
			//
			// singleRevisionPanel
			//
			this.singleRevisionPanel.AutoSize = true;
			this.singleRevisionPanel.Controls.Add(this.singleRevisionPictureBox);
			this.singleRevisionPanel.Controls.Add(this.singleRevisionDescriptionLabel);
			this.singleRevisionPanel.Controls.Add(this.singleRevisionLabel);
			this.singleRevisionPanel.Location = new System.Drawing.Point(0, 55);
			this.singleRevisionPanel.Margin = new System.Windows.Forms.Padding(0);
			this.singleRevisionPanel.Name = "singleRevisionPanel";
			this.singleRevisionPanel.Size = new System.Drawing.Size(500, 42);
			this.singleRevisionPanel.TabIndex = 4;
			//
			// noSwitchedChildrenLabel
			//
			this.noSwitchedChildrenLabel.AutoSize = true;
			this.noSwitchedChildrenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
			this.noSwitchedChildrenLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.noSwitchedChildrenLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.noSwitchedChildrenLabel.Location = new System.Drawing.Point(21, 7);
			this.noSwitchedChildrenLabel.Margin = new System.Windows.Forms.Padding(0);
			this.noSwitchedChildrenLabel.Name = "noSwitchedChildrenLabel";
			this.noSwitchedChildrenLabel.Size = new System.Drawing.Size(126, 13);
			this.noSwitchedChildrenLabel.TabIndex = 0;
			this.noSwitchedChildrenLabel.Text = "No switched children";
			this.noSwitchedChildrenLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			// noSwitchedChildrenDescriptionLabel
			//
			this.noSwitchedChildrenDescriptionLabel.AutoSize = true;
			this.noSwitchedChildrenDescriptionLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.noSwitchedChildrenDescriptionLabel.Location = new System.Drawing.Point(21, 25);
			this.noSwitchedChildrenDescriptionLabel.Margin = new System.Windows.Forms.Padding(0);
			this.noSwitchedChildrenDescriptionLabel.Name = "noSwitchedChildrenDescriptionLabel";
			this.noSwitchedChildrenDescriptionLabel.Size = new System.Drawing.Size(271, 13);
			this.noSwitchedChildrenDescriptionLabel.TabIndex = 2;
			this.noSwitchedChildrenDescriptionLabel.Text = "The working copy does not have any switched children.";
			//
			// noSwitchedChildrenPanel
			//
			this.noSwitchedChildrenPanel.AutoSize = true;
			this.noSwitchedChildrenPanel.Controls.Add(this.noSwitchedChildrenPictureBox);
			this.noSwitchedChildrenPanel.Controls.Add(this.noSwitchedChildrenDescriptionLabel);
			this.noSwitchedChildrenPanel.Controls.Add(this.noSwitchedChildrenLabel);
			this.noSwitchedChildrenPanel.Location = new System.Drawing.Point(0, 97);
			this.noSwitchedChildrenPanel.Margin = new System.Windows.Forms.Padding(0);
			this.noSwitchedChildrenPanel.Name = "noSwitchedChildrenPanel";
			this.noSwitchedChildrenPanel.Size = new System.Drawing.Size(500, 42);
			this.noSwitchedChildrenPanel.TabIndex = 5;
			//
			// dividerLabel
			//
			this.dividerLabel.BackColor = System.Drawing.SystemColors.ControlText;
			this.dividerLabel.Location = new System.Drawing.Point(0, 194);
			this.dividerLabel.Margin = new System.Windows.Forms.Padding(0);
			this.dividerLabel.Name = "dividerLabel";
			this.dividerLabel.Size = new System.Drawing.Size(500, 1);
			this.dividerLabel.TabIndex = 6;
			//
			// completeWorkingCopyPanel
			//
			this.completeWorkingCopyPanel.AutoSize = true;
			this.completeWorkingCopyPanel.Controls.Add(this.completeWorkingCopyPictureBox);
			this.completeWorkingCopyPanel.Controls.Add(this.completeWorkingCopyDescriptionLabel);
			this.completeWorkingCopyPanel.Controls.Add(this.completeWorkingCopyLabel);
			this.completeWorkingCopyPanel.Location = new System.Drawing.Point(0, 139);
			this.completeWorkingCopyPanel.Margin = new System.Windows.Forms.Padding(0);
			this.completeWorkingCopyPanel.Name = "completeWorkingCopyPanel";
			this.completeWorkingCopyPanel.Size = new System.Drawing.Size(500, 55);
			this.completeWorkingCopyPanel.TabIndex = 7;
			//
			// completeWorkingCopyDescriptionLabel
			//
			this.completeWorkingCopyDescriptionLabel.AutoSize = true;
			this.completeWorkingCopyDescriptionLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.completeWorkingCopyDescriptionLabel.Location = new System.Drawing.Point(21, 25);
			this.completeWorkingCopyDescriptionLabel.Margin = new System.Windows.Forms.Padding(0);
			this.completeWorkingCopyDescriptionLabel.MaximumSize = new System.Drawing.Size(450, 0);
			this.completeWorkingCopyDescriptionLabel.MinimumSize = new System.Drawing.Size(450, 25);
			this.completeWorkingCopyDescriptionLabel.Name = "completeWorkingCopyDescriptionLabel";
			this.completeWorkingCopyDescriptionLabel.Size = new System.Drawing.Size(450, 26);
			this.completeWorkingCopyDescriptionLabel.TabIndex = 2;
			this.completeWorkingCopyDescriptionLabel.Text = "The working copy should be a complete working copy (depth=infinity).  If the work" +
	"ing copy is not complete, update the working copy before merging.";
			//
			// completeWorkingCopyLabel
			//
			this.completeWorkingCopyLabel.AutoSize = true;
			this.completeWorkingCopyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
			this.completeWorkingCopyLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.completeWorkingCopyLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.completeWorkingCopyLabel.Location = new System.Drawing.Point(21, 7);
			this.completeWorkingCopyLabel.Margin = new System.Windows.Forms.Padding(0);
			this.completeWorkingCopyLabel.Name = "completeWorkingCopyLabel";
			this.completeWorkingCopyLabel.Size = new System.Drawing.Size(138, 13);
			this.completeWorkingCopyLabel.TabIndex = 0;
			this.completeWorkingCopyLabel.Text = "Complete working copy";
			this.completeWorkingCopyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			// validRevisionPanel
			//
			this.validRevisionPanel.AutoSize = true;
			this.validRevisionPanel.Controls.Add(this.validRevisionDescriptionLabel);
			this.validRevisionPanel.Controls.Add(this.validRevisionLabel);
			this.validRevisionPanel.Location = new System.Drawing.Point(0, 218);
			this.validRevisionPanel.Margin = new System.Windows.Forms.Padding(0);
			this.validRevisionPanel.Name = "validRevisionPanel";
			this.validRevisionPanel.Size = new System.Drawing.Size(500, 55);
			this.validRevisionPanel.TabIndex = 8;
			//
			// validRevisionDescriptionLabel
			//
			this.validRevisionDescriptionLabel.AutoSize = true;
			this.validRevisionDescriptionLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.validRevisionDescriptionLabel.Location = new System.Drawing.Point(21, 25);
			this.validRevisionDescriptionLabel.Margin = new System.Windows.Forms.Padding(0);
			this.validRevisionDescriptionLabel.MaximumSize = new System.Drawing.Size(450, 0);
			this.validRevisionDescriptionLabel.MinimumSize = new System.Drawing.Size(450, 25);
			this.validRevisionDescriptionLabel.Name = "validRevisionDescriptionLabel";
			this.validRevisionDescriptionLabel.Size = new System.Drawing.Size(450, 26);
			this.validRevisionDescriptionLabel.TabIndex = 2;
			this.validRevisionDescriptionLabel.Text = "The revision of the working copy must be greater than or equal to the last revisi" +
	"on the branch was synchronized to.  If the working copy is at a lesser revision," +
	" update before merging.";
			//
			// validRevisionLabel
			//
			this.validRevisionLabel.AutoSize = true;
			this.validRevisionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
			this.validRevisionLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.validRevisionLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.validRevisionLabel.Location = new System.Drawing.Point(21, 7);
			this.validRevisionLabel.Margin = new System.Windows.Forms.Padding(0);
			this.validRevisionLabel.Name = "validRevisionLabel";
			this.validRevisionLabel.Size = new System.Drawing.Size(333, 13);
			this.validRevisionLabel.TabIndex = 0;
			this.validRevisionLabel.Text = "Working copy at a valid revision (Reintegrate merge only)";
			this.validRevisionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			// notCheckedLabel
			//
			this.notCheckedLabel.AutoSize = true;
			this.notCheckedLabel.Location = new System.Drawing.Point(5, 200);
			this.notCheckedLabel.Margin = new System.Windows.Forms.Padding(0);
			this.notCheckedLabel.Name = "notCheckedLabel";
			this.notCheckedLabel.Size = new System.Drawing.Size(267, 13);
			this.notCheckedLabel.TabIndex = 9;
			this.notCheckedLabel.Text = "The following are best practices but were not checked:";
			//
			// completeWorkingCopyPictureBox
			//
			this.completeWorkingCopyPictureBox.Image = global::Ankh.UI.ResourcesMergeImage.BPCheck;
			this.completeWorkingCopyPictureBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.completeWorkingCopyPictureBox.Location = new System.Drawing.Point(5, 5);
			this.completeWorkingCopyPictureBox.Margin = new System.Windows.Forms.Padding(0);
			this.completeWorkingCopyPictureBox.Name = "completeWorkingCopyPictureBox";
			this.completeWorkingCopyPictureBox.Size = new System.Drawing.Size(16, 16);
			this.completeWorkingCopyPictureBox.TabIndex = 3;
			this.completeWorkingCopyPictureBox.TabStop = false;
			//
			// noSwitchedChildrenPictureBox
			//
			this.noSwitchedChildrenPictureBox.Image = global::Ankh.UI.ResourcesMergeImage.BPCheck;
			this.noSwitchedChildrenPictureBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.noSwitchedChildrenPictureBox.Location = new System.Drawing.Point(5, 5);
			this.noSwitchedChildrenPictureBox.Margin = new System.Windows.Forms.Padding(0);
			this.noSwitchedChildrenPictureBox.Name = "noSwitchedChildrenPictureBox";
			this.noSwitchedChildrenPictureBox.Size = new System.Drawing.Size(16, 16);
			this.noSwitchedChildrenPictureBox.TabIndex = 1;
			this.noSwitchedChildrenPictureBox.TabStop = false;
			//
			// singleRevisionPictureBox
			//
			this.singleRevisionPictureBox.Image = global::Ankh.UI.ResourcesMergeImage.BPCheck;
			this.singleRevisionPictureBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.singleRevisionPictureBox.Location = new System.Drawing.Point(5, 5);
			this.singleRevisionPictureBox.Margin = new System.Windows.Forms.Padding(0);
			this.singleRevisionPictureBox.Name = "singleRevisionPictureBox";
			this.singleRevisionPictureBox.Size = new System.Drawing.Size(16, 16);
			this.singleRevisionPictureBox.TabIndex = 1;
			this.singleRevisionPictureBox.TabStop = false;
			//
			// noUncommitedModificationsPictureBox
			//
			this.noUncommitedModificationsPictureBox.Image = global::Ankh.UI.ResourcesMergeImage.BPCheck;
			this.noUncommitedModificationsPictureBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.noUncommitedModificationsPictureBox.Location = new System.Drawing.Point(5, 5);
			this.noUncommitedModificationsPictureBox.Margin = new System.Windows.Forms.Padding(0);
			this.noUncommitedModificationsPictureBox.Name = "noUncommitedModificationsPictureBox";
			this.noUncommitedModificationsPictureBox.Size = new System.Drawing.Size(16, 16);
			this.noUncommitedModificationsPictureBox.TabIndex = 1;
			this.noUncommitedModificationsPictureBox.TabStop = false;
			//
			// MergeBestPracticesPage
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.notCheckedLabel);
			this.Controls.Add(this.validRevisionPanel);
			this.Controls.Add(this.completeWorkingCopyPanel);
			this.Controls.Add(this.dividerLabel);
			this.Controls.Add(this.noSwitchedChildrenPanel);
			this.Controls.Add(this.singleRevisionPanel);
			this.Controls.Add(this.noUncommitedModificationsPanel);
			this.Margin = new System.Windows.Forms.Padding(0);
			this.Name = "MergeBestPracticesPage";
			this.Size = new System.Drawing.Size(500, 405);
			this.noUncommitedModificationsPanel.ResumeLayout(false);
			this.noUncommitedModificationsPanel.PerformLayout();
			this.singleRevisionPanel.ResumeLayout(false);
			this.singleRevisionPanel.PerformLayout();
			this.noSwitchedChildrenPanel.ResumeLayout(false);
			this.noSwitchedChildrenPanel.PerformLayout();
			this.completeWorkingCopyPanel.ResumeLayout(false);
			this.completeWorkingCopyPanel.PerformLayout();
			this.validRevisionPanel.ResumeLayout(false);
			this.validRevisionPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.completeWorkingCopyPictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.noSwitchedChildrenPictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.singleRevisionPictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.noUncommitedModificationsPictureBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label noUncommitedModificationsLabel;
		private System.Windows.Forms.Label noUncommittedModificationsDescriptionLabel;
		private System.Windows.Forms.PictureBox noUncommitedModificationsPictureBox;
		private System.Windows.Forms.Panel noUncommitedModificationsPanel;
		private System.Windows.Forms.Label singleRevisionLabel;
		private System.Windows.Forms.Label singleRevisionDescriptionLabel;
		private System.Windows.Forms.PictureBox singleRevisionPictureBox;
		private System.Windows.Forms.Panel singleRevisionPanel;
		private System.Windows.Forms.Label noSwitchedChildrenLabel;
		private System.Windows.Forms.Label noSwitchedChildrenDescriptionLabel;
		private System.Windows.Forms.PictureBox noSwitchedChildrenPictureBox;
		private System.Windows.Forms.Panel noSwitchedChildrenPanel;
		private System.Windows.Forms.Label dividerLabel;
		private System.Windows.Forms.Panel completeWorkingCopyPanel;
		private System.Windows.Forms.Label completeWorkingCopyDescriptionLabel;
		private System.Windows.Forms.Label completeWorkingCopyLabel;
		private System.Windows.Forms.Panel validRevisionPanel;
		private System.Windows.Forms.Label validRevisionDescriptionLabel;
		private System.Windows.Forms.Label validRevisionLabel;
		private System.Windows.Forms.Label notCheckedLabel;
		private System.Windows.Forms.PictureBox completeWorkingCopyPictureBox;



	}
}
