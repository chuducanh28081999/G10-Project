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
    public partial class fQuanlyDiem : Form
    {
        

        public fQuanlyDiem()
        {
            InitializeComponent();
            
        }

        private void QuanlyDiem_Load(object sender, EventArgs e)
        {
            dgvData.Rows.Clear();


        }
    }
}
