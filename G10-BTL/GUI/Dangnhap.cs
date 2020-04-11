using System;
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
    public partial class Dangnhap : Form
    {
        QLTHEntities db = new QLTHEntities();
        public Dangnhap()
        {
            InitializeComponent();
        }

        private void Dangnhap_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            NguoiDung nd = db.NguoiDung.Where(m => m.TaiKhoan == txtname.Text && m.MatKhau == txtpasswold.Text).SingleOrDefault();
            if(nd == null)
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác!", "Đăng nhập không thành công", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                ChucVu cv = db.ChucVu.Where(m => m.MaChucVu == nd.MaChucVu).SingleOrDefault();
                if(cv.ChucVu1 == "admin")
                {
                    QuanLy ql = new QuanLy();
                    this.Hide();
                    ql.ShowDialog();
                    this.Show();
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát ứng dụng không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
