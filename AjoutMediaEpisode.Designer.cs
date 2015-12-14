namespace Main_project_VERON_MERLIN
{
    partial class AjoutMediaEpisode
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelSaison = new System.Windows.Forms.Label();
            this.labelEpisode = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.labelMedia = new System.Windows.Forms.Label();
            this.listeSerie = new System.Windows.Forms.ComboBox();
            this.listeSaison = new System.Windows.Forms.ComboBox();
            this.listeEpisode = new System.Windows.Forms.ComboBox();
            this.listeType = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.parcourir = new System.Windows.Forms.Button();
            this.ajouter = new System.Windows.Forms.Button();
            this.cheminMedia = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelSaison, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelEpisode, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelType, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.labelMedia, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.listeSerie, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.listeSaison, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.listeEpisode, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.listeType, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.ajouter, 0, 10);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 11;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(457, 235);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(451, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choississez une série :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSaison
            // 
            this.labelSaison.AutoSize = true;
            this.labelSaison.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelSaison.Location = new System.Drawing.Point(3, 40);
            this.labelSaison.Name = "labelSaison";
            this.labelSaison.Size = new System.Drawing.Size(451, 13);
            this.labelSaison.TabIndex = 1;
            this.labelSaison.Text = "Choississez une saison :";
            this.labelSaison.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelSaison.Visible = false;
            // 
            // labelEpisode
            // 
            this.labelEpisode.AutoSize = true;
            this.labelEpisode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelEpisode.Location = new System.Drawing.Point(3, 80);
            this.labelEpisode.Name = "labelEpisode";
            this.labelEpisode.Size = new System.Drawing.Size(451, 13);
            this.labelEpisode.TabIndex = 2;
            this.labelEpisode.Text = "Choississez un épisode :";
            this.labelEpisode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelEpisode.Visible = false;
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelType.Location = new System.Drawing.Point(3, 120);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(451, 13);
            this.labelType.TabIndex = 3;
            this.labelType.Text = "Choississez un type de média :";
            this.labelType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelType.Visible = false;
            // 
            // labelMedia
            // 
            this.labelMedia.AutoSize = true;
            this.labelMedia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMedia.Location = new System.Drawing.Point(3, 160);
            this.labelMedia.Name = "labelMedia";
            this.labelMedia.Size = new System.Drawing.Size(451, 13);
            this.labelMedia.TabIndex = 4;
            this.labelMedia.Text = "Choississez le média à ajouter :";
            this.labelMedia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelMedia.Visible = false;
            // 
            // listeSerie
            // 
            this.listeSerie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listeSerie.FormattingEnabled = true;
            this.listeSerie.Location = new System.Drawing.Point(3, 16);
            this.listeSerie.Name = "listeSerie";
            this.listeSerie.Size = new System.Drawing.Size(451, 21);
            this.listeSerie.TabIndex = 5;
            this.listeSerie.SelectedIndexChanged += new System.EventHandler(this.listeSerie_SelectedIndexChanged);
            // 
            // listeSaison
            // 
            this.listeSaison.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listeSaison.FormattingEnabled = true;
            this.listeSaison.Location = new System.Drawing.Point(3, 56);
            this.listeSaison.Name = "listeSaison";
            this.listeSaison.Size = new System.Drawing.Size(451, 21);
            this.listeSaison.TabIndex = 6;
            this.listeSaison.Visible = false;
            // 
            // listeEpisode
            // 
            this.listeEpisode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listeEpisode.FormattingEnabled = true;
            this.listeEpisode.Location = new System.Drawing.Point(3, 96);
            this.listeEpisode.Name = "listeEpisode";
            this.listeEpisode.Size = new System.Drawing.Size(451, 21);
            this.listeEpisode.TabIndex = 7;
            this.listeEpisode.Visible = false;
            // 
            // listeType
            // 
            this.listeType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listeType.FormattingEnabled = true;
            this.listeType.Items.AddRange(new object[] {
            "Image",
            "Son",
            "Vidéo"});
            this.listeType.Location = new System.Drawing.Point(3, 136);
            this.listeType.Name = "listeType";
            this.listeType.Size = new System.Drawing.Size(451, 21);
            this.listeType.TabIndex = 8;
            this.listeType.Visible = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.parcourir, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.cheminMedia, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 176);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(451, 29);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // parcourir
            // 
            this.parcourir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.parcourir.Location = new System.Drawing.Point(341, 3);
            this.parcourir.Name = "parcourir";
            this.parcourir.Size = new System.Drawing.Size(107, 23);
            this.parcourir.TabIndex = 0;
            this.parcourir.Text = "Parcourir";
            this.parcourir.UseVisualStyleBackColor = true;
            this.parcourir.Visible = false;
            // 
            // ajouter
            // 
            this.ajouter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ajouter.Location = new System.Drawing.Point(3, 211);
            this.ajouter.Name = "ajouter";
            this.ajouter.Size = new System.Drawing.Size(451, 23);
            this.ajouter.TabIndex = 10;
            this.ajouter.Text = "Ajouter le média";
            this.ajouter.UseVisualStyleBackColor = true;
            this.ajouter.Visible = false;
            // 
            // cheminMedia
            // 
            this.cheminMedia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cheminMedia.Enabled = false;
            this.cheminMedia.Location = new System.Drawing.Point(3, 3);
            this.cheminMedia.Name = "cheminMedia";
            this.cheminMedia.Size = new System.Drawing.Size(332, 20);
            this.cheminMedia.TabIndex = 1;
            this.cheminMedia.Visible = false;
            // 
            // AjoutMediaEpisode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 235);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AjoutMediaEpisode";
            this.Text = "Ajouter un média - épisode";
            this.Load += new System.EventHandler(this.AjoutMediaEpisode_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelSaison;
        private System.Windows.Forms.Label labelEpisode;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelMedia;
        private System.Windows.Forms.ComboBox listeSerie;
        private System.Windows.Forms.ComboBox listeSaison;
        private System.Windows.Forms.ComboBox listeEpisode;
        private System.Windows.Forms.ComboBox listeType;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button parcourir;
        private System.Windows.Forms.TextBox cheminMedia;
        private System.Windows.Forms.Button ajouter;
    }
}