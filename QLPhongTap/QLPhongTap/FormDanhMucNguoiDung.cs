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
    public partial class FormDanhMucNguoiDung : Form
    {
        public FormDanhMucNguoiDung()
        {
            InitializeComponent();
        }

        ConnectSQL conn = new ConnectSQL();
        public static string them_sua;
        public static string TenDangNhap;

        private void FormDanhMucNguoiDung_Load(object sender, EventArgs e)
        {
            conn.KetNoi();
            DataTable tb = new DataTable();
            tb.Load(conn.ThucHienReader("Select * from TAIKHOAN"));
            Load_ListView(listView1, tb);
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
        }

        public void Load_ListView(ListView lvwName, DataTable tb)
        {
            listView1.Items.Clear();
            for (int i = 0; i < tb.Rows.Count; i++)
            {
                string[] col = new string[tb.Columns.Count];
                {
                    col[0] = tb.Rows[i]["TenDangNhap"].ToString();
                    col[1] = tb.Rows[i]["MatKhau"].ToString();
                    col[2] = tb.Rows[i]["QuyenHan"].ToString();
                }
                ListViewItem lvItem = new ListViewItem(col);
                lvwName.Items.Add(lvItem);
            }
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                return;
            }
            else
            {
                btnXoa.Enabled = true;
                btnSua.Enabled = true;
                ListViewItem item = listView1.SelectedItems[0];
                TenDangNhap = item.SubItems[0].Text.Trim();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            them_sua = "them";
            Form frm = new FrmThemSuaNguoiDung();
            frm.ShowDialog();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            them_sua = "sua";
           Form frm = new FrmThemSuaNguoiDung();
           frm.ShowDialog();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            ListViewItem item = listView1.SelectedItems[0];
            if (item.SubItems[2].Text.Trim() == "admin")
            {
                MessageBox.Show("Bạn không thể xóa Người Dùng có quyền hạn admin.", "Thông Báo");
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn có chắc là muốn xóa Người Dùng này khỏi danh sách không ?", "Xóa Người Dùng", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    conn.RunSQL("DELETE FROM TAIKHOAN WHERE TenDangNhap='" + item.SubItems[0].Text.Trim() + "'");
                    MessageBox.Show("Người Dùng đã được xóa thành công", "Xóa Người Dùng");
                   FormDanhMucNguoiDung_Load(sender, e);
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult hoi;
            hoi = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (hoi == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
