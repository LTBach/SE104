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
    public partial class fCustomerType : Form
    {
        SqlExecuter exc = new SqlExecuter();
        public fCustomerType()
        {
            InitializeComponent();
            showTable();
        }

        private void btnAddCusType_Click(object sender, EventArgs e)
        {
            fAddCusType new_ct = new fAddCusType();
            new_ct.Show();
            new_ct.FormClosed += new FormClosedEventHandler(fAddCusType_Closed);
        }

        void fAddCusType_Closed(object sender, FormClosedEventArgs e)
        {
            fAddCusType new_ct = (fAddCusType)sender;
            showTable();
        }

        private void btnEditCusType_Click(object sender, EventArgs e)
        {
            if (dataCusType.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui long chon 1 dong");
                return;
            }

            if (dataCusType.SelectedRows.Count > 1)
            {
                MessageBox.Show("Vui long chi chon 1 dong");
                return;
            }

            fUpdateCusType update_ct = new fUpdateCusType(dataCusType.SelectedRows[0].Cells[0].Value.ToString());
            update_ct.Show();
            update_ct.FormClosed += new FormClosedEventHandler(fUpdateCusType_Closed);
        }

        void fUpdateCusType_Closed(object sender, FormClosedEventArgs e)
        {
            fUpdateCusType update_ct = (fUpdateCusType)sender;
            showTable();
        }
        public void showTable()
        {
            dataCusType.DataSource = exc.executeQuery("SELECT MaLoaiKH as 'Mã Loại KH', TenLoaiKH as 'Tên Loại KH', HeSo as 'Hệ Số' FROM LOAIKHACHHANG");
        }

        private void btnDelCusType_Click(object sender, EventArgs e)
        {
            if (dataCusType.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui long chon 1 dong");
                return;
            }

            if (dataCusType.SelectedRows.Count > 1)
            {
                MessageBox.Show("Vui long chi chon 1 dong");
                return;
            }

            string MaLKH = dataCusType.SelectedRows[0].Cells[0].Value.ToString();

            if (exc.executeQuery("SELECT MaKH FROM KHACHHANG WHERE MaLoaiKH = '" + MaLKH + "'").Rows.Count != 0)
            {
                MessageBox.Show("Khong xoa duoc do van con khach hang thuoc loai khach hang nay");
                return;
            }

            exc.executeNonQuery("DELETE FROM LOAIKHACHHANG WHERE MaLoaiKH = '" + MaLKH + "'");
            showTable();
        }
    }
}
