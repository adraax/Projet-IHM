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

        private string nomFichier;

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
            cheminTextBox.Text = string.Empty;

            if (typeMedia.SelectedIndex != -1)
            {
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
                Properties.Settings.Default.serie = listeSerie.SelectedItem.ToString().Replace("'", "''");
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

        private void parcourir_Click(object sender, EventArgs e)
        {
            valider.Visible = false;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (typeMedia.SelectedItem.ToString() == "Image")
            {
                openFileDialog1.Filter = "Fichiers image(*.BMP; *.JPG; *.GIF; *.PNG)| *.BMP; *.JPG; *.GIF; *.PNG";
            }
            else if(typeMedia.SelectedItem.ToString() == "Son")
            {
                openFileDialog1.Filter = "Fichiers audio(*.MP3; *.WAV)| *.MP3; *.WAV";
            }
            else
            {
                openFileDialog1.Filter = "Fichiers vidéo(*.MP4; *.AVI)| *.MP4; *.AVI";
            }

            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                cheminTextBox.Text = openFileDialog1.FileName;
                nomFichier = openFileDialog1.SafeFileName;
                valider.Visible = true;
            }
        }

        private void valider_Click(object sender, EventArgs e)
        {
            string targetPath = string.Format(@"Data\{0}\", Properties.Settings.Default.serie);
            string destFile = System.IO.Path.Combine(targetPath, nomFichier.Replace(" ", "_"));
            if (!System.IO.Directory.Exists(targetPath))
            {
                System.IO.Directory.CreateDirectory(targetPath);
            }

            System.IO.File.Copy(cheminTextBox.Text, destFile, true);

            commande = string.Format("INSERT INTO PROJET_IHM_MEDIA VALUES('{0}', NULL, NULL, '{1}', '{2}')", listeSerie.SelectedItem.ToString().Replace("'", "''"), destFile, typeMedia.SelectedItem.ToString());
            bdd.Insert(commande);
            this.Dispose();
        }
    }
}
