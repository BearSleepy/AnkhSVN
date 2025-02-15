﻿namespace Ankh.Scc.SccUI
{
	partial class EditReadOnlyFileDialog
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
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.cancelButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			//
			// pictureBox1
			//
			this.pictureBox1.Location = new System.Drawing.Point(15, 26);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(32, 32);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			//
			// label1
			//
			this.label1.Location = new System.Drawing.Point(70, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(573, 59);
			this.label1.TabIndex = 1;
			this.label1.Text = "The file {0}, which you attempted to edit, is read-only on disk. Would you like t" +
	"o make the file writeable or edit it anyway?";
			//
			// button1
			//
			this.button1.DialogResult = System.Windows.Forms.DialogResult.No;
			this.button1.Location = new System.Drawing.Point(99, 101);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(128, 23);
			this.button1.TabIndex = 2;
			this.button1.Text = "&Edit In-Memory";
			this.button1.UseVisualStyleBackColor = true;
			//
			// button2
			//
			this.button2.DialogResult = System.Windows.Forms.DialogResult.Yes;
			this.button2.Location = new System.Drawing.Point(242, 101);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(131, 23);
			this.button2.TabIndex = 3;
			this.button2.Text = "&Make Writeable";
			this.button2.UseVisualStyleBackColor = true;
			//
			// cancelButton
			//
			this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cancelButton.Location = new System.Drawing.Point(388, 101);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(91, 23);
			this.cancelButton.TabIndex = 4;
			this.cancelButton.Text = "Cancel";
			this.cancelButton.UseVisualStyleBackColor = true;
			//
			// EditReadOnlyFileDialog
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.CancelButton = this.cancelButton;
			this.ClientSize = new System.Drawing.Size(655, 136);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.Name = "EditReadOnlyFileDialog";
			this.Text = "Edit of Read-Only File";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button cancelButton;
	}
}