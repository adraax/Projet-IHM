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
        string commande;

        public AjoutSaison()
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

        private void listeSaison_SelectedIndexChanged(object sender, EventArgs e)
        {
            string saison = listeSaison.Items[listeSaison.SelectedIndex].ToString();
            string numSaison = saison.Substring(saison.Length - 1);
            decimal noSaison = decimal.Parse(numSaison);

            Trace.WriteLine($"-- Ajout saison : saison {saison} selectionnée");
            ajouterSaison.Visible = true;
        }

        private void listeSerie_SelectedIndexChanged(object sender, EventArgs e)
        {
            string serie = listeSerie.Items[listeSerie.SelectedIndex].ToString();
            Trace.WriteLine($"-- Ajout saison : série {serie} selectionnée");
            saisonLabel.Visible = true;

            listeSaison.Items.Clear();
            for (int i = 1; i <= 10; i++)
                listeSaison.Items.Add($"Saison {i}");

            commande = $"SELECT NUMEROSAISON FROM PROJET_IHM_SAISON WHERE NOMSERIE='{serie}'";
            DataSet ds = bdd.Select(commande);

            foreach(DataRow r in ds.Tables["Data"].Rows)
            {
                decimal num = (decimal)r["NUMEROSAISON"];
                listeSaison.Items.Remove($"Saison {num}");
            }

            listeSaison.Visible = true;
        }

        private void ajouterSaison_Click(object sender, EventArgs e)
        {
            string serie = listeSerie.Items[listeSerie.SelectedIndex].ToString();
            string saison = listeSaison.Items[listeSaison.SelectedIndex].ToString();
            string numSaison = saison.Substring(saison.Length - 1);
            decimal noSaison = decimal.Parse(numSaison);

            Trace.WriteLine($"-- Ajout Saison : ajout de la saison {noSaison} à la série {serie}");

            commande = $"INSERT INTO PROJET_IHM_SAISON VALUES('{serie}', {noSaison})";
            bdd.Insert(commande);

            this.Dispose();
        }
    }
}
