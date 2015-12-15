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
            this.labelSynopsis = new System.Windows.Forms.Label();
            this.synopsis = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dateDiff = new System.Windows.Forms.Label();
            this.vuCheckBox = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.nomEpisode = new System.Windows.Forms.Label();
            this.noteEpisode = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.media = new System.Windows.Forms.Button();
            this.noterEpisode = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.labelSynopsis, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.synopsis, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.426967F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.179775F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.52631F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.894737F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(451, 380);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // labelSynopsis
            // 
            this.labelSynopsis.AutoSize = true;
            this.labelSynopsis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelSynopsis.Location = new System.Drawing.Point(3, 59);
            this.labelSynopsis.Name = "labelSynopsis";
            this.labelSynopsis.Size = new System.Drawing.Size(445, 23);
            this.labelSynopsis.TabIndex = 1;
            this.labelSynopsis.Text = "Résumé :";
            this.labelSynopsis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // synopsis
            // 
            this.synopsis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.synopsis.Location = new System.Drawing.Point(3, 85);
            this.synopsis.Name = "synopsis";
            this.synopsis.ReadOnly = true;
            this.synopsis.Size = new System.Drawing.Size(445, 260);
            this.synopsis.TabIndex = 2;
            this.synopsis.Text = "";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.dateDiff, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.vuCheckBox, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 31);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(445, 25);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // dateDiff
            // 
            this.dateDiff.AutoSize = true;
            this.dateDiff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateDiff.Location = new System.Drawing.Point(3, 0);
            this.dateDiff.Name = "dateDiff";
            this.dateDiff.Size = new System.Drawing.Size(216, 25);
            this.dateDiff.TabIndex = 0;
            this.dateDiff.Text = "label1";
            this.dateDiff.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // vuCheckBox
            // 
            this.vuCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.vuCheckBox.AutoSize = true;
            this.vuCheckBox.Location = new System.Drawing.Point(294, 3);
            this.vuCheckBox.Name = "vuCheckBox";
            this.vuCheckBox.Size = new System.Drawing.Size(79, 19);
            this.vuCheckBox.TabIndex = 1;
            this.vuCheckBox.Text = "Épisode vu";
            this.vuCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.vuCheckBox.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.nomEpisode, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.noteEpisode, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(445, 22);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // nomEpisode
            // 
            this.nomEpisode.AutoSize = true;
            this.nomEpisode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nomEpisode.Location = new System.Drawing.Point(3, 0);
            this.nomEpisode.Name = "nomEpisode";
            this.nomEpisode.Size = new System.Drawing.Size(216, 22);
            this.nomEpisode.TabIndex = 0;
            this.nomEpisode.Text = "label1";
            this.nomEpisode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // noteEpisode
            // 
            this.noteEpisode.AutoSize = true;
            this.noteEpisode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.noteEpisode.Location = new System.Drawing.Point(225, 0);
            this.noteEpisode.Name = "noteEpisode";
            this.noteEpisode.Size = new System.Drawing.Size(217, 22);
            this.noteEpisode.TabIndex = 1;
            this.noteEpisode.Text = "label2";
            this.noteEpisode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.media, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.noterEpisode, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 351);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(445, 26);
            this.tableLayoutPanel4.TabIndex = 6;
            // 
            // media
            // 
            this.media.Dock = System.Windows.Forms.DockStyle.Fill;
            this.media.Location = new System.Drawing.Point(3, 3);
            this.media.Name = "media";
            this.media.Size = new System.Drawing.Size(216, 20);
            this.media.TabIndex = 0;
            this.media.Text = "button1";
            this.media.UseVisualStyleBackColor = true;
            // 
            // noterEpisode
            // 
            this.noterEpisode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.noterEpisode.Location = new System.Drawing.Point(225, 3);
            this.noterEpisode.Name = "noterEpisode";
            this.noterEpisode.Size = new System.Drawing.Size(217, 20);
            this.noterEpisode.TabIndex = 1;
            this.noterEpisode.Text = "Noter cet épisode";
            this.noterEpisode.UseVisualStyleBackColor = true;
            this.noterEpisode.Click += new System.EventHandler(this.noterEpisode_Click);
            // 
            // FicheEpisode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 380);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FicheEpisode";
            this.Text = "FicheEpisode";
            this.Load += new System.EventHandler(this.FicheEpisode_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelSynopsis;
        private System.Windows.Forms.RichTextBox synopsis;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label dateDiff;
        private System.Windows.Forms.CheckBox vuCheckBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label nomEpisode;
        private System.Windows.Forms.Label noteEpisode;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button media;
        private System.Windows.Forms.Button noterEpisode;
    }
}