using QL_TTB2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_TTB2;

namespace QL_TTB2
{
    public partial class frmDangNhap : Form
    {
        public static int resultLogin = -1;
        public static string tentaikhoan = "Unkown";
        public static string matkhau = "NULL";
        public static string tentk = "NULL";
      
        // 
    /// <summary>
    /// /   SqlConnection connect = ConnectDatabase.connect;
    /// </summary>

       

        // private TrangThietBiEntities db = new TrangThietBiEntities();
        //Connection database
        // SqlConnection conn = ConnectDatabase.connect;


        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }

       /* private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           
                if (radioButton1.Checked)
                {
                    txbMatKhau.PasswordChar = (char)0;
                }
                else
                {
                    txbMatKhau.PasswordChar = '*';
                }
            }*/


        /*
          string tentaikhoan = txbTaiKhoan.Text;
            string matkhau = txbMatKhau.Text;
            //
            CheckLogin(tentaikhoan, matkhau);
            ////
            ///  //gọi đến class MatKhau
            ///  
            MatKhau obj = new MatKhau();
            List<MatKhau> list = obj.GetAll();

            // string tenDangNhap = txbTenTaiKhoan.Text;
            //  string matKhau = txbMatKhau.Text;
            //var check = list.Where(item => item.tentaikhoan.Equals(tentaikhoan)).ToList();
            var TaiKhoan = db.TaiKhoans.Where(u => u.tentaikhoan.Equals(tentaikhoan)).ToList();
            var MatKhau = db.TaiKhoans.Where(u => u.matkhau.Equals(matkhau)).ToList();
            if (TaiKhoan.Count > 0)
            {
                if (TaiKhoan[0].matkhau.Equals(MatKhau))
                {
                    MessageBox.Show("Dang nhap thanh cong");
                    frmNhanVien mhc = new frmNhanVien();
                    mhc.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Mat khau khong dung!");
                }
            }
            else
            {
                MessageBox.Show("Khong ton tai tai khoan!");
            }
         
         */
        
        private void frmDangNhap_Load_1(object sender, EventArgs e)
        {

        }
        private void btnDangNhap_Click(object sender, System.EventArgs e)
        {
            View.frmQLTHIETBI t = new View.frmQLTHIETBI();
            t.Show();
            /*
            //query data
         ////   tentk = frmHeThong.checkInjectionSQL(txbTaiKhoan.Text.Trim());
          ////  matkhau = frmHeThong.checkInjectionSQL(txbMatKhau.Text.Trim());

            string query = "SELECT NHANVIEN.MaCV, NHANVIEN.TenNV " +
                "FROM TAIKHOAN " +
                "INNER JOIN NHANVIEN " +
                "ON TAIKHOAN.MaNV = NHANVIEN.MaNV " +
                "WHERE TAIKHOAN.TenTK = '" + tentk + "' " +
                "AND TAIKHOAN.MatKhau = '" + matkhau + "'; ";

            //action get database
            DataTable result = new DataTable();
            try
            {
               /// SqlDataAdapter sqldata = new SqlDataAdapter(query, connect);
                result = new DataTable();
               /// sqldata.Fill(result);
            }
            catch (Exception ce)
            {
                MessageBox.Show(ce.Message, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // check database
            if (rdbQTV.Checked)
            {
                try
                {
                    if (result.Rows[0]["MaCV"].ToString() == "1")
                    {
                        tentk = result.Rows[0]["TenNV"].ToString();
                        resultLogin = 1;
                        getfrmHeThong();
                    }
                    else
                    {
                        MessageBox.Show("Sai tài khoản hoặc mật khẩu!\nKiểm tra lại quyền đăng nhập!");
                    }
                }
                catch (Exception ce)
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu!\nKiểm tra lại quyền đăng nhập!\n" + ce.Message);
                }

            }
            else
            {
                try
                {
                    if (result.Rows.Count > 0 && result.Rows[0]["MaCV"].ToString() != "1")
                    {
                        tentk = result.Rows[0]["TenTK"].ToString();
                        resultLogin = 0;
                        getfrmHeThong();
                    }
                    else
                    {
                        MessageBox.Show("Sai tài khoản hoặc mật khẩu!\nKiểm tra lại quyền đăng nhập!");
                    }
                }
                catch (Exception ce)
                {
                    MessageBox.Show(ce.Message);
                }*/
        }

        private void txbTaiKhoan_Click(object sender, EventArgs e)
        {
            txbTaiKhoan.Clear();
        }

        private void txbMatKhau_Click(object sender, EventArgs e)
        {
            txbMatKhau.Clear();
        }

        private void txbTaiKhoan_MouseClick(object sender, MouseEventArgs e)
        {
            txbTaiKhoan.Clear();
        }

        private void txbMatKhau_MouseClick(object sender, MouseEventArgs e)
        {
            txbMatKhau.Clear();
        }
        private void getfrmHeThong()
        {
            frmGiaoDien hethong = new frmGiaoDien();
            hethong.Show();
        }
       public static string getMaNVDangNhap()
        {
            
            //query data
            try
            {
                string query = "SELECT MaNV FROM TAIKHOAN WHERE TenTK = '" + tentk + "' AND MatKhau = '" + matkhau + "'";
                //action get database
              //  SqlConnection connect = ConnectDatabase.connect;
               ///. SqlDataAdapter sqldata = new SqlDataAdapter(query, connect);
                DataTable result = new DataTable();
             ///   sqldata.Fill(result);
                // check database
               tentk = result.Rows[0]["MaNV"].ToString();
                return result.Rows[0]["MaNV"].ToString();
            }
            catch
            {
                return "NULL";
            }
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Thoát", "Thông báp", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
                this.Close();
        }
    }
}
