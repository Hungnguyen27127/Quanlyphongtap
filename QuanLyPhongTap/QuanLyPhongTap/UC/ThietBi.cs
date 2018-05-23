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
    public partial class ThietBi : UserControl
    {
        public ThietBi()
        {
            InitializeComponent();
        }
        private void xuat()
        {
            dgv_tb.DataSource = BUS.BUS.xuat_tb();
        }
        private void TB_Load(object sender, EventArgs e)
        {
            xuat();
        }

        private void dgv_tb_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txt_matb.Text = dgv_tb.CurrentRow.Cells[0].Value.ToString();
            txt_tentb.Text = dgv_tb.CurrentRow.Cells[1].Value.ToString();
            txt_loaitb.Text = dgv_tb.CurrentRow.Cells[2].Value.ToString();
            txt_sl.Text = dgv_tb.CurrentRow.Cells[3].Value.ToString();
            txt_namsx.Text = dgv_tb.CurrentRow.Cells[4].Value.ToString();
            txt_hangsx.Text = dgv_tb.CurrentRow.Cells[5].Value.ToString();
            txt_giatb.Text = dgv_tb.CurrentRow.Cells[6].Value.ToString();
            txt_manql.Text = dgv_tb.CurrentRow.Cells[7].Value.ToString();
        }
        private void reset()
        {
            txt_matb.ResetText();
            txt_tentb.ResetText();
            txt_loaitb.ResetText();
            txt_sl.ResetText();
            txt_namsx.ResetText();
            txt_hangsx.ResetText();
            txt_giatb.ResetText();
            txt_manql.ResetText();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txt_matb.Enabled = true;
            reset();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Thietbi a = new Thietbi();
            a.Matb = txt_matb.Text.Trim();
            a.Tentb = txt_tentb.Text.Trim();
            a.Giatb = int.Parse(txt_giatb.Text.Trim());
            a.Loaitb = txt_loaitb.Text.Trim();
            a.Soluong = int.Parse(txt_sl.Text.Trim());
            a.Hangsx = txt_hangsx.Text.Trim();
            a.Namsx = int.Parse(txt_namsx.Text.Trim());
            a.Manql = int.Parse(txt_manql.Text.Trim());
            if (a.Matb == null)
                MessageBox.Show("Không được để trống mã thiết bị!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (BUS.BUS.sua_tb(a) == 1)
            {
                MessageBox.Show("Sửa thành công");
                txt_matb.Enabled = false;
            }
            xuat();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Thietbi a = new Thietbi();
            a.Matb = txt_matb.Text.Trim();
            a.Tentb = txt_tentb.Text.Trim();
            a.Giatb = int.Parse(txt_giatb.Text.Trim());
            a.Loaitb = txt_loaitb.Text.Trim();
            a.Soluong = int.Parse(txt_sl.Text.Trim());
            a.Hangsx = txt_hangsx.Text.Trim();
            a.Namsx = int.Parse(txt_namsx.Text.Trim());
            a.Manql = int.Parse(txt_manql.Text.Trim());
            if (a.Matb == null)
                MessageBox.Show("Không được để trống mã thiết bị!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (BUS.BUS.xoa_tb(a) == 1)
            {
                MessageBox.Show("Xóa thành công");
                txt_matb.Enabled = false;
            }
            xuat();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            reset();
        }



        private void btnLuu_Click(object sender, EventArgs e)
        {
            Thietbi a = new Thietbi();
            a.Matb = txt_matb.Text.Trim();
            a.Tentb = txt_tentb.Text.Trim();
            a.Giatb = int.Parse(txt_giatb.Text.Trim());
            a.Loaitb = txt_loaitb.Text.Trim();
            a.Soluong = int.Parse(txt_sl.Text.Trim());
            a.Hangsx = txt_hangsx.Text.Trim();
            a.Namsx = int.Parse(txt_namsx.Text.Trim());
            a.Manql = int.Parse(txt_manql.Text.Trim());
            if (a.Matb == null)
                MessageBox.Show("Không được để trống mã THIẾT BỊ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (BUS.BUS.them_tb(a) == 1)
            {
                MessageBox.Show("Thêm thành công");
                txt_matb.Enabled = false;
            }
            xuat();
        }
    }
}
