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
    public partial class FormDoiMatKhau : Form
    {
        public FormDoiMatKhau()
        {
            InitializeComponent();
        }

        ConnectSQL conn = new ConnectSQL();

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            DataTable tb = new DataTable();
            tb.Load(conn.ThucHienReader("Select * from TaiKhoan where TenDangNhap='" + FormDangNhap.TenDangNhap.Trim() + "'"));
            if (txtMatKhauCu.Text.Trim() != tb.Rows[0]["MatKhau"].ToString().Trim())
            {
                MessageBox.Show("Bạn đã nhâp mật khẩu cũ không đúng.Bạn hãy nhập lại");

            }
            else
            {
                if (txtMatKhauMoi.Text.Trim() != txtXacNhanMatKhau.Text.Trim())
                {
                    MessageBox.Show("Mật khẩu không giống nhau.Bạn hãy nhập lại.", "Thông Báo");
                }
                else
                {
                    string str;
                    str = "UPDATE TAIKHOAN SET MATKHAU='" + txtMatKhauMoi.Text.Trim() + "' WHERE TenDangNhap='" + FormDangNhap.TenDangNhap.ToString().Trim() + "'";
                    conn.RunSQL(str);
                    MessageBox.Show("Bạn đã đổi mật khẩu thành công.", "Thông Báo");
                    this.Close();
                }

            }

        }

        private void FormDoiMatKhau_Load(object sender, EventArgs e)
        {
            conn.KetNoi();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult hoi;
            hoi = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (hoi == DialogResult.Yes)
                this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMatKhauCu.Text = "";
            txtMatKhauMoi.Text = "";
            txtXacNhanMatKhau.Text = "";
        }
    }
}
