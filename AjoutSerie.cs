using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main_project_VERON_MERLIN
{
    public partial class AjoutSerie : Form
    {
        private ConnexionOracle bdd;
        public AjoutSerie()
        {
            InitializeComponent();
            bdd = new ConnexionOracle();
        }

        private void ajouterSerie_Click(object sender, EventArgs e)
        {
            errorNom.Visible = false;
            if (nomSerie.Text != string.Empty)
            {
                string commande = $"SELECT * FROM PROJET_IHM_SERIE WHERE NOM='{nomSerie.Text}'";
                DataSet ds = bdd.Select(commande);

                if (ds.Tables["Data"].Rows.Count != 0)
                {
                    Trace.WriteLine("-- Ajout Série : erreur - nom déjà utilisé");
                    errorNom.Visible = true;
                }
                else
                {
                    commande = $"INSERT INTO PROJET_IHM_SERIE VALUES('{nomSerie.Text}', '{synopsisSerie.Text}')";
                    bdd.Insert(commande);
                    Trace.WriteLine("-- Ajout série réussi");
                    this.Dispose();
                }
            }
        }
    }
}
