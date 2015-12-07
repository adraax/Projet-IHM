using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Main_project_VERON_MERLIN
{
    public partial class FicheSerie : Form
    {
        private string commande;
        private ConnexionOracle bdd;
        private DataSet ds;
        public FicheSerie()
        {
            InitializeComponent();
            bdd = new ConnexionOracle();
        }

        private void FicheSerie_Load(object sender, EventArgs e)
        {
            this.Text = $"Fiche {Properties.Settings.Default.serie}";
            nomSerie.Text = Properties.Settings.Default.serie;

            commande = $"SELECT SYNOPSIS FROM PROJET_IHM_SERIE WHERE NOM='{Properties.Settings.Default.serie}'";
            ds = bdd.Select(commande);

            synopsisSerie.Text = (string)ds.Tables["Data"].Rows[0]["SYNOPSIS"];

            commande = $"SELECT NUMEROSAISON FROM PROJET_IHM_SAISON WHERE NOMSERIE='{Properties.Settings.Default.serie}'";
            ds = bdd.Select(commande);

            listeSaison.Items.Clear();
            foreach (DataRow r in ds.Tables["Data"].Rows)
            {
                string saison = $"Saison {(decimal)r["NUMEROSAISON"]}";
                listeSaison.Items.Add(saison);
            }

            commande = $"SELECT * FROM PROJET_IHM_SUIVI_SERIE WHERE NOMSERIE='{Properties.Settings.Default.serie}' AND NOMUTILISATEUR='{Properties.Settings.Default.username}'";
            ds = bdd.Select(commande);

            if(ds.Tables["Data"].Rows.Count == 0)
            {
                Properties.Settings.Default.suivi = false;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.suivi = true;
                Properties.Settings.Default.Save();
                suiviButton.Text = "Ne plus suivre la série";
            }
        }

        private void listeSaison_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nomSaison = listeSaison.SelectedItem.ToString();
            string numSaison = nomSaison.Substring(nomSaison.Length - 1);
            decimal noSaison = decimal.Parse(numSaison);

            Properties.Settings.Default.saison = noSaison;
            Properties.Settings.Default.Save();

            FicheSaison f = new FicheSaison();
            f.ShowDialog();
        }

        private void suiviButton_Click(object sender, EventArgs e)
        {
            if(Properties.Settings.Default.suivi)
            {
                commande = $"DELETE FROM PROJET_IHM_SUIVI_SERIE WHERE NOMSERIE='{Properties.Settings.Default.serie}' AND NOMUTILISATEUR='{Properties.Settings.Default.username}'";
                bdd.Delete(commande);

                Properties.Settings.Default.suivi = false;
                Properties.Settings.Default.Save();
                suiviButton.Text = "Suivre la série";
            }
            else
            {
                commande = $"INSERT INTO PROJET_IHM_SUIVI_SERIE VALUES('{Properties.Settings.Default.serie}', '{Properties.Settings.Default.username}')";
                bdd.Insert(commande);

                Properties.Settings.Default.suivi = true;
                Properties.Settings.Default.Save();
                suiviButton.Text = "Ne plus suivre la série";
            }
        }
    }
}
