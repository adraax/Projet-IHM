namespace Main_project_VERON_MERLIN
{
    partial class AjoutMediaSerie
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
            this.listeSerie = new System.Windows.Forms.ComboBox();
            this.typeLabel = new System.Windows.Forms.Label();
            this.typeMedia = new System.Windows.Forms.ComboBox();
            this.cheminLabel = new System.Windows.Forms.Label();
            this.cheminTextBox = new System.Windows.Forms.TextBox();
            this.parcourir = new System.Windows.Forms.Button();
            this.valider = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.listeSerie, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.typeLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.typeMedia, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.cheminLabel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.cheminTextBox, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.parcourir, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.valider, 0, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(721, 149);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 2);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(715, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sélectionnez une série :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listeSerie
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.listeSerie, 2);
            this.listeSerie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listeSerie.FormattingEnabled = true;
            this.listeSerie.Location = new System.Drawing.Point(3, 16);
            this.listeSerie.Name = "listeSerie";
            this.listeSerie.Size = new System.Drawing.Size(715, 21);
            this.listeSerie.TabIndex = 1;
            this.listeSerie.SelectedIndexChanged += new System.EventHandler(this.listeSerie_SelectedIndexChanged);
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.typeLabel, 2);
            this.typeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.typeLabel.Location = new System.Drawing.Point(3, 40);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(715, 13);
            this.typeLabel.TabIndex = 2;
            this.typeLabel.Text = "Choississez le type de média :";
            this.typeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.typeLabel.Visible = false;
            // 
            // typeMedia
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.typeMedia, 2);
            this.typeMedia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.typeMedia.FormattingEnabled = true;
            this.typeMedia.Items.AddRange(new object[] {
            "Image",
            "Son",
            "Vidéo"});
            this.typeMedia.Location = new System.Drawing.Point(3, 56);
            this.typeMedia.Name = "typeMedia";
            this.typeMedia.Size = new System.Drawing.Size(715, 21);
            this.typeMedia.TabIndex = 3;
            this.typeMedia.Visible = false;
            this.typeMedia.SelectedIndexChanged += new System.EventHandler(this.typeMedia_SelectedIndexChanged);
            // 
            // cheminLabel
            // 
            this.cheminLabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.cheminLabel, 2);
            this.cheminLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cheminLabel.Location = new System.Drawing.Point(3, 80);
            this.cheminLabel.Name = "cheminLabel";
            this.cheminLabel.Size = new System.Drawing.Size(715, 13);
            this.cheminLabel.TabIndex = 4;
            this.cheminLabel.Text = "Choississez le média :";
            this.cheminLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cheminLabel.Visible = false;
            // 
            // cheminTextBox
            // 
            this.cheminTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cheminTextBox.Location = new System.Drawing.Point(3, 96);
            this.cheminTextBox.Name = "cheminTextBox";
            this.cheminTextBox.ReadOnly = true;
            this.cheminTextBox.Size = new System.Drawing.Size(534, 20);
            this.cheminTextBox.TabIndex = 5;
            this.cheminTextBox.Visible = false;
            // 
            // parcourir
            // 
            this.parcourir.Dock = System.Windows.Forms.DockStyle.Top;
            this.parcourir.Location = new System.Drawing.Point(543, 96);
            this.parcourir.Name = "parcourir";
            this.parcourir.Size = new System.Drawing.Size(175, 23);
            this.parcourir.TabIndex = 6;
            this.parcourir.Text = "Parcourir";
            this.parcourir.UseVisualStyleBackColor = true;
            this.parcourir.Visible = false;
            this.parcourir.Click += new System.EventHandler(this.parcourir_Click);
            // 
            // valider
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.valider, 2);
            this.valider.Dock = System.Windows.Forms.DockStyle.Top;
            this.valider.Location = new System.Drawing.Point(3, 125);
            this.valider.Name = "valider";
            this.valider.Size = new System.Drawing.Size(715, 23);
            this.valider.TabIndex = 7;
            this.valider.Text = "Ajouter";
            this.valider.UseVisualStyleBackColor = true;
            this.valider.Visible = false;
            this.valider.Click += new System.EventHandler(this.valider_Click);
            // 
            // AjoutMediaSerie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 149);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AjoutMediaSerie";
            this.Text = "Ajouter un média - série";
            this.Load += new System.EventHandler(this.AjoutMediaSerie_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox listeSerie;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.ComboBox typeMedia;
        private System.Windows.Forms.Label cheminLabel;
        private System.Windows.Forms.TextBox cheminTextBox;
        private System.Windows.Forms.Button parcourir;
        private System.Windows.Forms.Button valider;
    }
}