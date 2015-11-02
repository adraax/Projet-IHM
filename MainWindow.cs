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
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void connexion_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Connexion fenetreConnexion = new Connexion();
            fenetreConnexion.ShowDialog();
            this.Dispose();
        }
    }
}
