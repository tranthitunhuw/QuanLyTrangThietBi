using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_TTB2.Models
{
    public class ConnDatabase1
    {
        private static SqlConnection connect = new SqlConnection(@"Data Source=.;Initial Catalog=QuanLyTrangThietBiDTH;Integrated Security=True");
    }
}
