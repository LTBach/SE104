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
    public partial class fListRental : Form
    {
        SqlExecuter exc = new SqlExecuter();
        public fListRental()
        {
            InitializeComponent();
            showTable();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddRental_Click(object sender, EventArgs e)
        {
            fsearch se = new fsearch();
            se.Show();
            se.FormClosed += new FormClosedEventHandler(se_Closed);
        }

        void se_Closed(object sender, FormClosedEventArgs e)
        {
            fsearch se = (fsearch)sender;
            showTable();
        }

        public void showTable()
        {

            dataListRental.DataSource = exc.executeQuery("SELECT MaPhieuThue as 'Mã Phiếu Thuê', NgayBDThue as 'Ngày bắt đầu thuê'," +
                " DonGia as 'Đơn Giá', SoLuongKH as 'Số Lượng KH', SoHD as 'Số Hóa Đơn', ThanhTien as 'Thành Tiền', SoNgayThue as 'Số ngày thuê' FROM PHIEUTHUE");
        }

        private void btnDelListRental_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataListRental.SelectedRows)
            {
                string MaPhieuThue = row.Cells[0].Value.ToString();
                exc.executeNonQuery("DELETE FROM CT_PHIEUTHUE WHERE MaPhieuThue = '" + MaPhieuThue + "'");
                exc.executeNonQuery("DELETE FROM PHIEUTHUE WHERE MaPhieuThue = '" + MaPhieuThue + "'");
            }
            MessageBox.Show("Xoa phieu thue thanh cong");
            showTable();
        }
    }
}
