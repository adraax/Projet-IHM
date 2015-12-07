namespace Main_project_VERON_MERLIN
{
    partial class FicheSerie
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
            this.nomSerie = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.synopsisSerieLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listeSaison = new System.Windows.Forms.ListBox();
            this.synopsisSerie = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.suiviButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.19135F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.80865F));
            this.tableLayoutPanel1.Controls.Add(this.nomSerie, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.listeSaison, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.961686F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.03831F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 79F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(514, 426);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // nomSerie
            // 
            this.nomSerie.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.nomSerie, 2);
            this.nomSerie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nomSerie.Location = new System.Drawing.Point(3, 0);
            this.nomSerie.Name = "nomSerie";
            this.nomSerie.Size = new System.Drawing.Size(508, 32);
            this.nomSerie.TabIndex = 0;
            this.nomSerie.Text = "label1";
            this.nomSerie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.synopsisSerieLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.synopsisSerie, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(230, 35);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.655172F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.34483F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(281, 290);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // synopsisSerieLabel
            // 
            this.synopsisSerieLabel.AutoSize = true;
            this.synopsisSerieLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.synopsisSerieLabel.Location = new System.Drawing.Point(3, 0);
            this.synopsisSerieLabel.Name = "synopsisSerieLabel";
            this.synopsisSerieLabel.Size = new System.Drawing.Size(275, 27);
            this.synopsisSerieLabel.TabIndex = 0;
            this.synopsisSerieLabel.Text = "Synopsis :";
            this.synopsisSerieLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 2);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 328);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(508, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Liste des saisons :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listeSaison
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.listeSaison, 2);
            this.listeSaison.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listeSaison.FormattingEnabled = true;
            this.listeSaison.Location = new System.Drawing.Point(3, 349);
            this.listeSaison.Name = "listeSaison";
            this.listeSaison.Size = new System.Drawing.Size(508, 74);
            this.listeSaison.TabIndex = 3;
            this.listeSaison.SelectedIndexChanged += new System.EventHandler(this.listeSaison_SelectedIndexChanged);
            // 
            // synopsisSerie
            // 
            this.synopsisSerie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.synopsisSerie.Location = new System.Drawing.Point(3, 30);
            this.synopsisSerie.Name = "synopsisSerie";
            this.synopsisSerie.ReadOnly = true;
            this.synopsisSerie.Size = new System.Drawing.Size(275, 257);
            this.synopsisSerie.TabIndex = 1;
            this.synopsisSerie.Text = "";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.suiviButton, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 35);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.655172F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.34483F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(221, 290);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // suiviButton
            // 
            this.suiviButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.suiviButton.Location = new System.Drawing.Point(3, 3);
            this.suiviButton.Name = "suiviButton";
            this.suiviButton.Size = new System.Drawing.Size(215, 21);
            this.suiviButton.TabIndex = 0;
            this.suiviButton.Text = "Suivre la série";
            this.suiviButton.UseVisualStyleBackColor = true;
            this.suiviButton.Click += new System.EventHandler(this.suiviButton_Click);
            // 
            // FicheSerie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 426);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FicheSerie";
            this.Text = "FicheSerie";
            this.Load += new System.EventHandler(this.FicheSerie_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label nomSerie;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label synopsisSerieLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listeSaison;
        private System.Windows.Forms.RichTextBox synopsisSerie;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button suiviButton;
    }
}