using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doancosonganh
{
    class taikhoan : ModuleDB
    {
        public taikhoan (): base("TBL_QUANLYTAIKHOAN" ) { }
        public taikhoan(string query) : base("TBL_QUANLYTAIKHOAN",query) { }

    }
}
