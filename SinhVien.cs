using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1911191_Lab03_Bai01
{
    public class SinhVien
    {
        public string maSo { get; set; }
        public string hoTen { get; set; }
        public DateTime ngaySinh { get; set; }
        public string diaChi { get; set; }
        public string lop { get; set; }
        public string hinh { get; set; }
        public bool gioiTinh { get; set; }
        public List<string> chuyenNganh { get; set; }
        public SinhVien()
        {
            chuyenNganh = new List<string>();
        }
        public SinhVien(string ms, string ten, DateTime ngay, string dc, string lop, string hinh, bool gt, List<string> cn)
        {
            this.maSo = ms;
            this.hoTen = ten;
            this.ngaySinh = ngay;
            this.diaChi = dc;
            this.lop = lop;
            this.hinh = hinh;
            this.gioiTinh = gt;
            this.chuyenNganh = cn;
        }
    }
}
