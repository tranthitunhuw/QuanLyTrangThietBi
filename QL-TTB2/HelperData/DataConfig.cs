using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using QL_TTB2.Models;
namespace QL_TTB2.HelperData
{
  class DataConfig
    {

        // SqlConnection conn = ConnDatabase.connect;
        SqlConnection conn = new SqlConnection();
        
        public DataConfig()
        {
            KetNoi();
        }

        void KetNoi()
        {
            if (conn.State == ConnectionState.Closed)
               conn.Open();
        }


        public DataSet LayDuLieu(SqlCommand sqlcmd)
        {
            DataSet ds = new DataSet();
           sqlcmd.Connection = conn;
            SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
            da.Fill(ds);
            return ds;
        }

        public int CapNhatDL(SqlCommand sqlcmd)
        {
            try
            {
                SqlCommand cmd = sqlcmd;
               // cmd.Connection = conn;
                int kq = cmd.ExecuteNonQuery();
                return kq;
            }
            catch (Exception ce)
            {
                Console.Write(ce.Message);
                return -9999;
            }

        }

        public bool CheckStatusLogin()
        {
            if (frmDangNhap.resultLogin == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



    }

}
