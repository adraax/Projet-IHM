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
    public partial class Planning : Form
    {
        private string commande;
        private ConnexionOracle bdd;
        private DataSet ds;

        public Planning()
        {
            InitializeComponent();
            bdd = new ConnexionOracle();
        }

        private void Planning_Load(object sender, EventArgs e)
        {
            commande = string.Format("SELECT DATEDIFFUSION FROM PROJET_IHM_EPISODE WHERE DATEDIFFUSION IS NOT NULL");
            ds = bdd.Select(commande);
            List<DateTime> date = new List<DateTime>();

            foreach(DataRow r in ds.Tables["Data"].Rows)
            {
                DateTime d = Convert.ToDateTime(r["DATEDIFFUSION"]);
                date.Add(d);
            }
            
            calendrier.BoldedDates = date.ToArray();
        }

        private void calendrier_DateChanged(object sender, DateRangeEventArgs e)
        {
            commande = string.Format("SELECT * FROM PROJET_IHM_EPISODE WHERE DATEDIFFUSION=TO_DATE('{0}', 'dd/MM/yyyy')", calendrier.SelectionStart.ToString("d"));
            ds = bdd.Select(commande);

            string message = string.Empty;

            foreach(DataRow r in ds.Tables["Data"].Rows)
            {
                message += string.Format("{0} - Saison {1} - Épisode {2} : {3}", r["NOMSERIE"], r["NUMEROSAISON"], r["NUMEPISODE"], r["NOMEPISODE"]); 
            }

            if (message == string.Empty)
                message = "Pas d'épisode diffusés à cette date.";

            string caption = calendrier.SelectionStart.ToString("d");
            MessageBoxButtons buttons = MessageBoxButtons.OK;

            MessageBox.Show(message, caption, buttons);
        }
    }
}
