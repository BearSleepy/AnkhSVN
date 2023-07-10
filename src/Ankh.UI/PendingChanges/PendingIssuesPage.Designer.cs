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
	partial class PendingIssuesPage
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
			this.pleaseConfigureLabel = new System.Windows.Forms.LinkLabel();
			this.SuspendLayout();
			//
			// pleaseConfigureLabel
			//
			this.pleaseConfigureLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pleaseConfigureLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pleaseConfigureLabel.Location = new System.Drawing.Point(0, 0);
			this.pleaseConfigureLabel.Name = "pleaseConfigureLabel";
			this.pleaseConfigureLabel.Size = new System.Drawing.Size(768, 300);
			this.pleaseConfigureLabel.TabIndex = 0;
			this.pleaseConfigureLabel.TabStop = true;
			this.pleaseConfigureLabel.Text = "This solution is not associated with an Issue Repository.\n\nConfigure an associati" +
	"on on the Solution node in the Solution explorer\nor click here for more informat" +
	"ion.";
			this.pleaseConfigureLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.pleaseConfigureLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.pleaseConfigureLabel_LinkClicked);
			//
			// PendingIssuesPage
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.pleaseConfigureLabel);
			this.Name = "PendingIssuesPage";
			this.Text = "Issues";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.LinkLabel pleaseConfigureLabel;


	}
}
