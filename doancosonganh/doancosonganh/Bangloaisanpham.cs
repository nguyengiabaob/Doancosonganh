using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doancosonganh
{
    class Bangloaisanpham:ModuleDB
    {
        public Bangloaisanpham() : base("TBL_LOAISANPHAM") { }
        public Bangloaisanpham(string query) : base("TBL_LOAISANPHAM",query) { }
    }
}
