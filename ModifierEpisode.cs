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
    public partial class ModifierEpisode : Form
    {
        private string commande;
        private ConnexionOracle bdd;
        public ModifierEpisode()
        {
            InitializeComponent();
            bdd = new ConnexionOracle();

            commande = "SELECT NOM FROM PROJET_IHM_SERIE";
            DataSet ds = bdd.Select(commande);

            foreach (DataRow r in ds.Tables["Data"].Rows)
            {
                ChoixSerie.Items.Add((string)r["NOM"]);
            }
        }

        private void ChoixSerieLabel_Click(object sender, EventArgs e)
        {

        }

        private void ResumeLabel_Click(object sender, EventArgs e)
        {

        }

        private void PanelModifEpisode_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ChoixSaison_SelectedIndexChanged(object sender, EventArgs e)
        {
            string serie = ChoixSerie.Items[ChoixSerie.SelectedIndex].ToString().Replace("'", "''");
            string saison = ChoixSaison.Items[ChoixSaison.SelectedIndex].ToString();
            string numSaison = saison.Substring(saison.Length - 1);
            decimal noSaison = decimal.Parse(numSaison);

            Trace.WriteLine(string.Format("-- Modif' épisode : saison {0} selectionnée", noSaison));


            ChoixNumEpi.Items.Clear();
            commande = string.Format("SELECT NUMEPISODE FROM PROJET_IHM_EPISODE WHERE NOMSERIE = {0} AND NUMEROSAISON={1}", serie, noSaison);
            DataSet ds = bdd.Select(commande);

            foreach (DataRow r in ds.Tables["Data"].Rows)
            {
                decimal num = (decimal)r["NUMEPISODE"];
                ChoixNumEpi.Items.Add(string.Format("Épisode {0}", num));
            }

            NomEpi.Visible = true;
            ChampNomEpi.Visible = true;
        }

        private void ChoixSerie_SelectedIndexChanged(object sender, EventArgs e)
        {
            string serie = ChoixSerie.Items[ChoixSerie.SelectedIndex].ToString().Replace("'", "''");
            Trace.WriteLine(string.Format("-- Modif épisode : série {0} selectionnée", serie));
            ChoixSaisonLabel.Visible = true;

            ChoixSaison.Items.Clear();

            commande = string.Format("SELECT NUMEROSAISON FROM PROJET_IHM_SAISON WHERE NOMSERIE='{0}'", serie);
            DataSet ds = bdd.Select(commande);

            foreach (DataRow r in ds.Tables["Data"].Rows)
            {
                decimal num = (decimal)r["NUMEROSAISON"];
                ChoixSaison.Items.Add(string.Format("Saison {0}", num));
            }

            ChoixSaison.Visible = true;
        }
    }
}
