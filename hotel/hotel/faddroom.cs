using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using hotel.DAO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace hotel
{
    public partial class faddroom : Form
    {
        SqlExecuter exc = new SqlExecuter();
        public faddroom()
        {
            InitializeComponent();
            try
            {
                DataTable dt = exc.executeQuery("SELECT TenLoaiPhong FROM LOAIPHONG");
                foreach (DataRow row in dt.Rows)
                {
                    cbbRoomType.Items.Add(row["TenLoaiPhong"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbbRoomType.SelectedIndex == -1 || txtRoomName.Text == "")
            {
                MessageBox.Show("Vui long dien vao cho trong");
            } 
            else
            {
                string roomType = cbbRoomType.SelectedItem.ToString();

                int roomId = exc.getID("MaPhong");

                DataTable dt = exc.executeQuery("SELECT MaLoaiPhong FROM LOAIPHONG WHERE TenLoaiPhong = '" + roomType + "'");
                string roomTypeId = dt.Rows[0]["MaLoaiPhong"].ToString();

                exc.executeNonQuery("INSERT INTO DANHMUCPHONG VALUES('" + roomId.ToString() + "','" + txtRoomName.Text + "','Khong','" + roomTypeId + "','" + txtNote.Text + "')");

                roomId++;
                exc.setID("MaPhong", roomId);
                MessageBox.Show("Them phong thanh cong");
                Close();
            }
        }
        public void clearAddRoom()
        {
            txtRoomName.Text = "";
            cbbRoomType.SelectedIndex = -1;
            txtNote.Text = "";
        }
    }
}
