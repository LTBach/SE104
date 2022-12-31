using hotel.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotel
{
    public partial class fUpdateCusType : Form
    {
        private string cusTypeId;
        SqlExecuter exc = new SqlExecuter();
        public fUpdateCusType(string cusTypeId)
        {
            InitializeComponent();
            this.cusTypeId = cusTypeId;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtCusTypeName.Text == "" && txtHeSo.Text == "")
            {
                MessageBox.Show("Vui long dien vao cho trong");
                return;
            }

            if (exc.executeQuery("SELECT MaKH FROM KHACHHANG WHERE MaLoaiKH = '" + cusTypeId + "'").Rows.Count != 0)
            {
                MessageBox.Show("Khong sua duoc do van con khach hang thuoc loai khach hang nay");
                return;
            }

            if (txtHeSo.Text != "")
            {
                double Value;
                if(!Double.TryParse(txtHeSo.Text, out Value) || Value <= 0)
                {
                    MessageBox.Show("He so phai la mot so thuc duong");
                    return;
                }

                exc.executeNonQuery("UPDATE LOAIKHACHHANG SET HeSo = '" + Value.ToString() + "' WHERE MaLoaiKH = '" + cusTypeId + "'");
            }

            if (txtCusTypeName.Text != "")
            {
                exc.executeNonQuery("UPDATE LOAIKHACHHANG SET TenLoaiKH = '" + txtCusTypeName.Text + "' WHERE MaLoaiKH = '" + cusTypeId + "'");
            }

            MessageBox.Show("Sua loai khach hang thanh cong");
            Close();
        }
    }
}
