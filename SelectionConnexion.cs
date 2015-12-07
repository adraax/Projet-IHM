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
    public partial class SelectionConnexion : Form
    {
        public SelectionConnexion()
        {
            InitializeComponent();
        }

        private void externe_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.connexion = "ufrsciencestech.u-bourgogne.fr:25559/ense2015";
            Properties.Settings.Default.Save();

            this.Visible = false;

            MainWindow w = new MainWindow();
            w.ShowDialog();
            this.Dispose();
        }

        private void interne_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.connexion = "eluard:1521/ense2015";
            Properties.Settings.Default.Save();

            this.Visible = false;

            MainWindow w = new MainWindow();
            w.ShowDialog();
            this.Dispose();
        }
    }
}
