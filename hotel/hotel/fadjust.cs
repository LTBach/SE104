using hotel.DAO;
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
    public partial class fadjust : Form
    {
        SqlExecuter exc = new SqlExecuter();
        public fadjust()
        {
            InitializeComponent();

            DataTable dt = exc.executeQuery("SELECT TenTS FROM THAMSO");

            foreach(DataRow dr in dt.Rows)
            {
                cbbRule.Items.Add(dr["TenTs"].ToString());
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            double Value;
            if(cbbRule.SelectedIndex != -1 && Double.TryParse(txtValue.Text,out Value))
            {
                exc.executeNonQuery("UPDATE THAMSO SET GiaTri = '" + Value + "' WHERE TenTS = '" + cbbRule.SelectedItem.ToString() + "'");
            } else
            {
                MessageBox.Show("Dien vao cho trong va chac chan GiaTri la so thuc");
            }
        }

        private void txtValue_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
