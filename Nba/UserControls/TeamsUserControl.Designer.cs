﻿namespace Nba.UserControls
{
    partial class TeamsUserControl
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
            this.tabControlConferences = new System.Windows.Forms.TabControl();
            this.SuspendLayout();
            // 
            // tabControlConferences
            // 
            this.tabControlConferences.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlConferences.Location = new System.Drawing.Point(4, 4);
            this.tabControlConferences.Name = "tabControlConferences";
            this.tabControlConferences.SelectedIndex = 0;
            this.tabControlConferences.Size = new System.Drawing.Size(643, 393);
            this.tabControlConferences.TabIndex = 0;
            // 
            // TeamsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControlConferences);
            this.Name = "TeamsUserControl";
            this.Size = new System.Drawing.Size(650, 400);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlConferences;
    }
}
