using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_TTB2.Models;

namespace QL_TTB2
{
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }
        bool them;
        //PhongBan _phongban;
        //NhanVien _nhanvien;
        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
           // _phongban = new PhongBan();
           // _nhanvien = new NhanVien();

          //  cbPhong.DataSource = _phongban.getList();
            cbPhong.DisplayMember = "TenPB";
            cbPhong.ValueMember = "MaPB";

        }
        void LoadData()
        {
            //data_NhanVien.DataSource = _nhanvien.getList();
        }
        void _enable()
        {
            
        }
    }
}
