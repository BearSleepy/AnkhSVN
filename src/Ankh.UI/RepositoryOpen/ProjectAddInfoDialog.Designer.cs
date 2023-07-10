namespace Ankh.UI.RepositoryOpen
{
	partial class ProjectAddInfoDialog
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
			this.projectLabel = new System.Windows.Forms.Label();
			this.externalRadio = new System.Windows.Forms.RadioButton();
			this.label1 = new System.Windows.Forms.Label();
			this.externalPropLocations = new System.Windows.Forms.ComboBox();
			this.externalBlock = new System.Windows.Forms.Panel();
			this.lockExternal = new System.Windows.Forms.CheckBox();
			this.externalDefInfo = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.copyRadio = new System.Windows.Forms.RadioButton();
			this.copyBlock = new System.Windows.Forms.Panel();
			this.copyDefInfo = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.slnRadio = new System.Windows.Forms.RadioButton();
			this.slnBlock = new System.Windows.Forms.Panel();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.unconnectedBlock = new System.Windows.Forms.Panel();
			this.label8 = new System.Windows.Forms.Label();
			this.unconnectedRadio = new System.Windows.Forms.RadioButton();
			this.okButton = new System.Windows.Forms.Button();
			this.cancelButton = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.notVersionedRadio = new System.Windows.Forms.RadioButton();
			this.externalBlock.SuspendLayout();
			this.copyBlock.SuspendLayout();
			this.slnBlock.SuspendLayout();
			this.unconnectedBlock.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			//
			// projectLabel
			//
			this.projectLabel.AutoSize = true;
			this.projectLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.projectLabel.Location = new System.Drawing.Point(12, 9);
			this.projectLabel.Name = "projectLabel";
			this.projectLabel.Size = new System.Drawing.Size(217, 13);
			this.projectLabel.TabIndex = 0;
			this.projectLabel.Text = "How would you like to connect your project?";
			//
			// externalRadio
			//
			this.externalRadio.AutoSize = true;
			this.externalRadio.Checked = true;
			this.externalRadio.Location = new System.Drawing.Point(29, 34);
			this.externalRadio.Name = "externalRadio";
			this.externalRadio.Size = new System.Drawing.Size(110, 17);
			this.externalRadio.TabIndex = 1;
			this.externalRadio.TabStop = true;
			this.externalRadio.Text = "&External Definition";
			this.externalRadio.UseVisualStyleBackColor = true;
			//
			// label1
			//
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(180, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Register an svn:external &property on:";
			//
			// externalPropLocations
			//
			this.externalPropLocations.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.externalPropLocations.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.externalPropLocations.FormattingEnabled = true;
			this.externalPropLocations.Location = new System.Drawing.Point(6, 16);
			this.externalPropLocations.Name = "externalPropLocations";
			this.externalPropLocations.Size = new System.Drawing.Size(470, 21);
			this.externalPropLocations.TabIndex = 1;
			//
			// externalBlock
			//
			this.externalBlock.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.externalBlock.Controls.Add(this.lockExternal);
			this.externalBlock.Controls.Add(this.externalDefInfo);
			this.externalBlock.Controls.Add(this.label2);
			this.externalBlock.Controls.Add(this.label1);
			this.externalBlock.Controls.Add(this.externalPropLocations);
			this.externalBlock.Location = new System.Drawing.Point(46, 57);
			this.externalBlock.Name = "externalBlock";
			this.externalBlock.Size = new System.Drawing.Size(479, 101);
			this.externalBlock.TabIndex = 2;
			//
			// lockExternal
			//
			this.lockExternal.AutoSize = true;
			this.lockExternal.Location = new System.Drawing.Point(6, 43);
			this.lockExternal.Name = "lockExternal";
			this.lockExternal.Size = new System.Drawing.Size(207, 17);
			this.lockExternal.TabIndex = 2;
			this.lockExternal.Text = "&Lock this exact version in the external.";
			this.lockExternal.UseVisualStyleBackColor = true;
			this.lockExternal.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			//
			// externalDefInfo
			//
			this.externalDefInfo.AutoSize = true;
			this.externalDefInfo.Location = new System.Drawing.Point(3, 80);
			this.externalDefInfo.Name = "externalDefInfo";
			this.externalDefInfo.Size = new System.Drawing.Size(261, 13);
			this.externalDefInfo.TabIndex = 4;
			this.externalDefInfo.Text = "(Only available when checked out in the Project Tree)";
			this.externalDefInfo.Visible = false;
			//
			// label2
			//
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 65);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(367, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "References project in original location. Compatible with all Subversion Clients";
			//
			// copyRadio
			//
			this.copyRadio.AutoSize = true;
			this.copyRadio.Location = new System.Drawing.Point(29, 164);
			this.copyRadio.Name = "copyRadio";
			this.copyRadio.Size = new System.Drawing.Size(85, 17);
			this.copyRadio.TabIndex = 3;
			this.copyRadio.Text = "&Copy Project";
			this.copyRadio.UseVisualStyleBackColor = true;
			//
			// copyBlock
			//
			this.copyBlock.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.copyBlock.Controls.Add(this.copyDefInfo);
			this.copyBlock.Controls.Add(this.label6);
			this.copyBlock.Location = new System.Drawing.Point(43, 187);
			this.copyBlock.Name = "copyBlock";
			this.copyBlock.Size = new System.Drawing.Size(482, 42);
			this.copyBlock.TabIndex = 4;
			//
			// copyDefInfo
			//
			this.copyDefInfo.AutoSize = true;
			this.copyDefInfo.Location = new System.Drawing.Point(3, 15);
			this.copyDefInfo.Name = "copyDefInfo";
			this.copyDefInfo.Size = new System.Drawing.Size(261, 13);
			this.copyDefInfo.TabIndex = 5;
			this.copyDefInfo.Text = "(Only available when checked out in the Project Tree)";
			this.copyDefInfo.Visible = false;
			//
			// label6
			//
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(3, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(245, 13);
			this.label6.TabIndex = 0;
			this.label6.Text = "Create a copy of the project in the current solution.";
			//
			// slnRadio
			//
			this.slnRadio.AutoSize = true;
			this.slnRadio.Location = new System.Drawing.Point(29, 235);
			this.slnRadio.Name = "slnRadio";
			this.slnRadio.Size = new System.Drawing.Size(142, 17);
			this.slnRadio.TabIndex = 5;
			this.slnRadio.Text = "Connect via &Solution File";
			this.slnRadio.UseVisualStyleBackColor = true;
			//
			// slnBlock
			//
			this.slnBlock.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.slnBlock.Controls.Add(this.label5);
			this.slnBlock.Controls.Add(this.label4);
			this.slnBlock.Location = new System.Drawing.Point(43, 258);
			this.slnBlock.Name = "slnBlock";
			this.slnBlock.Size = new System.Drawing.Size(482, 45);
			this.slnBlock.TabIndex = 6;
			//
			// label5
			//
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(3, 21);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(159, 13);
			this.label5.TabIndex = 1;
			this.label5.Text = "Requires AnkhSVN 2.4+ clients.";
			//
			// label4
			//
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(3, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(463, 13);
			this.label4.TabIndex = 0;
			this.label4.Text = "Store information on how to check out the project in the solution file to allow a" +
	"utomatic checkout.";
			//
			// unconnectedBlock
			//
			this.unconnectedBlock.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.unconnectedBlock.Controls.Add(this.label8);
			this.unconnectedBlock.Location = new System.Drawing.Point(43, 332);
			this.unconnectedBlock.Name = "unconnectedBlock";
			this.unconnectedBlock.Size = new System.Drawing.Size(482, 23);
			this.unconnectedBlock.TabIndex = 8;
			//
			// label8
			//
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(3, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(323, 13);
			this.label8.TabIndex = 0;
			this.label8.Text = "Don\'t connect the project, just use it from the current working copy.";
			//
			// unconnectedRadio
			//
			this.unconnectedRadio.AutoSize = true;
			this.unconnectedRadio.Location = new System.Drawing.Point(29, 309);
			this.unconnectedRadio.Name = "unconnectedRadio";
			this.unconnectedRadio.Size = new System.Drawing.Size(96, 17);
			this.unconnectedRadio.TabIndex = 7;
			this.unconnectedRadio.Text = "&No Connection";
			this.unconnectedRadio.UseVisualStyleBackColor = true;
			//
			// okButton
			//
			this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.okButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.okButton.Location = new System.Drawing.Point(369, 421);
			this.okButton.Name = "okButton";
			this.okButton.Size = new System.Drawing.Size(75, 23);
			this.okButton.TabIndex = 11;
			this.okButton.Text = "OK";
			this.okButton.UseVisualStyleBackColor = true;
			//
			// cancelButton
			//
			this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cancelButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.cancelButton.Location = new System.Drawing.Point(450, 421);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(75, 23);
			this.cancelButton.TabIndex = 12;
			this.cancelButton.Text = "Cancel";
			this.cancelButton.UseVisualStyleBackColor = true;
			//
			// panel1
			//
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.Controls.Add(this.label3);
			this.panel1.Location = new System.Drawing.Point(43, 381);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(482, 23);
			this.panel1.TabIndex = 10;
			//
			// label3
			//
			this.label3.AutoSize = true;
			this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.label3.Location = new System.Drawing.Point(3, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(345, 13);
			this.label3.TabIndex = 0;
			this.label3.Text = "Don\'t use a Subversion working Copy. Allows committing as new project";
			//
			// notVersionedRadio
			//
			this.notVersionedRadio.AutoSize = true;
			this.notVersionedRadio.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.notVersionedRadio.Location = new System.Drawing.Point(29, 358);
			this.notVersionedRadio.Name = "notVersionedRadio";
			this.notVersionedRadio.Size = new System.Drawing.Size(85, 17);
			this.notVersionedRadio.TabIndex = 9;
			this.notVersionedRadio.Text = "&Unversioned";
			this.notVersionedRadio.UseVisualStyleBackColor = true;
			//
			// ProjectAddInfoDialog
			//
			this.AcceptButton = this.okButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.CancelButton = this.cancelButton;
			this.ClientSize = new System.Drawing.Size(537, 456);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.notVersionedRadio);
			this.Controls.Add(this.okButton);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.unconnectedBlock);
			this.Controls.Add(this.unconnectedRadio);
			this.Controls.Add(this.slnBlock);
			this.Controls.Add(this.slnRadio);
			this.Controls.Add(this.copyBlock);
			this.Controls.Add(this.copyRadio);
			this.Controls.Add(this.externalBlock);
			this.Controls.Add(this.externalRadio);
			this.Controls.Add(this.projectLabel);
			this.Name = "ProjectAddInfoDialog";
			this.Text = "Project Registration";
			this.externalBlock.ResumeLayout(false);
			this.externalBlock.PerformLayout();
			this.copyBlock.ResumeLayout(false);
			this.copyBlock.PerformLayout();
			this.slnBlock.ResumeLayout(false);
			this.slnBlock.PerformLayout();
			this.unconnectedBlock.ResumeLayout(false);
			this.unconnectedBlock.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label projectLabel;
		private System.Windows.Forms.RadioButton externalRadio;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox externalPropLocations;
		private System.Windows.Forms.Panel externalBlock;
		private System.Windows.Forms.CheckBox lockExternal;
		private System.Windows.Forms.Label externalDefInfo;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.RadioButton copyRadio;
		private System.Windows.Forms.Panel copyBlock;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.RadioButton slnRadio;
		private System.Windows.Forms.Panel slnBlock;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Panel unconnectedBlock;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.RadioButton unconnectedRadio;
		private System.Windows.Forms.Button okButton;
		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.Label copyDefInfo;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.RadioButton notVersionedRadio;
	}
}