namespace Main_project_VERON_MERLIN
{
    partial class AjoutSerie
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
            this.errorNom = new System.Windows.Forms.Label();
            this.nomSerie = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ajouterSerie = new System.Windows.Forms.Button();
            this.synopsisSerie = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.etatSerie = new System.Windows.Forms.ComboBox();
            this.nbSaison = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbSaison)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(541, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom de la série :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorNom
            // 
            this.errorNom.AutoSize = true;
            this.errorNom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.errorNom.ForeColor = System.Drawing.Color.Red;
            this.errorNom.Location = new System.Drawing.Point(3, 0);
            this.errorNom.Name = "errorNom";
            this.errorNom.Size = new System.Drawing.Size(541, 22);
            this.errorNom.TabIndex = 1;
            this.errorNom.Text = "La série existe déjà";
            this.errorNom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.errorNom.Visible = false;
            // 
            // nomSerie
            // 
            this.nomSerie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nomSerie.Location = new System.Drawing.Point(3, 51);
            this.nomSerie.Name = "nomSerie";
            this.nomSerie.Size = new System.Drawing.Size(541, 20);
            this.nomSerie.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(541, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "Synopsis :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ajouterSerie
            // 
            this.ajouterSerie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ajouterSerie.Location = new System.Drawing.Point(3, 328);
            this.ajouterSerie.Name = "ajouterSerie";
            this.ajouterSerie.Size = new System.Drawing.Size(541, 22);
            this.ajouterSerie.TabIndex = 5;
            this.ajouterSerie.Text = "Ajouter";
            this.ajouterSerie.UseVisualStyleBackColor = true;
            this.ajouterSerie.Click += new System.EventHandler(this.ajouterSerie_Click);
            // 
            // synopsisSerie
            // 
            this.synopsisSerie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.synopsisSerie.Location = new System.Drawing.Point(3, 103);
            this.synopsisSerie.Name = "synopsisSerie";
            this.synopsisSerie.Size = new System.Drawing.Size(541, 157);
            this.synopsisSerie.TabIndex = 6;
            this.synopsisSerie.Text = "";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.errorNom, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.nomSerie, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.synopsisSerie, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.ajouterSerie, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.83333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.16667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 163F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(547, 353);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label4, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.etatSerie, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.nbSaison, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 266);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(541, 56);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(264, 28);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nombre de saisons (par défaut 10) :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(273, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(265, 28);
            this.label4.TabIndex = 9;
            this.label4.Text = "État de la série :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // etatSerie
            // 
            this.etatSerie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.etatSerie.FormattingEnabled = true;
            this.etatSerie.Items.AddRange(new object[] {
            "À venir",
            "En cours",
            "Terminée"});
            this.etatSerie.Location = new System.Drawing.Point(273, 31);
            this.etatSerie.Name = "etatSerie";
            this.etatSerie.Size = new System.Drawing.Size(265, 21);
            this.etatSerie.TabIndex = 10;
            // 
            // nbSaison
            // 
            this.nbSaison.Cursor = System.Windows.Forms.Cursors.Default;
            this.nbSaison.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nbSaison.Location = new System.Drawing.Point(3, 31);
            this.nbSaison.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nbSaison.Name = "nbSaison";
            this.nbSaison.Size = new System.Drawing.Size(264, 20);
            this.nbSaison.TabIndex = 11;
            this.nbSaison.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // AjoutSerie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 353);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AjoutSerie";
            this.Text = "Ajouter une série";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbSaison)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label errorNom;
        private System.Windows.Forms.TextBox nomSerie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ajouterSerie;
        private System.Windows.Forms.RichTextBox synopsisSerie;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox etatSerie;
        private System.Windows.Forms.NumericUpDown nbSaison;
    }
}