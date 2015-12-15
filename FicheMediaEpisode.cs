using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main_project_VERON_MERLIN
{
    public partial class FicheMediaEpisode : Form
    {
        private string commande;
        private ConnexionOracle bdd;
        private DataSet ds;

        private ProcessStartInfo vlcInfo;
        private Process vlc;

        public FicheMediaEpisode()
        {
            InitializeComponent();
            bdd = new ConnexionOracle();

            //Initialisation pour VLC
            if (File.Exists("D:\\Program Files (x86)\\VideoLAN\\VLC\\vlc.exe"))
            {
                vlcInfo = new ProcessStartInfo("D:\\Program Files (x86)\\VideoLAN\\VLC\\vlc.exe");
                vlcInfo.FileName = "vlc.exe";
                vlcInfo.WorkingDirectory = "D:\\Program Files (x86)\\VideoLAN\\VLC";
            }
            vlc = null;
        }

        private void FicheMediaEpisode_Load(object sender, EventArgs e)
        {
            commande = string.Format("SELECT NUMEPISODE, NOMEPISODE, SYNOPSIS, DATEDIFFUSION FROM PROJET_IHM_EPISODE WHERE NOMSERIE='{0}' AND NUMEROSAISON={1} AND NUMEPISODE={2}", Properties.Settings.Default.serie, Properties.Settings.Default.saison, Properties.Settings.Default.episode);
            ds = bdd.Select(commande);

            this.Text = string.Format("Fiche média {0} - saison {1} - épisode {2} : {3}", Properties.Settings.Default.serie, Properties.Settings.Default.saison, Properties.Settings.Default.episode, (string)ds.Tables["Data"].Rows[0]["NOMEPISODE"]);

            RemplissagePanneau();
        }

        private void RemplissagePanneau()
        {
            commande = string.Format("SELECT * FROM PROJET_IHM_MEDIA WHERE NOMSERIE='{0}' AND NUMEROSAISON={1} AND NUMEROEPISODE={2} AND TYPE='Image'", Properties.Settings.Default.serie, Properties.Settings.Default.saison, Properties.Settings.Default.episode);

            ds = bdd.Select(commande);

            foreach(DataRow r in ds.Tables["Data"].Rows)
            {
                PictureBox p = new PictureBox();
                p.Width = 200;
                p.Height = 200;
                p.SizeMode = PictureBoxSizeMode.StretchImage;
                if (System.IO.File.Exists((string)ds.Tables["Data"].Rows[0]["CHEMIN"]))
                {
                    Image image = Image.FromFile(ds.Tables["Data"].Rows[0]["CHEMIN"].ToString(), true);
                    p.Image = image;
                }
                panneau.Controls.Add(p);
            }
        }

        private void audio_Click(object sender, EventArgs e)
        {
            if (File.Exists("D:\\Program Files (x86)\\VideoLAN\\VLC\\vlc.exe"))
            {
                if (vlc != null && Process.GetProcessesByName("vlc").Length > 0)
                    vlc.Kill();

                string chemin = string.Empty;
                commande = string.Format("SELECT * FROM PROJET_IHM_MEDIA WHERE NOMSERIE='{0}' AND NUMEROSAISON={1} AND NUMEROEPISODE={2} AND TYPE='Son'", Properties.Settings.Default.serie, Properties.Settings.Default.saison, Properties.Settings.Default.episode);
                ds = bdd.Select(commande);

                foreach(DataRow r in ds.Tables["Data"].Rows)
                {
                    if(File.Exists((string)r["CHEMIN"]))
                        chemin += Directory.GetCurrentDirectory() + "\\" + (string)r["CHEMIN"];
                }

                Trace.WriteLine(chemin);

                if (!chemin.Equals(""))
                {
                    vlcInfo.Arguments = chemin;
                    vlc = Process.Start(vlcInfo);
                }
                else
                    MessageBox.Show("Les médias ne sont pas présents sur cet ordinateur.");
            }
            else
                MessageBox.Show("VLC doit être installé dans C:\\Program Files (x86) pour pouvoir lire les médias");
        }
    }
}
