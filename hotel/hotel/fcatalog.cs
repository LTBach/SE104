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
            faddroom.FormClosed += new FormClosedEventHandler(faddroom_Closed);
        }

        void faddroom_Closed(object sender, FormClosedEventArgs e)
        {
            faddroom faddroom = (faddroom)sender;
            showTable();
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

                dataCatalog.DataSource = exc.executeQuery("SELECT TenPhong, TenLoaiPhong, DonGiaTC, GhiChu FROM LOAIPHONG lp, DANHMUCPHONG dmp " +
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
            if (dataCatalog.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui long chon 1 dong");
                return;
            }

            if (dataCatalog.SelectedRows.Count > 1)
            {
                MessageBox.Show("Vui long chi chon 1 dong");
                return;
            }

            string TenPhong = dataCatalog.SelectedRows[0].Cells[0].Value.ToString();

            if (exc.executeQuery("SELECT * FROM PHIEUTHUE PT JOIN DANHMUCPHONG DMP ON PT.MaPhong = DMP.MaPhong WHERE TenPhong = '" +TenPhong+ "'").Rows.Count != 0)
            {
                MessageBox.Show("Khong xoa duoc phong do phong do van con phieu thue");
                return;
            }

            exc.executeNonQuery("DELETE FROM DANHMUCPHONG WHERE TenPhong = '" + TenPhong + "'");
            MessageBox.Show("Xoa phong thanh cong");
            showTable();
        }

        private void btnUpdateRoom_Click(object sender, EventArgs e)
        {
            if (dataCatalog.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui long chon 1 dong");
                return;
            }

            if (dataCatalog.SelectedRows.Count > 1)
            {
                MessageBox.Show("Vui long chi chon 1 dong");
                return;
            }

            fUpdateRoom ur = new fUpdateRoom(dataCatalog.SelectedRows[0].Cells[0].Value.ToString());
            ur.Show();
            ur.FormClosed += new FormClosedEventHandler(fUpdateRoom_Closed);
        }

        void fUpdateRoom_Closed(object sender, FormClosedEventArgs e)
        {
            fUpdateRoom ur = (fUpdateRoom)sender;
            showTable();
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
