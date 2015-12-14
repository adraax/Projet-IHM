namespace Main_project_VERON_MERLIN
{
    partial class AjoutSaison
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
            this.label1 = new System.Windows.Forms.Label();
            this.listeSerie = new System.Windows.Forms.ComboBox();
            this.saisonLabel = new System.Windows.Forms.Label();
            this.listeSaison = new System.Windows.Forms.ComboBox();
            this.ajouterSaison = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.nbEpisodeLabel = new System.Windows.Forms.Label();
            this.nbEpisode = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbEpisode)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choisissez une série :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // listeSerie
            // 
            this.listeSerie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listeSerie.FormattingEnabled = true;
            this.listeSerie.Location = new System.Drawing.Point(3, 22);
            this.listeSerie.Name = "listeSerie";
            this.listeSerie.Size = new System.Drawing.Size(385, 21);
            this.listeSerie.TabIndex = 1;
            this.listeSerie.SelectedIndexChanged += new System.EventHandler(this.listeSerie_SelectedIndexChanged);
            // 
            // saisonLabel
            // 
            this.saisonLabel.AutoSize = true;
            this.saisonLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.saisonLabel.Location = new System.Drawing.Point(3, 45);
            this.saisonLabel.Name = "saisonLabel";
            this.saisonLabel.Size = new System.Drawing.Size(385, 17);
            this.saisonLabel.TabIndex = 2;
            this.saisonLabel.Text = "Choississez la saison à ajouter :";
            this.saisonLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.saisonLabel.Visible = false;
            // 
            // listeSaison
            // 
            this.listeSaison.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listeSaison.FormattingEnabled = true;
            this.listeSaison.Location = new System.Drawing.Point(3, 65);
            this.listeSaison.Name = "listeSaison";
            this.listeSaison.Size = new System.Drawing.Size(385, 21);
            this.listeSaison.TabIndex = 3;
            this.listeSaison.Visible = false;
            this.listeSaison.SelectedIndexChanged += new System.EventHandler(this.listeSaison_SelectedIndexChanged);
            // 
            // ajouterSaison
            // 
            this.ajouterSaison.Dock = System.Windows.Forms.DockStyle.Top;
            this.ajouterSaison.Location = new System.Drawing.Point(3, 141);
            this.ajouterSaison.Name = "ajouterSaison";
            this.ajouterSaison.Size = new System.Drawing.Size(385, 23);
            this.ajouterSaison.TabIndex = 4;
            this.ajouterSaison.Text = "Ajouter la saison";
            this.ajouterSaison.UseVisualStyleBackColor = true;
            this.ajouterSaison.Visible = false;
            this.ajouterSaison.Click += new System.EventHandler(this.ajouterSaison_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.listeSerie, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.saisonLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.listeSaison, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.nbEpisodeLabel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.nbEpisode, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.ajouterSaison, 0, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.24324F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.75676F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(391, 174);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // nbEpisodeLabel
            // 
            this.nbEpisodeLabel.AutoSize = true;
            this.nbEpisodeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nbEpisodeLabel.Location = new System.Drawing.Point(3, 90);
            this.nbEpisodeLabel.Name = "nbEpisodeLabel";
            this.nbEpisodeLabel.Size = new System.Drawing.Size(385, 19);
            this.nbEpisodeLabel.TabIndex = 4;
            this.nbEpisodeLabel.Text = "Choississez le nombre d\'épisodes :";
            this.nbEpisodeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.nbEpisodeLabel.Visible = false;
            // 
            // nbEpisode
            // 
            this.nbEpisode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nbEpisode.Location = new System.Drawing.Point(3, 112);
            this.nbEpisode.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nbEpisode.Name = "nbEpisode";
            this.nbEpisode.Size = new System.Drawing.Size(385, 20);
            this.nbEpisode.TabIndex = 5;
            this.nbEpisode.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nbEpisode.Visible = false;
            // 
            // AjoutSaison
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 174);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AjoutSaison";
            this.Text = "AjoutSaison";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbEpisode)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox listeSerie;
        private System.Windows.Forms.Label saisonLabel;
        private System.Windows.Forms.ComboBox listeSaison;
        private System.Windows.Forms.Button ajouterSaison;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label nbEpisodeLabel;
        private System.Windows.Forms.NumericUpDown nbEpisode;
    }
}