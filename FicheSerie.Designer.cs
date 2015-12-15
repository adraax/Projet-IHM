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
            this.synopsisSerie = new System.Windows.Forms.RichTextBox();
            this.synopsisSerieLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listeSaison = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.ImageBox = new System.Windows.Forms.PictureBox();
            this.suiviButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.labelEtat = new System.Windows.Forms.Label();
            this.noteLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.34705F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.65295F));
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.nomSerie, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.listeSaison, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.961687F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.03831F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 79F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(729, 508);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // nomSerie
            // 
            this.nomSerie.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.nomSerie, 2);
            this.nomSerie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nomSerie.Location = new System.Drawing.Point(3, 0);
            this.nomSerie.Name = "nomSerie";
            this.nomSerie.Size = new System.Drawing.Size(723, 37);
            this.nomSerie.TabIndex = 0;
            this.nomSerie.Text = "label1";
            this.nomSerie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.synopsisSerie, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.synopsisSerieLabel, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(318, 40);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(408, 337);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // synopsisSerie
            // 
            this.synopsisSerie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.synopsisSerie.Location = new System.Drawing.Point(3, 53);
            this.synopsisSerie.Name = "synopsisSerie";
            this.synopsisSerie.ReadOnly = true;
            this.synopsisSerie.Size = new System.Drawing.Size(402, 281);
            this.synopsisSerie.TabIndex = 1;
            this.synopsisSerie.Text = "";
            // 
            // synopsisSerieLabel
            // 
            this.synopsisSerieLabel.AutoSize = true;
            this.synopsisSerieLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.synopsisSerieLabel.Location = new System.Drawing.Point(3, 25);
            this.synopsisSerieLabel.Name = "synopsisSerieLabel";
            this.synopsisSerieLabel.Size = new System.Drawing.Size(402, 25);
            this.synopsisSerieLabel.TabIndex = 0;
            this.synopsisSerieLabel.Text = "Synopsis :";
            this.synopsisSerieLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 2);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 380);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(723, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Liste des saisons :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listeSaison
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.listeSaison, 2);
            this.listeSaison.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listeSaison.FormattingEnabled = true;
            this.listeSaison.Location = new System.Drawing.Point(3, 401);
            this.listeSaison.Name = "listeSaison";
            this.listeSaison.Size = new System.Drawing.Size(723, 73);
            this.listeSaison.TabIndex = 3;
            this.listeSaison.SelectedIndexChanged += new System.EventHandler(this.listeSaison_SelectedIndexChanged);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.ImageBox, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.suiviButton, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 40);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.5F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(309, 337);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // ImageBox
            // 
            this.ImageBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImageBox.Location = new System.Drawing.Point(3, 28);
            this.ImageBox.Name = "ImageBox";
            this.ImageBox.Size = new System.Drawing.Size(303, 306);
            this.ImageBox.TabIndex = 1;
            this.ImageBox.TabStop = false;
            this.ImageBox.ClientSizeChanged += new System.EventHandler(this.ImageBox_ClientSizeChanged);
            // 
            // suiviButton
            // 
            this.suiviButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.suiviButton.Location = new System.Drawing.Point(3, 3);
            this.suiviButton.Name = "suiviButton";
            this.suiviButton.Size = new System.Drawing.Size(303, 19);
            this.suiviButton.TabIndex = 0;
            this.suiviButton.Text = "Suivre la série";
            this.suiviButton.UseVisualStyleBackColor = true;
            this.suiviButton.Click += new System.EventHandler(this.suiviButton_Click);
            // 
            // button1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.button1, 2);
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(3, 480);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(723, 25);
            this.button1.TabIndex = 1;
            this.button1.Text = "Noter cette série";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.labelEtat, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.noteLabel, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(402, 19);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // labelEtat
            // 
            this.labelEtat.AutoSize = true;
            this.labelEtat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelEtat.Location = new System.Drawing.Point(3, 0);
            this.labelEtat.Name = "labelEtat";
            this.labelEtat.Size = new System.Drawing.Size(195, 19);
            this.labelEtat.TabIndex = 0;
            this.labelEtat.Text = "label2";
            this.labelEtat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // noteLabel
            // 
            this.noteLabel.AutoSize = true;
            this.noteLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.noteLabel.Location = new System.Drawing.Point(204, 0);
            this.noteLabel.Name = "noteLabel";
            this.noteLabel.Size = new System.Drawing.Size(195, 19);
            this.noteLabel.TabIndex = 1;
            this.noteLabel.Text = "label2";
            this.noteLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FicheSerie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 508);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FicheSerie";
            this.Text = "FicheSerie";
            this.Load += new System.EventHandler(this.FicheSerie_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
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
        private System.Windows.Forms.PictureBox ImageBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label labelEtat;
        private System.Windows.Forms.Label noteLabel;
    }
}