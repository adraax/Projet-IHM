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
    public partial class SuppressionSerie : Form
    {
        private string commande;
        private ConnexionOracle bdd;
        private DataSet ds;

        public SuppressionSerie()
        {
            InitializeComponent();
            bdd = new ConnexionOracle();
        }

        private void SuppressionSerie_Load(object sender, EventArgs e)
        {
            commande = "SELECT * FROM PROJET_IHM_SERIE";
            ds = bdd.Select(commande);

            foreach (DataRow r in ds.Tables["Data"].Rows)
                listeSerie.Items.Add((string)r["NOM"]);
        }

        private void suppression_Click(object sender, EventArgs e)
        {
            commande = string.Format("DELETE FROM PROJET_IHM_SERIE WHERE NOM='{0}'", listeSerie.SelectedItem.ToString().Replace("'", "''"));
            bdd.Delete(commande);
            this.Dispose();
        }

        private void listeSerie_SelectedIndexChanged(object sender, EventArgs e)
        {
            suppression.Visible = false;

            if (listeSerie.SelectedIndex != -1)
                suppression.Visible = true;
        }
    }
}
