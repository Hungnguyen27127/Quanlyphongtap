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
    public partial class FrmThemSuaNguoiDung : Form
    {
        public FrmThemSuaNguoiDung()
        {
            InitializeComponent();
        }
        ConnectSQL conn = new ConnectSQL();
        private void FrmThemSuaNguoiDung_Load(object sender, EventArgs e)
        {
            conn.KetNoi();
            cboQuyenHan.Items.Clear();
            cboQuyenHan.Items.Add("admin");
            cboQuyenHan.Items.Add("NhanVien");
            if (FormDanhMucNguoiDung.them_sua == "sua")
            {
                DataTable tb = new DataTable();
                tb.Load(conn.ThucHienReader("SELECT * FROM TAIKHOAN WHERE TenDangNhap='" + FormDanhMucNguoiDung.TenDangNhap.Trim() + "'"));
                txtTenDangNhap.Text = FormDanhMucNguoiDung.TenDangNhap.Trim();
                txtMatKhau.Text = tb.Rows[0]["MatKhau"].ToString();
                cboQuyenHan.Text = tb.Rows[0]["QuyenHan"].ToString();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                string str;
                if (FormDanhMucNguoiDung.them_sua == "sua")
                {
                    str = "UPDATE TAIKHOAN SET TenDangNhap='" + txtTenDangNhap.Text.Trim() + "',MatKhau='" + txtMatKhau.Text.Trim() + "',QuyenHan='" + cboQuyenHan.Text.Trim() + "' WHERE TenDangNhap='" + FormDanhMucNguoiDung.TenDangNhap.Trim() + "'";
                    conn.RunSQL(str);
                    this.Close();
                }
                else
                    if (FormDanhMucNguoiDung.them_sua == "them")
                {
                    str = "INSERT INTO TAIKHOAN(TenDangNhap,MatKhau,QuyenHan) VALUES('" + txtTenDangNhap.Text.Trim() + "','" + txtMatKhau.Text.Trim() + "','" + cboQuyenHan.Text.Trim() + "')";
                    conn.RunSQL(str);
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Lỗi nhập dữ liệu. Bạn hãy xem lại dữ liệu vừa nhập");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMatKhau.Text = "";
            txtTenDangNhap.Text = "";
            cboQuyenHan.Text = "";
        }
    }
    
}
