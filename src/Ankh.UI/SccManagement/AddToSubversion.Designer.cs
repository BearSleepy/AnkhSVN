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

namespace Ankh.UI.SccManagement
{
	partial class AddToSubversion
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
			this.components = new System.ComponentModel.Container();
			this.locationBox = new System.Windows.Forms.GroupBox();
			this.selectRepositoryButton = new System.Windows.Forms.Button();
			this.repositoryUrl = new System.Windows.Forms.ComboBox();
			this.createFolderButton = new System.Windows.Forms.Button();
			this.repositoryTree = new Ankh.UI.RepositoryExplorer.RepositoryTreeView();
			this.localFolderBox = new System.Windows.Forms.GroupBox();
			this.commitAll = new System.Windows.Forms.CheckBox();
			this.localFolder = new System.Windows.Forms.ComboBox();
			this.cancelButton = new System.Windows.Forms.Button();
			this.okButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.projectBox = new System.Windows.Forms.GroupBox();
			this.projectNameBox = new System.Windows.Forms.TextBox();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.resultUriBox = new System.Windows.Forms.TextBox();
			this.addTrunk = new System.Windows.Forms.CheckBox();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.bodyPanel = new System.Windows.Forms.Panel();
			this.locationBox.SuspendLayout();
			this.localFolderBox.SuspendLayout();
			this.projectBox.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.bodyPanel.SuspendLayout();
			this.SuspendLayout();
			//
			// locationBox
			//
			this.locationBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
			| System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.locationBox.Controls.Add(this.selectRepositoryButton);
			this.locationBox.Controls.Add(this.repositoryUrl);
			this.locationBox.Controls.Add(this.createFolderButton);
			this.locationBox.Controls.Add(this.repositoryTree);
			this.locationBox.Location = new System.Drawing.Point(12, 91);
			this.locationBox.Name = "locationBox";
			this.locationBox.Size = new System.Drawing.Size(468, 215);
			this.locationBox.TabIndex = 2;
			this.locationBox.TabStop = false;
			this.locationBox.Text = "&Repository Url:";
			//
			// selectRepositoryButton
			//
			this.selectRepositoryButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.selectRepositoryButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.selectRepositoryButton.Location = new System.Drawing.Point(368, 17);
			this.selectRepositoryButton.Name = "selectRepositoryButton";
			this.selectRepositoryButton.Size = new System.Drawing.Size(93, 23);
			this.selectRepositoryButton.TabIndex = 5;
			this.selectRepositoryButton.Text = "...";
			this.selectRepositoryButton.UseVisualStyleBackColor = true;
			this.selectRepositoryButton.Click += new System.EventHandler(this.selectRepositoryButton_Click);
			//
			// repositoryUrl
			//
			this.repositoryUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.repositoryUrl.FormattingEnabled = true;
			this.repositoryUrl.Location = new System.Drawing.Point(6, 19);
			this.repositoryUrl.Name = "repositoryUrl";
			this.repositoryUrl.Size = new System.Drawing.Size(356, 21);
			this.repositoryUrl.TabIndex = 1;
			this.repositoryUrl.SelectedIndexChanged += new System.EventHandler(this.repositoryUrl_SelectedIndexChanged);
			this.repositoryUrl.TextUpdate += new System.EventHandler(this.repositoryUrl_TextUpdate);
			//
			// createFolderButton
			//
			this.createFolderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.createFolderButton.Enabled = false;
			this.createFolderButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.createFolderButton.Location = new System.Drawing.Point(368, 46);
			this.createFolderButton.Name = "createFolderButton";
			this.createFolderButton.Size = new System.Drawing.Size(93, 23);
			this.createFolderButton.TabIndex = 3;
			this.createFolderButton.Text = "&Create Folder...";
			this.createFolderButton.UseVisualStyleBackColor = true;
			this.createFolderButton.Click += new System.EventHandler(this.createFolderButton_Click);
			//
			// repositoryTree
			//
			this.repositoryTree.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
			| System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.repositoryTree.Location = new System.Drawing.Point(6, 46);
			this.repositoryTree.Name = "repositoryTree";
			this.repositoryTree.ShowFiles = false;
			this.repositoryTree.ShowLines = false;
			this.repositoryTree.Size = new System.Drawing.Size(356, 97);
			this.repositoryTree.TabIndex = 2;
			this.repositoryTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
			//
			// localFolderBox
			//
			this.localFolderBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.localFolderBox.Controls.Add(this.commitAll);
			this.localFolderBox.Controls.Add(this.localFolder);
			this.localFolderBox.Location = new System.Drawing.Point(12, 312);
			this.localFolderBox.Name = "localFolderBox";
			this.localFolderBox.Size = new System.Drawing.Size(468, 70);
			this.localFolderBox.TabIndex = 3;
			this.localFolderBox.TabStop = false;
			this.localFolderBox.Text = "Local &Folder:";
			//
			// commitAll
			//
			this.commitAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.commitAll.AutoSize = true;
			this.commitAll.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.commitAll.Location = new System.Drawing.Point(6, 46);
			this.commitAll.Name = "commitAll";
			this.commitAll.Size = new System.Drawing.Size(172, 17);
			this.commitAll.TabIndex = 5;
			this.commitAll.Text = "Commit files in the initial commit";
			this.commitAll.UseVisualStyleBackColor = true;
			//
			// localFolder
			//
			this.localFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.localFolder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.localFolder.FormattingEnabled = true;
			this.localFolder.Location = new System.Drawing.Point(6, 19);
			this.localFolder.Name = "localFolder";
			this.localFolder.Size = new System.Drawing.Size(455, 21);
			this.localFolder.TabIndex = 0;
			this.localFolder.SelectedIndexChanged += new System.EventHandler(this.localFolder_SelectedIndexChanged);
			//
			// cancelButton
			//
			this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cancelButton.CausesValidation = false;
			this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cancelButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.cancelButton.Location = new System.Drawing.Point(406, 476);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(75, 23);
			this.cancelButton.TabIndex = 2;
			this.cancelButton.Text = "Cancel";
			this.cancelButton.UseVisualStyleBackColor = true;
			//
			// okButton
			//
			this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.okButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.okButton.Location = new System.Drawing.Point(325, 476);
			this.okButton.Name = "okButton";
			this.okButton.Size = new System.Drawing.Size(75, 23);
			this.okButton.TabIndex = 1;
			this.okButton.Text = "OK";
			this.okButton.UseVisualStyleBackColor = true;
			this.okButton.Click += new System.EventHandler(this.okButton_Click);
			//
			// label1
			//
			this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(427, 28);
			this.label1.TabIndex = 0;
			this.label1.Text = "This will create a folder in the repository to hold your project and initialize y" +
	"our working copy.";
			//
			// projectBox
			//
			this.projectBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.projectBox.Controls.Add(this.projectNameBox);
			this.projectBox.Location = new System.Drawing.Point(12, 40);
			this.projectBox.Name = "projectBox";
			this.projectBox.Size = new System.Drawing.Size(468, 45);
			this.projectBox.TabIndex = 1;
			this.projectBox.TabStop = false;
			this.projectBox.Text = "Project &Name:";
			//
			// projectNameBox
			//
			this.projectNameBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.projectNameBox.Location = new System.Drawing.Point(6, 17);
			this.projectNameBox.Name = "projectNameBox";
			this.projectNameBox.Size = new System.Drawing.Size(456, 20);
			this.projectNameBox.TabIndex = 0;
			this.projectNameBox.TextChanged += new System.EventHandler(this.projectNameBox_TextChanged);
			//
			// timer1
			//
			this.timer1.Interval = 350;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			//
			// groupBox2
			//
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox2.Controls.Add(this.resultUriBox);
			this.groupBox2.Location = new System.Drawing.Point(12, 409);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(468, 48);
			this.groupBox2.TabIndex = 5;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Project will be create&d in:";
			//
			// resultUriBox
			//
			this.resultUriBox.Location = new System.Drawing.Point(6, 19);
			this.resultUriBox.Name = "resultUriBox";
			this.resultUriBox.ReadOnly = true;
			this.resultUriBox.Size = new System.Drawing.Size(421, 20);
			this.resultUriBox.TabIndex = 0;
			this.resultUriBox.TabStop = false;
			//
			// addTrunk
			//
			this.addTrunk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.addTrunk.AutoSize = true;
			this.addTrunk.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.addTrunk.Location = new System.Drawing.Point(18, 388);
			this.addTrunk.Name = "addTrunk";
			this.addTrunk.Size = new System.Drawing.Size(155, 17);
			this.addTrunk.TabIndex = 4;
			this.addTrunk.Text = "A&dd trunk Folder for Project";
			this.addTrunk.UseVisualStyleBackColor = true;
			this.addTrunk.CheckedChanged += new System.EventHandler(this.addTrunk_CheckedChanged);
			//
			// errorProvider1
			//
			this.errorProvider1.ContainerControl = this;
			//
			// bodyPanel
			//
			this.bodyPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
			| System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.bodyPanel.Controls.Add(this.addTrunk);
			this.bodyPanel.Controls.Add(this.groupBox2);
			this.bodyPanel.Controls.Add(this.projectBox);
			this.bodyPanel.Controls.Add(this.label1);
			this.bodyPanel.Controls.Add(this.localFolderBox);
			this.bodyPanel.Controls.Add(this.locationBox);
			this.bodyPanel.Location = new System.Drawing.Point(0, 0);
			this.bodyPanel.Name = "bodyPanel";
			this.bodyPanel.Size = new System.Drawing.Size(493, 466);
			this.bodyPanel.TabIndex = 0;
			//
			// AddToSubversion
			//
			this.AcceptButton = this.okButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.CancelButton = this.cancelButton;
			this.ClientSize = new System.Drawing.Size(494, 511);
			this.Controls.Add(this.okButton);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.bodyPanel);
			this.Name = "AddToSubversion";
			this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
			this.Text = "Add to Subversion";
			this.locationBox.ResumeLayout(false);
			this.localFolderBox.ResumeLayout(false);
			this.localFolderBox.PerformLayout();
			this.projectBox.ResumeLayout(false);
			this.projectBox.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.bodyPanel.ResumeLayout(false);
			this.bodyPanel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox locationBox;
		private System.Windows.Forms.GroupBox localFolderBox;
		private System.Windows.Forms.Button createFolderButton;
		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.Button okButton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox projectBox;
		private System.Windows.Forms.TextBox projectNameBox;
		private System.Windows.Forms.ComboBox repositoryUrl;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox resultUriBox;
		private System.Windows.Forms.CheckBox addTrunk;
		protected internal System.Windows.Forms.ComboBox localFolder;
		internal Ankh.UI.RepositoryExplorer.RepositoryTreeView repositoryTree;
		protected internal System.Windows.Forms.ErrorProvider errorProvider1;
		protected System.Windows.Forms.Panel bodyPanel;
		private System.Windows.Forms.CheckBox commitAll;
		private System.Windows.Forms.Button selectRepositoryButton;
	}
}
