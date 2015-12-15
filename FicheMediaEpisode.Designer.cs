namespace Main_project_VERON_MERLIN
{
    partial class FicheMediaEpisode
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panneau = new System.Windows.Forms.FlowLayoutPanel();
            this.audio = new System.Windows.Forms.Button();
            this.video = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panneau, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.audio, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.video, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(447, 261);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panneau
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panneau, 2);
            this.panneau.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panneau.Location = new System.Drawing.Point(3, 3);
            this.panneau.Name = "panneau";
            this.panneau.Size = new System.Drawing.Size(441, 225);
            this.panneau.TabIndex = 0;
            // 
            // audio
            // 
            this.audio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.audio.Location = new System.Drawing.Point(3, 234);
            this.audio.Name = "audio";
            this.audio.Size = new System.Drawing.Size(217, 24);
            this.audio.TabIndex = 1;
            this.audio.Text = "Audios";
            this.audio.UseVisualStyleBackColor = true;
            // 
            // video
            // 
            this.video.Dock = System.Windows.Forms.DockStyle.Fill;
            this.video.Location = new System.Drawing.Point(226, 234);
            this.video.Name = "video";
            this.video.Size = new System.Drawing.Size(218, 24);
            this.video.TabIndex = 2;
            this.video.Text = "Vidéos";
            this.video.UseVisualStyleBackColor = true;
            // 
            // FicheMediaEpisode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 261);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FicheMediaEpisode";
            this.Text = "FicheMediaEpisode";
            this.Load += new System.EventHandler(this.FicheMediaEpisode_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel panneau;
        private System.Windows.Forms.Button audio;
        private System.Windows.Forms.Button video;
    }
}