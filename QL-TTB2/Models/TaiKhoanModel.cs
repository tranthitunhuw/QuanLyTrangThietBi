using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_TTB2.HelperData;
namespace QL_TTB2.Models
{
    internal class TaiKhoanModel
    {
        DataConfig cls = new DataConfig();

        public DataSet GetDataAccount(string idCustomer)
        {
            SqlCommand sqlcmd;
            if (cls.CheckStatusLogin() == true)
            {
                sqlcmd = new SqlCommand("SELECT * FROM TAIKHOAN");
            }
            else
            {
                sqlcmd = new SqlCommand("SELECT * FROM TAIKHOAN WHERE MaNV = '" + frmDangNhap.getMaNVDangNhap() + "'");
            }
            return cls.LayDuLieu(sqlcmd);
        }

       /* public void HienThi(DataGridView dgv)
        {
            dgv.DataSource = GetDataAccount(frmDangNhap.getMaNVDangNhap().Tables[0]);
        }*/

        public int Update(TaiKhoanModel acc)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "UPDATE Account SET PassWord_Customer = @pass WHERE Id_Customer = @id AND User_Name_Customer = @ten; ";

           // cmd.Parameters.Add("ten", SqlDbType.NVarChar).Value = acc.TenTK;
           // cmd.Parameters.Add("pass", SqlDbType.NVarChar).Value = acc.MatKhau;
           // cmd.Parameters.Add("MaNV", SqlDbType.Int).Value = acc.MaNV;

            return cls.CapNhatDL(cmd);
        }

        public int Save(TaiKhoanModel acc)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO TAIKHOAN VALUES (@MaNV, @TenTK, @MatKhau)";

           /// cmd.Parameters.Add("TenTK", SqlDbType.NVarChar).Value = acc.TenTK;
           // cmd.Parameters.Add("MatKhau", SqlDbType.VarChar).Value = acc.MatKhau;
           // cmd.Parameters.Add("MaNV", SqlDbType.Int).Value = acc.MaNV;

            return cls.CapNhatDL(cmd);
        }
        //
        public int Xoa(string manv, string tentk, string matkhau)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "DELETE FROM TAIKHOAN WHERE MaNV= @manv AND tentk = @tentk AND matkhau = @matkhau";
            cmd.Parameters.Add("manv", SqlDbType.Int).Value = Convert.ToInt32(manv);
            cmd.Parameters.Add("tentk", SqlDbType.NVarChar).Value = tentk;
            cmd.Parameters.Add("matkhau", SqlDbType.VarChar).Value = matkhau;
            return cls.CapNhatDL(cmd);
        }

        public DataSet getListAcc(string key, string tieuchi)
        {
            string sql = "SELECT * FROM TAIKHOAN WHERE ";

            switch (tieuchi)
            {
                case "MaNV":
                    sql += "MaNV = " + key + "";
                    break;
                default:
                    sql += "TenTK like '%" + key + "%'";
                    break;
            }
            try
            {
                SqlCommand sqlcmd = new SqlCommand(sql);
                return cls.LayDuLieu(sqlcmd);
            }
            catch (Exception ce)
            {
                MessageBox.Show("Null " + ce.Message);
                return null;
            }

        }
    }
}

