using hotel.DAO;
using hotel;
using hotel.PhieuThue;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace hotel
{
    public partial class fbill : Form
    {
        SqlExecuter exc = new SqlExecuter();
        DataTable dt; 
        List<string> listRoomName = new List<string> { };
        public fbill()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if(listRoomName.Contains(txtRoomName.Text))
            {
                MessageBox.Show("Phong nay da duoc them roi");
                return;
            }
            listRoomName.Add(txtRoomName.Text);
            showTable();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            //kiem tra phong ton tai
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                listRoomName.Remove(row.Cells[0].Value.ToString());
                dataGridView1.Rows.RemoveAt(row.Index);
            }
        }
        public void showTable()
        {
            dt = new DataTable();
            dt.Columns.Add("TenPhong");
            dt.Columns.Add("SoNgayThue");
            dt.Columns.Add("DonGia");
            dt.Columns.Add("ThanhTien");
            DateTime billDay = dateTimePicker1.Value;
            List<string> delNameList = new List<string> { };
            double TotalPrice = 0;
            foreach (string roomName in listRoomName)
            {
                DataTable dt1 = exc.executeQuery("SELECT NgayBDThue, DonGia FROM PHIEUTHUE WHERE SoNgayThue is" +
                    " null and MaPhong IN (SELECT MaPhong FROM DANHMUCPHONG WHERE TenPhong = '" + roomName + "')");
                if (dt1.Rows.Count == 0)
                {
                    MessageBox.Show("There is no PHIEUTHUE with roomName " + roomName);
                    delNameList.Add(roomName);
                    continue;
                }
                DateTime rentDay = DateTime.Parse(dt1.Rows[0]["NgayBDThue"].ToString());
                DataRow dr = dt.NewRow();
                dr[0] = roomName;
                dr[1] = Math.Ceiling((billDay - rentDay).TotalDays);
                dr[2] = dt1.Rows[0]["DonGia"].ToString();
                dr[3] = Math.Ceiling((billDay - rentDay).TotalDays) * Convert.ToDouble(dr[2]);
                TotalPrice += Math.Ceiling((billDay - rentDay).TotalDays) * Convert.ToDouble(dr[2]);
                dt.Rows.Add(dr);   
            }
            foreach (string RoomName in delNameList)
            {
                listRoomName.Remove(RoomName);
            }

            if(TotalPrice == 0)
            {
                lbTotalPrice.Text = "0";
            }
            else
            {
                lbTotalPrice.Text = TotalPrice.ToString();
            }
            dataGridView1.DataSource = dt;
        }

        private void btn_pay_Click(object sender, EventArgs e)
        {
            if (lbTotalPrice.Text != "0" && txtPayer.Text != "" && txtAddress.Text != "")
            {
                int billId = exc.getID("SoHD");

                exc.executeNonQuery("INSERT INTO HOADON VALUES('" + billId.ToString() + "','" + lbTotalPrice.Text + "','"
                    + txtPayer.Text + "','" + txtAddress.Text + "','" + dateTimePicker1.Value.ToString("yyyy/MM/dd") + "')");
               
                
                
                DateTime billDay = dateTimePicker1.Value;
                foreach (string roomName in listRoomName)
                {
                    DataTable dt1 = exc.executeQuery("SELECT MaPhieuThue, NgayBDThue, DonGia FROM PHIEUTHUE WHERE SoNgayThue is" +
                        " null and MaPhong IN (SELECT MaPhong FROM DANHMUCPHONG WHERE TenPhong = '" + roomName + "')");
                    if (dt1.Rows.Count == 0)
                    {
                        MessageBox.Show("There is no PHIEUTHUE with roomName " + roomName);
                        
                        continue;
                    }
                    double thanhtien, sohd, songay;
                    DateTime rentDay = DateTime.Parse(dt1.Rows[0]["NgayBDThue"].ToString());
                    DataRow dr = dt.NewRow();
                    dr[0] = roomName;
                    dr[1] = Math.Ceiling((billDay - rentDay).TotalDays);
                    dr[2] = dt1.Rows[0]["DonGia"].ToString();
                    dr[3] = Math.Ceiling((billDay - rentDay).TotalDays) * Convert.ToDouble(dr[2]);

                    string maphieuthue = dt1.Rows[0]["MaPhieuThue"].ToString();
                    songay = Math.Ceiling((billDay - rentDay).TotalDays);
                    thanhtien = Math.Ceiling((billDay - rentDay).TotalDays) * Convert.ToDouble(dr[2]);

                    exc.executeNonQuery("UPDATE PHIEUTHUE SET SOHD = '" + billId.ToString() + "',THANHTIEN = " + thanhtien.ToString() + ",SONGAYTHUE = " + songay.ToString() + " WHERE MaPhieuThue = '" + maphieuthue +"'");

                }
                billId++;
                exc.setID("SoHD", billId);
                MessageBox.Show("Hoa don da duoc thanh toan");
                foreach (DataRow row in dt.Rows)
                {
                    exc.executeNonQuery("UPDATE DANHMUCPHONG SET TinhTrang = 'Khong' WHERE TenPhong = '" + row["TenPhong"] + "'");
                }
                Close();
            }else
            {
                MessageBox.Show("Chua dien du thong tin");
            }
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            showTable();
        }

    }
}
