using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHS
{
    class tblHocSinh
    {
        private string taikhoan;
        private string matkhau;

        public tblHocSinh(string u,string p)
        {
            Taikhoan = u;
            Matkhau = p;
        }

        public string Taikhoan { get => taikhoan; set => taikhoan = value; }
        public string Matkhau { get => matkhau; set => matkhau = value; }
    }
}
