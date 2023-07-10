namespace Ankh.UI.PendingChanges
{
	partial class PendingActivationPage
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
			this.openSccSelectorLink = new System.Windows.Forms.LinkLabel();
			this.SuspendLayout();
			//
			// openSccSelectorLink
			//
			this.openSccSelectorLink.Dock = System.Windows.Forms.DockStyle.Fill;
			this.openSccSelectorLink.Location = new System.Drawing.Point(0, 0);
			this.openSccSelectorLink.Name = "openSccSelectorLink";
			this.openSccSelectorLink.Size = new System.Drawing.Size(764, 296);
			this.openSccSelectorLink.TabIndex = 0;
			this.openSccSelectorLink.TabStop = true;
			this.openSccSelectorLink.Text = "\'AnkhSVN - Subversion Support for Visual Studio\' is not your current Source Contr" +
	"ol plug-in.\n\nClick here to set the current Source Control plug-in.";
			this.openSccSelectorLink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.openSccSelectorLink.Visible = false;
			this.openSccSelectorLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.openSccSelectorLink_LinkClicked);
			//
			// PendingActivationPage
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Controls.Add(this.openSccSelectorLink);
			this.Name = "PendingActivationPage";
			this.Size = new System.Drawing.Size(764, 296);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.LinkLabel openSccSelectorLink;
	}
}
