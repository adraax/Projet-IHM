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
    public partial class SuppressionMediaSerie : Form
    {
        private string commande;
        private ConnexionOracle bdd;
        private DataSet ds;

        public SuppressionMediaSerie()
        {
            InitializeComponent();
            bdd = new ConnexionOracle();
        }

        private void SuppressionMediaSerie_Load(object sender, EventArgs e)
        {
            labelMedia.Visible = false;
            listeMedia.Visible = false;
            suppression.Visible = false;

            commande = "SELECT * FROM PROJET_IHM_SERIE";
            ds = bdd.Select(commande);

            foreach (DataRow r in ds.Tables["Data"].Rows)
                listeSerie.Items.Add((string)r["NOM"]);
        }

        private void listeSerie_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelMedia.Visible = false;
            listeMedia.Visible = false;
            suppression.Visible = false;

            if (listeSerie.SelectedIndex != -1)
            {
                commande = string.Format("SELECT * FROM PROJET_IHM_MEDIA WHERE NOMSERIE='{0}' AND NUMEROSAISON IS NULL AND NUMEROEPISODE IS NULL", listeSerie.SelectedItem.ToString().Replace("'", "''"));
                ds = bdd.Select(commande);

                listeMedia.Items.Clear();
                foreach (DataRow r in ds.Tables["Data"].Rows)
                    listeMedia.Items.Add((string)r["CHEMIN"]);

                labelMedia.Visible = true;
                listeMedia.Visible = true;
            }
        }

        private void listeMedia_SelectedIndexChanged(object sender, EventArgs e)
        {
            suppression.Visible = false;

            if (listeMedia.SelectedIndex != -1)
                suppression.Visible = true;
        }

        private void suppression_Click(object sender, EventArgs e)
        {
            commande = string.Format("DELETE FROM PROJET_IHM_MEDIA WHERE NOMSERIE='{0}' AND NUMEROSAISON IS NULL AND NUMEROEPISODE IS NULL AND CHEMIN='{1}'", listeSerie.SelectedItem.ToString().Replace("'", "''"), listeMedia.SelectedItem.ToString());
            bdd.Delete(commande);

            this.Dispose();
        }
    }
}
