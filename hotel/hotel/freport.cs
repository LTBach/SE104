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
    public partial class freport : Form
    {
        DataTable dt;
        private SqlExecuter exc= new SqlExecuter();
        public freport()
        {
            InitializeComponent();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            if (cbbMonth.SelectedIndex != -1 && txtYear.Text != string.Empty)
            {
                int year = 0;
                if (Int32.TryParse(txtYear.Text, out year))
                {
                    //MessageBox.Show(cbbMonth.SelectedItem.ToString() + txtYear.Text);
                    showTable();
                }
                else MessageBox.Show("Nam phai la so!!!", "Error");
                
            }
            else
                MessageBox.Show("Phai chon day du thang va nam", "Error");
            
        }
        
        private void showTable()
        {
            dt = new DataTable();
            
            dt.Columns.Add("TenLoaiPhong");
            dt.Columns.Add("tyle");
            dt.Columns.Add("DoanhThu");

            DataTable dtmp = new DataTable();
            dtmp = exc.executeQuery("SELECT TenLoaiPhong, SUM(CASE WHEN THANHTIEN IS NULL THEN 0 ELSE THANHTIEN END) AS DoanhThu\r\nFROM LOAIPHONG LP \r\n\t" +
                "LEFT JOIN DANHMUCPHONG DMP\r\n\tON LP.MaLoaiPhong = DMP.MaLoaiPhong\r\n\tLEFT JOIN PHIEUTHUE PT\r\n\tON PT.MaPhong = DMP.MaPhong AND  PT.SoHD IS NOT NULL AND MONTH(NgayBDThue) = " 
                + cbbMonth.SelectedItem.ToString() +" AND YEAR(NgayBDThue) = "+ txtYear.Text +"\r\nGROUP BY LP.MaLoaiPhong, TenLoaiPhong");
            double totalRevenue = 0.0;
            foreach (DataRow row in dtmp.Rows)
            {
                totalRevenue += double.Parse(row["DoanhThu"].ToString());
            }
            foreach (DataRow row in dtmp.Rows)
            {
                DataRow dr = dt.NewRow();
                dr[0] = row["TenLoaiPhong"];
                dr[2] = row["DoanhThu"];
                if (totalRevenue > 0)
                {
                    dr[1] = double.Parse(dr[2].ToString()) / totalRevenue * 100.0;
                }
                else dr[1] = 100;
                
                dt.Rows.Add(dr);
            }
                dataGridView1.DataSource = dt;
        }

    }
}
