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
            this.Text = string.Format("Fiche saison {0} - {1} - {2}", Properties.Settings.Default.saison, Properties.Settings.Default.serie, Properties.Settings.Default.episode);

            commande = string.Format("SELECT NUMEPISODE, NOMEPISODE FROM PROJET_IHM_EPISODE WHERE NOMSERIE='{0}' AND NUMEROSAISON={1}", Properties.Settings.Default.serie, Properties.Settings.Default.saison);
            ds = bdd.Select(commande);
            
        }
    }
}
