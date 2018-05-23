using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyPhongTap.BUS;
using QuanLyPhongTap.DAL;
using QuanLyPhongTap.DT0;
using QuanLyPhongTap.Properties;
namespace QuanLyPhongTap.UC
{
    public partial class SanPham : UserControl
    {
        public SanPham()
        {
            InitializeComponent();
        }
        private void xuat()
        {
            dgv_sp.DataSource = BUS.BUS.xuat_SP();
        }
        
        private void SanPham_Load(object sender, EventArgs e)
        {
            xuat();
            txt_masp.Enabled = false;
        }



        private void dgv_sp_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txt_masp.Text = dgv_sp.CurrentRow.Cells[0].Value.ToString();
            txt_tensp.Text = dgv_sp.CurrentRow.Cells[1].Value.ToString();
            txt_gia.Text = dgv_sp.CurrentRow.Cells[2].Value.ToString();
            txt_nguongoc.Text = dgv_sp.CurrentRow.Cells[3].Value.ToString();
        }
        private void reset()
        {
            txt_masp.ResetText();
            txt_tensp.ResetText();
            txt_gia.ResetText();
            txt_nguongoc.ResetText();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txt_masp.Enabled = true;
            reset();

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Sanpham a = new Sanpham();
            a.Masp = txt_masp.Text.Trim();
            a.Tensp = txt_tensp.Text.Trim();
            a.Gia = int.Parse( txt_gia.Text.Trim());
            a.Nguonngoc = txt_nguongoc.Text.Trim();
            if (a.Masp == null)
                MessageBox.Show("Không được để trống mã sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (BUS.BUS.sua_SP(a) == 1)
            {
                MessageBox.Show("Sửa thành công");
                txt_masp.Enabled = false;
            }
            xuat();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            Sanpham a = new Sanpham();
            a.Masp = txt_masp.Text.Trim();
            a.Tensp = txt_tensp.Text.Trim();
            a.Gia = int.Parse(txt_gia.Text.Trim());
            a.Nguonngoc = txt_nguongoc.Text.Trim();
            if (a.Masp == null)
                MessageBox.Show("Không được để trống mã sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (BUS.BUS.them_SP(a) == 1)
            {
                MessageBox.Show("Thêm thành công");
                txt_masp.Enabled = false;
            }
            xuat();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Sanpham a = new Sanpham();
            a.Masp = txt_masp.Text.Trim();
            if (BUS.BUS.xoa_SP(a) != 1)
                MessageBox.Show("Không xóa được");
            else
            {

                MessageBox.Show("Xóa Thành Công");
            }
            reset();
            xuat();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            reset();
        }

        

        
    }
}
