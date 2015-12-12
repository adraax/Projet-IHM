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
    public partial class AjoutMediaSerie : Form
    {
        private string commande;
        private DataSet ds;
        private ConnexionOracle bdd;
        public AjoutMediaSerie()
        {
            InitializeComponent();
            bdd = new ConnexionOracle();
        }

        private void typeMedia_SelectedIndexChanged(object sender, EventArgs e)
        {
            cheminLabel.Visible = false;
            cheminTextBox.Visible = false;
            parcourir.Visible = false;
            valider.Visible = false;

            if (typeMedia.SelectedIndex != -1)
            {
                Properties.Settings.Default.typeMedia = typeMedia.SelectedItem.ToString();
                Properties.Settings.Default.Save();

                cheminLabel.Visible = true;
                cheminTextBox.Visible = true;
                parcourir.Visible = true;
            }
        }

        private void listeSerie_SelectedIndexChanged(object sender, EventArgs e)
        {
            typeLabel.Visible = false;
            typeMedia.Visible = false;
            cheminLabel.Visible = false;
            cheminTextBox.Visible = false;
            parcourir.Visible = false;
            valider.Visible = false;

            if (listeSerie.SelectedIndex != -1)
            {
                Properties.Settings.Default.serie = listeSerie.SelectedItem.ToString();
                Properties.Settings.Default.Save();

                typeLabel.Visible = true;
                typeMedia.Visible = true;
            }
        }

        private void AjoutMediaSerie_Load(object sender, EventArgs e)
        {
            commande = string.Format("SELECT NOM FROM PROJET_IHM_SERIE");
            ds = bdd.Select(commande);

            foreach (DataRow r in ds.Tables["Data"].Rows)
                listeSerie.Items.Add((string)r["NOM"]);
        }
    }
}
