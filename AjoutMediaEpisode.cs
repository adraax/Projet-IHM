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
    public partial class AjoutMediaEpisode : Form
    {
        private string commande;
        private ConnexionOracle bdd;
        private DataSet ds;
        private decimal nbSaison;
        private decimal nbEpisode;
        public AjoutMediaEpisode()
        {
            InitializeComponent();
            bdd = new ConnexionOracle();
        }

        private void listeSerie_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelSaison.Visible = false;
            listeSaison.Visible = false;
            labelEpisode.Visible = false;
            listeEpisode.Visible = false;
            labelType.Visible = false;
            listeType.Visible = false;
            labelMedia.Visible = false;
            cheminMedia.Visible = false;
            parcourir.Visible = false;
            ajouter.Visible = false;

            if (listeSerie.SelectedIndex != -1)
            {
                Properties.Settings.Default.serie = listeSerie.SelectedItem.ToString().Replace("'", "''");
                Properties.Settings.Default.Save();

                commande = string.Format("SELECT NBSAISON FROM PROJET_IHM_SERIE WHERE NOM='{0}'", Properties.Settings.Default.serie);
                ds = bdd.Select(commande);

                nbSaison = (decimal)ds.Tables["Data"].Rows[0]["NBSAISON"];

                commande = string.Format("SELECT NUMEROSAISON FROM PROJET_IHM_SAISON WHERE NOMSERIE='{0}'", Properties.Settings.Default.serie);
                ds = bdd.Select(commande);

                foreach (DataRow r in ds.Tables["Data"].Rows)
                    listeSaison.Items.Add((string)r["NOMSERIE"]);

                labelSaison.Visible = true;
                listeSaison.Visible = true;
            }
        }

        private void AjoutMediaEpisode_Load(object sender, EventArgs e)
        {
            commande = string.Format("SELECT NOM FROM PROJET_IHM_SERIE");
            ds = bdd.Select(commande);

            foreach (DataRow r in ds.Tables["Data"].Rows)
                listeSerie.Items.Add((string)r["NOM"]);
        }
    }
}
