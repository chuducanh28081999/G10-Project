using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G10_BTL
{
    public partial class QuanLyAdmin : Form
    {
        public QuanLyAdmin()
        {
            InitializeComponent();
        }

        QuanLyTruongHocEntities db = new QuanLyTruongHocEntities();
        HocSinh hs = new HocSinh();
        GiaoVien gv = new GiaoVien();

        private void trangChuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();
            GUI.fTrangChu fhs = new GUI.fTrangChu();
            fhs.MdiParent = this;
            //hs.StartPosition = FormStartPosition.CenterParent;
            if (hs != null)
            {
                fhs.Tag = hs;
            }
            else
            {
                fhs.Tag = gv;
            }
            fhs.Show();
        }

        private void QuanLyAdmin_Load(object sender, EventArgs e)
        {
            hs = this.Tag as HocSinh;
            gv = this.Tag as GiaoVien;
            trangChuToolStripMenuItem_Click(sender, e);
        }

        private void quanLyHcSinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();
            GUI.fQuanlyHocSinh hs = new GUI.fQuanlyHocSinh();
            hs.MdiParent = this;
            //hs.StartPosition = FormStartPosition.CenterParent;
            hs.Show();
        }

        private void quanLyGiaoVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();
            GUI.fQuanlyGiaoVien hs = new GUI.fQuanlyGiaoVien();
            hs.MdiParent = this;
            //hs.StartPosition = FormStartPosition.CenterParent;
            hs.Show();
        }

        private void lopHocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();
            GUI.fLop hs = new GUI.fLop();
            hs.MdiParent = this;
            //hs.StartPosition = FormStartPosition.CenterParent;
            hs.Show();
        }

        private void monHocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();
            GUI.fMonHoc hs = new GUI.fMonHoc();
            hs.MdiParent = this;
            //hs.StartPosition = FormStartPosition.CenterParent;
            hs.Show();
        }

        private void ketQuaHocTapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();
            GUI.fKQHocTap hs = new GUI.fKQHocTap();
            hs.MdiParent = this;
            //hs.StartPosition = FormStartPosition.CenterParent;
            hs.Show();
        }

        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn thoát ứng dụng không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if(dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void quảnLýĐiểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();
            GUI.fQuanlyDiem d = new GUI.fQuanlyDiem();
            d.MdiParent = this;
            //hs.StartPosition = FormStartPosition.CenterParent;
            if (hs != null)
            {
                d.Tag = hs;
            }
            else
            {
                d.Tag = gv;
            }
            d.Show();
        }
    }
}
