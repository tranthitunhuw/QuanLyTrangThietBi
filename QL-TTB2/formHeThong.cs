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
using QL_TTB2.View;
namespace QL_TTB2
{
    public partial class formHeThong : Form
    {
        public formHeThong()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            /*Form formulario;
            formulario = panelformularios.Controls.OfType<MiForm>().FirstOrDefault();
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelformularios.Controls.Add(formulario);
                panelformularios.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
                formulario.FormClosed += new FormClosedEventHandler(CloseForms);
            }
            else
            {
                formulario.BringToFront();
            }*/

        }
        private void CloseForms(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms["QuanLyTaiKhoan"] == null)
                btnQLTaiKhoan.BackColor = Color.FromArgb(4, 41, 68);
            if (Application.OpenForms["QuanLyNguoiDung"] == null)
                btnQLNhanVien.BackColor = Color.FromArgb(4, 41, 68);
            if (Application.OpenForms["QuanLyNhomNguoiDung"] == null)
                btnQLNhomNguoiDung.BackColor = Color.FromArgb(4, 41, 68);
          
           
            if (Application.OpenForms["QuanLyThongKe"] == null)
                btnThongKeTB.BackColor = Color.FromArgb(4, 41, 68);
            if (Application.OpenForms["QuanLyLoaiThietBi"] == null)
                btnQLLoaiThietBi.BackColor = Color.FromArgb(4, 41, 68);
        }

        private void resetColorForButton()
        {
            btnQLTaiKhoan.BackColor = Color.FromArgb(4, 41, 68);
 
            btnQLThietBi.BackColor = Color.FromArgb(4, 41, 68);
            btnQLLoaiThietBi.BackColor = Color.FromArgb(4, 41, 68);
            btnQLPhong.BackColor = Color.FromArgb(4, 41, 68);
            btnThongKeTB.BackColor = Color.FromArgb(4, 41, 68);
            btnQLNhomNguoiDung.BackColor = Color.FromArgb(4, 41, 68);

        }
        private void btnQLTaiKhoan_Click(object sender, EventArgs e)
        {
            frmQLTaiKhoan TK = new frmQLTaiKhoan();
            TK.ShowDialog();
            /*resetColorForButton();
            AbrirFormulario<frmQLTaiKhoan>();
            btnQLTaiKhoan.BackColor = Color.FromArgb(0, 154, 205);
        */
        }

        private void formHeThong_Load(object sender, EventArgs e)
        {



        }

        private void label4_Click(object sender, EventArgs e)
        {
            frmGioiThieu gt = new frmGioiThieu();
            gt.Show();
        }
        public static bool onLoadCheckAccLogin()
        {
            //query data
            try
            {
                //string query = "SELECT * FROM Account WHERE Id_Customer = " + Login.getIdCustomerLogin() + "";
                //action get database
               // SqlConnection connect = ConnectDatabase.connect;
                //SqlDataAdapter sqldata = new SqlDataAdapter(query, connect);
                DataTable result = new DataTable();
               // sqldata.Fill(result);
                // check database
                if (result.Rows.Count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ce)
            {
                MessageBox.Show(ce.Message);
                return false;
            }
        }
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (!onLoadCheckAccLogin())
            {
                this.Close();
            }
            DateTime datetime = DateTime.Now;
            this.lbtGio.Text = datetime.ToString("HH:mm:ss");
            this.lbNgayThang.Text = datetime.ToString("dd/MM/yyyy");
            this.lbThu.Text = datetime.ToString("dddd");
        }
        private void lbtGio_Click(object sender, EventArgs e)
        {

        }

        private void btnQLNhanVien_Click(object sender, EventArgs e)
        {
            frmNhanVien nv = new frmNhanVien();
            nv.Show();
        }

        private void btnQLNhomNguoiDung_Click(object sender, EventArgs e)
        {
            frmQLChucVu cv = new frmQLChucVu();
            cv.ShowDialog();
        }
    }
}
