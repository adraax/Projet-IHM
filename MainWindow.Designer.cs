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
            this.connexion = new System.Windows.Forms.Button();
            this.passwordConnexion = new System.Windows.Forms.TextBox();
            this.passwordLabelConnexion = new System.Windows.Forms.Label();
            this.usernameConnexion = new System.Windows.Forms.TextBox();
            this.usernameLabelConnexion = new System.Windows.Forms.Label();
            this.inscriptionTabPage = new System.Windows.Forms.TabPage();
            this.inscriptionOk = new System.Windows.Forms.Label();
            this.errorPassword = new System.Windows.Forms.Label();
            this.errorUsername = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.confirmPassword = new System.Windows.Forms.TextBox();
            this.inscription = new System.Windows.Forms.Button();
            this.passwordInscription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.usernameInscription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorConnexion = new System.Windows.Forms.Label();
            this.conInscrTabControl.SuspendLayout();
            this.connexionTabPage.SuspendLayout();
            this.inscriptionTabPage.SuspendLayout();
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
            this.conInscrTabControl.Size = new System.Drawing.Size(321, 223);
            this.conInscrTabControl.TabIndex = 3;
            // 
            // connexionTabPage
            // 
            this.connexionTabPage.Controls.Add(this.errorConnexion);
            this.connexionTabPage.Controls.Add(this.connexion);
            this.connexionTabPage.Controls.Add(this.passwordConnexion);
            this.connexionTabPage.Controls.Add(this.passwordLabelConnexion);
            this.connexionTabPage.Controls.Add(this.usernameConnexion);
            this.connexionTabPage.Controls.Add(this.usernameLabelConnexion);
            this.connexionTabPage.Location = new System.Drawing.Point(4, 22);
            this.connexionTabPage.Name = "connexionTabPage";
            this.connexionTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.connexionTabPage.Size = new System.Drawing.Size(313, 197);
            this.connexionTabPage.TabIndex = 0;
            this.connexionTabPage.Text = "Connexion";
            this.connexionTabPage.UseVisualStyleBackColor = true;
            // 
            // connexion
            // 
            this.connexion.Location = new System.Drawing.Point(110, 107);
            this.connexion.Name = "connexion";
            this.connexion.Size = new System.Drawing.Size(100, 23);
            this.connexion.TabIndex = 4;
            this.connexion.Text = "Connexion";
            this.connexion.UseVisualStyleBackColor = true;
            this.connexion.Click += new System.EventHandler(this.connexion_Click);
            // 
            // passwordConnexion
            // 
            this.passwordConnexion.Location = new System.Drawing.Point(110, 80);
            this.passwordConnexion.Name = "passwordConnexion";
            this.passwordConnexion.Size = new System.Drawing.Size(100, 20);
            this.passwordConnexion.TabIndex = 3;
            this.passwordConnexion.UseSystemPasswordChar = true;
            // 
            // passwordLabelConnexion
            // 
            this.passwordLabelConnexion.AutoSize = true;
            this.passwordLabelConnexion.Location = new System.Drawing.Point(110, 63);
            this.passwordLabelConnexion.Name = "passwordLabelConnexion";
            this.passwordLabelConnexion.Size = new System.Drawing.Size(77, 13);
            this.passwordLabelConnexion.TabIndex = 2;
            this.passwordLabelConnexion.Text = "Mot de passe :";
            // 
            // usernameConnexion
            // 
            this.usernameConnexion.Location = new System.Drawing.Point(110, 36);
            this.usernameConnexion.Name = "usernameConnexion";
            this.usernameConnexion.Size = new System.Drawing.Size(100, 20);
            this.usernameConnexion.TabIndex = 1;
            // 
            // usernameLabelConnexion
            // 
            this.usernameLabelConnexion.AutoSize = true;
            this.usernameLabelConnexion.Location = new System.Drawing.Point(107, 20);
            this.usernameLabelConnexion.Name = "usernameLabelConnexion";
            this.usernameLabelConnexion.Size = new System.Drawing.Size(90, 13);
            this.usernameLabelConnexion.TabIndex = 0;
            this.usernameLabelConnexion.Text = "Nom d\'utilisateur :";
            // 
            // inscriptionTabPage
            // 
            this.inscriptionTabPage.Controls.Add(this.inscriptionOk);
            this.inscriptionTabPage.Controls.Add(this.errorPassword);
            this.inscriptionTabPage.Controls.Add(this.errorUsername);
            this.inscriptionTabPage.Controls.Add(this.label3);
            this.inscriptionTabPage.Controls.Add(this.confirmPassword);
            this.inscriptionTabPage.Controls.Add(this.inscription);
            this.inscriptionTabPage.Controls.Add(this.passwordInscription);
            this.inscriptionTabPage.Controls.Add(this.label2);
            this.inscriptionTabPage.Controls.Add(this.usernameInscription);
            this.inscriptionTabPage.Controls.Add(this.label1);
            this.inscriptionTabPage.Location = new System.Drawing.Point(4, 22);
            this.inscriptionTabPage.Name = "inscriptionTabPage";
            this.inscriptionTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.inscriptionTabPage.Size = new System.Drawing.Size(313, 197);
            this.inscriptionTabPage.TabIndex = 1;
            this.inscriptionTabPage.Text = "Inscription";
            this.inscriptionTabPage.UseVisualStyleBackColor = true;
            // 
            // inscriptionOk
            // 
            this.inscriptionOk.AutoSize = true;
            this.inscriptionOk.ForeColor = System.Drawing.Color.SteelBlue;
            this.inscriptionOk.Location = new System.Drawing.Point(119, 3);
            this.inscriptionOk.Name = "inscriptionOk";
            this.inscriptionOk.Size = new System.Drawing.Size(97, 13);
            this.inscriptionOk.TabIndex = 9;
            this.inscriptionOk.Text = "Inscription réussie !";
            this.inscriptionOk.Visible = false;
            // 
            // errorPassword
            // 
            this.errorPassword.AutoSize = true;
            this.errorPassword.ForeColor = System.Drawing.Color.Red;
            this.errorPassword.Location = new System.Drawing.Point(50, 147);
            this.errorPassword.Name = "errorPassword";
            this.errorPassword.Size = new System.Drawing.Size(236, 13);
            this.errorPassword.TabIndex = 8;
            this.errorPassword.Text = "Les deux mots de passes doivent être identiques";
            this.errorPassword.Visible = false;
            // 
            // errorUsername
            // 
            this.errorUsername.AutoSize = true;
            this.errorUsername.ForeColor = System.Drawing.Color.Red;
            this.errorUsername.Location = new System.Drawing.Point(87, 58);
            this.errorUsername.Name = "errorUsername";
            this.errorUsername.Size = new System.Drawing.Size(157, 13);
            this.errorUsername.TabIndex = 7;
            this.errorUsername.Text = "Ce nom d\'utilisateur est déjà pris";
            this.errorUsername.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Confirmez le mot de passe :";
            // 
            // confirmPassword
            // 
            this.confirmPassword.Location = new System.Drawing.Point(118, 124);
            this.confirmPassword.Name = "confirmPassword";
            this.confirmPassword.Size = new System.Drawing.Size(100, 20);
            this.confirmPassword.TabIndex = 5;
            this.confirmPassword.UseSystemPasswordChar = true;
            // 
            // inscription
            // 
            this.inscription.Location = new System.Drawing.Point(118, 162);
            this.inscription.Margin = new System.Windows.Forms.Padding(2);
            this.inscription.Name = "inscription";
            this.inscription.Size = new System.Drawing.Size(98, 21);
            this.inscription.TabIndex = 4;
            this.inscription.Text = "S\'inscrire";
            this.inscription.UseVisualStyleBackColor = true;
            this.inscription.Click += new System.EventHandler(this.inscription_Click);
            // 
            // passwordInscription
            // 
            this.passwordInscription.Location = new System.Drawing.Point(118, 86);
            this.passwordInscription.Margin = new System.Windows.Forms.Padding(2);
            this.passwordInscription.Name = "passwordInscription";
            this.passwordInscription.Size = new System.Drawing.Size(100, 20);
            this.passwordInscription.TabIndex = 3;
            this.passwordInscription.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mot de passe :";
            // 
            // usernameInscription
            // 
            this.usernameInscription.Location = new System.Drawing.Point(118, 35);
            this.usernameInscription.Name = "usernameInscription";
            this.usernameInscription.Size = new System.Drawing.Size(100, 20);
            this.usernameInscription.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom d\'utilisateur :";
            // 
            // errorConnexion
            // 
            this.errorConnexion.AutoSize = true;
            this.errorConnexion.ForeColor = System.Drawing.Color.Red;
            this.errorConnexion.Location = new System.Drawing.Point(107, 3);
            this.errorConnexion.Name = "errorConnexion";
            this.errorConnexion.Size = new System.Drawing.Size(107, 13);
            this.errorConnexion.TabIndex = 5;
            this.errorConnexion.Text = "Identifiants incorrects";
            this.errorConnexion.Visible = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 223);
            this.Controls.Add(this.conInscrTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainWindow";
            this.Text = "Projet IHM 2015-2016";
            this.conInscrTabControl.ResumeLayout(false);
            this.connexionTabPage.ResumeLayout(false);
            this.connexionTabPage.PerformLayout();
            this.inscriptionTabPage.ResumeLayout(false);
            this.inscriptionTabPage.PerformLayout();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox usernameInscription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passwordInscription;
        private System.Windows.Forms.Button inscription;
        private System.Windows.Forms.TextBox confirmPassword;
        private System.Windows.Forms.Label errorPassword;
        private System.Windows.Forms.Label errorUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label inscriptionOk;
        private System.Windows.Forms.Label errorConnexion;
    }
}