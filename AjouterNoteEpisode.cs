using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main_project_VERON_MERLIN
{
    public partial class AjouterNoteEpisode : Form
    {
        private string commande;
        private ConnexionOracle bdd;

        public AjouterNoteEpisode()
        {
            InitializeComponent();
            bdd = new ConnexionOracle();
        }

        private void AjouterNoteEpisode_Load(object sender, EventArgs e)
        {
            this.Text = string.Format("Fiche note {0} - saison {1} - épisode {2}", Properties.Settings.Default.serie, Properties.Settings.Default.saison, Properties.Settings.Default.episode);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            commande = string.Format("INSERT INTO PROJET_IHM_NOTE VALUES('{0}', {1}, {2}, '{3}', {4})", Properties.Settings.Default.serie, Properties.Settings.Default.saison, Properties.Settings.Default.episode, Properties.Settings.Default.username, note.Value);

            bdd.Insert(commande);
            this.Dispose();
        }
    }
}
