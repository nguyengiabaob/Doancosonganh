using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doancosonganh
{
    class TBhoadonct:ModuleDB
    {
        public TBhoadonct() : base("TBL_HOADONCT") { }
        public TBhoadonct(string query) : base("TBL_HOADONCT", query) { }
    }
}
