using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using QuanLyPhongTap.DT0;
namespace QuanLyPhongTap.DAL
{
    class DAO
    {

        //Nhân Viên
        public static DataTable xuat_NV()
        {
            return DataProvider.GetData("get_NV");
        }
        public static int them_NV(Nhanvien a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@manv", a.MaNV),
                new SqlParameter("@tennv", a.TenNV),
                new SqlParameter("@machucvu", a.Chucvu),
                new SqlParameter("@diachi", a.Diachi),
                new SqlParameter("@sdt", a.Sdt),
             
            };
            return DataProvider.ExecuteNonQuery("them_NV", para);
        }
        public static int sua_NV(Nhanvien a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@manv", a.MaNV),
                new SqlParameter("@tennv", a.TenNV),
                new SqlParameter("@machucvu", a.Chucvu),

                new SqlParameter("@diachi", a.Diachi),
                new SqlParameter("@sdt", a.Sdt),
                
            };
            return DataProvider.ExecuteNonQuery("sua_NV", para);
        }
        public static int xoa_NV(Nhanvien a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@manv", a.MaNV),


            };
            return DataProvider.ExecuteNonQuery("xoa_NV", para);
        }

        //Sản phẩm
        public static DataTable xuat_SP()
        {
            return DataProvider.GetData("get_SP");
        }
        public static int them_SP(Sanpham a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@masp", a.Masp),
                new SqlParameter("@tensp", a.Tensp),
                new SqlParameter("@gia", a.Gia),
                new SqlParameter("@nguongoc", a.Nguonngoc),


            };
            return DataProvider.ExecuteNonQuery("them_SP", para);
        }
        public static int sua_SP(Sanpham a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@masp", a.Masp),
                new SqlParameter("@tensp", a.Tensp),
                new SqlParameter("@gia", a.Gia),
                new SqlParameter("@nguongoc", a.Nguonngoc),

            };
            return DataProvider.ExecuteNonQuery("sua_SP", para);
        }
        public static int xoa_SP(Sanpham a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@masp", a.Masp),

            };
            return DataProvider.ExecuteNonQuery("xoa_SP", para);
        }

        //Khách hàng
        public static DataTable xuat_KH()
        {
            return DataProvider.GetData("get_KH");
        }
        public static int them_KH(Khachhang a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@makh", a.Makh),
                new SqlParameter("@tenkh", a.Tenkh),
                new SqlParameter("@cmnd",a.Cmnd),
                new SqlParameter("@email",a.Email),
                new SqlParameter("@diachi", a.Diachi),

                new SqlParameter("@sdt", a.Sdt),
                new SqlParameter("@mathe", a.Mathe),

            };
            return DataProvider.ExecuteNonQuery("them_KH", para);
        }
        public static int sua_KH(Khachhang a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@makh", a.Makh),
                new SqlParameter("@tenkh", a.Tenkh),
                new SqlParameter("@cmnd",a.Cmnd),
                new SqlParameter("@email",a.Email),
                new SqlParameter("@diachi", a.Diachi),

                new SqlParameter("@sdt", a.Sdt),
                new SqlParameter("@mathe", a.Mathe),

            };
            return DataProvider.ExecuteNonQuery("sua_KH", para);
        }
        public static int xoa_KH(Khachhang a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@makh", a.Makh),


            };
            return DataProvider.ExecuteNonQuery("xoa_KH", para);
        }

        //Thiết bị
        public static DataTable xuat_tb()
        {
            return DataProvider.GetData("get_tb");
        }
        public static int them_tb(Thietbi a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@matb", a.Matb),
                new SqlParameter("@tentb", a.Tentb),
                new SqlParameter("@loaitb", a.Loaitb),
                new SqlParameter("@soluong", a.Soluong),
                new SqlParameter("@namsx", a.Namsx),
                new SqlParameter("@hangsx", a.Hangsx),
                new SqlParameter("@giatb", a.Giatb),
                new SqlParameter("@manql", a.Manql)

            };
            return DataProvider.ExecuteNonQuery("them_tb", para);
        }
        public static int sua_tb(Thietbi a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                 new SqlParameter("@matb", a.Matb),
                new SqlParameter("@tentb", a.Tentb),
                new SqlParameter("@loaitb", a.Loaitb),
                new SqlParameter("@soluong", a.Soluong),
                new SqlParameter("@namsx", a.Namsx),
                new SqlParameter("@hangsx", a.Hangsx),
                new SqlParameter("@giatb", a.Giatb),
                new SqlParameter("@manql", a.Manql)
            };
            return DataProvider.ExecuteNonQuery("sua_tb", para);
        }
        public static int xoa_tb(Thietbi a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@matb", a.Matb),


            };
            return DataProvider.ExecuteNonQuery("xoa_tb", para);
        }
        //Hóa đơn
        public static DataTable xuat_HD()
        {
            return DataProvider.GetData("get_HD");

        }

        public static int them_hd(Hoadon a)
        {
            SqlParameter[] para = new SqlParameter[] {
            new SqlParameter("@mahd", a.Mahd),
            new SqlParameter("@tensp", a.Tensp),
            new SqlParameter("@ngaylap", a.Ngaylap),
            new SqlParameter("@tongtien", a.Tongtien),
            new SqlParameter("@makh", a.Makh),
            new SqlParameter("@manv", a.Manv),
        };
            return DataProvider.ExecuteNonQuery("them_hd", para);
        }
        public static int sua_hd(Hoadon a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
              
            new SqlParameter("@mahd", a.Mahd),
            new SqlParameter("@tensp", a.Tensp),
            new SqlParameter("@ngaylap", a.Ngaylap),
            new SqlParameter("@makh", a.Makh),
            new SqlParameter("@manv", a.Manv),
        };
            return DataProvider.ExecuteNonQuery("sua_hd", para);
        }

        public static int sua_hoadon1(Hoadon a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@mahd", a.Mahd),

                new SqlParameter("@tongtien", a.Tongtien),

            };
            return DataProvider.ExecuteNonQuery("luu_tien", para);
        }
        public static int xoa_hd(Hoadon a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@mahd", a.Mahd),


            };
            return DataProvider.ExecuteNonQuery("xoa_hd", para);
        }


        //GÓI DỊCH VỤ
        public static DataTable xuat_GDV()
        {
            return DataProvider.GetData("get_GDV");

        }
        public static DataTable xuat_ctdv()
        {
            return DataProvider.GetData("get_ctdv");
        }

        //Chi tiết hóa đơn
        public static DataTable xuat_cthd(string ma)
        {
            return DataProvider.GetData("get_cthd" + "'" + ma + "'");
        }
        public static int them_cthd(CTHoadon a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@macthd", a.Macthd),
                new SqlParameter("@masp", a.Masp),
                new SqlParameter("@madv", a.Madv),
                new SqlParameter("@dongia", a.Dongia),
                new SqlParameter("@sl", a.Soluong),
                new SqlParameter("@tien", a.Tien),

            };
            return DataProvider.ExecuteNonQuery("them_cthd", para);
        }
        public static int sua_cthd(CTHoadon a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@macthd", a.Macthd),
                 new SqlParameter("@masp", a.Masp),
                new SqlParameter("@madv", a.Madv),
                new SqlParameter("@dongia", a.Dongia),
                new SqlParameter("@sl", a.Soluong),
                new SqlParameter("@tien", a.Tien),

            };
            return DataProvider.ExecuteNonQuery("sua_cthd", para);
        }
        public static int xoa_cthd(CTHoadon a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@macthd", a.Macthd),


            };
            return DataProvider.ExecuteNonQuery("xoa_cthd", para);
        }

       
    }
}
