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
    public partial class fAddCusType : Form
    {
        SqlExecuter exc = new SqlExecuter();
        public fAddCusType()
        {
            InitializeComponent();
        }

        private void txtCusTypeName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtCusTypeName.Text == "" || txtHeSo.Text == "")
            {
                MessageBox.Show("Vui long dien vao cho trong");
                return;
            }

            double Value;
            if(!Double.TryParse(txtHeSo.Text, out Value) || Value <= 0)
            {
                MessageBox.Show("He so cua loai khach hang phai la mot so duong");
                return;
            }

            int cusTypeId = exc.getID("MaLoaiKH");

            exc.executeNonQuery("INSERT INTO LOAIKHACHHANG VALUES('" + cusTypeId.ToString() + "','" + txtCusTypeName.Text + "'," + Value.ToString() + ")");
            cusTypeId++;
            exc.setID("MaLoaiKH", cusTypeId);
            Close();
        }
    }
}
