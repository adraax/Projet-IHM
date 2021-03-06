﻿using System;
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
                nomSerie.Text = nomSerie.Text.Replace("'", "''");
                string commande = string.Format("SELECT * FROM PROJET_IHM_SERIE WHERE NOM='{0}'", nomSerie.Text);
                DataSet ds = bdd.Select(commande);

                if (ds.Tables["Data"].Rows.Count != 0)
                {
                    Trace.WriteLine("-- Ajout Série : erreur - nom déjà utilisé");
                    errorNom.Visible = true;
                }
                else
                {
                    if (etatSerie.SelectedIndex != -1)
                    {
                        synopsisSerie.Text = synopsisSerie.Text.Replace("'", "''");
                        commande = string.Format("INSERT INTO PROJET_IHM_SERIE VALUES('{0}', '{1}', '{2}', {3})", nomSerie.Text, synopsisSerie.Text, etatSerie.SelectedItem.ToString(), nbSaison.Value);
                        bdd.Insert(commande);
                        Trace.WriteLine("-- Ajout série réussi");
                        this.Dispose();
                    }
                }
            }
        }
    }
}
