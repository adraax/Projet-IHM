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
    public partial class SuppressionSaison : Form
    {
        private string commande;
        private ConnexionOracle bdd;
        private DataSet ds;

        public SuppressionSaison()
        {
            InitializeComponent();
            bdd = new ConnexionOracle();
        }

        private void SuppressionSaison_Load(object sender, EventArgs e)
        {
            labelSaison.Visible = false;
            listeSaison.Visible = false;
            suppression.Visible = false;

            commande = "SELECT * FROM PROJET_IHM_SERIE";
            ds = bdd.Select(commande);

            foreach (DataRow r in ds.Tables["Data"].Rows)
                listeSerie.Items.Add((string)r["NOM"]);
        }

        private void listeSerie_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelSaison.Visible = false;
            listeSaison.Visible = false;
            suppression.Visible = false;

            if (listeSerie.SelectedIndex != -1)
            {
                commande = string.Format("SELECT * FROM PROJET_IHM_SAISON WHERE NOMSERIE='{0}'", listeSerie.SelectedItem.ToString().Replace("'", "''"));
                ds = bdd.Select(commande);

                listeSaison.Items.Clear();
                foreach (DataRow r in ds.Tables["Data"].Rows)
                    listeSaison.Items.Add(string.Format("Saison {0}", (decimal)r["NUMEROSAISON"]));

                labelSaison.Visible = true;
                listeSaison.Visible = true;
            }
        }

        private void listeSaison_SelectedIndexChanged(object sender, EventArgs e)
        {
            suppression.Visible = false;
            if (listeSaison.SelectedIndex != -1)
                suppression.Visible = true;
        }

        private void suppression_Click(object sender, EventArgs e)
        {
            commande = string.Format("DELETE FROM PROJET_IHM_SAISON WHERE NOMSERIE='{0}' AND NUMEROSAISON={1}", listeSerie.SelectedItem.ToString().Replace("'", "''"), Decimal.Parse(listeSaison.SelectedItem.ToString().Substring(listeSaison.SelectedItem.ToString().Length-1)));
            bdd.Delete(commande);
            this.Dispose();
        }
    }
}
