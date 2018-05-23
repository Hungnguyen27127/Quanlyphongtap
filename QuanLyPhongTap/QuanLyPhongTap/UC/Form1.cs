using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace QuanLyPhongTap
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }
        String TenDangNhap = "", MatKhau = "" , MANQL = "", TenNhanVien ="", QuyenHan = "";
        
        public Form_Main(String tendangnhap, String matkhau, String manql, String tennhanvien, String quyenhan)
        {
            InitializeComponent();
            this.TenDangNhap = tendangnhap;
            this.MatKhau = matkhau;
            this.MANQL = manql;
            this.TenNhanVien = tennhanvien;
            this.QuyenHan = quyenhan;
        }
        private void timkiem_Click(object sender, EventArgs e)
        {
            QuanLyPhongTap.UC.TimKiem a = new UC.TimKiem();
            a.Dock = DockStyle.Fill;
            panel_main.Controls.Add(a);
          //  lbl.Text = "Tìm Kiếm Gói DV";
            foreach (Control ctrl in panel_main.Controls)
            {
                if (ctrl != a)
                    ctrl.Dispose();
            }
        }
        
        private void nhanvien_Click(object sender, EventArgs e)
        {
            if (QuyenHan == "admin")
            {
                nhanvien.Enabled = true;
                QuanLyPhongTap.UC.NhanVien a = new UC.NhanVien();
                a.Dock = DockStyle.Fill;
                panel_main.Controls.Add(a);
                //   lbl.Text = "Quản lí Nhân Viên";
                foreach (Control ctrl in panel_main.Controls)
                {
                    if (ctrl != a)
                        ctrl.Dispose();
                }
            }
            else if (QuyenHan == "nhanvien")
            {
                nhanvien.Enabled = false;
                MessageBox.Show("Quyền của bạn không cho phép sử dụng chức năng này");
            }
            else if (QuyenHan == "khachhang")
            {
                nhanvien.Enabled = false;

                MessageBox.Show("Quyền của bạn không cho phép sử dụng chức năng này");

            }
            //if (Form_dangnhap.QuyenHan != "admin" && Form_dangnhap.QuyenHan != "Quanly")
            //{
            //    MessageBox.Show("Bạn không có quyền truy cập vào chức năng này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else
            //{

            
           // }
        }

        private void khachhang_Click(object sender, EventArgs e)
        {
            QuanLyPhongTap.UC.KhachHang a = new UC.KhachHang();
            a.Dock = DockStyle.Fill;
            panel_main.Controls.Add(a);
         //   lbl.Text = "Quản lí Khách Hàng";
            foreach (Control ctrl in panel_main.Controls)
            {
                if (ctrl != a)
                    ctrl.Dispose();
            }
        }

        private void Sanpham_Click(object sender, EventArgs e)
        {

            if (QuyenHan == "admin")
            {
                QuanLyPhongTap.UC.SanPham a = new UC.SanPham();
                a.Dock = DockStyle.Fill;
                panel_main.Controls.Add(a);
                //   lbl.Text = "Quản lý Sản Phẩm";
                foreach (Control ctrl in panel_main.Controls)
                {
                    if (ctrl != a)
                        ctrl.Dispose();
                }
            }
            else if (QuyenHan == "nhanvien")
            {
                QuanLyPhongTap.UC.SanPham a = new UC.SanPham();
                a.Dock = DockStyle.Fill;
                panel_main.Controls.Add(a);
                //   lbl.Text = "Quản lý Sản Phẩm";
                foreach (Control ctrl in panel_main.Controls)
                {
                    if (ctrl != a)
                        ctrl.Dispose();
                }
            }
            else if (QuyenHan == "khachhang")
            {
                nhanvien.Enabled = false;

                MessageBox.Show("Quyền của bạn không cho phép sử dụng chức năng này");

            }
            
        }

        private void lbl_x_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void nguoidung_Click(object sender, EventArgs e)
        {

            if (QuyenHan == "admin")
            {

            }
            else if (QuyenHan == "nhanvien")
            {
                nhanvien.Enabled = false;
                MessageBox.Show("Quyền của bạn không cho phép sử dụng chức năng này");
            }
            else if (QuyenHan == "khachhang")
            {
                nhanvien.Enabled = false;

                MessageBox.Show("Quyền của bạn không cho phép sử dụng chức năng này");

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (panel1.Width == 42)
            {
                panel1.Width = 268;
                goidichvu.Visible = true;
                khachhang.Visible = true;
                thietbi.Visible = true;
                nhanvien.Visible = true;
                sanpham.Visible = true;
                hoadon.Visible = true;
                nguoidung.Visible = true;
            }
            else
            {
                panel1.Width = 42;

                goidichvu.Visible = false;
                khachhang.Visible = false;
                thietbi.Visible = false;
                nhanvien.Visible = false;
                sanpham.Visible = false;
                hoadon.Visible = false;
                nguoidung.Visible = false;
            }
        }

        private void thietbi_Click(object sender, EventArgs e)
        {

            if (QuyenHan == "admin")
            {
                QuanLyPhongTap.UC.ThietBi a = new UC.ThietBi();
                a.Dock = DockStyle.Fill;
                panel_main.Controls.Add(a);
                // lbl.Text = "Quản Lý Thiết Bị";
                foreach (Control ctrl in panel_main.Controls)
                {
                    if (ctrl != a)
                        ctrl.Dispose();
                }
            }
            else if (QuyenHan == "nhanvien")
            {
                QuanLyPhongTap.UC.ThietBi a = new UC.ThietBi();
                a.Dock = DockStyle.Fill;
                panel_main.Controls.Add(a);
                // lbl.Text = "Quản Lý Thiết Bị";
                foreach (Control ctrl in panel_main.Controls)
                {
                    if (ctrl != a)
                        ctrl.Dispose();
                }
            }
            else if (QuyenHan == "khachhang")
            {
                nhanvien.Enabled = false;

                MessageBox.Show("Quyền của bạn không cho phép sử dụng chức năng này");

            }
            
        }

        private void thanhtoan_Click(object sender, EventArgs e)
        {

            if (QuyenHan == "admin")
            {
                QuanLyPhongTap.UC.ThanhToan a = new UC.ThanhToan();
                a.Dock = DockStyle.Fill;
                panel_main.Controls.Add(a);
                // lbl.Text = "Quản Lý Thanh Toán";
                foreach (Control ctrl in panel_main.Controls)
                {
                    if (ctrl != a)
                        ctrl.Dispose();
                }
            }
            else if (QuyenHan == "nhanvien")
            {
                QuanLyPhongTap.UC.ThanhToan a = new UC.ThanhToan();
                a.Dock = DockStyle.Fill;
                panel_main.Controls.Add(a);
                // lbl.Text = "Quản Lý Thanh Toán";
                foreach (Control ctrl in panel_main.Controls)
                {
                    if (ctrl != a)
                        ctrl.Dispose();
                }
            }
            else if (QuyenHan == "khachhang")
            {
                nhanvien.Enabled = false;

                MessageBox.Show("Quyền của bạn không cho phép sử dụng chức năng này");

            }
            
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            // panel_main.Width = 1052;
        }


        //private void nhaphang_Click(object sender, EventArgs e)
        //{
        //    QuanLyPhongTap.UC.NhapHang a = new UC.NhapHang();
        //    a.Dock = DockStyle.Fill;
        //    panel_main.Controls.Add(a);
        //    lbl.Text = "Nhập Hàng";
        //    foreach (Control ctrl in panel_main.Controls)
        //    {
        //        if (ctrl != a)
        //            ctrl.Dispose();
        //    }
        //}

        //private void banhang_Click(object sender, EventArgs e)
        //{
        //    QuanLyPhongTap.UC.BanHang a = new UC.BanHang();
        //    a.Dock = DockStyle.Fill;
        //    panel_main.Controls.Add(a);
        //    lbl.Text = "Bán Hàng";
        //    foreach (Control ctrl in panel_main.Controls)
        //    {
        //        if (ctrl != a)
        //            ctrl.Dispose();
        //    }
        //}








        //private void nguoidung_Click(object sender, EventArgs e)
        //{
        //if (Form_dangnhap.QuyenHan != "admin" && Form_dangnhap.QuyenHan != "Quanly")
        //    {
        //        MessageBox.Show("Bạn không có quyền truy cập vào chức năng này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //    else
        //    {
        //    QuanLyPhongTap.UC.NguoiDung a = new UC.TNguoiDung();
        //    a.Dock = DockStyle.Fill;
        //    panel_main.Controls.Add(a);
        //    lbl.Text = "Quản Lý Người Dùng";
        //    foreach (Control ctrl in panel_main.Controls)
        //    {
        //        if (ctrl != a)
        //            ctrl.Dispose();
        //    }
        //}

        
    }
}
