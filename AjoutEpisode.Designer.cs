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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelDate = new System.Windows.Forms.Label();
            this.dateDiff = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ajouterEpisode
            // 
            this.ajouterEpisode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ajouterEpisode.Location = new System.Drawing.Point(3, 540);
            this.ajouterEpisode.Name = "ajouterEpisode";
            this.ajouterEpisode.Size = new System.Drawing.Size(735, 25);
            this.ajouterEpisode.TabIndex = 20;
            this.ajouterEpisode.Text = "Ajouter l\'épisode";
            this.ajouterEpisode.UseVisualStyleBackColor = true;
            this.ajouterEpisode.Visible = false;
            this.ajouterEpisode.Click += new System.EventHandler(this.ajouterEpisode_Click);
            // 
            // listeSaison
            // 
            this.listeSaison.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listeSaison.FormattingEnabled = true;
            this.listeSaison.Location = new System.Drawing.Point(3, 72);
            this.listeSaison.Name = "listeSaison";
            this.listeSaison.Size = new System.Drawing.Size(735, 21);
            this.listeSaison.TabIndex = 8;
            this.listeSaison.Visible = false;
            this.listeSaison.SelectedIndexChanged += new System.EventHandler(this.listeSaison_SelectedIndexChanged);
            // 
            // saisonLabel
            // 
            this.saisonLabel.AutoSize = true;
            this.saisonLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.saisonLabel.Location = new System.Drawing.Point(3, 42);
            this.saisonLabel.Name = "saisonLabel";
            this.saisonLabel.Size = new System.Drawing.Size(735, 27);
            this.saisonLabel.TabIndex = 7;
            this.saisonLabel.Text = "Choississez la saison :";
            this.saisonLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.saisonLabel.Visible = false;
            // 
            // listeSerie
            // 
            this.listeSerie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listeSerie.FormattingEnabled = true;
            this.listeSerie.Location = new System.Drawing.Point(3, 23);
            this.listeSerie.Name = "listeSerie";
            this.listeSerie.Size = new System.Drawing.Size(735, 21);
            this.listeSerie.TabIndex = 6;
            this.listeSerie.SelectedIndexChanged += new System.EventHandler(this.listeSerie_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(735, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Choisissez une série :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // episodeLabel
            // 
            this.episodeLabel.AutoSize = true;
            this.episodeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.episodeLabel.Location = new System.Drawing.Point(3, 96);
            this.episodeLabel.Name = "episodeLabel";
            this.episodeLabel.Size = new System.Drawing.Size(735, 23);
            this.episodeLabel.TabIndex = 10;
            this.episodeLabel.Text = "Choisissez l\'épisode à ajouter :";
            this.episodeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.episodeLabel.Visible = false;
            // 
            // listeEpisode
            // 
            this.listeEpisode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listeEpisode.FormattingEnabled = true;
            this.listeEpisode.Location = new System.Drawing.Point(3, 122);
            this.listeEpisode.Name = "listeEpisode";
            this.listeEpisode.Size = new System.Drawing.Size(735, 21);
            this.listeEpisode.TabIndex = 10;
            this.listeEpisode.Visible = false;
            this.listeEpisode.SelectedIndexChanged += new System.EventHandler(this.listeEpisode_SelectedIndexChanged);
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelNom.Location = new System.Drawing.Point(3, 147);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(735, 22);
            this.labelNom.TabIndex = 21;
            this.labelNom.Text = "Nom de l\'épisode :";
            this.labelNom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelNom.Visible = false;
            // 
            // nomEpisode
            // 
            this.nomEpisode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nomEpisode.Location = new System.Drawing.Point(3, 172);
            this.nomEpisode.Name = "nomEpisode";
            this.nomEpisode.Size = new System.Drawing.Size(735, 20);
            this.nomEpisode.TabIndex = 22;
            this.nomEpisode.Visible = false;
            // 
            // labelSynopsis
            // 
            this.labelSynopsis.AutoSize = true;
            this.labelSynopsis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelSynopsis.Location = new System.Drawing.Point(3, 195);
            this.labelSynopsis.Name = "labelSynopsis";
            this.labelSynopsis.Size = new System.Drawing.Size(735, 19);
            this.labelSynopsis.TabIndex = 23;
            this.labelSynopsis.Text = "Synopsis de l\'épisode :";
            this.labelSynopsis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelSynopsis.Visible = false;
            // 
            // synopsisEpisode
            // 
            this.synopsisEpisode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.synopsisEpisode.Location = new System.Drawing.Point(3, 217);
            this.synopsisEpisode.Name = "synopsisEpisode";
            this.synopsisEpisode.Size = new System.Drawing.Size(735, 270);
            this.synopsisEpisode.TabIndex = 24;
            this.synopsisEpisode.Text = "";
            this.synopsisEpisode.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.listeSerie, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ajouterEpisode, 0, 12);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.synopsisEpisode, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.labelSynopsis, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.nomEpisode, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.labelNom, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.labelDate, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.dateDiff, 0, 11);
            this.tableLayoutPanel1.Controls.Add(this.saisonLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.episodeLabel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.listeSaison, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.listeEpisode, 0, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 13;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.521127F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.87324F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.753521F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.753521F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.049296F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.929577F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.87324F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.577465F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.34507F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.59155F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.225352F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.049296F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.105634F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(741, 568);
            this.tableLayoutPanel1.TabIndex = 25;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDate.Location = new System.Drawing.Point(3, 490);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(735, 24);
            this.labelDate.TabIndex = 25;
            this.labelDate.Text = "Date de diffusion :";
            this.labelDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelDate.Visible = false;
            // 
            // dateDiff
            // 
            this.dateDiff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateDiff.Location = new System.Drawing.Point(3, 517);
            this.dateDiff.Name = "dateDiff";
            this.dateDiff.Size = new System.Drawing.Size(735, 20);
            this.dateDiff.TabIndex = 26;
            this.dateDiff.Visible = false;
            // 
            // AjoutEpisode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 568);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AjoutEpisode";
            this.Text = "Ajouter un épisode";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.DateTimePicker dateDiff;
    }
}