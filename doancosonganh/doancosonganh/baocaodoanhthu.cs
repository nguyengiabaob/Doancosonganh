using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace doancosonganh
{
    public partial class baocaodoanhthu : Form
    {
        public baocaodoanhthu()
        {
            InitializeComponent();
        }
        ComboBox loai_=null;
        TextBox tensanpham_=null;
        DateTimePicker ngaybd_=null;
        DateTimePicker ngaykt_=null;
        public baocaodoanhthu(ComboBox loai ,TextBox tensanpham,DateTimePicker ngaybd,DateTimePicker ngaykt)
        {
            InitializeComponent();
            loai_ = loai;
            tensanpham_ = tensanpham;
            ngaybd_ = ngaybd;
            ngaykt_ = ngaykt;
        }

    }
}
