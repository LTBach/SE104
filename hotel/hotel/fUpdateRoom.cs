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
    public partial class fUpdateRoom : Form
    {
        private string roomName;
        SqlExecuter exc = new SqlExecuter();
        public fUpdateRoom(string roomName)
        {
            InitializeComponent();
            this.roomName = roomName;

            DataTable dt = exc.executeQuery("SELECT TenLoaiPhong FROM LOAIPHONG");

            foreach (DataRow row in dt.Rows)
            {
                cbbRoomType.Items.Add(row["TenLoaiPhong"].ToString());
            }
        }

        private void btnSaveRoom_Click(object sender, EventArgs e)
        {
            if(txtRoomName.Text == "" && txtNote.Text == "" && cbbRoomType.SelectedIndex == -1) 
            {
                MessageBox.Show("Vui long dien vao cho trong");
                return;
            }

            if (exc.executeQuery("SELECT * FROM PHIEUTHUE PT JOIN DANHMUCPHONG DMP ON PT.MaPhong = DMP.MaPhong WHERE TenPhong = '" 
                + roomName + "'").Rows.Count != 0)
            {
                MessageBox.Show("Khong sua duoc phong do phong do van con phieu thue");
                Close();
            }

            if(cbbRoomType.SelectedIndex != -1)
            {
                string roomTypeId = exc.executeQuery("SELECT MaLoaiPhong FROM LOAIPHONG WHERE TenLoaiPhong = '"
                    + cbbRoomType.SelectedItem.ToString() + "'").Rows[0]["MaLoaiPhong"].ToString();
                exc.executeNonQuery("UPDATE DANHMUCPHONG SET MaLoaiPhong = '" + roomTypeId + "' WHERE TenPhong = '" + roomName + "'");
            }

            if(txtNote.Text != "")
            {
                exc.executeNonQuery("UPDATE DANHMUCPHONG SET GhiChu = '" + txtNote.Text + "' WHERE TenPhong = '" + roomName + "'");
            }

            if(txtRoomName.Text != "")
            {
                exc.executeNonQuery("UPDATE DANHMUCPHONG SET TenPhong = '" + txtRoomName.Text + "' WHERE TenPhong = '" + roomName + "'");
            }

            MessageBox.Show("Sua phong thanh cong");
            Close();
        }

    }
}
