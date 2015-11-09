namespace Main_project_VERON_MERLIN
{
    partial class MainWindow
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
            this.conInscrTabControl = new System.Windows.Forms.TabControl();
            this.connexionTabPage = new System.Windows.Forms.TabPage();
            this.inscriptionTabPage = new System.Windows.Forms.TabPage();
            this.usernameLabelConnexion = new System.Windows.Forms.Label();
            this.usernameConnexion = new System.Windows.Forms.TextBox();
            this.passwordLabelConnexion = new System.Windows.Forms.Label();
            this.passwordConnexion = new System.Windows.Forms.TextBox();
            this.connexion = new System.Windows.Forms.Button();
            this.conInscrTabControl.SuspendLayout();
            this.connexionTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // conInscrTabControl
            // 
            this.conInscrTabControl.Controls.Add(this.connexionTabPage);
            this.conInscrTabControl.Controls.Add(this.inscriptionTabPage);
            this.conInscrTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.conInscrTabControl.Location = new System.Drawing.Point(0, 0);
            this.conInscrTabControl.Name = "conInscrTabControl";
            this.conInscrTabControl.SelectedIndex = 0;
            this.conInscrTabControl.Size = new System.Drawing.Size(321, 160);
            this.conInscrTabControl.TabIndex = 3;
            // 
            // connexionTabPage
            // 
            this.connexionTabPage.Controls.Add(this.connexion);
            this.connexionTabPage.Controls.Add(this.passwordConnexion);
            this.connexionTabPage.Controls.Add(this.passwordLabelConnexion);
            this.connexionTabPage.Controls.Add(this.usernameConnexion);
            this.connexionTabPage.Controls.Add(this.usernameLabelConnexion);
            this.connexionTabPage.Location = new System.Drawing.Point(4, 22);
            this.connexionTabPage.Name = "connexionTabPage";
            this.connexionTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.connexionTabPage.Size = new System.Drawing.Size(313, 134);
            this.connexionTabPage.TabIndex = 0;
            this.connexionTabPage.Text = "Connexion";
            this.connexionTabPage.UseVisualStyleBackColor = true;
            // 
            // inscriptionTabPage
            // 
            this.inscriptionTabPage.Location = new System.Drawing.Point(4, 22);
            this.inscriptionTabPage.Name = "inscriptionTabPage";
            this.inscriptionTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.inscriptionTabPage.Size = new System.Drawing.Size(313, 134);
            this.inscriptionTabPage.TabIndex = 1;
            this.inscriptionTabPage.Text = "Inscription";
            this.inscriptionTabPage.UseVisualStyleBackColor = true;
            // 
            // usernameLabelConnexion
            // 
            this.usernameLabelConnexion.AutoSize = true;
            this.usernameLabelConnexion.Location = new System.Drawing.Point(104, 3);
            this.usernameLabelConnexion.Name = "usernameLabelConnexion";
            this.usernameLabelConnexion.Size = new System.Drawing.Size(90, 13);
            this.usernameLabelConnexion.TabIndex = 0;
            this.usernameLabelConnexion.Text = "Nom d\'utilisateur :";
            // 
            // usernameConnexion
            // 
            this.usernameConnexion.Location = new System.Drawing.Point(107, 19);
            this.usernameConnexion.Name = "usernameConnexion";
            this.usernameConnexion.Size = new System.Drawing.Size(100, 20);
            this.usernameConnexion.TabIndex = 1;
            // 
            // passwordLabelConnexion
            // 
            this.passwordLabelConnexion.AutoSize = true;
            this.passwordLabelConnexion.Location = new System.Drawing.Point(107, 46);
            this.passwordLabelConnexion.Name = "passwordLabelConnexion";
            this.passwordLabelConnexion.Size = new System.Drawing.Size(77, 13);
            this.passwordLabelConnexion.TabIndex = 2;
            this.passwordLabelConnexion.Text = "Mot de passe :";
            // 
            // passwordConnexion
            // 
            this.passwordConnexion.Location = new System.Drawing.Point(107, 63);
            this.passwordConnexion.Name = "passwordConnexion";
            this.passwordConnexion.PasswordChar = '*';
            this.passwordConnexion.Size = new System.Drawing.Size(100, 20);
            this.passwordConnexion.TabIndex = 3;
            // 
            // connexion
            // 
            this.connexion.Location = new System.Drawing.Point(107, 90);
            this.connexion.Name = "connexion";
            this.connexion.Size = new System.Drawing.Size(100, 23);
            this.connexion.TabIndex = 4;
            this.connexion.Text = "Connexion";
            this.connexion.UseVisualStyleBackColor = true;
            this.connexion.Click += new System.EventHandler(this.connexion_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 160);
            this.Controls.Add(this.conInscrTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.conInscrTabControl.ResumeLayout(false);
            this.connexionTabPage.ResumeLayout(false);
            this.connexionTabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl conInscrTabControl;
        private System.Windows.Forms.TabPage connexionTabPage;
        private System.Windows.Forms.TabPage inscriptionTabPage;
        private System.Windows.Forms.TextBox usernameConnexion;
        private System.Windows.Forms.Label usernameLabelConnexion;
        private System.Windows.Forms.Label passwordLabelConnexion;
        private System.Windows.Forms.Button connexion;
        private System.Windows.Forms.TextBox passwordConnexion;
    }
}