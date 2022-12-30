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
                if(cbbRule.SelectedItem.ToString() ==  "So khach toi da")
                {
                    int Value_tmp;
                    if (!Int32.TryParse(txtValue.Text, out Value_tmp) || Value <= 0)
                    {
                        MessageBox.Show("Tham so cua \"So khach toi da\" phai la so nguyen duong");
                        return;
                    }
                    
                    int Numofpeostd = (int)Double.Parse(exc.executeQuery("SELECT GiaTri FROM THAMSO WHERE TenTS = 'So khach tieu chuan'").Rows[0]["GiaTri"].ToString());

                    if(Value_tmp < Numofpeostd)
                    {
                        MessageBox.Show("Tham so cua \"So khach toi da\" phai lon hon hoac bang tham so cua \"So khach tieu chuan\" la " + Numofpeostd.ToString());
                        return;
                    }

                }
                if (cbbRule.SelectedItem.ToString() == "So khach tieu chuan")
                {
                    int Value_tmp;
                    if (!Int32.TryParse(txtValue.Text, out Value_tmp) || Value <= 0)
                    {
                        MessageBox.Show("Tham so cua \"So khach tieu chuan\" phai la so nguyen duong");
                        return;
                    }

                    int Numofpeomax = (int)Double.Parse(exc.executeQuery("SELECT GiaTri FROM THAMSO WHERE TenTS = 'So khach toi da'").Rows[0]["GiaTri"].ToString());

                    if (Value_tmp > Numofpeomax)
                    {
                        MessageBox.Show("Tham so cua \"So khach tieu chuan\" phai nho hon hoac bang tham so cua \"So khach toi da\" la " + Numofpeomax.ToString());
                        return;
                    }
                }
                exc.executeNonQuery("UPDATE THAMSO SET GiaTri = '" + Value + "' WHERE TenTS = '" + cbbRule.SelectedItem.ToString() + "'");
                MessageBox.Show("Thong tin tham so da duoc cap nhat");
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
