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
    public partial class fsearch : Form
    {
        SqlExecuter exc = new SqlExecuter();
        public fsearch()
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

        private void btn_reserve_Click(object sender, EventArgs e)
        {
            DataTable dt = exc.executeQuery("SELECT MaPhong, TenPhong, TenLoaiPhong, DonGiaTC, TinhTrang FROM DANHMUCPHONG dmp, LOAIPHONG lp WHERE " +
                "dmp.MaLoaiPhong = lp.MaLoaiPhong and MaPhong = '" + txtRoomId.Text + "'");
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("MaPhong khong ton tai");
                return;
            }
            if (dt.Rows[0]["TinhTrang"].ToString() == "Co nguoi")
            {
                MessageBox.Show("Phong da co nguoi");
                return;
            }
            freserve reserve = new freserve(dt.Rows[0]);
            reserve.Show();
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

                dataGridView1.DataSource = exc.executeQuery("SELECT MaPhong, TenPhong, TenLoaiPhong, DonGiaTC, TinhTrang FROM LOAIPHONG lp, DANHMUCPHONG dmp " +
                    "WHERE lp.MaLoaiPhong = dmp.MaLoaiPhong and TenPhong like '" + txtRoomName.Text + "%' and TenLoaiPhong like '"
                    + RoomType + "%' and DonGiaTC > " + Price + " and TinhTrang like '" + Status + "%'");
            }
            catch (Exception ex)
            {
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

        private void fsearch_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void fsearch_Load_1(object sender, EventArgs e)
        {

        }
    }
}
