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
    public partial class fAddRoomType : Form
    {
        SqlExecuter exc = new SqlExecuter();
        public fAddRoomType()
        {
            InitializeComponent();
        }

        private void btnSaveRoomType_Click(object sender, EventArgs e)
        {
            if (txtRoomTypeName.Text == "" || txtPrice.Text == "")
            {
                MessageBox.Show("Vui long dien day du thong tin");
                return;
            }

            double Value;

            if (!Double.TryParse(txtPrice.Text, out Value) || Value <= 0)
            {
                MessageBox.Show("Don gia phai la so duong");
                return;
            }

            int roomTypeId = exc.getID("MaLoaiPhong");

            exc.executeNonQuery("INSERT INTO LOAIPHONG VALUES('"+roomTypeId.ToString()+"','"+txtRoomTypeName.Text+"',"+Value.ToString()+",0)");
            roomTypeId++;
            exc.setID("MaLoaiPhong", roomTypeId);

            Close();
        }
    }
}
