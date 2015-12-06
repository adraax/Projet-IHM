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

        public AccueilUser()
        {
            InitializeComponent();
            bdd = new ConnexionOracle();
        }

        private void AcceuilUser_Load(object sender, EventArgs e)
        {
            this.Text = $"Accueil {Properties.Settings.Default.username}";

            if (Properties.Settings.Default.admin)
                administrationToolStripMenuItem.Visible = true;
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
    }
}
