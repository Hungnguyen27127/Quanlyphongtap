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
    public partial class NhanVien : UserControl
    {
        public NhanVien()
        {
            InitializeComponent();
        }
        private void xuat()
        {
            dgv_nv.DataSource = BUS.BUS.xuat_NV();
            txt_manv.Enabled = false;

        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            txt_manv.Enabled = true;
            xuat();
        }

        private void dgv_nv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_manv.Text = dgv_nv.CurrentRow.Cells[0].Value.ToString();
            txt_tennv.Text = dgv_nv.CurrentRow.Cells[1].Value.ToString();
            txt_chucvu.Text = dgv_nv.CurrentRow.Cells[2].Value.ToString();
         
    
            txt_diachi.Text = dgv_nv.CurrentRow.Cells[3].Value.ToString();
            txt_sdt.Text = dgv_nv.CurrentRow.Cells[4].Value.ToString();
           
        }
        private void reset()
        {
            txt_manv.ResetText();
            txt_tennv.ResetText();
            txt_chucvu.ResetText();
    
            txt_diachi.ResetText();
            txt_sdt.ResetText();
          
        }
        //thêm
        private void btnThem_Click(object sender, EventArgs e)
        {
            txt_manv.Enabled = true;
            reset();
        }
        //sửa
        private void btnSua_Click(object sender, EventArgs e)
        {
            Nhanvien a = new Nhanvien();
            a.MaNV = txt_manv.Text.Trim();
            a.TenNV = txt_tennv.Text.Trim();
            a.Chucvu = txt_chucvu.Text.Trim();
         
            a.Diachi = txt_diachi.Text.Trim();
            a.Sdt = int.Parse(txt_sdt.Text.Trim());
           
            if (a.MaNV == null) throw new Exception();
            if (BUS.BUS.sua_NV(a) == 1)
            {
                MessageBox.Show("Sửa thành công");
                txt_manv.Enabled = false;
            }
            xuat();
        }
        //lưu
        private void btnLuu_Click(object sender, EventArgs e)
        {

            Nhanvien a = new Nhanvien();
            a.MaNV = txt_manv.Text.Trim();
            a.TenNV = txt_tennv.Text.Trim();
            a.Chucvu = txt_chucvu.Text.Trim();
           
            a.Diachi = txt_diachi.Text.Trim();
            a.Sdt = int.Parse(txt_sdt.Text.Trim());
           
            if (a.MaNV == null || a.TenNV == "") throw new Exception();
            if (MessageBox.Show("Bạn có muốn Thêm NV ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (BUS.BUS.them_NV(a) == 1)
                {
                    MessageBox.Show("Thêm Thành Công");
                    txt_manv.Enabled = false;
                }
            }

            xuat();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Nhanvien a = new Nhanvien();
            a.MaNV = txt_manv.Text.Trim();
            if (BUS.BUS.xoa_NV(a) != 1)
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


        private void btnChon_Click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                OpenFileDialog ifile = new OpenFileDialog();
                ifile.Title = "Chọn ảnh";
                ifile.Multiselect = false;
                ifile.Filter = "jpg files(*.jpg)|*.jpg| png files(*.png)|*.png";
                ifile.ShowDialog();
                try
                {
                    imgGV.Image = Image.FromStream(new System.IO.MemoryStream(System.IO.File.ReadAllBytes(ifile.FileName)));
                }
                catch (Exception)
                {
                    imgGV.Image = null;
                }
            }
        }

    }

}
