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
    public partial class fRoomType : Form
    {
        public fRoomType()
        {
            InitializeComponent();
        }

        private void btnAddRoomType_Click(object sender, EventArgs e)
        {
            fAddRoomType new_rt = new fAddRoomType();
            new_rt.Show();
        }

        private void btnEditRoomType_Click(object sender, EventArgs e)
        {
            fUpdateRoomType update_rt = new fUpdateRoomType(); 
            update_rt.Show();
        }
    }
}
