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
    public partial class AjoutSaison : Form
    {
        private ConnexionOracle bdd;
        private string commande;
        private DataSet ds;

        public AjoutSaison()
        {
            InitializeComponent();
            bdd = new ConnexionOracle();

            commande = "SELECT NOM FROM PROJET_IHM_SERIE";
            ds = bdd.Select(commande);

            foreach (DataRow r in ds.Tables["Data"].Rows)
            {
                listeSerie.Items.Add((string)r["NOM"]);
            }
        }

        private void listeSaison_SelectedIndexChanged(object sender, EventArgs e)
        {
            nbEpisodeLabel.Visible = false;
            nbEpisode.Visible = false;
            string saison = listeSaison.Items[listeSaison.SelectedIndex].ToString();
            string numSaison = saison.Substring(saison.Length - 1);
            decimal noSaison = decimal.Parse(numSaison);

            Trace.WriteLine(string.Format("-- Ajout saison : saison {0} selectionnée", noSaison));
            nbEpisodeLabel.Visible = true;
            nbEpisode.Visible = true;
            ajouterSaison.Visible = true;
        }

        private void listeSerie_SelectedIndexChanged(object sender, EventArgs e)
        {
            listeSaison.Visible = false;
            ajouterSaison.Visible = false;
            saisonLabel.Visible = false;
            nbEpisodeLabel.Visible = false;
            nbEpisode.Visible = false;

            string serie = listeSerie.Items[listeSerie.SelectedIndex].ToString().Replace("'", "''");
            Trace.WriteLine(string.Format("-- Ajout saison : série {0} selectionnée", serie));
            saisonLabel.Visible = true;

            commande = string.Format("SELECT NBSAISON FROM PROJET_IHM_SERIE WHERE NOM='{0}'", serie);
            ds = bdd.Select(commande);

            listeSaison.Items.Clear();
            for (decimal i = 1; i <= (decimal)ds.Tables["Data"].Rows[0]["NBSAISON"]; i++)
                listeSaison.Items.Add(string.Format("Saison {0}", i));

            commande = string.Format("SELECT NUMEROSAISON FROM PROJET_IHM_SAISON WHERE NOMSERIE='{0}'", serie);
            ds = bdd.Select(commande);

            foreach(DataRow r in ds.Tables["Data"].Rows)
            {
                decimal num = (decimal)r["NUMEROSAISON"];
                listeSaison.Items.Remove(string.Format("Saison {0}", num));
            }

            listeSaison.Visible = true;
        }

        private void ajouterSaison_Click(object sender, EventArgs e)
        {
            string serie = listeSerie.Items[listeSerie.SelectedIndex].ToString().Replace("'", "''");
            string saison = listeSaison.Items[listeSaison.SelectedIndex].ToString();
            string numSaison = saison.Substring(saison.Length - 1);
            decimal noSaison = decimal.Parse(numSaison);

            Trace.WriteLine(string.Format("-- Ajout Saison : ajout de la saison {0} à la série {1}", noSaison, serie));

            commande = string.Format("INSERT INTO PROJET_IHM_SAISON VALUES('{0}', {1}, {2})", serie, noSaison, nbEpisode.Value);
            bdd.Insert(commande);

            this.Dispose();
        }
    }
}
