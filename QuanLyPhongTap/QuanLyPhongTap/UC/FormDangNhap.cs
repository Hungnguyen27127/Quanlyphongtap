using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyPhongTap
{
    public partial class Form_dangnhap : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-EADVFVM;Initial Catalog=QLPHONGTAPGYM;Integrated Security=True");
        public String quyenhan = "";
        public Form_dangnhap()
        {
            InitializeComponent();
        }

        public string get_permission(/*String taikhoan, String matkhau*/)
        {
            String quyenhan = "";
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from TAIKHOAN where TenDangNhap = '" + txt_tk.Text + "'and MatKhau = '" + txt_mk.Text + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if(dt!= null)
                {
                    foreach(DataRow dr in dt.Rows)
                    {
                        quyenhan = dr["QuyenHan"].ToString();
                    }
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Lỗi kết nối xin thử lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                con.Close();
            }
            return quyenhan;
        }
        private void lbl_x_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txt_tk_Click(object sender, EventArgs e)
        {
            txt_tk.Text = "";
        }

        private void txt_mk_Click(object sender, EventArgs e)
        {
            txt_mk.Text = "";
        }


        private void lbl_dangnhap_Click(object sender, EventArgs e)
        {
            
            if ((txt_tk.Text == "") || (txt_mk.Text == ""))
            {
                errortk.Icon = Properties.Resources._1481007008_Error;
                errortk.SetError(txt_tk, "Tài Khoản Lỗi");
                MessageBox.Show("Xin hãy Điền Đủ Thông Tin", "Thông Báo");
                return;
            }
            else
            {
                errortk.Icon = Properties.Resources._1481007037_Tick_Mark;
                errortk.SetError(txt_tk, "OK");
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-EADVFVM;Initial Catalog=QLPHONGTAPGYM;Integrated Security=True");
                con.Open();
                string s = "select * from TAIKHOAN where TenDangNhap='" + txt_tk.Text + "'and MatKhau='" + txt_mk.Text + "'";
                SqlDataAdapter da = new SqlDataAdapter(s, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count >0)
                { 
                    this.Hide();
                    Form_Main a = new Form_Main(dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString(),dt.Rows[0][3].ToString(), dt.Rows[0][4].ToString());
                    a.Show();
                    con.Close();
                }
                else
                {
                    // MessageBox.Show("loi");
                    MessageBox.Show("Kiểm Tra Lại Mật Khẩu Hoặc Tài Khoản");
                }
            }
            
            
        }

        private void checkBox_hienmk_CheckedChanged(object sender, EventArgs e)
        {
            if (txt_mk.UseSystemPasswordChar)
            {
                txt_mk.UseSystemPasswordChar = false;
            }
            else
            {
                txt_mk.UseSystemPasswordChar = true;
            }
        }

        private void txt_tk_Leave(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txt_tk.Text))
            {
                errortk.Icon = Properties.Resources._1481007008_Error;
                errortk.SetError(txt_tk, "Tài Khoản Lỗi");

            }
            else
            {
                errortk.Icon = Properties.Resources._1481007037_Tick_Mark;
                errortk.SetError(txt_tk, "OK");

            }
        }

        private void txt_tk_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) txt_mk.Focus();
        }

        private void txt_mk_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) lbl_dangnhap_Click(sender, null);
        }

      
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txt_tk_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
