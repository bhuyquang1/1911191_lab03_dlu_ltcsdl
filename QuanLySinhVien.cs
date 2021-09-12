using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1911191_Lab03_Bai01
{
    public delegate int SoSanh(object sv1, object sv2);
    public class QuanLySinhVien
    {
        public List<SinhVien> danhSach;
        public QuanLySinhVien()
        {
            danhSach = new List<SinhVien>();
        }
        public void Them(SinhVien sv)
        {
            this.danhSach.Add(sv);
        }
        public SinhVien this[int index]
        {
            get { return danhSach[index]; }
            set { danhSach[index] = value; }
        }
        public void Xoa(object obj, SoSanh ss)
        {
            int i = danhSach.Count - 1;
            for (; i >= 0; i--)
                if (ss(obj, this[i]) == 0)
                    this.danhSach.RemoveAt(i);
        }
        public SinhVien Tim(object obj, SoSanh ss)
        {
            SinhVien svResult = null;
            foreach (SinhVien sv in danhSach)
                if (ss(obj, sv) == 0)
                {
                    svResult = sv;
                    break;
                }
            return svResult;
        }
        public bool Sua(SinhVien svSua, object obj, SoSanh ss)
        {
            int i, count;
            bool kq = false;
            count = this.danhSach.Count - 1;
            for (i = 0; i < count; i++)
                if (ss(obj, this[i]) == 0)
                {
                    this[i] = svSua;
                    kq = true;
                    break;
                }
            return kq;
        }
        public void DocTuFile()
        {
            string fileName = "SinhVien.txt", t;
            string[] s;
            SinhVien sv;
            StreamReader sr = new StreamReader(new FileStream(fileName, FileMode.Open));
            while ((t = sr.ReadLine()) != null)
            {
                s = t.Split('\t');
                sv = new SinhVien();
                sv.maSo = s[0];
                sv.hoTen = s[1];
                sv.ngaySinh = DateTime.Parse(s[2]);
                sv.diaChi = s[3];
                sv.lop = s[4];
                sv.hinh = s[5];
                sv.gioiTinh = false;
                if (s[6] == "1") sv.gioiTinh = true;
                else if (s[6] == "0") sv.gioiTinh = false;
                string[] cn = s[7].Split(',');
                foreach (string c in cn)
                {
                    sv.chuyenNganh.Add(c);
                }
                this.Them(sv);
            }
        }
    }
}
