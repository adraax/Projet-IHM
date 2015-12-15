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
    public partial class FicheMediaEpisode : Form
    {
        private string commande;
        private ConnexionOracle bdd;
        private DataSet ds;

        public FicheMediaEpisode()
        {
            InitializeComponent();
            bdd = new ConnexionOracle();
        }

        private void FicheMediaEpisode_Load(object sender, EventArgs e)
        {
            commande = string.Format("SELECT NUMEPISODE, NOMEPISODE, SYNOPSIS, DATEDIFFUSION FROM PROJET_IHM_EPISODE WHERE NOMSERIE='{0}' AND NUMEROSAISON={1} AND NUMEPISODE={2}", Properties.Settings.Default.serie, Properties.Settings.Default.saison, Properties.Settings.Default.episode);
            ds = bdd.Select(commande);

            this.Text = string.Format("Fiche média {0} - saison {1} - épisode {2} : {3}", Properties.Settings.Default.serie, Properties.Settings.Default.saison, Properties.Settings.Default.episode, (string)ds.Tables["Data"].Rows[0]["NOMEPISODE"]);

            RemplissagePanneau();
        }

        private void RemplissagePanneau()
        {

        }
    }
}
