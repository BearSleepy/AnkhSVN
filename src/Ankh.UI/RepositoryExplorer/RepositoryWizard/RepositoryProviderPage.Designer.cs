namespace Ankh.UI.RepositoryExplorer.RepositoryWizard
{
	partial class RepositoryProviderPage
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
			this.providerPanel = new System.Windows.Forms.TableLayoutPanel();
			this.urlRadioButton = new System.Windows.Forms.RadioButton();
			this.urlComboBox = new System.Windows.Forms.ComboBox();
			this.providerRadioButton = new System.Windows.Forms.RadioButton();
			this.wikiLinkLabel = new System.Windows.Forms.LinkLabel();
			this.providerListView = new Ankh.UI.VSSelectionControls.SmartListView();
			this.wikiLinkLabel1 = new System.Windows.Forms.LinkLabel();
			this.nameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.providerPanel.SuspendLayout();
			this.SuspendLayout();
			//
			// providerPanel
			//
			this.providerPanel.ColumnCount = 2;
			this.providerPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.providerPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.providerPanel.Controls.Add(this.urlRadioButton, 0, 0);
			this.providerPanel.Controls.Add(this.urlComboBox, 0, 1);
			this.providerPanel.Controls.Add(this.providerRadioButton, 0, 3);
			this.providerPanel.Controls.Add(this.wikiLinkLabel, 0, 2);
			this.providerPanel.Controls.Add(this.providerListView, 0, 4);
			this.providerPanel.Controls.Add(this.wikiLinkLabel1, 0, 5);
			this.providerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.providerPanel.Location = new System.Drawing.Point(10, 10);
			this.providerPanel.Name = "providerPanel";
			this.providerPanel.RowCount = 6;
			this.providerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.providerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.providerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.providerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.providerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.providerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.providerPanel.Size = new System.Drawing.Size(450, 330);
			this.providerPanel.TabIndex = 0;
			//
			// urlRadioButton
			//
			this.urlRadioButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.urlRadioButton.AutoSize = true;
			this.urlRadioButton.Checked = true;
			this.providerPanel.SetColumnSpan(this.urlRadioButton, 2);
			this.urlRadioButton.Location = new System.Drawing.Point(3, 3);
			this.urlRadioButton.Name = "urlRadioButton";
			this.urlRadioButton.Size = new System.Drawing.Size(47, 17);
			this.urlRadioButton.TabIndex = 0;
			this.urlRadioButton.TabStop = true;
			this.urlRadioButton.Text = "URL";
			this.urlRadioButton.UseVisualStyleBackColor = true;
			this.urlRadioButton.CheckedChanged += new System.EventHandler(this.urlRadioButton_CheckedChanged);
			//
			// urlComboBox
			//
			this.urlComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.urlComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.urlComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllUrl;
			this.providerPanel.SetColumnSpan(this.urlComboBox, 2);
			this.urlComboBox.FormattingEnabled = true;
			this.urlComboBox.Location = new System.Drawing.Point(3, 26);
			this.urlComboBox.Name = "urlComboBox";
			this.urlComboBox.Size = new System.Drawing.Size(444, 21);
			this.urlComboBox.TabIndex = 1;
			this.urlComboBox.TextChanged += new System.EventHandler(this.urlComboBox_TextChanged);
			//
			// providerRadioButton
			//
			this.providerRadioButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.providerRadioButton.AutoSize = true;
			this.providerRadioButton.Location = new System.Drawing.Point(3, 121);
			this.providerRadioButton.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
			this.providerRadioButton.Name = "providerRadioButton";
			this.providerRadioButton.Size = new System.Drawing.Size(116, 17);
			this.providerRadioButton.TabIndex = 2;
			this.providerRadioButton.TabStop = true;
			this.providerRadioButton.Text = "Repository provider";
			this.providerRadioButton.UseVisualStyleBackColor = true;
			this.providerRadioButton.CheckedChanged += new System.EventHandler(this.providerRadioButton_CheckedChanged);
			//
			// wikiLinkLabel
			//
			this.wikiLinkLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.wikiLinkLabel.AutoSize = true;
			this.providerPanel.SetColumnSpan(this.wikiLinkLabel, 2);
			this.wikiLinkLabel.LinkArea = new System.Windows.Forms.LinkArea(144, 194);
			this.wikiLinkLabel.Location = new System.Drawing.Point(3, 53);
			this.wikiLinkLabel.Margin = new System.Windows.Forms.Padding(3);
			this.wikiLinkLabel.Name = "wikiLinkLabel";
			this.wikiLinkLabel.Size = new System.Drawing.Size(421, 55);
			this.wikiLinkLabel.TabIndex = 3;
			this.wikiLinkLabel.TabStop = true;
			this.wikiLinkLabel.Text = "Tired of typing in long URL\'s?  Your repository provider might provide a plug-in " +
	"that would allow you to select your repository from a list.\r\n\r\nClick here to see" +
	" the list of available providers.";
			this.wikiLinkLabel.UseCompatibleTextRendering = true;
			this.wikiLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.wikiLinkLabel_LinkClicked);
			//
			// providerListView
			//
			this.providerPanel.SetColumnSpan(this.providerListView, 2);
			this.providerListView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.providerListView.GridLines = true;
			this.providerListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
			this.providerListView.HideSelection = false;
			this.providerListView.Location = new System.Drawing.Point(3, 144);
			this.providerListView.MultiSelect = false;
			this.providerListView.Name = "providerListView";
			this.providerListView.Size = new System.Drawing.Size(444, 164);
			this.providerListView.TabIndex = 4;
			this.providerListView.SelectedIndexChanged += new System.EventHandler(this.providerListView_SelectedIndexChanged);
			//
			// wikiLinkLabel1
			//
			this.wikiLinkLabel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.wikiLinkLabel1.AutoSize = true;
			this.providerPanel.SetColumnSpan(this.wikiLinkLabel1, 2);
			this.wikiLinkLabel1.Location = new System.Drawing.Point(3, 314);
			this.wikiLinkLabel1.Margin = new System.Windows.Forms.Padding(3);
			this.wikiLinkLabel1.Name = "wikiLinkLabel1";
			this.wikiLinkLabel1.Size = new System.Drawing.Size(225, 13);
			this.wikiLinkLabel1.TabIndex = 5;
			this.wikiLinkLabel1.TabStop = true;
			this.wikiLinkLabel1.Text = "Click here to see the list of available providers.";
			this.wikiLinkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.wikiLinkLabel1.Visible = false;
			this.wikiLinkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.wikiLinkLabel_LinkClicked);
			//
			// nameColumn
			//
			this.nameColumn.Text = "Name";
			//
			// RepositoryProviderPage
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.providerPanel);
			this.Name = "RepositoryProviderPage";
			this.Padding = new System.Windows.Forms.Padding(10);
			this.Size = new System.Drawing.Size(470, 350);
			this.providerPanel.ResumeLayout(false);
			this.providerPanel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel providerPanel;
		private System.Windows.Forms.RadioButton urlRadioButton;
		private System.Windows.Forms.ComboBox urlComboBox;
		private System.Windows.Forms.RadioButton providerRadioButton;
		private System.Windows.Forms.LinkLabel wikiLinkLabel;
		private Ankh.UI.VSSelectionControls.SmartListView providerListView;
		private System.Windows.Forms.ColumnHeader nameColumn;
		private System.Windows.Forms.LinkLabel wikiLinkLabel1;
	}
}
