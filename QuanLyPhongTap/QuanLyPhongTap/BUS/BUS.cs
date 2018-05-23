using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyPhongTap.DAL;
using QuanLyPhongTap.DT0;
namespace QuanLyPhongTap.BUS
{
    class BUS
    {
        //Nhân viên
        public static DataTable xuat_NV()
        {
            return DAO.xuat_NV();
        }
        public static int them_NV(Nhanvien a)
        {
            return DAO.them_NV(a);
        }
        public static int sua_NV(Nhanvien a)
        {
            return DAO.sua_NV(a);
        }
        public static int xoa_NV(Nhanvien a)
        {
            return DAO.xoa_NV(a);
        }
        //Khách hàng
        public static DataTable xuat_KH()
        {
            return DAO.xuat_KH();
        }
        public static int them_KH(Khachhang a)
        {
            return DAO.them_KH(a);
        }
        public static int sua_KH(Khachhang a)
        {
            return DAO.sua_KH(a);
        }
        public static int xoa_KH(Khachhang a)
        {
            return DAO.xoa_KH(a);
        }

        //Sản phẩm
        public static DataTable xuat_SP()
        {
            return DAO.xuat_SP();
        }
        public static int them_SP(Sanpham a)
        {
            return DAO.them_SP(a);
        }
        public static int sua_SP(Sanpham a)
        {
            return DAO.sua_SP(a);
        }
        public static int xoa_SP(Sanpham a)
        {
            return DAO.xoa_SP(a);
        }
        //Thiết Bị
        public static DataTable xuat_tb()
        {
            return DAO.xuat_tb();
        }
        public static int them_tb(Thietbi a)
        {
            return DAO.them_tb(a);
        }
        public static int sua_tb(Thietbi a)
        {
            return DAO.sua_tb(a);
        }
        public static int xoa_tb(Thietbi a)
        {
            return DAO.xoa_tb(a);
        }

        ////Hóa đơn
        public static DataTable xuat_HD()
        {
            return DAO.xuat_HD();
        }
        public static int them_hd(Hoadon a)
        {
            return DAO.them_hd(a);
        }
        public static int sua_hd(Hoadon a)
        {
            return DAO.sua_hd(a);
        }
        public static int xoa_hd(Hoadon a)
        {
            return DAO.xoa_hd(a);
        }
        public static int sua_hoadon1(Hoadon a)
        {
            return DAO.sua_hoadon1(a);
        }

        //GÓI DỊCH VỤ
        public static DataTable xuat_GDV()
        {
            return DAO.xuat_GDV();
        }

        public static DataTable xuat_ctdv()
        {
            return DAO.xuat_ctdv();

        }
        //chi tiết hóa đơn
        public static DataTable xuat_cthd(string ma)
        {
            return DAO.xuat_cthd(ma);

        }
        public static int them_cthd(CTHoadon a)
        {
            return DAO.them_cthd(a);
        }
        public static int sua_cthd(CTHoadon a)
        {
            return DAO.sua_cthd(a);
        }
        public static int xoa_cthd(CTHoadon a)
        {
            return DAO.xoa_cthd(a);
        }
        public static DataTable xuat_ctdv(string ma)
        {
            return DataProvider.GetData("get_ctdv" + "'" + ma + "'");
        }

    }
}
