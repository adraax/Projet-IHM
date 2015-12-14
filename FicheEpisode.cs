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
    public partial class FicheEpisode : Form
    {
        private ConnexionOracle bdd;
        private DataSet ds;
        private string commande;
        public FicheEpisode()
        {
            InitializeComponent();
            bdd = new ConnexionOracle();
        }

        private void FicheEpisode_Load(object sender, EventArgs e)
        {
            this.Text = string.Format("Fiche {0} - saison {1} - épisode {2}", Properties.Settings.Default.serie, Properties.Settings.Default.saison, Properties.Settings.Default.episode);

            commande = string.Format("SELECT NUMEPISODE, NOMEPISODE, SYNOPSIS, DATEDIFFUSION FROM PROJET_IHM_EPISODE WHERE NOMSERIE='{0}' AND NUMEROSAISON={1}", Properties.Settings.Default.serie, Properties.Settings.Default.saison);
            ds = bdd.Select(commande);

            nomEpisode.Text = (string)ds.Tables["Data"].Rows[0]["NOMEPISODE"];
            synopsis.Text = (string)ds.Tables["Data"].Rows[0]["SYNOPSIS"];
            DateTime date = Convert.ToDateTime(ds.Tables["Data"].Rows[0]["DATEDIFFUSION"]);
            dateDiff.Text = string.Format("Diffusé le : {0}", date.ToString("d"));

            commande = string.Format("SELECT * FROM PROJET_IHM_MEDIA WHERE NOMSERIE='{0}' AND NUMEROSAISON={1} AND NUMEROEPISODE={2}", Properties.Settings.Default.serie, Properties.Settings.Default.saison, Properties.Settings.Default.episode);

            ds = bdd.Select(commande);
            if (ds.Tables["Data"].Rows.Count != 0)
                media.Text = "Afficher la liste des médias";
            else
            {
                media.Text = "Aucuns médias pour cet épisode";
                media.Enabled = false;
            }
        }
    }
}
