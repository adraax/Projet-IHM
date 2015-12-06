using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main_project_VERON_MERLIN
{
    public partial class AccueilUser : Form
    {
        private ConnexionOracle bdd;
        private DataSet ds;
        private string commande;

        public AccueilUser()
        {
            InitializeComponent();
            bdd = new ConnexionOracle();

            commande = $"SELECT NOMSERIE FROM PROJET_IHM_SUIVI_SERIE WHERE NOMUTILISATEUR='{Properties.Settings.Default.username}' ORDER BY NOMSERIE";
            ds = bdd.Select(commande);

            foreach (DataRow r in ds.Tables["Data"].Rows)
            {
                suiviListe.Items.Add((string)r["NOMSERIE"]);
            }

            commande = $"SELECT NOM FROM PROJET_IHM_SERIE ORDER BY NOM";
            ds = bdd.Select(commande);

            foreach (DataRow r in ds.Tables["Data"].Rows)
            {
                serieListe.Items.Add((string)r["NOM"]);
            }
        }

        private void AcceuilUser_Load(object sender, EventArgs e)
        {
            this.Text = $"Accueil {Properties.Settings.Default.username}";

            if (Properties.Settings.Default.admin)
            {
                ajouterToolStripMenuItem.Visible = true;
                modifierToolStripMenuItem.Visible = true;
                supprimerToolStripMenuItem.Visible = true;
            }
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Trace.WriteLine("-- Accueil User : fermeture de l'application");
            Application.Exit();
        }

        private void déconnexionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //réinitialisation des propriétés
            Properties.Settings.Default.username = "";
            Properties.Settings.Default.admin = false;
            Properties.Settings.Default.Save();

            Trace.WriteLine("-- Accueil User : déconnexion");

            this.Dispose();
        }

        private void ajouterUneSérieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Trace.WriteLine("-- Accueil Utilisateur -> Ajout série");
            AjoutSerie ajoutS = new AjoutSerie();
            ajoutS.ShowDialog();
        }

        private void ajouterUneSaisonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Trace.WriteLine("-- Accueil Utilisateur -> Ajout saison");
            AjoutSaison ajoutS = new AjoutSaison();
            ajoutS.ShowDialog();
        }

        private void ajouterUnEpisodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Trace.WriteLine("-- Accueil Utilisateur -> Ajout épisode");
            AjoutEpisode ajoutE = new AjoutEpisode();
            ajoutE.ShowDialog();
        }
    }
}
