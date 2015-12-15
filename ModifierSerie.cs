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
    public partial class ModifierSerie : Form
    {
        private string commande;
        private ConnexionOracle bdd;
        private DataSet ds;
        public ModifierSerie()
        {
            InitializeComponent();
            bdd = new ConnexionOracle();

            commande = "SELECT NOM FROM PROJET_IHM_SERIE";
            DataSet ds = bdd.Select(commande);

            foreach (DataRow r in ds.Tables["Data"].Rows)
            {
                ListeSeries.Items.Add((string)r["NOM"]);
            }
        }

        private void Modifier_Click(object sender, EventArgs e)
        {
            SynopsisSerie.Text = SynopsisSerie.Text.Replace("'", "''");
            string serieSelec = ListeSeries.Items[ListeSeries.SelectedIndex].ToString().Replace("'", "''");
            decimal nbsaisons = ChoixNbSaisons.Value;
            commande = string.Format("UPDATE PROJET_IHM_SERIE SET SYNOPSIS='{0}', NBSAISON={1}, ETAT='{3}' WHERE NOM='{2}'",  SynopsisSerie.Text,nbsaisons, serieSelec, ChoixEtatSerie.SelectedItem.ToString());
            bdd.Update(commande);
            Trace.WriteLine("-- Modification série réussie");
            this.Dispose();
        }

        private void ListeSeries_SelectedIndexChanged(object sender, EventArgs e)
        {
            EtatSerie.Visible = false;
            ChoixEtatSerie.Visible = false;
            NbSaisons.Visible = false;
            ChoixNbSaisons.Visible = false;
            NewSynopsis.Visible = false;
            SynopsisSerie.Visible = false;
            Modifier.Visible = false;

            if(ListeSeries.SelectedIndex != -1)
            {
                EtatSerie.Visible = true;
                ChoixEtatSerie.Visible = true;
                NbSaisons.Visible = true;
                ChoixNbSaisons.Visible = true;
                NewSynopsis.Visible = true;
                SynopsisSerie.Visible = true;
                Modifier.Visible = true;

                string s = ListeSeries.SelectedItem.ToString().Replace("'", "''");
                commande = string.Format("SELECT * FROM PROJET_IHM_SERIE WHERE NOM='{0}'", s);
                ds = bdd.Select(commande);

                ChoixEtatSerie.SelectedItem = (string)ds.Tables["Data"].Rows[0]["ETAT"];
                ChoixNbSaisons.Value = (decimal)ds.Tables["Data"].Rows[0]["NBSAISON"];
                SynopsisSerie.Text = (string)ds.Tables["Data"].Rows[0]["SYNOPSIS"];
            }
        }
    }
}
