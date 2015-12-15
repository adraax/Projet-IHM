namespace Main_project_VERON_MERLIN
{
    partial class SuppressionMediaSerie
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
            this.labelMedia = new System.Windows.Forms.Label();
            this.listeSerie = new System.Windows.Forms.ComboBox();
            this.listeMedia = new System.Windows.Forms.ComboBox();
            this.suppression = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelMedia, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.listeSerie, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.listeMedia, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.suppression, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(652, 126);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(646, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choississez une série :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMedia
            // 
            this.labelMedia.AutoSize = true;
            this.labelMedia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMedia.Location = new System.Drawing.Point(3, 50);
            this.labelMedia.Name = "labelMedia";
            this.labelMedia.Size = new System.Drawing.Size(646, 25);
            this.labelMedia.TabIndex = 1;
            this.labelMedia.Text = "Choississez un média :";
            this.labelMedia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelMedia.Visible = false;
            // 
            // listeSerie
            // 
            this.listeSerie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listeSerie.FormattingEnabled = true;
            this.listeSerie.Location = new System.Drawing.Point(3, 28);
            this.listeSerie.Name = "listeSerie";
            this.listeSerie.Size = new System.Drawing.Size(646, 21);
            this.listeSerie.TabIndex = 2;
            this.listeSerie.SelectedIndexChanged += new System.EventHandler(this.listeSerie_SelectedIndexChanged);
            // 
            // listeMedia
            // 
            this.listeMedia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listeMedia.FormattingEnabled = true;
            this.listeMedia.Location = new System.Drawing.Point(3, 78);
            this.listeMedia.Name = "listeMedia";
            this.listeMedia.Size = new System.Drawing.Size(646, 21);
            this.listeMedia.TabIndex = 3;
            this.listeMedia.Visible = false;
            this.listeMedia.SelectedIndexChanged += new System.EventHandler(this.listeMedia_SelectedIndexChanged);
            // 
            // suppression
            // 
            this.suppression.Dock = System.Windows.Forms.DockStyle.Fill;
            this.suppression.Location = new System.Drawing.Point(3, 103);
            this.suppression.Name = "suppression";
            this.suppression.Size = new System.Drawing.Size(646, 20);
            this.suppression.TabIndex = 4;
            this.suppression.Text = "Supprimer le média";
            this.suppression.UseVisualStyleBackColor = true;
            this.suppression.Visible = false;
            this.suppression.Click += new System.EventHandler(this.suppression_Click);
            // 
            // SuppressionMediaSerie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 126);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "SuppressionMediaSerie";
            this.Text = "Supprimer un média sur une série";
            this.Load += new System.EventHandler(this.SuppressionMediaSerie_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelMedia;
        private System.Windows.Forms.ComboBox listeSerie;
        private System.Windows.Forms.ComboBox listeMedia;
        private System.Windows.Forms.Button suppression;
    }
}