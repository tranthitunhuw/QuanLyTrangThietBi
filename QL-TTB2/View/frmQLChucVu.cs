using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_TTB2.View
{
    public partial class frmQLChucVu : Form
    {
        public frmQLChucVu()
        {
            InitializeComponent();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ThemChucVuMoi cvm = new ThemChucVuMoi();
            cvm.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
