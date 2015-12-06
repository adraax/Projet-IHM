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
            this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUneSérieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUneSaisonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUnEpisodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUnMédiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierUneSérieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierUnÉpisodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierUnMédiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerUneSérieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerUneSaisonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerUnÉpisodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerUnMédiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.ajouterToolStripMenuItem,
            this.modifierToolStripMenuItem,
            this.supprimerToolStripMenuItem});
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
            this.déconnexionToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.déconnexionToolStripMenuItem.Text = "Déconnexion";
            this.déconnexionToolStripMenuItem.Click += new System.EventHandler(this.déconnexionToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // ajouterToolStripMenuItem
            // 
            this.ajouterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterUneSérieToolStripMenuItem,
            this.ajouterUneSaisonToolStripMenuItem,
            this.ajouterUnEpisodeToolStripMenuItem,
            this.ajouterUnMédiaToolStripMenuItem});
            this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.ajouterToolStripMenuItem.Text = "Ajouter";
            this.ajouterToolStripMenuItem.Visible = false;
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
            this.ajouterUneSaisonToolStripMenuItem.Click += new System.EventHandler(this.ajouterUneSaisonToolStripMenuItem_Click);
            // 
            // ajouterUnEpisodeToolStripMenuItem
            // 
            this.ajouterUnEpisodeToolStripMenuItem.Name = "ajouterUnEpisodeToolStripMenuItem";
            this.ajouterUnEpisodeToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.ajouterUnEpisodeToolStripMenuItem.Text = "Ajouter un épisode";
            this.ajouterUnEpisodeToolStripMenuItem.Click += new System.EventHandler(this.ajouterUnEpisodeToolStripMenuItem_Click);
            // 
            // ajouterUnMédiaToolStripMenuItem
            // 
            this.ajouterUnMédiaToolStripMenuItem.Name = "ajouterUnMédiaToolStripMenuItem";
            this.ajouterUnMédiaToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.ajouterUnMédiaToolStripMenuItem.Text = "Ajouter un média";
            // 
            // modifierToolStripMenuItem
            // 
            this.modifierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modifierUneSérieToolStripMenuItem,
            this.modifierUnÉpisodeToolStripMenuItem,
            this.modifierUnMédiaToolStripMenuItem});
            this.modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            this.modifierToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.modifierToolStripMenuItem.Text = "Modifier";
            this.modifierToolStripMenuItem.Visible = false;
            // 
            // modifierUneSérieToolStripMenuItem
            // 
            this.modifierUneSérieToolStripMenuItem.Name = "modifierUneSérieToolStripMenuItem";
            this.modifierUneSérieToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modifierUneSérieToolStripMenuItem.Text = "Modifier une série";
            // 
            // modifierUnÉpisodeToolStripMenuItem
            // 
            this.modifierUnÉpisodeToolStripMenuItem.Name = "modifierUnÉpisodeToolStripMenuItem";
            this.modifierUnÉpisodeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modifierUnÉpisodeToolStripMenuItem.Text = "Modifier un épisode";
            // 
            // modifierUnMédiaToolStripMenuItem
            // 
            this.modifierUnMédiaToolStripMenuItem.Name = "modifierUnMédiaToolStripMenuItem";
            this.modifierUnMédiaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modifierUnMédiaToolStripMenuItem.Text = "Modifier un média";
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.supprimerUneSérieToolStripMenuItem,
            this.supprimerUneSaisonToolStripMenuItem,
            this.supprimerUnÉpisodeToolStripMenuItem,
            this.supprimerUnMédiaToolStripMenuItem});
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.supprimerToolStripMenuItem.Text = "Supprimer";
            this.supprimerToolStripMenuItem.Visible = false;
            // 
            // supprimerUneSérieToolStripMenuItem
            // 
            this.supprimerUneSérieToolStripMenuItem.Name = "supprimerUneSérieToolStripMenuItem";
            this.supprimerUneSérieToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.supprimerUneSérieToolStripMenuItem.Text = "Supprimer une série";
            // 
            // supprimerUneSaisonToolStripMenuItem
            // 
            this.supprimerUneSaisonToolStripMenuItem.Name = "supprimerUneSaisonToolStripMenuItem";
            this.supprimerUneSaisonToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.supprimerUneSaisonToolStripMenuItem.Text = "Supprimer une saison";
            // 
            // supprimerUnÉpisodeToolStripMenuItem
            // 
            this.supprimerUnÉpisodeToolStripMenuItem.Name = "supprimerUnÉpisodeToolStripMenuItem";
            this.supprimerUnÉpisodeToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.supprimerUnÉpisodeToolStripMenuItem.Text = "Supprimer un épisode";
            // 
            // supprimerUnMédiaToolStripMenuItem
            // 
            this.supprimerUnMédiaToolStripMenuItem.Name = "supprimerUnMédiaToolStripMenuItem";
            this.supprimerUnMédiaToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.supprimerUnMédiaToolStripMenuItem.Text = "Supprimer un média";
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
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUneSérieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUneSaisonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUnEpisodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUnMédiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierUneSérieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierUnÉpisodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierUnMédiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerUneSérieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerUneSaisonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerUnÉpisodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerUnMédiaToolStripMenuItem;
    }
}