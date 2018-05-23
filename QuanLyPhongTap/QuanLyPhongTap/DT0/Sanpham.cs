using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongTap.DT0
{
    class Sanpham
    {
        private string masp;
        private string tensp;
        private int gia;
        private string nguongoc;

        public string Masp
        {
            get { return masp; }
            set { masp = value; }
        }
        public string Tensp
        {
            get { return tensp; }
            set { tensp = value; }
        }
        public int Gia
        {
            get { return gia; }
            set { gia = value; }
        }
        public string Nguonngoc
        {
            get { return nguongoc; }
            set { nguongoc = value; }
        }
    }
}
