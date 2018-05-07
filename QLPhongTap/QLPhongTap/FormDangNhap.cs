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
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }
        ConnectSQL conn = new ConnectSQL();
        public static string TenDangNhap, QuyenHan;
        public static int kiemtra;

       

        private void FormDangNhap_Load(object sender, EventArgs e)
        {
            try
            {
                
                conn.KetNoi();
            }
            catch
            {
                MessageBox.Show("Lỗi Kết Nối");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            DialogResult hoi;
            hoi = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (hoi == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtmatkhau.Text = " ";
            txttendangnhap.Text = " ";
        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            DataTable tb = new DataTable();
            tb.Load(conn.ThucHienReader("Select * from TAIKHOAN where TenDangNhap= '" + txttendangnhap.Text.Trim() + "'"));
            if (tb.Rows.Count == 0)
            {
                MessageBox.Show("Không tồn tại tên đăng nhập này. Bạn hãy liên hệ với admin để tạo tài khoản.", "Thông Báo");
            }
            else
                if(tb.Rows[0]["MatKhau"].ToString().Trim()==txtmatkhau.Text.Trim())
            {
                kiemtra = 2;
                TenDangNhap = txttendangnhap.Text.Trim();
                this.Hide();
                QuyenHan = tb.Rows[0]["QuyenHan"].ToString();
                this.Close();
            }
            else
            {
                MessageBox.Show("Mật khẩu của bạn không đúng", "Thông Báo");

            }
        }
    }
}
