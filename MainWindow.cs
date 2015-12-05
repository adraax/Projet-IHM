using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using System.Data.Common;
using System.Diagnostics;

namespace Main_project_VERON_MERLIN
{
    public partial class MainWindow : Form
    {
        private ConnexionOracle bdd;
        public MainWindow()
        {
            InitializeComponent();
            bdd = new ConnexionOracle(); //Objet servant aux requêtes vers la BD

            //réinitialisation des propriétés
            Properties.Settings.Default.username = "";
            Properties.Settings.Default.admin = false;
            Properties.Settings.Default.Save();
        }

        private void connexion_Click(object sender, EventArgs e)
        {
            errorConnexion.Visible = false;
            string commande = $"SELECT * FROM PROJET_IHM_USERS WHERE USERNAME = '{usernameConnexion.Text}' AND PASSWORD = '{passwordConnexion.Text}'";
            DataSet ds = bdd.Select(commande);


            if (ds.Tables["Data"].Rows.Count == 1)
            {
                this.Visible = false;
                Trace.WriteLine("-- Connexion réussie -> ouverture accueil");

                Properties.Settings.Default.username = (string)ds.Tables["Data"].Rows[0]["USERNAME"];

                if ((string)(ds.Tables["Data"].Rows[0]["ADMIN"]) == "1")
                    Properties.Settings.Default.admin = true;
                else
                    Properties.Settings.Default.admin = false;
                Properties.Settings.Default.Save();

                AccueilUser acceuil = new AccueilUser();
                acceuil.ShowDialog();

                this.Visible = true;//affichage de la connexion après fermeture de l'accueil
            }
            else
            {
                Trace.WriteLine("-- Connexion : Erreur Identifiants");
                errorConnexion.Visible = true;
            }
        }

        private void inscription_Click(object sender, EventArgs e)
        {
            errorUsername.Visible = false;
            errorPassword.Visible = false;
            inscriptionOk.Visible = false;

            if (usernameInscription.Text != string.Empty)
            {
                string commande = $"SELECT * FROM PROJET_IHM_USERS WHERE USERNAME = '{usernameInscription.Text}' ";
                DataSet ds = bdd.Select(commande);

                if (ds.Tables["Data"].Rows.Count != 0)
                {
                    errorUsername.Visible = true;
                    Trace.WriteLine("-- Inscription : username déjà utilisé");
                }

                if (passwordInscription.Text != string.Empty && confirmPassword.Text != string.Empty)
                {
                    if (passwordInscription.Text != confirmPassword.Text)
                    {
                        errorPassword.Visible = true;
                        Trace.WriteLine("-- Inscription : password non identiques");
                    }
                    else
                    {
                        commande = $"INSERT INTO PROJET_IHM_USERS VALUES('{usernameInscription.Text}', '{passwordInscription.Text}', '0')";
                        bdd.Insert(commande);
                        inscriptionOk.Visible = true;
                        Trace.WriteLine("-- Inscription réussie");
                    }
                }
            }
        }
    }
}
