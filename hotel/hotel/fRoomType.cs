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
    public partial class fRoomType : Form
    {
        SqlExecuter exc = new SqlExecuter();
        public fRoomType()
        {
            InitializeComponent();
            showTable();
        }

        private void btnAddRoomType_Click(object sender, EventArgs e)
        {
            fAddRoomType new_rt = new fAddRoomType();
            new_rt.Show();
            new_rt.FormClosed += new FormClosedEventHandler(fAddRoomType_Closed);
        }

        void fAddRoomType_Closed(object sender, FormClosedEventArgs e)
        {
            fAddRoomType new_rt = (fAddRoomType)sender;
            showTable();
        }

        private void btnEditRoomType_Click(object sender, EventArgs e)
        {
            fUpdateRoomType update_rt = new fUpdateRoomType(); 
            update_rt.Show();
        }

        public void showTable()
        {
            dataRoomType.DataSource = exc.executeQuery("SELECT MaLoaiPhong as 'Mã Loại Phòng', TenLoaiPhong as 'Tên Loại Phòng',DonGiaTC as 'Đơn giá', SoLuong as 'Số lượng' FROM LOAIPHONG");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnDelRoomType_Click(object sender, EventArgs e)
        {
            if (dataRoomType.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui long chon 1 dong");
                return;
            }

            if (dataRoomType.SelectedRows.Count > 1)
            {
                MessageBox.Show("Vui long chi chon 1 dong");
                return;
            }

            string MaLP = dataRoomType.SelectedRows[0].Cells[0].Value.ToString();

            if(exc.executeQuery("SELECT MaPhong FROM DANHMUCPHONG WHERE MaLoaiPhong = '" + MaLP + "'").Rows.Count != 0)
            {
                MessageBox.Show("Khong xoa duoc do van con phong thuoc loai phong nay");
                return;
            }
            exc.executeNonQuery("DELETE FROM LOAIPHONG WHERE MaLoaiPhong = '" + MaLP + "'");
            showTable();
        }

        private void dataRoomType_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
