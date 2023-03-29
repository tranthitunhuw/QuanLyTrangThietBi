using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_TTB2.Object
{
    internal class TaiKhoanObj
    {
        private string _manv;
        public string MaNV
        {
            get { return _manv; }
            set { _manv = value; }
        }

        private string _tentk;

        public string TenTK
        {
            get { return _tentk; }
            set { _tentk = value; }
        }

        private string _matkhau;

        public string MatKhau
        {
            get { return _matkhau; }
            set { _matkhau = value; }
        }
    }
}
