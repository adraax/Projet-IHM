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
        }

        private void RemplissageListe()
        {
            suiviListe.Items.Clear();

            commande = string.Format("SELECT NOMSERIE FROM PROJET_IHM_SUIVI_SERIE WHERE NOMUTILISATEUR='{0}' ORDER BY NOMSERIE", Properties.Settings.Default.username);
            ds = bdd.Select(commande);

            foreach (DataRow r in ds.Tables["Data"].Rows)
            {
                suiviListe.Items.Add((string)r["NOMSERIE"]);
            }

            serieListe.Items.Clear();

            commande = "SELECT NOM FROM PROJET_IHM_SERIE ORDER BY NOM";
            ds = bdd.Select(commande);

            foreach (DataRow r in ds.Tables["Data"].Rows)
            {
                serieListe.Items.Add((string)r["NOM"]);
            }
        }

        private void AcceuilUser_Load(object sender, EventArgs e)
        {
            this.Text = string.Format("Accueil {0}", Properties.Settings.Default.username);

            if (Properties.Settings.Default.admin)
            {
                ajouterToolStripMenuItem.Visible = true;
                modifierToolStripMenuItem.Visible = true;
                supprimerToolStripMenuItem.Visible = true;
            }

            RemplissageListe();
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

        private void serieListe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (serieListe.SelectedIndex != -1)
            {
                string serie = serieListe.SelectedItem.ToString();
                Properties.Settings.Default.serie = serie;
                Properties.Settings.Default.Save();

                FicheSerie f = new FicheSerie();
                f.ShowDialog();

                RemplissageListe();
            }
        }

        private void suiviListe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (suiviListe.SelectedIndex != -1)
            {
                string serie = suiviListe.SelectedItem.ToString();
                Properties.Settings.Default.serie = serie;
                Properties.Settings.Default.Save();

                FicheSerie f = new FicheSerie();
                f.ShowDialog();

                RemplissageListe();
            }
        }

        private void ajouterUnMédiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.IO.Directory.CreateDirectory("Data");
        }

        private void surUneSérieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AjoutMediaSerie a = new AjoutMediaSerie();
            a.ShowDialog();
        }
    }
}
