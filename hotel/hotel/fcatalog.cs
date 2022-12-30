using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.Intrinsics.Arm;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using hotel.DAO;

namespace hotel
{
    public partial class fcatalog : Form
    {
        SqlExecuter exc = new SqlExecuter();
        public fcatalog()
        {
            InitializeComponent();
            cbbStatus.Items.Add("Co nguoi");
            cbbStatus.Items.Add("Khong");

            DataTable dt = exc.executeQuery("SELECT TenLoaiPhong FROM LOAIPHONG");

            foreach (DataRow row in dt.Rows)
            {
                cbbRoomType.Items.Add(row["TenLoaiPhong"].ToString());
            }
            showTable();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_add_room_Click(object sender, EventArgs e)
        {
            faddroom faddroom = new faddroom();
            faddroom.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        public void showTable()
        {
            try
            {
                string Status = "";
                if (cbbStatus.SelectedIndex != -1) 
                {
                    Status = cbbStatus.SelectedItem.ToString();
                } 

                string RoomType = "";
                if (cbbRoomType.SelectedIndex != -1) 
                {
                    RoomType = cbbRoomType.SelectedItem.ToString();
                } 

                string Price = "0";
                if (txtPrice.Text != "") 
                {
                    Price = txtPrice.Text;
                }

                dataGridView1.DataSource = exc.executeQuery("SELECT TenPhong, TenLoaiPhong, DonGiaTC, GhiChu FROM LOAIPHONG lp, DANHMUCPHONG dmp " +
                    "WHERE lp.MaLoaiPhong = dmp.MaLoaiPhong and TenPhong like '" + txtRoomName.Text + "%' and TenLoaiPhong like '"
                    + RoomType + "%' and DonGiaTC > " + Price + " and TinhTrang like '" + Status + "%'");
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }

        }
        private void txtRoomName_TextChanged(object sender, EventArgs e)
        {
            showTable();
        }
        private void cbbRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            showTable();
        }
        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            showTable();
        }

        private void cbbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            showTable();
        }

        private void btnDelRoom_Click(object sender, EventArgs e)
        {
            //foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            //{
            //    string roomId = exc.executeQuery("SELECT MaPhong FROM DANHMUCPHONG WHERE TenPhong = '"+ row.Cells[0].Value.ToString() + "'").Rows[0]["MaPhongS"].ToString();

            //    exc.executeNonQuery("DELETE FROM PHIEUTHUE WHERE MaPhong = '" + roomId + "'");

            //    exc.executeNonQuery("DELETE FROM DANHMUCPHONG WHERE MaPhong = '" + roomId + "'");

            //}
        }

        private void btnUpdateRoom_Click(object sender, EventArgs e)
        {
            fUpdateRoom ur = new fUpdateRoom();
            ur.Show();
        }

        private void btnRoomType_Click(object sender, EventArgs e)
        {
            fRoomType rt = new fRoomType();
            rt.Show();
        }

        private void btnCusType_Click(object sender, EventArgs e)
        {
            fCustomerType ct = new fCustomerType();
            ct.Show();
        }
    }
}
