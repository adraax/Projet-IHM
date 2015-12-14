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
        private Image image;
        public FicheSerie()
        {
            InitializeComponent();
            bdd = new ConnexionOracle();
        }

        private void FicheSerie_Load(object sender, EventArgs e)
        {
            this.Text = string.Format("Fiche {0}", Properties.Settings.Default.serie);
            nomSerie.Text = Properties.Settings.Default.serie;

            commande = string.Format("SELECT SYNOPSIS, ETAT FROM PROJET_IHM_SERIE WHERE NOM='{0}'", Properties.Settings.Default.serie);
            ds = bdd.Select(commande);

            synopsisSerie.Text = (string)ds.Tables["Data"].Rows[0]["SYNOPSIS"];
            labelEtat.Text = string.Format("État : {0}", (string)ds.Tables["Data"].Rows[0]["ETAT"]);

            commande = string.Format("SELECT NUMEROSAISON FROM PROJET_IHM_SAISON WHERE NOMSERIE='{0}'", Properties.Settings.Default.serie);
            ds = bdd.Select(commande);

            listeSaison.Items.Clear();
            foreach (DataRow r in ds.Tables["Data"].Rows)
            {
                string saison = string.Format("Saison {0}", (decimal)r["NUMEROSAISON"]);
                listeSaison.Items.Add(saison);
            }

            commande = string.Format("SELECT * FROM PROJET_IHM_SUIVI_SERIE WHERE NOMSERIE='{0}' AND NOMUTILISATEUR='{1}'", Properties.Settings.Default.serie, Properties.Settings.Default.username);
            ds = bdd.Select(commande);

            if (ds.Tables["Data"].Rows.Count == 0)
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

            commande = string.Format("SELECT CHEMIN FROM PROJET_IHM_MEDIA WHERE NOMSERIE='{0}' AND NUMEROSAISON IS NULL AND TYPE='Image'", Properties.Settings.Default.serie);
            ds = bdd.Select(commande);
            if (ds.Tables["Data"].Rows.Count > 0)
            {
                if (System.IO.Directory.Exists((string)ds.Tables["Data"].Rows[0]["CHEMIN"]))
                {
                    image = Image.FromFile(ds.Tables["Data"].Rows[0]["CHEMIN"].ToString(), true);
                    Bitmap im = new Bitmap(image, new Size(ImageBox.Size.Width, ImageBox.Size.Height));
                    ImageBox.Image = im;
                }
            }
        }

        private void listeSaison_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listeSaison.SelectedIndex != -1)
            {
                string nomSaison = listeSaison.SelectedItem.ToString();
                string numSaison = nomSaison.Substring(nomSaison.Length - 1);
                decimal noSaison = decimal.Parse(numSaison);

                Properties.Settings.Default.saison = noSaison;
                Properties.Settings.Default.Save();

                FicheSaison f = new FicheSaison();
                f.ShowDialog();
            }
        }

        private void suiviButton_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.suivi)
            {
                commande = string.Format("DELETE FROM PROJET_IHM_SUIVI_SERIE WHERE NOMSERIE='{0}' AND NOMUTILISATEUR='{1}'", Properties.Settings.Default.serie, Properties.Settings.Default.username);
                bdd.Delete(commande);

                Properties.Settings.Default.suivi = false;
                Properties.Settings.Default.Save();
                suiviButton.Text = "Suivre la série";
            }
            else
            {
                commande = string.Format("INSERT INTO PROJET_IHM_SUIVI_SERIE VALUES('{0}', '{1}')", Properties.Settings.Default.serie, Properties.Settings.Default.username);
                bdd.Insert(commande);

                Properties.Settings.Default.suivi = true;
                Properties.Settings.Default.Save();
                suiviButton.Text = "Ne plus suivre la série";
            }
        }

        private void ImageBox_ClientSizeChanged(object sender, EventArgs e)
        {
            if (image != null)
            {
                Bitmap im = new Bitmap(image, new Size(ImageBox.Size.Width, ImageBox.Size.Height));
                ImageBox.Image = im;
            }
        }
    }
}
