namespace Main_project_VERON_MERLIN
{
    partial class AccueilUser
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.déconnexionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUneSérieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUneSaisonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUnEpisodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUnMédiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.administrationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.déconnexionToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // déconnexionToolStripMenuItem
            // 
            this.déconnexionToolStripMenuItem.Name = "déconnexionToolStripMenuItem";
            this.déconnexionToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.déconnexionToolStripMenuItem.Text = "Déconnexion";
            this.déconnexionToolStripMenuItem.Click += new System.EventHandler(this.déconnexionToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // administrationToolStripMenuItem
            // 
            this.administrationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterUneSérieToolStripMenuItem,
            this.ajouterUneSaisonToolStripMenuItem,
            this.ajouterUnEpisodeToolStripMenuItem,
            this.ajouterUnMédiaToolStripMenuItem});
            this.administrationToolStripMenuItem.Name = "administrationToolStripMenuItem";
            this.administrationToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.administrationToolStripMenuItem.Text = "Administration";
            this.administrationToolStripMenuItem.Visible = false;
            // 
            // ajouterUneSérieToolStripMenuItem
            // 
            this.ajouterUneSérieToolStripMenuItem.Name = "ajouterUneSérieToolStripMenuItem";
            this.ajouterUneSérieToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.ajouterUneSérieToolStripMenuItem.Text = "Ajouter une série";
            this.ajouterUneSérieToolStripMenuItem.Click += new System.EventHandler(this.ajouterUneSérieToolStripMenuItem_Click);
            // 
            // ajouterUneSaisonToolStripMenuItem
            // 
            this.ajouterUneSaisonToolStripMenuItem.Name = "ajouterUneSaisonToolStripMenuItem";
            this.ajouterUneSaisonToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.ajouterUneSaisonToolStripMenuItem.Text = "Ajouter une saison";
            // 
            // ajouterUnEpisodeToolStripMenuItem
            // 
            this.ajouterUnEpisodeToolStripMenuItem.Name = "ajouterUnEpisodeToolStripMenuItem";
            this.ajouterUnEpisodeToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.ajouterUnEpisodeToolStripMenuItem.Text = "Ajouter un épisode";
            // 
            // ajouterUnMédiaToolStripMenuItem
            // 
            this.ajouterUnMédiaToolStripMenuItem.Name = "ajouterUnMédiaToolStripMenuItem";
            this.ajouterUnMédiaToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.ajouterUnMédiaToolStripMenuItem.Text = "Ajouter un média";
            // 
            // AccueilUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AccueilUser";
            this.Text = "Accueil";
            this.Load += new System.EventHandler(this.AcceuilUser_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem déconnexionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUneSérieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUneSaisonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUnEpisodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUnMédiaToolStripMenuItem;
    }
}