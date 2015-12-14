namespace Main_project_VERON_MERLIN
{
    partial class ModifierSerie
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
            this.Modifier = new System.Windows.Forms.Button();
            this.SynopsisSerie = new System.Windows.Forms.RichTextBox();
            this.NewSynopsis = new System.Windows.Forms.Label();
            this.ListeSeries = new System.Windows.Forms.ComboBox();
            this.SerieAModifier = new System.Windows.Forms.Label();
            this.LayoutModifSerie = new System.Windows.Forms.TableLayoutPanel();
            this.EtatSerie = new System.Windows.Forms.Label();
            this.ChoixEtatSerie = new System.Windows.Forms.ComboBox();
            this.NbSaisons = new System.Windows.Forms.Label();
            this.ChoixNbSaisons = new System.Windows.Forms.NumericUpDown();
            this.LayoutModifSerie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChoixNbSaisons)).BeginInit();
            this.SuspendLayout();
            // 
            // Modifier
            // 
            this.Modifier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Modifier.Location = new System.Drawing.Point(3, 353);
            this.Modifier.Name = "Modifier";
            this.Modifier.Size = new System.Drawing.Size(466, 22);
            this.Modifier.TabIndex = 6;
            this.Modifier.Text = "Modifier";
            this.Modifier.UseVisualStyleBackColor = true;
            this.Modifier.Visible = false;
            this.Modifier.Click += new System.EventHandler(this.Modifier_Click);
            // 
            // SynopsisSerie
            // 
            this.SynopsisSerie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SynopsisSerie.Location = new System.Drawing.Point(3, 170);
            this.SynopsisSerie.Name = "SynopsisSerie";
            this.SynopsisSerie.Size = new System.Drawing.Size(466, 177);
            this.SynopsisSerie.TabIndex = 5;
            this.SynopsisSerie.Text = "";
            this.SynopsisSerie.Visible = false;
            // 
            // NewSynopsis
            // 
            this.NewSynopsis.AutoSize = true;
            this.NewSynopsis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NewSynopsis.Location = new System.Drawing.Point(3, 146);
            this.NewSynopsis.Name = "NewSynopsis";
            this.NewSynopsis.Size = new System.Drawing.Size(466, 21);
            this.NewSynopsis.TabIndex = 4;
            this.NewSynopsis.Text = "Nouveau synopsis";
            this.NewSynopsis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NewSynopsis.Visible = false;
            // 
            // ListeSeries
            // 
            this.ListeSeries.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListeSeries.FormattingEnabled = true;
            this.ListeSeries.Location = new System.Drawing.Point(3, 34);
            this.ListeSeries.Name = "ListeSeries";
            this.ListeSeries.Size = new System.Drawing.Size(466, 21);
            this.ListeSeries.TabIndex = 1;
            this.ListeSeries.SelectedIndexChanged += new System.EventHandler(this.ListeSeries_SelectedIndexChanged);
            // 
            // SerieAModifier
            // 
            this.SerieAModifier.AutoSize = true;
            this.SerieAModifier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SerieAModifier.Location = new System.Drawing.Point(3, 0);
            this.SerieAModifier.Name = "SerieAModifier";
            this.SerieAModifier.Size = new System.Drawing.Size(466, 31);
            this.SerieAModifier.TabIndex = 0;
            this.SerieAModifier.Text = "Série à modifier";
            this.SerieAModifier.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LayoutModifSerie
            // 
            this.LayoutModifSerie.ColumnCount = 1;
            this.LayoutModifSerie.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LayoutModifSerie.Controls.Add(this.SerieAModifier, 0, 0);
            this.LayoutModifSerie.Controls.Add(this.ListeSeries, 0, 1);
            this.LayoutModifSerie.Controls.Add(this.NewSynopsis, 0, 6);
            this.LayoutModifSerie.Controls.Add(this.SynopsisSerie, 0, 7);
            this.LayoutModifSerie.Controls.Add(this.Modifier, 0, 8);
            this.LayoutModifSerie.Controls.Add(this.EtatSerie, 0, 2);
            this.LayoutModifSerie.Controls.Add(this.ChoixEtatSerie, 0, 3);
            this.LayoutModifSerie.Controls.Add(this.NbSaisons, 0, 4);
            this.LayoutModifSerie.Controls.Add(this.ChoixNbSaisons, 0, 5);
            this.LayoutModifSerie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LayoutModifSerie.Location = new System.Drawing.Point(0, 0);
            this.LayoutModifSerie.Name = "LayoutModifSerie";
            this.LayoutModifSerie.RowCount = 9;
            this.LayoutModifSerie.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.LayoutModifSerie.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.374631F));
            this.LayoutModifSerie.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.LayoutModifSerie.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.144543F));
            this.LayoutModifSerie.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.LayoutModifSerie.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.734807F));
            this.LayoutModifSerie.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.906077F));
            this.LayoutModifSerie.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.83978F));
            this.LayoutModifSerie.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.LayoutModifSerie.Size = new System.Drawing.Size(472, 378);
            this.LayoutModifSerie.TabIndex = 0;
            // 
            // EtatSerie
            // 
            this.EtatSerie.AutoSize = true;
            this.EtatSerie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EtatSerie.Location = new System.Drawing.Point(3, 54);
            this.EtatSerie.Name = "EtatSerie";
            this.EtatSerie.Size = new System.Drawing.Size(466, 20);
            this.EtatSerie.TabIndex = 7;
            this.EtatSerie.Text = "Etat de la série (en cours, terminée)";
            this.EtatSerie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EtatSerie.Visible = false;
            // 
            // ChoixEtatSerie
            // 
            this.ChoixEtatSerie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChoixEtatSerie.FormattingEnabled = true;
            this.ChoixEtatSerie.Items.AddRange(new object[] {
            "À venir",
            "En cours",
            "Terminée"});
            this.ChoixEtatSerie.Location = new System.Drawing.Point(3, 77);
            this.ChoixEtatSerie.Name = "ChoixEtatSerie";
            this.ChoixEtatSerie.Size = new System.Drawing.Size(466, 21);
            this.ChoixEtatSerie.TabIndex = 8;
            this.ChoixEtatSerie.Visible = false;
            // 
            // NbSaisons
            // 
            this.NbSaisons.AutoSize = true;
            this.NbSaisons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NbSaisons.Location = new System.Drawing.Point(3, 102);
            this.NbSaisons.Name = "NbSaisons";
            this.NbSaisons.Size = new System.Drawing.Size(466, 20);
            this.NbSaisons.TabIndex = 9;
            this.NbSaisons.Text = "Nombre de saisons";
            this.NbSaisons.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NbSaisons.Visible = false;
            // 
            // ChoixNbSaisons
            // 
            this.ChoixNbSaisons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChoixNbSaisons.Location = new System.Drawing.Point(3, 125);
            this.ChoixNbSaisons.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ChoixNbSaisons.Name = "ChoixNbSaisons";
            this.ChoixNbSaisons.Size = new System.Drawing.Size(466, 20);
            this.ChoixNbSaisons.TabIndex = 10;
            this.ChoixNbSaisons.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ChoixNbSaisons.Visible = false;
            // 
            // ModifierSerie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 378);
            this.Controls.Add(this.LayoutModifSerie);
            this.Name = "ModifierSerie";
            this.Text = "ModifierSerie";
            this.LayoutModifSerie.ResumeLayout(false);
            this.LayoutModifSerie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChoixNbSaisons)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Modifier;
        private System.Windows.Forms.RichTextBox SynopsisSerie;
        private System.Windows.Forms.Label NewSynopsis;
        private System.Windows.Forms.ComboBox ListeSeries;
        private System.Windows.Forms.Label SerieAModifier;
        private System.Windows.Forms.TableLayoutPanel LayoutModifSerie;
        private System.Windows.Forms.Label EtatSerie;
        private System.Windows.Forms.ComboBox ChoixEtatSerie;
        private System.Windows.Forms.Label NbSaisons;
        private System.Windows.Forms.NumericUpDown ChoixNbSaisons;

    }
}