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

namespace Ankh.UI.PendingChanges
{
	partial class PendingConflictsPage
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
			this.components = new System.ComponentModel.Container();
			this.splitContainer1 = new Ankh.UI.VSSelectionControls.SmartSplitContainer(this.components);
			this.borderPanel = new System.Windows.Forms.Panel();
			this.conflictHeader = new System.Windows.Forms.Label();
			this.conflictEditSplitter = new Ankh.UI.VSSelectionControls.SmartSplitContainer(this.components);
			this.conflictView = new Ankh.UI.PendingChanges.Conflicts.ConflictListView();
			this.resolvePanel = new System.Windows.Forms.FlowLayoutPanel();
			this.resolveButton0 = new System.Windows.Forms.Button();
			this.resolveButton1 = new System.Windows.Forms.Button();
			this.resolveButton2 = new System.Windows.Forms.Button();
			this.resolveButton3 = new System.Windows.Forms.Button();
			this.resolveButton4 = new System.Windows.Forms.Button();
			this.resolveButton5 = new System.Windows.Forms.Button();
			this.resolveButton6 = new System.Windows.Forms.Button();
			this.resolveButton7 = new System.Windows.Forms.Button();
			this.resolveTopLabel = new System.Windows.Forms.Label();
			this.resolveBottomLabel = new System.Windows.Forms.Label();
			this.resolveLinkLabel = new System.Windows.Forms.LinkLabel();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.borderPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.conflictEditSplitter)).BeginInit();
			this.conflictEditSplitter.Panel1.SuspendLayout();
			this.conflictEditSplitter.Panel2.SuspendLayout();
			this.conflictEditSplitter.SuspendLayout();
			this.resolvePanel.SuspendLayout();
			this.SuspendLayout();
			//
			// splitContainer1
			//
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.splitContainer1.IsSplitterFixed = true;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			//
			// splitContainer1.Panel1
			//
			this.splitContainer1.Panel1.Controls.Add(this.borderPanel);
			this.splitContainer1.Panel1MinSize = 23;
			//
			// splitContainer1.Panel2
			//
			this.splitContainer1.Panel2.Controls.Add(this.conflictEditSplitter);
			this.splitContainer1.Size = new System.Drawing.Size(768, 300);
			this.splitContainer1.SplitterDistance = 25;
			this.splitContainer1.SplitterWidth = 1;
			this.splitContainer1.TabIndex = 3;
			//
			// borderPanel
			//
			this.borderPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.borderPanel.Controls.Add(this.conflictHeader);
			this.borderPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.borderPanel.Location = new System.Drawing.Point(0, 0);
			this.borderPanel.Margin = new System.Windows.Forms.Padding(0);
			this.borderPanel.Name = "borderPanel";
			this.borderPanel.Size = new System.Drawing.Size(768, 25);
			this.borderPanel.TabIndex = 2;
			//
			// conflictHeader
			//
			this.conflictHeader.AutoEllipsis = true;
			this.conflictHeader.Dock = System.Windows.Forms.DockStyle.Fill;
			this.conflictHeader.Location = new System.Drawing.Point(0, 0);
			this.conflictHeader.Margin = new System.Windows.Forms.Padding(2, 0, 3, 0);
			this.conflictHeader.Name = "conflictHeader";
			this.conflictHeader.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
			this.conflictHeader.Size = new System.Drawing.Size(766, 23);
			this.conflictHeader.TabIndex = 0;
			this.conflictHeader.Text = "0 Conflicts: 0 Version, 0 Tree Conflicts; 0 Automatic merges.";
			this.conflictHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			// conflictEditSplitter
			//
			this.conflictEditSplitter.Dock = System.Windows.Forms.DockStyle.Fill;
			this.conflictEditSplitter.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
			this.conflictEditSplitter.IsSplitterFixed = true;
			this.conflictEditSplitter.Location = new System.Drawing.Point(0, 0);
			this.conflictEditSplitter.Margin = new System.Windows.Forms.Padding(0);
			this.conflictEditSplitter.Name = "conflictEditSplitter";
			this.conflictEditSplitter.Orientation = System.Windows.Forms.Orientation.Horizontal;
			//
			// conflictEditSplitter.Panel1
			//
			this.conflictEditSplitter.Panel1.Controls.Add(this.conflictView);
			//
			// conflictEditSplitter.Panel2
			//
			this.conflictEditSplitter.Panel2.Controls.Add(this.resolvePanel);
			this.conflictEditSplitter.Panel2MinSize = 32;
			this.conflictEditSplitter.Size = new System.Drawing.Size(768, 274);
			this.conflictEditSplitter.SplitterDistance = 238;
			this.conflictEditSplitter.TabIndex = 0;
			//
			// conflictView
			//
			this.conflictView.Context = null;
			this.conflictView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.conflictView.HideSelection = false;
			this.conflictView.Location = new System.Drawing.Point(0, 0);
			this.conflictView.Margin = new System.Windows.Forms.Padding(0);
			this.conflictView.Name = "conflictView";
			this.conflictView.Size = new System.Drawing.Size(768, 238);
			this.conflictView.TabIndex = 0;
			//
			// resolvePanel
			//
			this.resolvePanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.resolvePanel.BackColor = System.Drawing.Color.SkyBlue;
			this.resolvePanel.Controls.Add(this.resolveButton0);
			this.resolvePanel.Controls.Add(this.resolveButton1);
			this.resolvePanel.Controls.Add(this.resolveButton2);
			this.resolvePanel.Controls.Add(this.resolveButton3);
			this.resolvePanel.Controls.Add(this.resolveButton4);
			this.resolvePanel.Controls.Add(this.resolveButton5);
			this.resolvePanel.Controls.Add(this.resolveButton6);
			this.resolvePanel.Controls.Add(this.resolveButton7);
			this.resolvePanel.Controls.Add(this.resolveTopLabel);
			this.resolvePanel.Controls.Add(this.resolveBottomLabel);
			this.resolvePanel.Controls.Add(this.resolveLinkLabel);
			this.resolvePanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.resolvePanel.Location = new System.Drawing.Point(0, 0);
			this.resolvePanel.Name = "resolvePanel";
			this.resolvePanel.Size = new System.Drawing.Size(768, 34);
			this.resolvePanel.TabIndex = 0;
			//
			// resolveButton0
			//
			this.resolveButton0.AutoSize = true;
			this.resolveButton0.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.resolveButton0.Enabled = false;
			this.resolveButton0.Location = new System.Drawing.Point(3, 1);
			this.resolveButton0.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
			this.resolveButton0.Name = "resolveButton0";
			this.resolveButton0.Size = new System.Drawing.Size(20, 23);
			this.resolveButton0.TabIndex = 0;
			this.resolveButton0.Text = " ";
			this.resolveButton0.UseVisualStyleBackColor = true;
			//
			// resolveButton1
			//
			this.resolveButton1.AutoSize = true;
			this.resolveButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.resolveButton1.Enabled = false;
			this.resolveButton1.Location = new System.Drawing.Point(29, 1);
			this.resolveButton1.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
			this.resolveButton1.Name = "resolveButton1";
			this.resolveButton1.Size = new System.Drawing.Size(20, 23);
			this.resolveButton1.TabIndex = 1;
			this.resolveButton1.Text = " ";
			this.resolveButton1.UseVisualStyleBackColor = true;
			//
			// resolveButton2
			//
			this.resolveButton2.AutoSize = true;
			this.resolveButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.resolveButton2.Enabled = false;
			this.resolveButton2.Location = new System.Drawing.Point(55, 1);
			this.resolveButton2.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
			this.resolveButton2.Name = "resolveButton2";
			this.resolveButton2.Size = new System.Drawing.Size(20, 23);
			this.resolveButton2.TabIndex = 2;
			this.resolveButton2.Text = " ";
			this.resolveButton2.UseVisualStyleBackColor = true;
			//
			// resolveButton3
			//
			this.resolveButton3.AutoSize = true;
			this.resolveButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.resolveButton3.Enabled = false;
			this.resolveButton3.Location = new System.Drawing.Point(81, 1);
			this.resolveButton3.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
			this.resolveButton3.Name = "resolveButton3";
			this.resolveButton3.Size = new System.Drawing.Size(20, 23);
			this.resolveButton3.TabIndex = 3;
			this.resolveButton3.Text = " ";
			this.resolveButton3.UseVisualStyleBackColor = true;
			//
			// resolveButton4
			//
			this.resolveButton4.AutoSize = true;
			this.resolveButton4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.resolveButton4.Enabled = false;
			this.resolveButton4.Location = new System.Drawing.Point(107, 1);
			this.resolveButton4.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
			this.resolveButton4.Name = "resolveButton4";
			this.resolveButton4.Size = new System.Drawing.Size(20, 23);
			this.resolveButton4.TabIndex = 4;
			this.resolveButton4.Text = " ";
			this.resolveButton4.UseVisualStyleBackColor = true;
			//
			// resolveButton5
			//
			this.resolveButton5.AutoSize = true;
			this.resolveButton5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.resolveButton5.Enabled = false;
			this.resolveButton5.Location = new System.Drawing.Point(133, 1);
			this.resolveButton5.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
			this.resolveButton5.Name = "resolveButton5";
			this.resolveButton5.Size = new System.Drawing.Size(20, 23);
			this.resolveButton5.TabIndex = 5;
			this.resolveButton5.Text = " ";
			this.resolveButton5.UseVisualStyleBackColor = true;
			//
			// resolveButton6
			//
			this.resolveButton6.AutoSize = true;
			this.resolveButton6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.resolveButton6.Enabled = false;
			this.resolveButton6.Location = new System.Drawing.Point(159, 1);
			this.resolveButton6.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
			this.resolveButton6.Name = "resolveButton6";
			this.resolveButton6.Size = new System.Drawing.Size(20, 23);
			this.resolveButton6.TabIndex = 6;
			this.resolveButton6.Text = " ";
			this.resolveButton6.UseVisualStyleBackColor = true;
			//
			// resolveButton7
			//
			this.resolveButton7.AutoSize = true;
			this.resolveButton7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.resolveButton7.Enabled = false;
			this.resolvePanel.SetFlowBreak(this.resolveButton7, true);
			this.resolveButton7.Location = new System.Drawing.Point(185, 1);
			this.resolveButton7.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
			this.resolveButton7.Name = "resolveButton7";
			this.resolveButton7.Size = new System.Drawing.Size(20, 23);
			this.resolveButton7.TabIndex = 7;
			this.resolveButton7.Text = " ";
			this.resolveButton7.UseVisualStyleBackColor = true;
			//
			// resolveTopLabel
			//
			this.resolveTopLabel.AutoSize = true;
			this.resolvePanel.SetFlowBreak(this.resolveTopLabel, true);
			this.resolveTopLabel.Location = new System.Drawing.Point(3, 25);
			this.resolveTopLabel.Name = "resolveTopLabel";
			this.resolveTopLabel.Size = new System.Drawing.Size(86, 13);
			this.resolveTopLabel.TabIndex = 8;
			this.resolveTopLabel.Text = "resolveTopLabel";
			this.resolveTopLabel.UseMnemonic = false;
			//
			// resolveBottomLabel
			//
			this.resolveBottomLabel.AutoSize = true;
			this.resolveBottomLabel.Location = new System.Drawing.Point(3, 38);
			this.resolveBottomLabel.Name = "resolveBottomLabel";
			this.resolveBottomLabel.Size = new System.Drawing.Size(35, 13);
			this.resolveBottomLabel.TabIndex = 9;
			this.resolveBottomLabel.Text = "label3";
			//
			// resolveLinkLabel
			//
			this.resolveLinkLabel.AutoSize = true;
			this.resolveLinkLabel.Location = new System.Drawing.Point(44, 38);
			this.resolveLinkLabel.Name = "resolveLinkLabel";
			this.resolveLinkLabel.Size = new System.Drawing.Size(0, 13);
			this.resolveLinkLabel.TabIndex = 10;
			//
			// PendingConflictsPage
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.splitContainer1);
			this.Name = "PendingConflictsPage";
			this.Text = "Conflicts and Merges";
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.borderPanel.ResumeLayout(false);
			this.conflictEditSplitter.Panel1.ResumeLayout(false);
			this.conflictEditSplitter.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.conflictEditSplitter)).EndInit();
			this.conflictEditSplitter.ResumeLayout(false);
			this.resolvePanel.ResumeLayout(false);
			this.resolvePanel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private Ankh.UI.VSSelectionControls.SmartSplitContainer splitContainer1;
		private System.Windows.Forms.Panel borderPanel;
		private Ankh.UI.VSSelectionControls.SmartSplitContainer conflictEditSplitter;
		private Ankh.UI.PendingChanges.Conflicts.ConflictListView conflictView;
		private System.Windows.Forms.FlowLayoutPanel resolvePanel;
		private System.Windows.Forms.Button resolveButton0;
		private System.Windows.Forms.Button resolveButton1;
		private System.Windows.Forms.Button resolveButton2;
		private System.Windows.Forms.Button resolveButton3;
		private System.Windows.Forms.Button resolveButton4;
		private System.Windows.Forms.Button resolveButton5;
		private System.Windows.Forms.Label resolveTopLabel;
		private System.Windows.Forms.Label resolveBottomLabel;
		private System.Windows.Forms.LinkLabel resolveLinkLabel;
		private System.Windows.Forms.Button resolveButton6;
		private System.Windows.Forms.Button resolveButton7;
		private System.Windows.Forms.Label conflictHeader;



	}
}
