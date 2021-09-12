using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1911191_Lab03_Bai01
{
    public partial class frmSinhVien : Form
    {
        QuanLySinhVien qlsv;
        public frmSinhVien()
        {
            InitializeComponent();
        }
        private SinhVien GetSinhVien()
        {
            SinhVien sv = new SinhVien();
            bool gt = true;
            List<string> cn = new List<string>();
            sv.maSo = this.mtMaSo.Text;
            sv.hoTen = this.txtHoTen.Text;
            sv.ngaySinh = this.dtNgaySinh.Value;
            sv.diaChi = this.txtDiaChi.Text;
            sv.lop = this.cbLop.Text;
            sv.hinh = this.txtHinh.Text;
            if (rbNam.Checked)
                gt = true;
            else if (rbNu.Checked)
                gt = false;
            sv.gioiTinh = gt;
            for (int i = 0; i < this.clbChuyenNganh.Items.Count; i++)
                if (clbChuyenNganh.GetItemChecked(i))
                    cn.Add(clbChuyenNganh.Items[i].ToString());
            sv.chuyenNganh = cn;
            return sv;
        }
        private SinhVien GetSinhVienLV(ListViewItem lvi)
        {
            SinhVien sv = new SinhVien();
            sv.maSo = lvi.SubItems[0].Text;
            sv.hoTen = lvi.SubItems[1].Text;
            sv.ngaySinh = DateTime.Parse(lvi.SubItems[2].Text);
            sv.diaChi = lvi.SubItems[3].Text;
            sv.lop = lvi.SubItems[4].Text;
            sv.gioiTinh = false;
            if (lvi.SubItems[5].Text == "Nữ") sv.gioiTinh = false;
            else if (lvi.SubItems[5].Text == "Nam")
                sv.gioiTinh = true;
            List<string> cn = new List<string>();
            string[] s = lvi.SubItems[6].Text.Split(',');
            foreach (string t in s)
                cn.Add(t);
            sv.chuyenNganh = cn;
            sv.hinh = lvi.SubItems[7].Text;
            return sv;
        }
        private void ThietLapThongTin(SinhVien sv)
        {
            this.mtMaSo.Text = sv.maSo;
            this.txtHoTen.Text = sv.hoTen;
            this.dtNgaySinh.Value = sv.ngaySinh;
            this.txtDiaChi.Text = sv.diaChi;
            this.cbLop.Text = sv.lop;
            this.txtHinh.Text = sv.hinh;
            if (sv.gioiTinh)
                this.rbNam.Checked = true;
            else
                this.rbNu.Checked = true;

            for (int i = 0; i < this.clbChuyenNganh.Items.Count; i++) this.clbChuyenNganh.SetItemChecked(i, false);
            foreach (string s in sv.chuyenNganh)
            {
                for (int i = 0; i < this.clbChuyenNganh.Items.Count; i++)
                {
                    if (s.CompareTo(this.clbChuyenNganh.Items[i]) == 0)
                    {
                        this.clbChuyenNganh.SetItemChecked(i, true);
                    }
                }
            }
        }
        private void ThemSV(SinhVien sv)
        {
            ListViewItem lvi = new ListViewItem(sv.maSo);
            lvi.SubItems.Add(sv.hoTen);
            lvi.SubItems.Add(sv.ngaySinh.ToShortDateString());
            lvi.SubItems.Add(sv.diaChi);
            lvi.SubItems.Add(sv.lop);
            string gt = "Nữ";
            if (!sv.gioiTinh)
                gt = "Nữ";
            else
                gt = "Nam";
            lvi.SubItems.Add(gt);
            string cn = "";
            foreach (string s in sv.chuyenNganh)
            {
                cn += s + ",";
            }
            cn = cn.Substring(0, cn.Length - 1);
            lvi.SubItems.Add(cn);
            lvi.SubItems.Add(sv.hinh);
            this.lvSV.Items.Add(lvi);
        }
        private void LoadListView()
        {
            this.lvSV.Items.Clear();
            foreach (SinhVien sv in qlsv.danhSach)
            {
                ThemSV(sv);
            }
        }

        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            qlsv = new QuanLySinhVien();
            qlsv.DocTuFile();
            LoadListView();
            tsslTongSV.Text = "Tổng số sinh viên là: " + lvSV.Items.Count;
        }

        private void lvSV_SelectedIndexChanged(object sender, EventArgs e)
        {
            int count = this.lvSV.SelectedItems.Count;
            if (count > 0)
            {
                ListViewItem lvi = this.lvSV.SelectedItems[0];
                SinhVien sv = GetSinhVienLV(lvi);
                ThietLapThongTin(sv);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            SinhVien sv = GetSinhVien();
            SinhVien kq = qlsv.Tim(sv.maSo, delegate (object o1, object o2)
            {
                return (o2 as SinhVien).maSo.CompareTo(o1.ToString());
            });
            if (kq != null)
            {
                MessageBox.Show("Mã sinh viên đã tồn tại!", "Lỗi thêm dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.qlsv.Them(sv);
                this.LoadListView();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int count, i;
            ListViewItem lvi;
            count = this.lvSV.Items.Count - 1;

            for (i = count; i >= 0; i--)
            {
                lvi = this.lvSV.Items[i];
                if (lvi.Checked)
                {
                    qlsv.Xoa(lvi.SubItems[0].Text, SoSanhTheoMa);
                }
            }
            this.LoadListView();
            this.btnMD.PerformClick();
        }

        private void btnMD_Click(object sender, EventArgs e)
        {
            this.mtMaSo.Text = "";
            this.txtHoTen.Text = "";
            this.dtNgaySinh.Value = DateTime.Now;
            this.txtDiaChi.Text = "";
            this.cbLop.Text = this.cbLop.Items[0].ToString();
            this.txtHinh.Text = "";
            this.pbHinh.ImageLocation = "";
            this.rbNam.Checked = true;
            for (int i = 0; i < this.clbChuyenNganh.Items.Count - 1; i++)
                this.clbChuyenNganh.SetItemChecked(i, false);
            this.pbHinh.Image = null;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SinhVien sv = GetSinhVien();
            bool kqsua;
            kqsua = qlsv.Sua(sv, sv.maSo, SoSanhTheoMa);
            if (kqsua)
            {
                this.LoadListView();
            }
        }
        private int SoSanhTheoMa(object o1, object o2)
        {
            SinhVien sv = o2 as SinhVien;
            return sv.maSo.CompareTo(o1);
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Các file hình ảnh|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
            openFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtHinh.Text = openFileDialog1.FileName;
                pbHinh.Image = new Bitmap(openFileDialog1.FileName);
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void sắpXếpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
