using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongTap.DT0
{
    class Khachhang
    {
        private string makh;
        private string tenkh;
        private string diachi;
        private string email;
        private int sdt;
        private int cmnd;
        private int mathe;
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

        public string Tenkh
        {
            get
            {
                return tenkh;
            }

            set
            {
                tenkh = value;
            }
        }

        public string Diachi
        {
            get
            {
                return diachi;
            }

            set
            {
                diachi = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public int Sdt
        {
            get
            {
                return sdt;
            }

            set
            {
                sdt = value;
            }
        }

        public int Mathe
        {
            get
            {
                return mathe;
            }

            set
            {
                mathe= value;
            }
        }

        public int Cmnd
        {
            get
            {
                return cmnd;
            }

            set
            {
                cmnd = value;
            }
        }
    }
}
