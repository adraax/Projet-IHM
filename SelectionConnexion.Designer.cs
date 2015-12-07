namespace Main_project_VERON_MERLIN
{
    partial class SelectionConnexion
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
            this.externe = new System.Windows.Forms.Button();
            this.interne = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.externe, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.interne, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.71429F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(284, 56);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 2);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Connexion depuis un :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // externe
            // 
            this.externe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.externe.Location = new System.Drawing.Point(3, 24);
            this.externe.Name = "externe";
            this.externe.Size = new System.Drawing.Size(136, 29);
            this.externe.TabIndex = 1;
            this.externe.Text = "PC extérieur à la fac";
            this.externe.UseVisualStyleBackColor = true;
            this.externe.Click += new System.EventHandler(this.externe_Click);
            // 
            // interne
            // 
            this.interne.Dock = System.Windows.Forms.DockStyle.Fill;
            this.interne.Location = new System.Drawing.Point(145, 24);
            this.interne.Name = "interne";
            this.interne.Size = new System.Drawing.Size(136, 29);
            this.interne.TabIndex = 2;
            this.interne.Text = "PC de la fac";
            this.interne.UseVisualStyleBackColor = true;
            this.interne.Click += new System.EventHandler(this.interne_Click);
            // 
            // SelectionConnexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 56);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "SelectionConnexion";
            this.Text = "SelectionConnexion";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button externe;
        private System.Windows.Forms.Button interne;
    }
}