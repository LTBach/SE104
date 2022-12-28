using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotel.PhieuThue
{
    public class KhachHang
    {
        public bool notEmpty()
        {
            return (this.tenKH != "" && this.loaiKH != "" && this.cmnd != "" && this.diachi != "");
        }
        public string tenKH { get; set; }
        public string loaiKH { get; set; }
        public string cmnd { get; set; }
        public string diachi { get; set; }
    }
    public class HoaDon
    {
        public string Phong { get; set; }

        public string SoNgayThue { get; set; }

        public string DonGia { get; set; }

        public string ThanhTien { get; set; }
    }

}
