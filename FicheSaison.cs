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
    public partial class FicheSaison : Form
    {
        public FicheSaison()
        {
            InitializeComponent();
        }

        private void FicheSaison_Load(object sender, EventArgs e)
        {
            this.Text = string.Format("Fiche saison {0} - {1}", Properties.Settings.Default.saison, Properties.Settings.Default.serie);
        }
    }
}
