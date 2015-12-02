using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using System.Data.Common;
using System.Diagnostics;

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

            #region Accès BD
            OracleConnection connec = new OracleConnection();
            connec.ConnectionString = "User Id=om141055; Password=om141055; Data Source=//ufrsciencestech.u-bourgogne.fr:25559/ense2015";
            DbProviderFactory dbpf;
            dbpf = DbProviderFactories.GetFactory("Oracle.DataAccess.Client");

            connec.Open();

            DbDataAdapter dba;
            // initialisation de la connexion conn et de dbpf
            dba = dbpf.CreateDataAdapter();
            dba.SelectCommand = connec.CreateCommand();
            dba.SelectCommand.CommandText = $"SELECT * FROM PROJET_IHM_USERS WHERE USERNAME = '{usernameConnexion.Text}' AND PASSWORD = '{passwordConnexion.Text}' AND ACTIVE = 1";
            DataSet ds = new DataSet();
            dba.Fill(ds, "Users");

            Trace.WriteLine(ds.Tables["Users"].Rows.Count);

            #endregion

            if (ds.Tables["Users"].Rows.Count == 1)
            {
                this.Visible = false;
                Accueil_user fenetreAccueilUser = new Accueil_user(new User(int.Parse(ds.Tables["Users"].Rows[0]["ID"].ToString()), ds.Tables["Users"].Rows[0]["USERNAME"].ToString()));
                fenetreAccueilUser.ShowDialog();
            }
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //TODO gestion du clic sur le boutton, je le ferais demain.
        }
    }
}
