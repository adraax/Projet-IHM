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
        public Planning()
        {
            InitializeComponent();
        }

        private void Planning_Load(object sender, EventArgs e)
        {
            calendrier.BoldedDates;
        }

        private void calendrier_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
    }
}
