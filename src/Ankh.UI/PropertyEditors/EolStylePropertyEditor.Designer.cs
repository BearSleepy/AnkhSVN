﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Ankh.UI
{
    partial class EolStylePropertyEditor
    {
        #region Component Designer generated code
        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nativeRadioButton = new System.Windows.Forms.RadioButton();
            this.eolLabel = new System.Windows.Forms.Label();
            this.lfRadioButton = new System.Windows.Forms.RadioButton();
            this.crRadioButton = new System.Windows.Forms.RadioButton();
            this.crlfRdioButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // nativeRadioButton
            // 
            this.nativeRadioButton.Checked = true;
            this.nativeRadioButton.Location = new System.Drawing.Point(0, 24);
            this.nativeRadioButton.Name = "nativeRadioButton";
            this.nativeRadioButton.TabIndex = 1;
            this.nativeRadioButton.TabStop = true;
            this.nativeRadioButton.Tag = "";
            this.nativeRadioButton.Text = "native";
            this.nativeRadioButton.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // eolLabel
            // 
            this.eolLabel.Name = "eolLabel";
            this.eolLabel.TabIndex = 2;
            this.eolLabel.Text = "Select eol-style:";
            // 
            // lfRadioButton
            // 
            this.lfRadioButton.Location = new System.Drawing.Point(0, 48);
            this.lfRadioButton.Name = "lfRadioButton";
            this.lfRadioButton.TabIndex = 3;
            this.lfRadioButton.Text = "LF";
            this.lfRadioButton.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // crRadioButton
            // 
            this.crRadioButton.Location = new System.Drawing.Point(0, 72);
            this.crRadioButton.Name = "crRadioButton";
            this.crRadioButton.TabIndex = 4;
            this.crRadioButton.Text = "CR";
            this.crRadioButton.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // crlfRdioButton
            // 
            this.crlfRdioButton.Location = new System.Drawing.Point(0, 96);
            this.crlfRdioButton.Name = "crlfRdioButton";
            this.crlfRdioButton.TabIndex = 5;
            this.crlfRdioButton.Text = "CRLF";
            this.crlfRdioButton.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // EolStylePropertyEditor
            // 
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                          this.crlfRdioButton,
                                                                          this.crRadioButton,
                                                                          this.lfRadioButton,
                                                                          this.eolLabel,
                                                                          this.nativeRadioButton});
            this.Name = "EolStylePropertyEditor";
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.RadioButton nativeRadioButton;
        private System.Windows.Forms.Label eolLabel;
        private System.Windows.Forms.RadioButton lfRadioButton;
        private System.Windows.Forms.RadioButton crRadioButton;
        private System.Windows.Forms.RadioButton crlfRdioButton;
    }
}
