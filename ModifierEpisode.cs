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

        private void ChoixSaison_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChoixNumEpiLabel.Visible = false;
            ChoixNumEpi.Visible = false;
            NomEpi.Visible = false;
            ChampNomEpi.Visible = false;
            ResumeLabel.Visible = false;
            ResumeEpisode.Visible = false;
            labelDate.Visible = false;
            date.Visible = false;
            Modifier.Visible = false;

            if (ChoixSaison.SelectedIndex != -1)
            {
                string serie = ChoixSerie.SelectedItem.ToString().Replace("'", "''");
                string saison = ChoixSaison.SelectedItem.ToString();
                string numSaison = saison.Substring(saison.Length - 1, 1);
                decimal noSaison = decimal.Parse(numSaison);

                ChoixNumEpi.Items.Clear();
                commande = string.Format("SELECT * FROM PROJET_IHM_EPISODE WHERE NOMSERIE='{0}' AND NUMEROSAISON={1}", serie, noSaison);
                DataSet ds = bdd.Select(commande);

                foreach (DataRow r in ds.Tables["Data"].Rows)
                {
                    decimal num = (decimal)r["NUMEPISODE"];
                    ChoixNumEpi.Items.Add(string.Format("Épisode {0} : {1}", num, (string)r["NOMEPISODE"]));
                }

                ChoixNumEpiLabel.Visible = true;
                ChoixNumEpi.Visible = true;
            }
        }

        private void ChoixSerie_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChoixSaisonLabel.Visible = false;
            ChoixSaison.Visible = false;
            ChoixNumEpiLabel.Visible = false;
            ChoixNumEpi.Visible = false;
            NomEpi.Visible = false;
            ChampNomEpi.Visible = false;
            ResumeLabel.Visible = false;
            ResumeEpisode.Visible = false;
            labelDate.Visible = false;
            date.Visible = false;
            Modifier.Visible = false;

            if (ChoixSerie.SelectedIndex != -1)
            {
                string serie = ChoixSerie.SelectedItem.ToString().Replace("'", "''");
                ChoixSaisonLabel.Visible = true;

                ChoixSaison.Items.Clear();
                commande = string.Format("SELECT * FROM PROJET_IHM_SAISON WHERE NOMSERIE='{0}'", serie);
                DataSet ds = bdd.Select(commande);

                foreach (DataRow r in ds.Tables["Data"].Rows)
                {
                    decimal num = (decimal)r["NUMEROSAISON"];
                    ChoixSaison.Items.Add(string.Format("Saison {0}", num));
                }

                ChoixSaison.Visible = true;
            }
        }

        private void ChoixNumEpi_SelectedIndexChanged(object sender, EventArgs e)
        {
            NomEpi.Visible = false;
            ChampNomEpi.Visible = false;
            ResumeLabel.Visible = false;
            ResumeEpisode.Visible = false;
            labelDate.Visible = false;
            date.Visible = false;
            Modifier.Visible = false;

            if (ChoixNumEpi.SelectedIndex != -1)
            {
                decimal numEpisode = Decimal.Parse(ChoixNumEpi.SelectedItem.ToString().Substring("Episode ".Length, 1));

                string serie = ChoixSerie.SelectedItem.ToString().Replace("'", "''");
                string saison = ChoixSaison.SelectedItem.ToString();
                string numSaison = saison.Substring(saison.Length - 1, 1);
                decimal noSaison = decimal.Parse(numSaison);

                commande = string.Format("SELECT * FROM PROJET_IHM_EPISODE WHERE NOMSERIE='{0}' AND NUMEROSAISON={1} AND NUMEPISODE={2}", serie, noSaison, numEpisode);
                DataSet ds = bdd.Select(commande);

                ChampNomEpi.Text = (string)ds.Tables["Data"].Rows[0]["NOMEPISODE"];

                if (ds.Tables["Data"].Rows[0]["SYNOPSIS"].ToString() != "")
                    ResumeEpisode.Text = (string)ds.Tables["Data"].Rows[0]["SYNOPSIS"];

                DateTime datet = Convert.ToDateTime(ds.Tables["Data"].Rows[0]["DATEDIFFUSION"]);
                date.Value = datet;

                NomEpi.Visible = true;
                ChampNomEpi.Visible = true;
                ResumeLabel.Visible = true;
                ResumeEpisode.Visible = true;
                labelDate.Visible = true;
                date.Visible = true;
                Modifier.Visible = true;
            }
        }
    }
}
