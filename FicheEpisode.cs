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
    public partial class FicheEpisode : Form
    {
        private ConnexionOracle bdd;
        private DataSet ds;
        private string commande;
        public FicheEpisode()
        {
            InitializeComponent();
            bdd = new ConnexionOracle();
        }

        private void FicheEpisode_Load(object sender, EventArgs e)
        {
            commande = string.Format("SELECT NUMEPISODE, NOMEPISODE, SYNOPSIS, DATEDIFFUSION FROM PROJET_IHM_EPISODE WHERE NOMSERIE='{0}' AND NUMEROSAISON={1} AND NUMEPISODE={2}", Properties.Settings.Default.serie, Properties.Settings.Default.saison, Properties.Settings.Default.episode);
            ds = bdd.Select(commande);

            nomEpisode.Text = (string)ds.Tables["Data"].Rows[0]["NOMEPISODE"];

            if(ds.Tables["Data"].Rows[0]["SYNOPSIS"].ToString() != "")
                synopsis.Text = (string)ds.Tables["Data"].Rows[0]["SYNOPSIS"];

            this.Text = string.Format("Fiche {0} - saison {1} - épisode {2} : {3}", Properties.Settings.Default.serie, Properties.Settings.Default.saison, Properties.Settings.Default.episode, nomEpisode.Text);

            DateTime date = Convert.ToDateTime(ds.Tables["Data"].Rows[0]["DATEDIFFUSION"]);
            dateDiff.Text = string.Format("Diffusé le : {0}", date.ToString("d"));

            commande = string.Format("SELECT AVG(NOTE) AS MOYENNE FROM PROJET_IHM_NOTE WHERE NOMSERIE='{0}' AND NUMEROSAISON={1} AND NUMEROEPISODE={2}", Properties.Settings.Default.serie, Properties.Settings.Default.saison, Properties.Settings.Default.episode);
            ds = bdd.Select(commande);

            if (ds.Tables["Data"].Rows[0]["MOYENNE"].ToString() != "")
                noteEpisode.Text = string.Format("Note : {0}/20", (decimal)ds.Tables["Data"].Rows[0]["MOYENNE"]);
            else
                noteEpisode.Text = "Pas de notes pour cet épisode";

            commande = string.Format("SELECT * FROM PROJET_IHM_MEDIA WHERE NOMSERIE='{0}' AND NUMEROSAISON={1} AND NUMEROEPISODE={2}", Properties.Settings.Default.serie, Properties.Settings.Default.saison, Properties.Settings.Default.episode);
            ds = bdd.Select(commande);

            if (ds.Tables["Data"].Rows.Count != 0)
                media.Text = "Afficher la liste des médias";
            else
            {
                media.Text = "Aucuns médias pour cet épisode";
                media.Enabled = false;
            }

            commande = string.Format("SELECT * FROM PROJET_IHM_EPISODE_VUS WHERE NOMSERIE='{0}' AND NUMEROSAISON={1} AND NUMEROEPISODE={2} AND USERNAME='{3}'", Properties.Settings.Default.serie, Properties.Settings.Default.saison, Properties.Settings.Default.episode, Properties.Settings.Default.username);
            ds = bdd.Select(commande);

            if (ds.Tables["Data"].Rows.Count != 0)
                vuCheckBox.Checked = true;
            else
                vuCheckBox.Checked = false;
        }

        private void noterEpisode_Click(object sender, EventArgs e)
        {
            commande = string.Format("SELECT * FROM PROJET_IHM_NOTE WHERE NOMSERIE='{0}' AND NUMEROSAISON={1} AND NUMEROEPISODE={2} AND USERNAME='{3}'", Properties.Settings.Default.serie, Properties.Settings.Default.saison, Properties.Settings.Default.episode, Properties.Settings.Default.username);
            ds = bdd.Select(commande);

            if(ds.Tables["Data"].Rows.Count != 0)
            {
                ModifierNoteEpisode m = new ModifierNoteEpisode();
                m.ShowDialog();

                commande = string.Format("SELECT AVG(NOTE) AS MOYENNE FROM PROJET_IHM_NOTE WHERE NOMSERIE='{0}' AND NUMEROSAISON={1} AND NUMEROEPISODE={2}", Properties.Settings.Default.serie, Properties.Settings.Default.saison, Properties.Settings.Default.episode);
                ds = bdd.Select(commande);

                if (ds.Tables["Data"].Rows[0]["MOYENNE"].ToString() != "")
                    noteEpisode.Text = string.Format("Note : {0}/20", (decimal)ds.Tables["Data"].Rows[0]["MOYENNE"]);
                else
                    noteEpisode.Text = "Pas de notes pour cet épisode";
            }
            else
            {
                AjouterNoteEpisode a = new AjouterNoteEpisode();
                a.ShowDialog();

                commande = string.Format("SELECT AVG(NOTE) AS MOYENNE FROM PROJET_IHM_NOTE WHERE NOMSERIE='{0}' AND NUMEROSAISON={1} AND NUMEROEPISODE={2}", Properties.Settings.Default.serie, Properties.Settings.Default.saison, Properties.Settings.Default.episode);
                ds = bdd.Select(commande);

                if (ds.Tables["Data"].Rows[0]["MOYENNE"].ToString() != "")
                    noteEpisode.Text = string.Format("Note : {0}/20", (decimal)ds.Tables["Data"].Rows[0]["MOYENNE"]);
                else
                    noteEpisode.Text = "Pas de notes pour cet épisode";
            }
        }

        private void media_Click(object sender, EventArgs e)
        {
            FicheMediaEpisode f = new FicheMediaEpisode();
            f.ShowDialog();
        }

        private void vuCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(vuCheckBox.Checked == true)
            {
                commande = string.Format("INSERT INTO PROJET_IHM_EPISODE_VUS VALUES('{0}', {1}, {2}, '{3}')", Properties.Settings.Default.serie, Properties.Settings.Default.saison, Properties.Settings.Default.episode, Properties.Settings.Default.username);
                bdd.Insert(commande);
            }
            else
            {
                commande = string.Format("DELETE FROM PROJET_IHM_EPISODE_VUS WHERE NOMSERIE='{0}' AND NUMEROSAISON={1} AND NUMEROEPISODE={2} AND USERNAME='{3}'", Properties.Settings.Default.serie, Properties.Settings.Default.saison, Properties.Settings.Default.episode, Properties.Settings.Default.username);
                bdd.Delete(commande);
            }
        }
    }
}
