using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongTap.DT0
{
    class Hoadon
    {
        private string mahd;
        private string tensp;
        private string makh;
        private string manv;
        private DateTime ngaylap;
        private float tongtien;

       
       

        public string Mahd
        {
            get
            {
                return mahd;
            }

            set
            {
                mahd = value;
            }
        }

        public string Manv
        {
            get
            {
                return manv;
            }

            set
            {
                manv = value;
            }
        }

        public DateTime Ngaylap
        {
            get
            {
                return ngaylap;
            }

            set
            {
                ngaylap = value;
            }
        }

        public string Tensp
        {
            get
            {
                return tensp;
            }

            set
            {
                tensp = value;
            }
        }

        public float Tongtien
        {
            get
            {
                return tongtien;
            }

            set
            {
                tongtien = value;
            }
        }

        public string Makh
        {
            get
            {
                return makh;
            }

            set
            {
                makh = value;
            }
        }
    }
}
