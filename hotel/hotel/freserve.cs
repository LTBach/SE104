using hotel.MDphong;
using hotel.PhieuThue;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using hotel.DAO;

namespace hotel
{
    public partial class freserve : Form
    {
        private DataRow dr;
        SqlExecuter exc = new SqlExecuter();
        double basePrice = 0;
        public freserve(DataRow dr)
        {
            InitializeComponent();

            this.dr = dr;
            lbRoomName.Text = dr["TenPhong"].ToString();
            lbRoomType.Text = dr["TenLoaiPhong"].ToString();
            lbPrice.Text = dr["DonGiaTC"].ToString();
            basePrice = double.Parse(lbPrice.Text);
            lbPeopleNum.Text = dataCustomer.Rows.Count.ToString();

            DataTable dt = exc.executeQuery("SELECT TenLoaiKH FROM LOAIKHACHHANG");
            foreach (DataRow row in dt.Rows) 
            {
                cbbCustomerType.Items.Add(row["TenLoaiKH"]);
            }

            //dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            //dateTimePicker1.Format = DateTimePickerFormat.Custom;
        }


        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Console.Write(dataCustomer.ColumnCount);
            //MessageBox.Show(dataGridView1.ColumnCount);
        }

        private void updatePrice()
        {
            double maxHeSo = 1;
            double newPrice = 0;
            double tmpValue = 0;
            DataTable dt = new DataTable();
            
            foreach (DataGridViewRow row in dataCustomer.Rows)
            {
                if (row.Cells[0].Value == null) continue;
                dt = exc.executeQuery("SELECT HESO FROM LOAIKHACHHANG WHERE TENLOAIKH = '"+ row.Cells[1].Value.ToString() +"'");//
                tmpValue = double.Parse(dt.Rows[0]["HESO"].ToString());
                if (maxHeSo < tmpValue) maxHeSo = tmpValue;
            }
            newPrice = maxHeSo * basePrice;
            dt = new DataTable();
            dt = exc.executeQuery("SELECT GIATRI FROM THAMSO WHERE TENTS = 'SO KHACH TIEU CHUAN'");
            double sokhachTC = double.Parse(dt.Rows[0]["GIATRI"].ToString());
            double phuthu = 0;

            dt = new DataTable();
            dt = exc.executeQuery("SELECT GIATRI FROM THAMSO WHERE TENTS = 'PHU THU'");
            phuthu = double.Parse(dt.Rows[0]["GIATRI"].ToString());
            if (dataCustomer.Rows.Count-1 > (int)sokhachTC)
                newPrice = newPrice * (1.0 + phuthu);
            lbPrice.Text = newPrice.ToString();
        }

        private void btn_add_customer_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = exc.executeQuery("SELECT GIATRI FROM THAMSO WHERE TENTS = 'SO KHACH TOI DA'");
            double sokhachtoida = double.Parse(dt.Rows[0]["GIATRI"].ToString());
            
            if (dataCustomer.Rows.Count - 1 >= sokhachtoida)
            {
                MessageBox.Show("So khach khong duoc vuot qua " + sokhachtoida.ToString() + " khach! >:(", "Error");
                return;
            }

            KhachHang newrow = new KhachHang();
            newrow.cmnd = txtNational_ID.Text;
            newrow.diachi = txtAddress.Text;
            newrow.tenKH = txtCusName.Text;
            newrow.loaiKH = "";
            if (cbbCustomerType.SelectedIndex != -1) 
            {
                newrow.loaiKH = cbbCustomerType.SelectedItem.ToString();
            }
            if (newrow.notEmpty())
            {
                khachHangBindingSource.Add(newrow);
                dataCustomer.Update();
                dataCustomer.Refresh();
                txtAddress.Clear();
                txtCusName.Clear();
                txtNational_ID.Clear();
                updatePrice();
            }
            else
                MessageBox.Show("Khach hang phai co day du thong tin", "Error");
            lbPeopleNum.Text = (dataCustomer.Rows.Count-1).ToString();
            
            //dataGridView1.Rows.Add(newRow);
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNational_ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_del_custome_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataCustomer.SelectedRows) {
                dataCustomer.Rows.RemoveAt(row.Index);
            }
            lbPeopleNum.Text = (dataCustomer.Rows.Count-1).ToString();
            updatePrice();
            MessageBox.Show("Da xoa thanh cong");
        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            int peopleNum;
            
            if (!Int32.TryParse(lbPeopleNum.Text, out peopleNum) || peopleNum == 0)
            {
                MessageBox.Show("Lap phieu that bai");
                return;
            }
            int customerId = exc.getID("MaKH");
            string rentDay = dateRental.Value.ToString("yyyy/MM/dd");

            int reserveId = exc.getID("MaPhieuThue");

            exc.executeNonQuery("SET DATEFORMAT DMY");
            exc.executeNonQuery("INSERT INTO PHIEUTHUE VALUES('" + reserveId.ToString() + "','" + rentDay + "'," + lbPrice.Text +
                "," + lbPeopleNum.Text + ",'" + dr["MaPhong"].ToString() + "', null, null, null)");
            foreach (DataGridViewRow row in dataCustomer.Rows) 
            {
                if (row.Cells[0].Value == null) continue;

                string st = (string)row.Cells[1].Value;
                DataTable dt = exc.executeQuery("SELECT MaLoaiKH FROM LOAIKHACHHANG WHERE TenLoaiKH = '" + st +"'");
 
                string customerTypeId = dt.Rows[0]["MaLoaiKH"].ToString();

                exc.executeNonQuery("INSERT INTO KHACHHANG VALUES('" + customerId.ToString() + "','"
                    + row.Cells[0].Value.ToString() + "','" + row.Cells[2].Value.ToString() + "','" + row.Cells[3].Value.ToString() 
                    + "','" + customerTypeId + "')");
                exc.executeNonQuery("INSERT INTO CT_PHIEUTHUE VALUES('" + reserveId.ToString() + "','" + customerId.ToString() + "')");

                customerId++;
            }
            exc.setID("MaKH", customerId);
            exc.executeNonQuery("UPDATE DANHMUCPHONG SET Tinhtrang = 'Co nguoi' WHERE TenPhong = '" + lbRoomName.Text + "'");
            reserveId++;
            exc.setID("MaPhieuThue", reserveId);            
            Close();
        }
    }
}
