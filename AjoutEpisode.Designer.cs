namespace Main_project_VERON_MERLIN
{
    partial class AjoutEpisode
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
            this.ajouterEpisode = new System.Windows.Forms.Button();
            this.listeSaison = new System.Windows.Forms.ComboBox();
            this.saisonLabel = new System.Windows.Forms.Label();
            this.listeSerie = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.episodeLabel = new System.Windows.Forms.Label();
            this.listeEpisode = new System.Windows.Forms.ComboBox();
            this.labelNom = new System.Windows.Forms.Label();
            this.nomEpisode = new System.Windows.Forms.TextBox();
            this.labelSynopsis = new System.Windows.Forms.Label();
            this.synopsisEpisode = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // ajouterEpisode
            // 
            this.ajouterEpisode.Location = new System.Drawing.Point(139, 274);
            this.ajouterEpisode.Name = "ajouterEpisode";
            this.ajouterEpisode.Size = new System.Drawing.Size(121, 23);
            this.ajouterEpisode.TabIndex = 20;
            this.ajouterEpisode.Text = "Ajouter l\'épisode";
            this.ajouterEpisode.UseVisualStyleBackColor = true;
            this.ajouterEpisode.Visible = false;
            this.ajouterEpisode.Click += new System.EventHandler(this.ajouterEpisode_Click);
            // 
            // listeSaison
            // 
            this.listeSaison.FormattingEnabled = true;
            this.listeSaison.Location = new System.Drawing.Point(139, 66);
            this.listeSaison.Name = "listeSaison";
            this.listeSaison.Size = new System.Drawing.Size(121, 21);
            this.listeSaison.TabIndex = 8;
            this.listeSaison.Visible = false;
            this.listeSaison.SelectedIndexChanged += new System.EventHandler(this.listeSaison_SelectedIndexChanged);
            // 
            // saisonLabel
            // 
            this.saisonLabel.AutoSize = true;
            this.saisonLabel.Location = new System.Drawing.Point(144, 49);
            this.saisonLabel.Name = "saisonLabel";
            this.saisonLabel.Size = new System.Drawing.Size(111, 13);
            this.saisonLabel.TabIndex = 7;
            this.saisonLabel.Text = "Choississez la saison :";
            this.saisonLabel.Visible = false;
            // 
            // listeSerie
            // 
            this.listeSerie.FormattingEnabled = true;
            this.listeSerie.Location = new System.Drawing.Point(139, 25);
            this.listeSerie.Name = "listeSerie";
            this.listeSerie.Size = new System.Drawing.Size(121, 21);
            this.listeSerie.TabIndex = 6;
            this.listeSerie.SelectedIndexChanged += new System.EventHandler(this.listeSerie_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Choisissez une série :";
            // 
            // episodeLabel
            // 
            this.episodeLabel.AutoSize = true;
            this.episodeLabel.Location = new System.Drawing.Point(124, 90);
            this.episodeLabel.Name = "episodeLabel";
            this.episodeLabel.Size = new System.Drawing.Size(150, 13);
            this.episodeLabel.TabIndex = 10;
            this.episodeLabel.Text = "Choisissez l\'épisode à ajouter :";
            this.episodeLabel.Visible = false;
            // 
            // listeEpisode
            // 
            this.listeEpisode.FormattingEnabled = true;
            this.listeEpisode.Location = new System.Drawing.Point(139, 103);
            this.listeEpisode.Name = "listeEpisode";
            this.listeEpisode.Size = new System.Drawing.Size(121, 21);
            this.listeEpisode.TabIndex = 10;
            this.listeEpisode.Visible = false;
            this.listeEpisode.SelectedIndexChanged += new System.EventHandler(this.listeEpisode_SelectedIndexChanged);
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(147, 131);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(94, 13);
            this.labelNom.TabIndex = 21;
            this.labelNom.Text = "Nom de l\'épisode :";
            this.labelNom.Visible = false;
            // 
            // nomEpisode
            // 
            this.nomEpisode.Location = new System.Drawing.Point(139, 148);
            this.nomEpisode.Name = "nomEpisode";
            this.nomEpisode.Size = new System.Drawing.Size(121, 20);
            this.nomEpisode.TabIndex = 22;
            this.nomEpisode.Visible = false;
            // 
            // labelSynopsis
            // 
            this.labelSynopsis.AutoSize = true;
            this.labelSynopsis.Location = new System.Drawing.Point(144, 171);
            this.labelSynopsis.Name = "labelSynopsis";
            this.labelSynopsis.Size = new System.Drawing.Size(108, 13);
            this.labelSynopsis.TabIndex = 23;
            this.labelSynopsis.Text = "Synopsis de l\'épisode";
            this.labelSynopsis.Visible = false;
            // 
            // synopsisEpisode
            // 
            this.synopsisEpisode.Location = new System.Drawing.Point(139, 188);
            this.synopsisEpisode.Name = "synopsisEpisode";
            this.synopsisEpisode.Size = new System.Drawing.Size(121, 80);
            this.synopsisEpisode.TabIndex = 24;
            this.synopsisEpisode.Text = "";
            this.synopsisEpisode.Visible = false;
            // 
            // AjoutEpisode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 329);
            this.Controls.Add(this.synopsisEpisode);
            this.Controls.Add(this.labelSynopsis);
            this.Controls.Add(this.nomEpisode);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.listeEpisode);
            this.Controls.Add(this.episodeLabel);
            this.Controls.Add(this.ajouterEpisode);
            this.Controls.Add(this.listeSaison);
            this.Controls.Add(this.saisonLabel);
            this.Controls.Add(this.listeSerie);
            this.Controls.Add(this.label1);
            this.Name = "AjoutEpisode";
            this.Text = "Ajouter un épisode";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ajouterEpisode;
        private System.Windows.Forms.ComboBox listeSaison;
        private System.Windows.Forms.Label saisonLabel;
        private System.Windows.Forms.ComboBox listeSerie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label episodeLabel;
        private System.Windows.Forms.ComboBox listeEpisode;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.TextBox nomEpisode;
        private System.Windows.Forms.Label labelSynopsis;
        private System.Windows.Forms.RichTextBox synopsisEpisode;
    }
}