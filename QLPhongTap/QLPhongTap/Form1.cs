using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLPhongTap
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        ConnectSQL conn = new ConnectSQL();
        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new FormDangNhap();
            frm.ShowDialog();
            if (FormDangNhap.kiemtra !=2)
            {
                this.Close();
            }
            else
            {
                if (FormDangNhap.QuyenHan == "Admin")
                {
                    đổiMậtKhẩuToolStripMenuItem.Enabled = true;
                    chuyểnNgườiDùngToolStripMenuItem.Enabled = true;
                    quảnTrịToolStripMenuItem.Enabled = true;
                    danhMụcToolStripMenuItem1.Enabled = true;
                    quảnLýToolStripMenuItem.Enabled = true;
                    cậpNhậtToolStripMenuItem.Enabled = true;
                    doanhThuToolStripMenuItem.Enabled = true;
                    trợGiúpToolStripMenuItem.Enabled = true;


                    ngườiDùngToolStripMenuItem.Enabled = true;
                    danhMụcNgườiDùngToolStripMenuItem.Enabled = true;
                   
                    
                  
                    góiDịchVụToolStripMenuItem.Enabled = true;
                    chiTiếtGóiDịchVụToolStripMenuItem.Enabled = true;
                    phiếuĐăngKýToolStripMenuItem.Enabled = true;

                    nhânViênToolStripMenuItem.Enabled = false;
                    kháchHàngToolStripMenuItem.Enabled = false;
                    chứcVụToolStripMenuItem.Enabled = false;

                    thiếtbịToolStripMenuItem.Enabled = false;
                    hoáĐơnToolStripMenuItem.Enabled = false;
                    sảnPhẩmToolStripMenuItem.Enabled = false;
                }
                else
                {
                    đổiMậtKhẩuToolStripMenuItem.Enabled = true;
                    chuyểnNgườiDùngToolStripMenuItem.Enabled = true;
                    quảnTrịToolStripMenuItem.Enabled = true;
                    danhMụcToolStripMenuItem1.Enabled = true;
                    quảnLýToolStripMenuItem.Enabled = true;
                    cậpNhậtToolStripMenuItem.Enabled = true;
                    doanhThuToolStripMenuItem.Enabled = true;
                    trợGiúpToolStripMenuItem.Enabled = true;


                    ngườiDùngToolStripMenuItem.Enabled = true;
                    danhMụcNgườiDùngToolStripMenuItem.Enabled = true;
                    góiDịchVụToolStripMenuItem.Enabled = true;
                    chiTiếtGóiDịchVụToolStripMenuItem.Enabled = true;
                    phiếuĐăngKýToolStripMenuItem.Enabled = true;

                    nhânViênToolStripMenuItem.Enabled = true;
                    kháchHàngToolStripMenuItem.Enabled = true;
                    chứcVụToolStripMenuItem.Enabled = true;

                    thiếtbịToolStripMenuItem.Enabled = true;
                    hoáĐơnToolStripMenuItem.Enabled = true;
                    sảnPhẩmToolStripMenuItem.Enabled = true;

                }
               MessageBox.Show("Bạn đã đăng nhập với vai trò là: " + FormDangNhap.QuyenHan.ToString());

            }
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new FormDoiMatKhau();
            frm.ShowDialog();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            đổiMậtKhẩuToolStripMenuItem.Enabled = false;
            chuyểnNgườiDùngToolStripMenuItem.Enabled = false;
            quảnTrịToolStripMenuItem.Enabled = false;
            danhMụcToolStripMenuItem1.Enabled = false;
            quảnLýToolStripMenuItem.Enabled = false;
            cậpNhậtToolStripMenuItem.Enabled = false;
            doanhThuToolStripMenuItem.Enabled = false;
            trợGiúpToolStripMenuItem.Enabled = false;

        }

        private void chuyểnNgườiDùngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            đăngNhậpToolStripMenuItem_Click(sender, e);
        }

        private void danhMụcNgườiDùngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (!CheckExistForm("FormDanhMucNguoiDung"))
            //{
                FormDanhMucNguoiDung frm = new FormDanhMucNguoiDung();
                frm.MdiParent = this;
                frm.Show();
            //}
            //else ActivateChildForm("FormDanhMucNguoiDung");
        }
        
        private void góiDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
        //    if (!CheckExistForm("FrmGoiDichVu"))
        //    {
                FrmGoiDichVu frm = new FrmGoiDichVu();
                frm.MdiParent = this;
                frm.Show();
            //}
            //else ActivateChildForm("FrmGoiDichVu");
        }

        private void chiTiếtGóiDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (!CheckExistForm("FrmChiTietGoiDichVu"))
            //{
                FrmChitietGoiDichVu frm = new FrmChitietGoiDichVu();
                frm.MdiParent = this;
                frm.Show();

            //}
            //else
            //{
            //    ActivateChildForm("FrmChiTietGoiDichVu");
            //}
        }

        private void phiếuĐăngKýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (!CheckExistForm("FrmPhieuDangKy"))
            //{
                FrmPhieuDangKy frm = new FrmPhieuDangKy();
                frm.MdiParent = this;
                frm.Show();
           // }
            //else
            //{
            //    ActivateChildForm("FrmPhieuDangKy");
            //}
            
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            //if (!CheckExistForm("FrmKhachHang")) 
            //{
                FrmKhachHang frm = new FrmKhachHang();
                frm.MdiParent = this;
               
                frm.Show();
            //}
            //else{
            //    ActivateChildForm("FrmKhachHang");
            //}
            
        }

        private void nhânNViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (!CheckExistForm("FrmNhanVien"))
            //{
                FrmNhanVien frm = new FrmNhanVien();
                frm.MdiParent = this;
                frm.Show();
            //}
            //else ActivateChildForm("FrmNhanVien");

        }

        private void chứcVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
        //    if (!CheckExistForm("FrmChucVu"))
        //    {
                FrmChucVu frm = new FrmChucVu();
                frm.MdiParent = this;
                frm.Show();
            //}
           // else ActivateChildForm("FrmChucVu");
        }

        private void thiếtbịToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (!CheckExistForm("FrmThietBi"))
            //{
                FrmThietBi frm = new FrmThietBi();
                frm.MdiParent = this;
                frm.Show();
            //}
            //else ActivateChildForm("FrmThietBi");
        }

        private void hoáĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (!CheckExistForm("FrmHoaDon"))
            //{
                FrmHoaDon frm = new FrmHoaDon();
                frm.MdiParent = this;
                frm.Show();
            //}
            //else ActivateChildForm("FrmHoaDon");
        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (!CheckExistForm("FrmSanPham"))
            //{
                FrmSanPham frm = new FrmSanPham();
                frm.MdiParent = this;
                frm.Show();
            //}
            //else ActivateChildForm("FrmSanPham");
        }

        private void thoátToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }



        //Kiểm tra xem 1 form con đã hiển thị trong form cha chưa
        //private bool CheckExistForm(string name)
        //{
        //    bool check = false;
        //    foreach(Form frm in this.MdiChildren)
        //    {
        //        if (frm.Name==name)
        //        {
        //            check = true;//=>đã hiển thị
        //            break;
        //        }
        //    }return check;
        //}

        ////Kích hoạt -hiển thị lên trên cùng các form
        //private void ActivateChildForm(string name)
        //{
        //    foreach(Form frm in this.MdiChildren)
        //    {
        //        if (frm.Name==name)
        //        {
        //            frm.Activate();
        //            break;
        //        }
        //    }
        //}
    }
}
