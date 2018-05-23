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
using QuanLyPhongTap.DT0;
using QuanLyPhongTap.DAL;
using QuanLyPhongTap.Properties;
namespace QuanLyPhongTap.UC
{
    public partial class KhachHang : UserControl
    {
        public KhachHang()
        {
            InitializeComponent();
        }
        private void xuat()
        {
            dgv_kh.DataSource = BUS.BUS.xuat_KH();
        }
        private void KhachHang_Load(object sender, EventArgs e)
        {
            xuat();
            txt_makh.Enabled = false;
        }

        private void dgv_kh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_makh.Text = dgv_kh.CurrentRow.Cells[0].Value.ToString();
            txt_tenkh.Text = dgv_kh.CurrentRow.Cells[1].Value.ToString();
            txtCMND.Text = dgv_kh.CurrentRow.Cells[2].Value.ToString();
            txt_Email.Text = dgv_kh.CurrentRow.Cells[3].Value.ToString();
            txt_diachi.Text = dgv_kh.CurrentRow.Cells[4].Value.ToString();
            txt_sdt.Text = dgv_kh.CurrentRow.Cells[5].Value.ToString();
            txt_mathe.Text = dgv_kh.CurrentRow.Cells[6].Value.ToString();
        }
        private void reset()
        {
            txt_makh.ResetText();
            txt_tenkh.ResetText();
            txtCMND.ResetText();
            txt_Email.ResetText();
            txt_diachi.ResetText();
            txt_sdt.ResetText();
            txt_mathe.ResetText();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {

            txt_makh.Enabled = true;
            reset();
        }


        private void btnSua_Click(object sender, EventArgs e)
        {
            Khachhang a = new Khachhang();
            a.Makh = txt_makh.Text.Trim();
            a.Tenkh = txt_tenkh.Text.Trim();
            a.Cmnd = int.Parse(txtCMND.Text);
            a.Sdt = int.Parse(txt_sdt.Text);
            a.Email = txt_Email.Text.Trim();
            a.Diachi = txt_diachi.Text.Trim();
            a.Mathe= int.Parse(txt_mathe.Text);
            if (a.Makh == null) throw new Exception();
            if (BUS.BUS.sua_KH(a) == 1)
            {
                MessageBox.Show("Sửa thành công");
                txt_makh.Enabled = false;
            }
            xuat();

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            Khachhang a = new Khachhang();
            a.Makh = txt_makh.Text.Trim();
            a.Tenkh = txt_tenkh.Text.Trim();
            a.Cmnd = int.Parse(txtCMND.Text);
            a.Sdt = int.Parse(txt_sdt.Text);
            a.Email = txt_Email.Text.Trim();
            a.Diachi = txt_diachi.Text.Trim();
            a.Mathe = int.Parse(txt_mathe.Text);
            if (a.Makh == null) throw new Exception();
            if (MessageBox.Show("Bạn có muốn Thêm Khách hàng ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (BUS.BUS.them_KH(a) == 1)
                {
                    MessageBox.Show("Thêm Thành Công");
                    txt_makh.Enabled = false;
                }
            }

            xuat();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Khachhang a = new Khachhang();
            a.Makh = txt_makh.Text.Trim();
            if (BUS.BUS.xoa_KH(a) != 1)
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

            private void txtCMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        // k cho phép nhập chữ
        private void txt_sdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txt_makh_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txt_tenkh_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txtCMND_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txt_Email_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txt_diachi_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txt_sdt_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

       

        
    }
}
