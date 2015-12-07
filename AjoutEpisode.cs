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
    public partial class AjoutEpisode : Form
    {
        private string commande;
        private ConnexionOracle bdd;
        public AjoutEpisode()
        {
            InitializeComponent();
            bdd = new ConnexionOracle();

            commande = "SELECT NOM FROM PROJET_IHM_SERIE";
            DataSet ds = bdd.Select(commande);

            foreach (DataRow r in ds.Tables["Data"].Rows)
            {
                listeSerie.Items.Add((string)r["NOM"]);
            }
        }

        private void listeSerie_SelectedIndexChanged(object sender, EventArgs e)
        {
            string serie = listeSerie.Items[listeSerie.SelectedIndex].ToString();
            Trace.WriteLine(string.Format("-- Ajout épisode : série {0} selectionnée", serie));
            saisonLabel.Visible = true;

            listeSaison.Items.Clear();

            commande = string.Format("SELECT NUMEROSAISON FROM PROJET_IHM_SAISON WHERE NOMSERIE='{0}'", serie);
            DataSet ds = bdd.Select(commande);

            foreach (DataRow r in ds.Tables["Data"].Rows)
            {
                decimal num = (decimal)r["NUMEROSAISON"];
                listeSaison.Items.Add(string.Format("Saison {0}", num));
            }

            listeSaison.Visible = true;
        }

        private void listeSaison_SelectedIndexChanged(object sender, EventArgs e)
        {
            string serie = listeSerie.Items[listeSerie.SelectedIndex].ToString();
            string saison = listeSaison.Items[listeSaison.SelectedIndex].ToString();
            string numSaison = saison.Substring(saison.Length - 1);
            decimal noSaison = decimal.Parse(numSaison);

            Trace.WriteLine(string.Format("-- Ajout épisode : saison {0} selectionnée", noSaison));

            listeEpisode.Items.Clear();
            for (int i = 1; i <= 30; i++)
                listeEpisode.Items.Add(string.Format("Épisode {0}", i));

            commande = string.Format("SELECT NUMEPISODE FROM PROJET_IHM_EPISODE WHERE NOMSERIE='{0}' AND NUMEROSAISON={1}", serie, noSaison);
            DataSet ds = bdd.Select(commande);

            foreach (DataRow r in ds.Tables["Data"].Rows)
            {
                decimal num = (decimal)r["NUMEPISODE"];
                listeEpisode.Items.Remove(string.Format("Épisode {0}", num));
            }

            episodeLabel.Visible = true;
            listeEpisode.Visible = true;
        }

        private void listeEpisode_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelNom.Visible = true;
            nomEpisode.Visible = true;
            labelSynopsis.Visible = true;
            synopsisEpisode.Visible = true;
            ajouterEpisode.Visible = true;
        }

        private void ajouterEpisode_Click(object sender, EventArgs e)
        {
            //série
            string serie = listeSerie.Items[listeSerie.SelectedIndex].ToString();
            //saison
            string saison = listeSaison.Items[listeSaison.SelectedIndex].ToString();
            string numSaison = saison.Substring(saison.Length - 1);
            decimal noSaison = decimal.Parse(numSaison);
            //épisode
            string episode = listeEpisode.Items[listeEpisode.SelectedIndex].ToString();
            string numEpisode = episode.Substring(episode.Length - 1);
            decimal noEpisode = decimal.Parse(numEpisode);

            nomEpisode.Text = nomEpisode.Text.Replace("'", "''");
            synopsisEpisode.Text = synopsisEpisode.Text.Replace("'", "''");

            Trace.WriteLine(string.Format("-- Ajout Épisode : ajout de l'épisode {0} à la saison {1} de la série {2}", noEpisode, noSaison, serie));

            commande = string.Format("INSERT INTO PROJET_IHM_EPISODE VALUES('{0}', {1}, {2}, '{3}', '{4}')", serie, noSaison, noEpisode, synopsisEpisode.Text, nomEpisode.Text);
            bdd.Insert(commande);

            this.Dispose();
        }
    }
}
