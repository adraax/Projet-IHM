﻿using System;
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
    public partial class AccueilUser : Form
    {
        public AccueilUser()
        {
            InitializeComponent();
        }

        private void AcceuilUser_Load(object sender, EventArgs e)
        {
            string username = Properties.Settings.Default.username;
            this.Text = $"Accueil {username}";
        }
    }
}
