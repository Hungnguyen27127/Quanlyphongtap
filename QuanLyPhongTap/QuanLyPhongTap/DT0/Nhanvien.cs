using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongTap.DT0
{
    class Nhanvien
    {
       

        public string MaNV
        {
            get
            {
                return maNV;
            }

            set
            {
                maNV = value;
            }
        }

        public string TenNV
        {
            get
            {
                return tenNV;
            }

            set
            {
                tenNV = value;
            }
        }

        public string Chucvu
        {
            get
            {
                return chucvu;
            }

            set
            {
                chucvu = value;
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

        private string maNV;
        private string tenNV;
        private string chucvu;
        private string diachi;
        private int sdt;
      
    }
    
}
