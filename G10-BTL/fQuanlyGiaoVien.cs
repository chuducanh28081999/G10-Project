﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G10_BTL.GUI
{
    public partial class fQuanlyGiaoVien : Form
    {
        public fQuanlyGiaoVien()
        {
            InitializeComponent();
        }

        QuanLyTruongHocEntities db = new QuanLyTruongHocEntities();

        private void QuanlyGiaoVien_Load(object sender, EventArgs e)
        {
            dgvData.Rows.Clear();
            List<GiaoVien> listgv = db.GiaoVien.Where(m=>m.trangThai == true).ToList();
            foreach(GiaoVien i in listgv)
            {
                dgvData.Rows.Add(i.maGV, i.ten, i.ngaySinh, i.gioiTinh, i.diaChi, i.sdt, i.bangCap, i.tgBatDau);
            }
            dtpNgaySinh.Text = DateTime.Now.Day.ToString() + "/" + DateTime.Now.Month.ToString() + "/" + DateTime.Now.Year.ToString();
            dtpNgayVaoLam.Text = DateTime.Now.Day.ToString() + "/" + DateTime.Now.Month.ToString() + "/" + DateTime.Now.Year.ToString();
            txtMaGV.Enabled = false;
            txtMaGV.Text = (db.GiaoVien.Max(m=>m.maGV)+1).ToString();
            rdbNam.Checked = true;
            txtBangCap.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
            txtTenGV.Text = "";
            txtTenDangNhap.Text = "";
            txtMatKhau.Text = "";
        }

        private bool KiemTra()
        {
            string tengv = "", taikhoan = "", matkhau = "", ngaysinh = "", gioitinh = "", sdt = "", diachi = "", bangcap = "", ngayvaolam = "";
            tengv = txtTenGV.Text;
            ngaysinh = dtpNgaySinh.Text;
            if (rdbNam.Checked)
            {
                gioitinh = "Nam";
            }
            else
            {
                gioitinh = "Nu";
            }
            sdt = txtSDT.Text;
            diachi = txtDiaChi.Text;
            bangcap = txtBangCap.Text;
            ngayvaolam = dtpNgayVaoLam.Text;
            taikhoan = txtTenDangNhap.Text;
            matkhau = txtMatKhau.Text;
            if (tengv == "")
            {
                MessageBox.Show("Bạn chưa nhập tên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (taikhoan == "")
            {
                MessageBox.Show("Bạn chưa nhập tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (matkhau == "")
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (sdt == "")
            {
                MessageBox.Show("Bạn chưa nhập số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (diachi == "")
            {
                MessageBox.Show("Bạn chưa nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (bangcap == "")
            {
                MessageBox.Show("Bạn chưa nhập bằng cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            bool ck = true;
            for (int i = 0; i < taikhoan.Length; i++)
            {
                if (taikhoan[i] >= 'a' && taikhoan[i] <= 'z' || taikhoan[i] >= 'A' && taikhoan[i] <= 'A' || taikhoan[i] >= '0' && taikhoan[i] <= '9')
                {
                    continue;
                }
                else
                {
                    ck = false;
                }
            }
            if (!ck)
            {
                MessageBox.Show("Tài khoản không hớp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            for (int i = 0; i < matkhau.Length; i++)
            {
                if (matkhau[i] >= 'a' && matkhau[i] <= 'z' || matkhau[i] >= 'A' && matkhau[i] <= 'A' || matkhau[i] >= '0' && matkhau[i] <= '9')
                {
                    continue;
                }
                else
                {
                    ck = false;
                }
            }
            if (!ck)
            {
                MessageBox.Show("Mật khẩu không hớp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            for (int i = 0; i < sdt.Length; i++)
            {
                if (sdt[i] >= '0' && sdt[i] <= '9')
                {
                    continue;
                }
                else
                {
                    ck = false;
                }
            }
            if (!ck || sdt.Length != 10 || (sdt[1] != '9' && sdt[1] != '3'))
            {
                MessageBox.Show("Số điện thoạt không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            return true;
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            if (!KiemTra())
            {
                return;
            }

            int ma = int.Parse(txtMaGV.Text.ToString());
            GiaoVien gvv = db.GiaoVien.Where(m => m.maGV == ma).SingleOrDefault();
            if(gvv != null)
            {
                return;
            }
            string tengv = "", taikhoan = "", matkhau = "", ngaysinh = "", gioitinh = "", sdt = "", diachi = "", bangcap = "", ngayvaolam = "";
            tengv = txtTenGV.Text;
            ngaysinh = dtpNgaySinh.Text;
            if (rdbNam.Checked)
            {
                gioitinh = "Nam";
            }
            else
            {
                gioitinh = "Nu";
            }
            sdt = txtSDT.Text;
            diachi = txtDiaChi.Text;
            bangcap = txtBangCap.Text;
            ngayvaolam = dtpNgayVaoLam.Text;
            taikhoan = txtTenDangNhap.Text;
            matkhau = txtMatKhau.Text;
            
            GiaoVien gv = new GiaoVien();
            gv.maGV = ma;
            gv.taiKhoan = taikhoan;
            gv.matKhau = matkhau;
            gv.bangCap = bangcap;
            gv.diaChi = diachi;
            gv.gioiTinh = gioitinh;
            gv.ngaySinh = DateTime.Parse(ngaysinh);
            gv.sdt = sdt;
            gv.ten = tengv;
            gv.tgBatDau = DateTime.Parse(ngayvaolam);
            gv.trangThai = true;
            db.GiaoVien.Add(gv);
            db.SaveChanges();
            MessageBox.Show("Thêm mới giáo viên " + tengv + " thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            QuanlyGiaoVien_Load(sender, e);
        }

        private void dgvData_SelectionChanged(object sender, EventArgs e)
        {

            int index = dgvData.CurrentRow.Index;
            int magv = int.Parse(dgvData.Rows[index].Cells[0].Value.ToString());
            GiaoVien gv = db.GiaoVien.Where(m => m.maGV == magv).FirstOrDefault();
            txtBangCap.Text = gv.bangCap;
            txtDiaChi.Text = gv.diaChi;
            txtMaGV.Text = gv.maGV.ToString();
            txtMatKhau.Text = gv.matKhau;
            txtSDT.Text = gv.sdt.ToString();
            txtTenDangNhap.Text = gv.taiKhoan;
            txtTenGV.Text = gv.ten;
            if(gv.gioiTinh == "Nam")
            {
                rdbNam.Checked = true;
            }
            else
            {
                rdbNu.Checked = true;
            }
            dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgayVaoLam.CustomFormat = "dd/MM/yyyy";
            dtpNgayVaoLam.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.Value = DateTime.Parse(gv.ngaySinh.ToString());
            dtpNgayVaoLam.Value = DateTime.Parse(gv.tgBatDau.ToString());
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int index = dgvData.CurrentRow.Index;
            int magv = int.Parse(dgvData.Rows[index].Cells[0].Value.ToString());
            GiaoVien gv = db.GiaoVien.Where(m => m.maGV == magv).FirstOrDefault();
            DialogResult result = MessageBox.Show("Bạn có muốn xóa giáo viên " + gv.ten, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if(result == DialogResult.Yes)
            {
                GiaoVien giaovien = db.GiaoVien.Where(m => m.maGV == gv.maGV).FirstOrDefault();
                giaovien.trangThai = false;
                db.SaveChanges();
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                QuanlyGiaoVien_Load(sender, e);
                return;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            QuanlyGiaoVien_Load(sender, e);
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            int ma = int.Parse(txtMaGV.Text.ToString());
            GiaoVien gvv = db.GiaoVien.Where(m => m.maGV == ma).SingleOrDefault();
            if (gvv == null)
            {
                return;
            }
            string tengv = "", taikhoan = "", matkhau = "", ngaysinh = "", gioitinh = "", sdt = "", diachi = "", bangcap = "", ngayvaolam = "";
            tengv = txtTenGV.Text;
            ngaysinh = dtpNgaySinh.Text;
            if (rdbNam.Checked)
            {
                gioitinh = "Nam";
            }
            else
            {
                gioitinh = "Nu";
            }
            sdt = txtSDT.Text;
            diachi = txtDiaChi.Text;
            bangcap = txtBangCap.Text;
            ngayvaolam = dtpNgayVaoLam.Text;
            GiaoVien gv = db.GiaoVien.Where(m => m.maGV == ma).FirstOrDefault();
            gv.bangCap = bangcap;
            gv.diaChi = diachi;
            gv.gioiTinh = gioitinh;
            gv.ngaySinh = DateTime.Parse(ngaysinh);
            gv.sdt = sdt;
            gv.ten = tengv;
            gv.tgBatDau = DateTime.Parse(ngayvaolam);
            gv.trangThai = true;
            db.SaveChanges();
            MessageBox.Show("Cập nhật thông tin giáo viên " + tengv + " thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            QuanlyGiaoVien_Load(sender, e);
        }

        private void txtMaGV_TextChanged(object sender, EventArgs e)
        {
            int ma = int.Parse(txtMaGV.Text.ToString());
            GiaoVien gvv = db.GiaoVien.Where(m => m.maGV == ma).FirstOrDefault();
            if (gvv != null)
            {
                txtTenDangNhap.Enabled = false;
                txtMatKhau.Enabled = false;
            }
            else
            {
                txtTenDangNhap.Enabled = true;
                txtMatKhau.Enabled = true;
            }
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            dgvData.Rows.Clear();
            List<GiaoVien> listgv = new List<GiaoVien>();
            if (txtMaGVTimKiem.Text != "")
            {
                int ma = int.Parse(txtMaGVTimKiem.Text);
                listgv = db.GiaoVien.Where(m => m.trangThai == true && m.maGV == ma).ToList();
            }
            else
            {
                listgv = db.GiaoVien.Where(m => m.trangThai == true).ToList();
            }
            if(txtTenGVTimKiem.Text != "")
            {
                listgv = listgv.Where(m => m.ten.ToUpper().Contains(txtTenGVTimKiem.Text.ToUpper())).ToList();
            }
            foreach (GiaoVien i in listgv)
            {
                dgvData.Rows.Add(i.maGV, i.ten, i.ngaySinh, i.gioiTinh, i.diaChi, i.sdt, i.bangCap, i.tgBatDau);
            }
            dtpNgaySinh.Text = DateTime.Now.Day.ToString() + "/" + DateTime.Now.Month.ToString() + "/" + DateTime.Now.Year.ToString();
            dtpNgayVaoLam.Text = DateTime.Now.Day.ToString() + "/" + DateTime.Now.Month.ToString() + "/" + DateTime.Now.Year.ToString();
            txtMaGV.Enabled = false;
            List<GiaoVien> lgv = db.GiaoVien.ToList();
            txtMaGV.Text = (lgv.Count() + 1).ToString();
            rdbNam.Checked = true;
            txtBangCap.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
            txtTenGV.Text = "";
            txtTenDangNhap.Text = "";
            txtMatKhau.Text = "";
        }
    }
}
