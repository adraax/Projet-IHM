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
    public partial class FicheSaison : Form
    {
        private ConnexionOracle bdd;
        private string commande;
        DataSet ds;

        public FicheSaison()
        {
            InitializeComponent();
            bdd = new ConnexionOracle();
        }

        private void FicheSaison_Load(object sender, EventArgs e)
        {
            this.Text = string.Format("Fiche {0} - saison {1}", Properties.Settings.Default.serie, Properties.Settings.Default.saison);

            commande = string.Format("SELECT NUMEPISODE, NOMEPISODE FROM PROJET_IHM_EPISODE WHERE NOMSERIE='{0}' AND NUMEROSAISON={1}", Properties.Settings.Default.serie, Properties.Settings.Default.saison);

            ds = bdd.Select(commande);
            listeEpisode.Items.Clear();
            foreach (DataRow r in ds.Tables["Data"].Rows)
            {
                listeEpisode.Items.Add(string.Format("Épisode {0} : {1}", r["NUMEPISODE"], r["NOMEPISODE"]));
            }
        }

        private void listeEpisode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listeEpisode.SelectedIndex != -1)
            {
                string nomEpisode = listeEpisode.SelectedItem.ToString();
                string numEpisode = nomEpisode.Substring("Episode ".Length, 1);
                decimal noEpisode = decimal.Parse(numEpisode);

                Properties.Settings.Default.episode = noEpisode;
                Properties.Settings.Default.Save();

                FicheEpisode f = new FicheEpisode();
                f.ShowDialog();
            }
        }
    }
}
