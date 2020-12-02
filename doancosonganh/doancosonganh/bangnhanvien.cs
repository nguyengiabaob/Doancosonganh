using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doancosonganh
{
    class bangnhanvien:ModuleDB
    {
        public bangnhanvien() : base("TBL_NHANVIEN"){ }
        public bangnhanvien(string query) : base("TBL_NHANVIEN", query) { }
    }
}
