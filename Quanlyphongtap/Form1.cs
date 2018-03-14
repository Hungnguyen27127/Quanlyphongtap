using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlyphongtap
{
    public partial class Form1 : Form
    {
        ConnectToSQL con = new ConnectToSQL();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = con.GetData("select * from TAIKHOAN where TEN_USER = '"+txtUser.Text+"' and MATKHAU = '"+txtPass.Text+"'");
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Đăng nhập thành công!","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrmMain f = new FrmMain(dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString(),dt.Rows[0][2].ToString(), dt.Rows[0][3].ToString());
                this.Hide();
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
