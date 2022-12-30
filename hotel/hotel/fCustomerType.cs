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
    public partial class fCustomerType : Form
    {
        public fCustomerType()
        {
            InitializeComponent();
        }

        private void btnAddCusType_Click(object sender, EventArgs e)
        {
            fAddCusType new_ct = new fAddCusType();
            new_ct.Show();
        }

        private void btnEditCusType_Click(object sender, EventArgs e)
        {
            fUpdateCusType update_ct = new fUpdateCusType();
            update_ct.Show();
        }
    }
}
