using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotel
{
    public partial class fListRental : Form
    {
        public fListRental()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddRental_Click(object sender, EventArgs e)
        {
            fsearch se = new fsearch();
            se.Show();
        }
    }
}
