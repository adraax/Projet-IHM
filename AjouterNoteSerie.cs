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
    public partial class AjouterNoteSerie : Form
    {
        private string commande;
        private ConnexionOracle bdd;

        public AjouterNoteSerie()
        {
            InitializeComponent();
            bdd = new ConnexionOracle();
        }

        private void AjouterNoteSerie_Load(object sender, EventArgs e)
        {
            this.Text = string.Format("Fiche note {0}", Properties.Settings.Default.serie);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            commande = string.Format("INSERT INTO PROJET_IHM_NOTE VALUES('{0}', NULL, NULL, '{1}', {2})", Properties.Settings.Default.serie, Properties.Settings.Default.username, note.Value);

            bdd.Insert(commande);
            this.Dispose();
        }
    }
}
