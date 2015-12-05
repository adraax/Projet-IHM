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
        private bool quitter = false;
        public MainWindow()
        {
            InitializeComponent();
            bdd = new ConnexionOracle(); //Objet servant aux requêtes vers la BD
        }

        private void connexion_Click(object sender, EventArgs e)
        {
            string commande = $"SELECT * FROM PROJET_IHM_USERS WHERE USERNAME = '{usernameConnexion.Text}' AND PASSWORD = '{passwordConnexion.Text}'";
            DataSet ds = bdd.Select(commande);


            if (ds.Tables["Data"].Rows.Count == 1)
            {
                this.Visible = false;
                Trace.WriteLine("-- Utilisateur trouvé, ouverture accueil");

                Properties.Settings.Default.username = (string) ds.Tables["Data"].Rows[0]["USERNAME"];

                if((string)(ds.Tables["Data"].Rows[0]["ADMIN"]) == "1")
                    Properties.Settings.Default.admin = true;
                else
                    Properties.Settings.Default.admin = false;
                Properties.Settings.Default.Save();

            }
            else
                Trace.WriteLine("-- Erreur Identifiants");

            if(quitter)
            {
                Properties.Settings.Default.username = "";
                Properties.Settings.Default.admin = false;
                Properties.Settings.Default.Save();
                this.Dispose();
            }
        }

        private void inscription_Click(object sender, EventArgs e)
        {
            string commande = $"SELECT * FROM PROJET_IHM_USERS WHERE USERNAME = '{usernameConnexion.Text}' ";
            DataSet ds = bdd.Select(commande);
        }
    }
}
