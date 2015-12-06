namespace Main_project_VERON_MERLIN
{
    partial class AjoutSaison
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
            this.listeSerie = new System.Windows.Forms.ComboBox();
            this.saisonLabel = new System.Windows.Forms.Label();
            this.listeSaison = new System.Windows.Forms.ComboBox();
            this.ajouterSaison = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choisissez une série :";
            // 
            // listeSerie
            // 
            this.listeSerie.FormattingEnabled = true;
            this.listeSerie.Location = new System.Drawing.Point(81, 25);
            this.listeSerie.Name = "listeSerie";
            this.listeSerie.Size = new System.Drawing.Size(121, 21);
            this.listeSerie.TabIndex = 1;
            this.listeSerie.SelectedIndexChanged += new System.EventHandler(this.listeSerie_SelectedIndexChanged);
            // 
            // saisonLabel
            // 
            this.saisonLabel.AutoSize = true;
            this.saisonLabel.Location = new System.Drawing.Point(66, 49);
            this.saisonLabel.Name = "saisonLabel";
            this.saisonLabel.Size = new System.Drawing.Size(155, 13);
            this.saisonLabel.TabIndex = 2;
            this.saisonLabel.Text = "Choississez la saison à ajouter :";
            this.saisonLabel.Visible = false;
            // 
            // listeSaison
            // 
            this.listeSaison.FormattingEnabled = true;
            this.listeSaison.Location = new System.Drawing.Point(81, 66);
            this.listeSaison.Name = "listeSaison";
            this.listeSaison.Size = new System.Drawing.Size(121, 21);
            this.listeSaison.TabIndex = 3;
            this.listeSaison.Visible = false;
            this.listeSaison.SelectedIndexChanged += new System.EventHandler(this.listeSaison_SelectedIndexChanged);
            // 
            // ajouterSaison
            // 
            this.ajouterSaison.Location = new System.Drawing.Point(92, 106);
            this.ajouterSaison.Name = "ajouterSaison";
            this.ajouterSaison.Size = new System.Drawing.Size(96, 23);
            this.ajouterSaison.TabIndex = 4;
            this.ajouterSaison.Text = "Ajouter la saison";
            this.ajouterSaison.UseVisualStyleBackColor = true;
            this.ajouterSaison.Visible = false;
            this.ajouterSaison.Click += new System.EventHandler(this.ajouterSaison_Click);
            // 
            // AjoutSaison
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 141);
            this.Controls.Add(this.ajouterSaison);
            this.Controls.Add(this.listeSaison);
            this.Controls.Add(this.saisonLabel);
            this.Controls.Add(this.listeSerie);
            this.Controls.Add(this.label1);
            this.Name = "AjoutSaison";
            this.Text = "AjoutSaison";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox listeSerie;
        private System.Windows.Forms.Label saisonLabel;
        private System.Windows.Forms.ComboBox listeSaison;
        private System.Windows.Forms.Button ajouterSaison;
    }
}