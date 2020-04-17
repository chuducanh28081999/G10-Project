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

        private void trangChuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();
            GUI.TrangChu hs = new GUI.TrangChu();
            hs.MdiParent = this;
            //hs.StartPosition = FormStartPosition.CenterParent;
            hs.Show();
        }

        private void QuanLyAdmin_Load(object sender, EventArgs e)
        {
            trangChuToolStripMenuItem_Click(sender, e);
        }

        private void quanLyHcSinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();
            GUI.QuanlyHocSinh hs = new GUI.QuanlyHocSinh();
            hs.MdiParent = this;
            //hs.StartPosition = FormStartPosition.CenterParent;
            hs.Show();
        }

        private void quanLyGiaoVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();
            GUI.QuanlyGiaoVien hs = new GUI.QuanlyGiaoVien();
            hs.MdiParent = this;
            //hs.StartPosition = FormStartPosition.CenterParent;
            hs.Show();
        }

        private void lopHocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();
            GUI.Lop hs = new GUI.Lop();
            hs.MdiParent = this;
            //hs.StartPosition = FormStartPosition.CenterParent;
            hs.Show();
        }

        private void monHocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();
            GUI.MonHoc hs = new GUI.MonHoc();
            hs.MdiParent = this;
            //hs.StartPosition = FormStartPosition.CenterParent;
            hs.Show();
        }

        private void ketQuaHocTapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();
            GUI.KQHocTap hs = new GUI.KQHocTap();
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
    }
}
