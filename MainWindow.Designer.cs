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
            this.label2 = new System.Windows.Forms.Label();
            this.usernameInscription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
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
            this.conInscrTabControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.conInscrTabControl.Name = "conInscrTabControl";
            this.conInscrTabControl.SelectedIndex = 0;
            this.conInscrTabControl.Size = new System.Drawing.Size(428, 197);
            this.conInscrTabControl.TabIndex = 3;
            // 
            // connexionTabPage
            // 
            this.connexionTabPage.Controls.Add(this.connexion);
            this.connexionTabPage.Controls.Add(this.passwordConnexion);
            this.connexionTabPage.Controls.Add(this.passwordLabelConnexion);
            this.connexionTabPage.Controls.Add(this.usernameConnexion);
            this.connexionTabPage.Controls.Add(this.usernameLabelConnexion);
            this.connexionTabPage.Location = new System.Drawing.Point(4, 25);
            this.connexionTabPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.connexionTabPage.Name = "connexionTabPage";
            this.connexionTabPage.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.connexionTabPage.Size = new System.Drawing.Size(420, 168);
            this.connexionTabPage.TabIndex = 0;
            this.connexionTabPage.Text = "Connexion";
            this.connexionTabPage.UseVisualStyleBackColor = true;
            // 
            // connexion
            // 
            this.connexion.Location = new System.Drawing.Point(143, 111);
            this.connexion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.connexion.Name = "connexion";
            this.connexion.Size = new System.Drawing.Size(133, 28);
            this.connexion.TabIndex = 4;
            this.connexion.Text = "Connexion";
            this.connexion.UseVisualStyleBackColor = true;
            this.connexion.Click += new System.EventHandler(this.connexion_Click);
            // 
            // passwordConnexion
            // 
            this.passwordConnexion.Location = new System.Drawing.Point(143, 78);
            this.passwordConnexion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.passwordConnexion.Name = "passwordConnexion";
            this.passwordConnexion.PasswordChar = '*';
            this.passwordConnexion.Size = new System.Drawing.Size(132, 22);
            this.passwordConnexion.TabIndex = 3;
            // 
            // passwordLabelConnexion
            // 
            this.passwordLabelConnexion.AutoSize = true;
            this.passwordLabelConnexion.Location = new System.Drawing.Point(143, 57);
            this.passwordLabelConnexion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwordLabelConnexion.Name = "passwordLabelConnexion";
            this.passwordLabelConnexion.Size = new System.Drawing.Size(101, 17);
            this.passwordLabelConnexion.TabIndex = 2;
            this.passwordLabelConnexion.Text = "Mot de passe :";
            // 
            // usernameConnexion
            // 
            this.usernameConnexion.Location = new System.Drawing.Point(143, 23);
            this.usernameConnexion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.usernameConnexion.Name = "usernameConnexion";
            this.usernameConnexion.Size = new System.Drawing.Size(132, 22);
            this.usernameConnexion.TabIndex = 1;
            // 
            // usernameLabelConnexion
            // 
            this.usernameLabelConnexion.AutoSize = true;
            this.usernameLabelConnexion.Location = new System.Drawing.Point(139, 4);
            this.usernameLabelConnexion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.usernameLabelConnexion.Name = "usernameLabelConnexion";
            this.usernameLabelConnexion.Size = new System.Drawing.Size(121, 17);
            this.usernameLabelConnexion.TabIndex = 0;
            this.usernameLabelConnexion.Text = "Nom d\'utilisateur :";
            // 
            // inscriptionTabPage
            // 
            this.inscriptionTabPage.Controls.Add(this.button1);
            this.inscriptionTabPage.Controls.Add(this.textBox1);
            this.inscriptionTabPage.Controls.Add(this.label2);
            this.inscriptionTabPage.Controls.Add(this.usernameInscription);
            this.inscriptionTabPage.Controls.Add(this.label1);
            this.inscriptionTabPage.Location = new System.Drawing.Point(4, 25);
            this.inscriptionTabPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inscriptionTabPage.Name = "inscriptionTabPage";
            this.inscriptionTabPage.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inscriptionTabPage.Size = new System.Drawing.Size(420, 168);
            this.inscriptionTabPage.TabIndex = 1;
            this.inscriptionTabPage.Text = "Inscription";
            this.inscriptionTabPage.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mot de passe :";
            // 
            // usernameInscription
            // 
            this.usernameInscription.Location = new System.Drawing.Point(155, 23);
            this.usernameInscription.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.usernameInscription.Name = "usernameInscription";
            this.usernameInscription.Size = new System.Drawing.Size(132, 22);
            this.usernameInscription.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(164, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom d\'utilisateur :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(155, 72);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 22);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(155, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 26);
            this.button1.TabIndex = 4;
            this.button1.Text = "S\'inscrire";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 197);
            this.Controls.Add(this.conInscrTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}