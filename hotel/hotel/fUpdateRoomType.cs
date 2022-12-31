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
    public partial class fUpdateRoomType : Form
    {
        string roomTypeId;
        SqlExecuter exc = new SqlExecuter();
        public fUpdateRoomType(string roomTypeId)
        {
            InitializeComponent();
            this.roomTypeId = roomTypeId;
        }

        private void btnSaveRoomType_Click(object sender, EventArgs e)
        {
            if (txtRoomTypeName.Text == "" && txtPrice.Text == "")
            {
                MessageBox.Show("Vui long dien vao cho trong");
                return;
            }

            if (exc.executeQuery("SELECT MaPhong FROM DANHMUCPHONG WHERE MaLoaiPhong = '" + roomTypeId + "'").Rows.Count != 0)
            {
                MessageBox.Show("Khong xoa duoc do van con phong thuoc loai phong nay");
                return;
            }

            if (txtPrice.Text != "")
            {
                double Value;
                if (!Double.TryParse(txtPrice.Text, out Value) || Value <= 0)
                {
                    MessageBox.Show("He so phai la mot so thuc duong");
                    return;
                }

                exc.executeNonQuery("UPDATE LOAIPHONG SET DonGiaTC = '" + Value.ToString() + "' WHERE MaLoaiPhong = '" + roomTypeId + "'");
            }

            if (txtRoomTypeName.Text != "")
            {
                exc.executeNonQuery("UPDATE LOAIPHONG SET TenLoaiPhong = '" + txtRoomTypeName.Text + "' WHERE MaLoaiPhong = '" + roomTypeId + "'");
            }

            MessageBox.Show("Sua loai phong thanh cong");
            Close();
        }
    }
}
