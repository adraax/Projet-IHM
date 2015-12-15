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
    public partial class ModifierNoteSerie : Form
    {
        private string commande;
        private ConnexionOracle bdd;
        private DataSet ds;

        public ModifierNoteSerie()
        {
            InitializeComponent();
            bdd = new ConnexionOracle();
        }

        private void ModifierNoteSerie_Load(object sender, EventArgs e)
        {
            this.Text = string.Format("Fiche note {0}", Properties.Settings.Default.serie);

            commande = string.Format("SELECT NOTE FROM PROJET_IHM_NOTE WHERE NOMSERIE='{0}' AND NUMEROSAISON IS NULL AND NUMEROEPISODE IS NULL AND USERNAME='{1}'", Properties.Settings.Default.serie, Properties.Settings.Default.username);
            ds = bdd.Select(commande);

            note.Value = (decimal)ds.Tables["Data"].Rows[0]["NOTE"];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            commande = string.Format("UPDATE PROJET_IHM_NOTE SET NOTE={0} WHERE NOMSERIE='{1}' AND NUMEROSAISON IS NULL AND NUMEROEPISODE IS NULL AND USERNAME='{2}'", note.Value, Properties.Settings.Default.serie, Properties.Settings.Default.username);

            bdd.Update(commande);
            this.Dispose();
        }
    }
}
