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
    public partial class FicheMediaSerie : Form
    {
        private string commande;
        private ConnexionOracle bdd;
        private DataSet ds;

        private ProcessStartInfo vlcInfo;
        private Process vlc;

        public FicheMediaSerie()
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

        private void FicheMediaSerie_Load(object sender, EventArgs e)
        {
            this.Text = string.Format("Fiche média {0}", Properties.Settings.Default.serie);

            RemplissagePanneau();

            commande = string.Format("SELECT * FROM PROJET_IHM_MEDIA WHERE NOMSERIE='{0}' AND NUMEROSAISON IS NULL AND NUMEROEPISODE IS NULL AND TYPE='Vidéo'", Properties.Settings.Default.serie);
            ds = bdd.Select(commande);

            if (ds.Tables["Data"].Rows.Count == 0)
                video.Enabled = false;

            commande = string.Format("SELECT * FROM PROJET_IHM_MEDIA WHERE NOMSERIE='{0}' AND NUMEROSAISON IS NULL AND NUMEROEPISODE IS NULL AND TYPE='Son'", Properties.Settings.Default.serie);
            ds = bdd.Select(commande);

            if (ds.Tables["Data"].Rows.Count == 0)
                audio.Enabled = false;
        }

        private void RemplissagePanneau()
        {
            commande = string.Format("SELECT * FROM PROJET_IHM_MEDIA WHERE NOMSERIE='{0}' AND NUMEROSAISON IS NULL AND NUMEROEPISODE IS NULL AND TYPE='Image'", Properties.Settings.Default.serie);

            ds = bdd.Select(commande);

            foreach (DataRow r in ds.Tables["Data"].Rows)
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
                commande = string.Format("SELECT * FROM PROJET_IHM_MEDIA WHERE NOMSERIE='{0}' AND NUMEROSAISON IS NULL AND NUMEROEPISODE IS NULL AND TYPE='Son'", Properties.Settings.Default.serie);
                ds = bdd.Select(commande);

                foreach (DataRow r in ds.Tables["Data"].Rows)
                {
                    if (File.Exists((string)r["CHEMIN"]))
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

        private void video_Click(object sender, EventArgs e)
        {
            if (File.Exists("D:\\Program Files (x86)\\VideoLAN\\VLC\\vlc.exe"))
            {
                if (vlc != null && Process.GetProcessesByName("vlc").Length > 0)
                    vlc.Kill();

                string chemin = string.Empty;
                commande = string.Format("SELECT * FROM PROJET_IHM_MEDIA WHERE NOMSERIE='{0}' AND NUMEROSAISON IS NULL AND NUMEROEPISODE IS NULL AND TYPE='Son'", Properties.Settings.Default.serie);
                ds = bdd.Select(commande);

                foreach (DataRow r in ds.Tables["Data"].Rows)
                {
                    if (File.Exists((string)r["CHEMIN"]))
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
