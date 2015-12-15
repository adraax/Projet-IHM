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

        private string nomFichier;

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
                if (listeSerie.SelectedIndex != -1)
                {
                    Properties.Settings.Default.serie = listeSerie.SelectedItem.ToString().Replace("'", "''");
                    Properties.Settings.Default.Save();

                    commande = string.Format("SELECT NUMEROSAISON FROM PROJET_IHM_SAISON WHERE NOMSERIE='{0}'", Properties.Settings.Default.serie);
                    ds = bdd.Select(commande);

                    foreach (DataRow r in ds.Tables["Data"].Rows)
                        listeSaison.Items.Add(string.Format("Saison {0}", (decimal)r["NUMEROSAISON"]));

                    labelSaison.Visible = true;
                    listeSaison.Visible = true;
                }
            }
        }

        private void AjoutMediaEpisode_Load(object sender, EventArgs e)
        {
            commande = string.Format("SELECT NOM FROM PROJET_IHM_SERIE");
            ds = bdd.Select(commande);

            foreach (DataRow r in ds.Tables["Data"].Rows)
                listeSerie.Items.Add((string)r["NOM"]);
        }

        private void listeSaison_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelEpisode.Visible = false;
            listeEpisode.Visible = false;
            labelType.Visible = false;
            listeType.Visible = false;
            labelMedia.Visible = false;
            cheminMedia.Visible = false;
            parcourir.Visible = false;
            ajouter.Visible = false;

            if (listeSaison.SelectedIndex != -1)
            {
                Properties.Settings.Default.saison = decimal.Parse(listeSaison.SelectedItem.ToString().Substring(listeSaison.SelectedItem.ToString().Length - 1, 1));
                Properties.Settings.Default.Save();

                commande = string.Format("SELECT NUMEPISODE, NOMEPISODE FROM PROJET_IHM_EPISODE WHERE NOMSERIE='{0}' AND NUMEROSAISON={1}", Properties.Settings.Default.serie, Properties.Settings.Default.saison);
                ds = bdd.Select(commande);

                foreach (DataRow r in ds.Tables["Data"].Rows)
                    listeEpisode.Items.Add(string.Format("Épisode {0} : {1}", (decimal)r["NUMEPISODE"], (string)r["NOMEPISODE"]));

                labelEpisode.Visible = true;
                listeEpisode.Visible = true;
            }
        }

        private void listeEpisode_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelType.Visible = false;
            listeType.Visible = false;
            labelMedia.Visible = false;
            cheminMedia.Visible = false;
            parcourir.Visible = false;
            ajouter.Visible = false;

            if (listeEpisode.SelectedIndex != -1)
            {
                Properties.Settings.Default.episode = decimal.Parse(listeEpisode.SelectedItem.ToString().Substring("Episode ".Length, 1));
                Properties.Settings.Default.Save();

                labelType.Visible = true;
                listeType.Visible = true;
            }
        }

        private void listeType_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelMedia.Visible = false;
            cheminMedia.Visible = false;
            parcourir.Visible = false;
            ajouter.Visible = false;

            if (listeType.SelectedIndex != -1)
            {
                labelMedia.Visible = true;
                cheminMedia.Visible = true;
                parcourir.Visible = true;
            }
        }

        private void parcourir_Click(object sender, EventArgs e)
        {
            ajouter.Visible = false;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (listeType.SelectedItem.ToString() == "Image")
            {
                openFileDialog1.Filter = "Fichiers image(*.BMP; *.JPG; *.GIF; *.PNG)| *.BMP; *.JPG; *.GIF; *.PNG";
            }
            else if (listeType.SelectedItem.ToString() == "Son")
            {
                openFileDialog1.Filter = "Fichiers audio(*.MP3; *.WAV)| *.MP3; *.WAV";
            }
            else
            {
                openFileDialog1.Filter = "Fichiers vidéo(*.MP4; *.AVI)| *.MP4; *.AVI";
            }

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                cheminMedia.Text = openFileDialog1.FileName;
                nomFichier = openFileDialog1.SafeFileName;
                ajouter.Visible = true;
            }
        }

        private void ajouter_Click(object sender, EventArgs e)
        {
            string targetPath = string.Format(@"Data\{0}\{1}\{2}\", Properties.Settings.Default.serie.Replace(" ","_"), Properties.Settings.Default.saison, Properties.Settings.Default.episode);
            string destFile = System.IO.Path.Combine(targetPath, nomFichier.Replace(" ", "_"));
            if (!System.IO.Directory.Exists(targetPath))
            {
                System.IO.Directory.CreateDirectory(targetPath);
            }

            System.IO.File.Copy(cheminMedia.Text, destFile, true);

            commande = string.Format("INSERT INTO PROJET_IHM_MEDIA VALUES('{0}', {1}, {2}, '{3}', '{4}')", Properties.Settings.Default.serie, Properties.Settings.Default.saison, Properties.Settings.Default.episode, destFile, listeType.SelectedItem.ToString());
            bdd.Insert(commande);
            this.Dispose();
        }
    }
}
