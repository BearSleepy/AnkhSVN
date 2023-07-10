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
	partial class RecentChangesPage
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
			this.syncView = new Ankh.UI.PendingChanges.Synchronize.SynchronizeListView();
			this.topLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.updateTime = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.refreshCombo = new System.Windows.Forms.ComboBox();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.splitContainer1 = new Ankh.UI.VSSelectionControls.SmartSplitContainer(this.components);
			this.borderPanel = new System.Windows.Forms.Panel();
			this.topLayoutPanel.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.borderPanel.SuspendLayout();
			this.SuspendLayout();
			//
			// syncView
			//
			this.syncView.Context = null;
			this.syncView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.syncView.HideSelection = false;
			this.syncView.Location = new System.Drawing.Point(0, 0);
			this.syncView.Margin = new System.Windows.Forms.Padding(0);
			this.syncView.Name = "syncView";
			this.syncView.Size = new System.Drawing.Size(768, 274);
			this.syncView.TabIndex = 0;
			//
			// topLayoutPanel
			//
			this.topLayoutPanel.ColumnCount = 5;
			this.topLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 77F));
			this.topLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.topLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
			this.topLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.topLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
			this.topLayoutPanel.Controls.Add(this.updateTime, 2, 0);
			this.topLayoutPanel.Controls.Add(this.label1, 0, 0);
			this.topLayoutPanel.Controls.Add(this.panel2, 4, 0);
			this.topLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.topLayoutPanel.Location = new System.Drawing.Point(0, 0);
			this.topLayoutPanel.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
			this.topLayoutPanel.Name = "topLayoutPanel";
			this.topLayoutPanel.RowCount = 1;
			this.topLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
			this.topLayoutPanel.Size = new System.Drawing.Size(766, 23);
			this.topLayoutPanel.TabIndex = 1;
			//
			// updateTime
			//
			this.updateTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.updateTime.Enabled = false;
			this.updateTime.Location = new System.Drawing.Point(234, 3);
			this.updateTime.Name = "updateTime";
			this.updateTime.ReadOnly = true;
			this.updateTime.Size = new System.Drawing.Size(74, 13);
			this.updateTime.TabIndex = 6;
			this.updateTime.Visible = false;
			//
			// label1
			//
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(2, 2);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 2, 3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(52, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Changes:";
			//
			// panel2
			//
			this.panel2.Controls.Add(this.refreshCombo);
			this.panel2.Controls.Add(this.checkBox1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(566, 1);
			this.panel2.Margin = new System.Windows.Forms.Padding(1);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(199, 21);
			this.panel2.TabIndex = 7;
			//
			// refreshCombo
			//
			this.refreshCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.refreshCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.refreshCombo.FormattingEnabled = true;
			this.refreshCombo.Items.AddRange(new object[] {
			"1 min",
			"5 min",
			"10 min",
			"15 min",
			"30 min",
			"1 hr",
			"2 hr"});
			this.refreshCombo.Location = new System.Drawing.Point(89, -1);
			this.refreshCombo.Name = "refreshCombo";
			this.refreshCombo.Size = new System.Drawing.Size(110, 21);
			this.refreshCombo.TabIndex = 1;
			//
			// checkBox1
			//
			this.checkBox1.Location = new System.Drawing.Point(0, 1);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(93, 17);
			this.checkBox1.TabIndex = 0;
			this.checkBox1.Text = "&Refresh every";
			this.checkBox1.UseVisualStyleBackColor = true;
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
			this.splitContainer1.Panel2.Controls.Add(this.syncView);
			this.splitContainer1.Size = new System.Drawing.Size(768, 300);
			this.splitContainer1.SplitterDistance = 25;
			this.splitContainer1.SplitterWidth = 1;
			this.splitContainer1.TabIndex = 2;
			//
			// borderPanel
			//
			this.borderPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.borderPanel.Controls.Add(this.topLayoutPanel);
			this.borderPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.borderPanel.Location = new System.Drawing.Point(0, 0);
			this.borderPanel.Margin = new System.Windows.Forms.Padding(0);
			this.borderPanel.Name = "borderPanel";
			this.borderPanel.Size = new System.Drawing.Size(768, 25);
			this.borderPanel.TabIndex = 2;
			//
			// RecentChangesPage
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.splitContainer1);
			this.Name = "RecentChangesPage";
			this.Text = "Recent Changes";
			this.topLayoutPanel.ResumeLayout(false);
			this.topLayoutPanel.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.borderPanel.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private Ankh.UI.PendingChanges.Synchronize.SynchronizeListView syncView;
		private System.Windows.Forms.TableLayoutPanel topLayoutPanel;
		private System.Windows.Forms.Label label1;
		private Ankh.UI.VSSelectionControls.SmartSplitContainer splitContainer1;
		private System.Windows.Forms.Panel borderPanel;
		private System.Windows.Forms.TextBox updateTime;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.ComboBox refreshCombo;
		private System.Windows.Forms.CheckBox checkBox1;

	}
}
