namespace Nba.UserControls
{
    partial class VisitorsMenuUserControl
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.butPhotos = new System.Windows.Forms.Button();
            this.butMachups = new System.Windows.Forms.Button();
            this.butPlayers = new System.Windows.Forms.Button();
            this.butTeams = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.butPhotos);
            this.panel1.Controls.Add(this.butMachups);
            this.panel1.Controls.Add(this.butPlayers);
            this.panel1.Controls.Add(this.butTeams);
            this.panel1.Location = new System.Drawing.Point(53, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(562, 306);
            this.panel1.TabIndex = 4;
            // 
            // butPhotos
            // 
            this.butPhotos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butPhotos.BackColor = System.Drawing.Color.SteelBlue;
            this.butPhotos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butPhotos.ForeColor = System.Drawing.Color.White;
            this.butPhotos.Location = new System.Drawing.Point(324, 183);
            this.butPhotos.Name = "butPhotos";
            this.butPhotos.Size = new System.Drawing.Size(190, 59);
            this.butPhotos.TabIndex = 3;
            this.butPhotos.Text = "Photos";
            this.butPhotos.UseVisualStyleBackColor = false;
            this.butPhotos.Click += new System.EventHandler(this.butPhotos_Click);
            // 
            // butMachups
            // 
            this.butMachups.BackColor = System.Drawing.Color.SteelBlue;
            this.butMachups.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butMachups.ForeColor = System.Drawing.Color.White;
            this.butMachups.Location = new System.Drawing.Point(36, 183);
            this.butMachups.Name = "butMachups";
            this.butMachups.Size = new System.Drawing.Size(190, 59);
            this.butMachups.TabIndex = 2;
            this.butMachups.Text = "Matchups";
            this.butMachups.UseVisualStyleBackColor = false;
            this.butMachups.Click += new System.EventHandler(this.butMachups_Click);
            // 
            // butPlayers
            // 
            this.butPlayers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butPlayers.BackColor = System.Drawing.Color.SteelBlue;
            this.butPlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butPlayers.ForeColor = System.Drawing.Color.White;
            this.butPlayers.Location = new System.Drawing.Point(324, 65);
            this.butPlayers.Name = "butPlayers";
            this.butPlayers.Size = new System.Drawing.Size(190, 59);
            this.butPlayers.TabIndex = 1;
            this.butPlayers.Text = "Players";
            this.butPlayers.UseVisualStyleBackColor = false;
            this.butPlayers.Click += new System.EventHandler(this.butPlayers_Click);
            // 
            // butTeams
            // 
            this.butTeams.BackColor = System.Drawing.Color.SteelBlue;
            this.butTeams.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butTeams.ForeColor = System.Drawing.Color.White;
            this.butTeams.Location = new System.Drawing.Point(36, 65);
            this.butTeams.Name = "butTeams";
            this.butTeams.Size = new System.Drawing.Size(190, 59);
            this.butTeams.TabIndex = 0;
            this.butTeams.Text = "Teams";
            this.butTeams.UseVisualStyleBackColor = false;
            this.butTeams.Click += new System.EventHandler(this.butTeams_Click);
            // 
            // VisitorsMenuUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "VisitorsMenuUserControl";
            this.Size = new System.Drawing.Size(650, 400);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button butPhotos;
        private System.Windows.Forms.Button butMachups;
        private System.Windows.Forms.Button butPlayers;
        private System.Windows.Forms.Button butTeams;
    }
}
