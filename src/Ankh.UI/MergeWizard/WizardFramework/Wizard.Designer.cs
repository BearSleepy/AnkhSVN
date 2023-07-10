/*
 * WizardDialog.Designer.cs
 *
 * Copyright (c) 2008 CollabNet, Inc. ("CollabNet"), http://www.collab.net,
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 *
 **/
namespace Ankh.UI.WizardFramework
{
	partial class Wizard
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
			this.controlPanel = new System.Windows.Forms.Panel();
			this.horizontalDividerLabel = new System.Windows.Forms.Label();
			this.backButton = new System.Windows.Forms.Button();
			this.nextButton = new System.Windows.Forms.Button();
			this.finishButton = new System.Windows.Forms.Button();
			this.cancelButton = new System.Windows.Forms.Button();
			this.wizardPagePanel = new System.Windows.Forms.Panel();
			this.headerPanel = new System.Windows.Forms.Panel();
			this.statusPanel = new System.Windows.Forms.Panel();
			this.statusIcon = new System.Windows.Forms.PictureBox();
			this.statusMessage = new System.Windows.Forms.Label();
			this.headerDescription = new System.Windows.Forms.Label();
			this.headerTitle = new System.Windows.Forms.Label();
			this.headerImage = new System.Windows.Forms.PictureBox();
			this.controlPanel.SuspendLayout();
			this.headerPanel.SuspendLayout();
			this.statusPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.statusIcon)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.headerImage)).BeginInit();
			this.SuspendLayout();
			//
			// controlPanel
			//
			this.controlPanel.Controls.Add(this.horizontalDividerLabel);
			this.controlPanel.Controls.Add(this.backButton);
			this.controlPanel.Controls.Add(this.nextButton);
			this.controlPanel.Controls.Add(this.finishButton);
			this.controlPanel.Controls.Add(this.cancelButton);
			this.controlPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.controlPanel.Location = new System.Drawing.Point(0, 425);
			this.controlPanel.Margin = new System.Windows.Forms.Padding(0);
			this.controlPanel.Name = "controlPanel";
			this.controlPanel.Size = new System.Drawing.Size(574, 50);
			this.controlPanel.TabIndex = 0;
			//
			// horizontalDividerLabel
			//
			this.horizontalDividerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.horizontalDividerLabel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.horizontalDividerLabel.ForeColor = System.Drawing.SystemColors.ControlText;
			this.horizontalDividerLabel.Location = new System.Drawing.Point(0, 0);
			this.horizontalDividerLabel.Name = "horizontalDividerLabel";
			this.horizontalDividerLabel.Size = new System.Drawing.Size(574, 1);
			this.horizontalDividerLabel.TabIndex = 0;
			//
			// backButton
			//
			this.backButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.backButton.Enabled = false;
			this.backButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.backButton.Location = new System.Drawing.Point(302, 16);
			this.backButton.Name = "backButton";
			this.backButton.Size = new System.Drawing.Size(75, 23);
			this.backButton.TabIndex = 1;
			this.backButton.Text = "< &Back";
			this.backButton.UseVisualStyleBackColor = true;
			this.backButton.Click += new System.EventHandler(this.backButton_Click);
			//
			// nextButton
			//
			this.nextButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.nextButton.Enabled = false;
			this.nextButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.nextButton.Location = new System.Drawing.Point(383, 16);
			this.nextButton.Name = "nextButton";
			this.nextButton.Size = new System.Drawing.Size(75, 23);
			this.nextButton.TabIndex = 2;
			this.nextButton.Text = "&Next >";
			this.nextButton.UseVisualStyleBackColor = true;
			this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
			//
			// finishButton
			//
			this.finishButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.finishButton.Enabled = false;
			this.finishButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.finishButton.Location = new System.Drawing.Point(384, 16);
			this.finishButton.Name = "finishButton";
			this.finishButton.Size = new System.Drawing.Size(75, 23);
			this.finishButton.TabIndex = 3;
			this.finishButton.Text = "Finish";
			this.finishButton.UseVisualStyleBackColor = true;
			this.finishButton.Visible = false;
			this.finishButton.Click += new System.EventHandler(this.finishButton_Click);
			//
			// cancelButton
			//
			this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cancelButton.Location = new System.Drawing.Point(485, 16);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(75, 23);
			this.cancelButton.TabIndex = 4;
			this.cancelButton.Text = "Cancel";
			this.cancelButton.UseVisualStyleBackColor = true;
			this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
			//
			// wizardPagePanel
			//
			this.wizardPagePanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.wizardPagePanel.Location = new System.Drawing.Point(0, 66);
			this.wizardPagePanel.Margin = new System.Windows.Forms.Padding(0);
			this.wizardPagePanel.MinimumSize = new System.Drawing.Size(349, 200);
			this.wizardPagePanel.Name = "wizardPagePanel";
			this.wizardPagePanel.Size = new System.Drawing.Size(574, 359);
			this.wizardPagePanel.TabIndex = 1;
			//
			// headerPanel
			//
			this.headerPanel.BackColor = System.Drawing.Color.White;
			this.headerPanel.Controls.Add(this.statusPanel);
			this.headerPanel.Controls.Add(this.headerDescription);
			this.headerPanel.Controls.Add(this.headerTitle);
			this.headerPanel.Controls.Add(this.headerImage);
			this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.headerPanel.Location = new System.Drawing.Point(0, 0);
			this.headerPanel.Margin = new System.Windows.Forms.Padding(0);
			this.headerPanel.Name = "headerPanel";
			this.headerPanel.Size = new System.Drawing.Size(574, 66);
			this.headerPanel.TabIndex = 2;
			//
			// statusPanel
			//
			this.statusPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.statusPanel.Controls.Add(this.statusIcon);
			this.statusPanel.Controls.Add(this.statusMessage);
			this.statusPanel.Location = new System.Drawing.Point(0, 21);
			this.statusPanel.Margin = new System.Windows.Forms.Padding(0);
			this.statusPanel.Name = "statusPanel";
			this.statusPanel.Size = new System.Drawing.Size(505, 45);
			this.statusPanel.TabIndex = 4;
			this.statusPanel.Visible = false;
			//
			// statusIcon
			//
			this.statusIcon.Location = new System.Drawing.Point(5, 3);
			this.statusIcon.Margin = new System.Windows.Forms.Padding(0);
			this.statusIcon.Name = "statusIcon";
			this.statusIcon.Size = new System.Drawing.Size(16, 16);
			this.statusIcon.TabIndex = 0;
			this.statusIcon.TabStop = false;
			//
			// statusMessage
			//
			this.statusMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.statusMessage.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.statusMessage.Location = new System.Drawing.Point(26, 3);
			this.statusMessage.Margin = new System.Windows.Forms.Padding(0);
			this.statusMessage.Name = "statusMessage";
			this.statusMessage.Size = new System.Drawing.Size(476, 38);
			this.statusMessage.TabIndex = 3;
			this.statusMessage.Text = "Wizard Page Status Message";
			//
			// headerDescription
			//
			this.headerDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.headerDescription.Location = new System.Drawing.Point(26, 24);
			this.headerDescription.Name = "headerDescription";
			this.headerDescription.Size = new System.Drawing.Size(475, 38);
			this.headerDescription.TabIndex = 2;
			this.headerDescription.Text = "Wizard Page Message";
			//
			// headerTitle
			//
			this.headerTitle.AutoSize = true;
			this.headerTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
			this.headerTitle.Location = new System.Drawing.Point(5, 5);
			this.headerTitle.Margin = new System.Windows.Forms.Padding(0);
			this.headerTitle.Name = "headerTitle";
			this.headerTitle.Size = new System.Drawing.Size(108, 13);
			this.headerTitle.TabIndex = 1;
			this.headerTitle.Text = "Wizard Page Title";
			this.headerTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			// headerImage
			//
			this.headerImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.headerImage.ErrorImage = null;
			this.headerImage.Location = new System.Drawing.Point(509, 1);
			this.headerImage.Margin = new System.Windows.Forms.Padding(0);
			this.headerImage.MaximumSize = new System.Drawing.Size(64, 64);
			this.headerImage.MinimumSize = new System.Drawing.Size(64, 64);
			this.headerImage.Name = "headerImage";
			this.headerImage.Size = new System.Drawing.Size(64, 64);
			this.headerImage.TabIndex = 0;
			this.headerImage.TabStop = false;
			//
			// Wizard
			//
			this.AcceptButton = this.nextButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.CancelButton = this.cancelButton;
			this.ClientSize = new System.Drawing.Size(574, 475);
			this.Controls.Add(this.wizardPagePanel);
			this.Controls.Add(this.headerPanel);
			this.Controls.Add(this.controlPanel);
			this.MinimumSize = new System.Drawing.Size(349, 332);
			this.Name = "Wizard";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.Text = "Wizard Dialog";
			this.controlPanel.ResumeLayout(false);
			this.headerPanel.ResumeLayout(false);
			this.headerPanel.PerformLayout();
			this.statusPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.statusIcon)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.headerImage)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel controlPanel;
		private System.Windows.Forms.Button backButton;
		private System.Windows.Forms.Button nextButton;
		private System.Windows.Forms.Button finishButton;
		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.Label horizontalDividerLabel;
		private System.Windows.Forms.Panel wizardPagePanel;
		private System.Windows.Forms.Panel headerPanel;
		private System.Windows.Forms.PictureBox headerImage;
		private System.Windows.Forms.Label headerTitle;
		private System.Windows.Forms.Label headerDescription;
		private System.Windows.Forms.Label statusMessage;
		private System.Windows.Forms.Panel statusPanel;
		private System.Windows.Forms.PictureBox statusIcon;


	}
}
