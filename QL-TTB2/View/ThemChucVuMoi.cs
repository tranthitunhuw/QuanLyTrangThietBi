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
    public partial class ThemChucVuMoi : Form
    {
        public ThemChucVuMoi()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            ThemChucVuMoi cvm = new ThemChucVuMoi();
            this.Close();

        }
    }
}
