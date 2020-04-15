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
    public partial class QuanLy : Form
    {
        public QuanLy()
        {
            InitializeComponent();
        }

        private void QuanLy_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            GUI.TrangChu tc = new GUI.TrangChu();
            tc.MdiParent = this;
            tc.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void quảnLýHọcSinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();
            GUI.QuanlyHocSinh hs = new GUI.QuanlyHocSinh();
            hs.MdiParent = this;
            hs.StartPosition = FormStartPosition.CenterParent;
            hs.Show();
        }

        private void trangChuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();
            GUI.TrangChu tc = new GUI.TrangChu();
            tc.MdiParent = this;
            tc.Show();
        }

        private void quảnLýGiáoViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();
            GUI.QuanlyGiaoVien gv = new GUI.QuanlyGiaoVien();
            gv.MdiParent = this;
            gv.Show();
        }

        private void quảnLýLớpHọcNhậpĐiểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();
            GUI.Lop lp = new GUI.Lop();
            lp.MdiParent = this;
            lp.Show();
        }

        private void mônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();
            GUI.MonHoc mh = new GUI.MonHoc();
            mh.MdiParent = this;
            mh.Show();
        }

        private void kếtQuảHọcTậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();
            GUI.KQHocTap kq = new GUI.KQHocTap();
            kq.MdiParent = this;
            kq.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
