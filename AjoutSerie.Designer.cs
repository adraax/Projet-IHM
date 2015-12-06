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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom de la série :";
            // 
            // errorNom
            // 
            this.errorNom.AutoSize = true;
            this.errorNom.ForeColor = System.Drawing.Color.Red;
            this.errorNom.Location = new System.Drawing.Point(125, 7);
            this.errorNom.Name = "errorNom";
            this.errorNom.Size = new System.Drawing.Size(97, 13);
            this.errorNom.TabIndex = 1;
            this.errorNom.Text = "La série existe déjà";
            this.errorNom.Visible = false;
            // 
            // nomSerie
            // 
            this.nomSerie.Location = new System.Drawing.Point(128, 38);
            this.nomSerie.Name = "nomSerie";
            this.nomSerie.Size = new System.Drawing.Size(100, 20);
            this.nomSerie.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Synopsis :";
            // 
            // ajouterSerie
            // 
            this.ajouterSerie.Location = new System.Drawing.Point(147, 217);
            this.ajouterSerie.Name = "ajouterSerie";
            this.ajouterSerie.Size = new System.Drawing.Size(75, 23);
            this.ajouterSerie.TabIndex = 5;
            this.ajouterSerie.Text = "Ajouter";
            this.ajouterSerie.UseVisualStyleBackColor = true;
            this.ajouterSerie.Click += new System.EventHandler(this.ajouterSerie_Click);
            // 
            // synopsisSerie
            // 
            this.synopsisSerie.Location = new System.Drawing.Point(98, 82);
            this.synopsisSerie.Name = "synopsisSerie";
            this.synopsisSerie.Size = new System.Drawing.Size(206, 129);
            this.synopsisSerie.TabIndex = 6;
            this.synopsisSerie.Text = "";
            // 
            // AjoutSerie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 261);
            this.Controls.Add(this.synopsisSerie);
            this.Controls.Add(this.ajouterSerie);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nomSerie);
            this.Controls.Add(this.errorNom);
            this.Controls.Add(this.label1);
            this.Name = "AjoutSerie";
            this.Text = "Ajouter une série";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label errorNom;
        private System.Windows.Forms.TextBox nomSerie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ajouterSerie;
        private System.Windows.Forms.RichTextBox synopsisSerie;
    }
}