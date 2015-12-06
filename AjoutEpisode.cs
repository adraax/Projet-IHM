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
            Trace.WriteLine($"-- Ajout épisode : série {serie} selectionnée");
            saisonLabel.Visible = true;

            listeSaison.Items.Clear();

            commande = $"SELECT NUMEROSAISON FROM PROJET_IHM_SAISON WHERE NOMSERIE='{serie}'";
            DataSet ds = bdd.Select(commande);

            foreach (DataRow r in ds.Tables["Data"].Rows)
            {
                decimal num = (decimal)r["NUMEROSAISON"];
                listeSaison.Items.Add($"Saison {num}");
            }

            listeSaison.Visible = true;
        }

        private void listeSaison_SelectedIndexChanged(object sender, EventArgs e)
        {
            string serie = listeSerie.Items[listeSerie.SelectedIndex].ToString();
            string saison = listeSaison.Items[listeSaison.SelectedIndex].ToString();
            string numSaison = saison.Substring(saison.Length - 1);
            decimal noSaison = decimal.Parse(numSaison);

            Trace.WriteLine($"-- Ajout épisode : saison {noSaison} selectionnée");

            listeEpisode.Items.Clear();
            for (int i = 1; i <= 30; i++)
                listeEpisode.Items.Add($"Épisode {i}");

            commande = $"SELECT NUMEPISODE FROM PROJET_IHM_EPISODE WHERE NOMSERIE='{serie}' AND NUMEROSAISON={noSaison}";
            DataSet ds = bdd.Select(commande);

            foreach (DataRow r in ds.Tables["Data"].Rows)
            {
                decimal num = (decimal)r["NUMEPISODE"];
                listeEpisode.Items.Remove($"Épisode {num}");
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

            Trace.WriteLine($"-- Ajout Épisode : ajout de l'épisode {noEpisode} à la saison {noSaison} de la série {serie}");

            commande = $"INSERT INTO PROJET_IHM_EPISODE VALUES('{serie}', {noSaison}, {noEpisode}, '{synopsisEpisode}', '{nomEpisode}')";
            bdd.Insert(commande);

            this.Dispose();
        }
    }
}
