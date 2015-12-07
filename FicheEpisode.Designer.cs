namespace Main_project_VERON_MERLIN
{
    partial class FicheEpisode
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
            this.nomEpisode = new System.Windows.Forms.Label();
            this.labelSynopsis = new System.Windows.Forms.Label();
            this.synopsis = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.nomEpisode, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelSynopsis, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.synopsis, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.16981F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.83019F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 196F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(284, 278);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // nomEpisode
            // 
            this.nomEpisode.AutoSize = true;
            this.nomEpisode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nomEpisode.Location = new System.Drawing.Point(3, 0);
            this.nomEpisode.Name = "nomEpisode";
            this.nomEpisode.Size = new System.Drawing.Size(278, 26);
            this.nomEpisode.TabIndex = 0;
            this.nomEpisode.Text = "label1";
            this.nomEpisode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSynopsis
            // 
            this.labelSynopsis.AutoSize = true;
            this.labelSynopsis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelSynopsis.Location = new System.Drawing.Point(3, 26);
            this.labelSynopsis.Name = "labelSynopsis";
            this.labelSynopsis.Size = new System.Drawing.Size(278, 30);
            this.labelSynopsis.TabIndex = 1;
            this.labelSynopsis.Text = "Résumé :";
            this.labelSynopsis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // synopsis
            // 
            this.synopsis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.synopsis.Location = new System.Drawing.Point(3, 59);
            this.synopsis.Name = "synopsis";
            this.synopsis.Size = new System.Drawing.Size(278, 190);
            this.synopsis.TabIndex = 2;
            this.synopsis.Text = "";
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(3, 255);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(278, 20);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FicheEpisode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 278);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FicheEpisode";
            this.Text = "FicheEpisode";
            this.Load += new System.EventHandler(this.FicheEpisode_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label nomEpisode;
        private System.Windows.Forms.Label labelSynopsis;
        private System.Windows.Forms.RichTextBox synopsis;
        private System.Windows.Forms.Button button1;
    }
}