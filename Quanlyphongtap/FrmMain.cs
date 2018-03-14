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
    public partial class FrmMain : Form
    {
        string tenuser = "", tennhanvien = "", matkhau = "", manql = "", quyen= "";

        private void qLNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ItmCCEmp_Click(object sender, EventArgs e)
        {
            if (quyen != "admin")
            {
                MessageBox.Show("Bạn không có quyền truy cập thông tin này!");
            }
        }

        private void ItmTKEmp_Click(object sender, EventArgs e)
        {
            if (quyen != "admin")
            {
                MessageBox.Show("Bạn không có quyền truy cập thông tin này!");
            }
        }

        private void ItmAddEmp_Click(object sender, EventArgs e)
        {
            if(quyen != "admin")
            {
                MessageBox.Show("Bạn không có quyền truy cập thông tin này!");
            }
        }

        public FrmMain()
        {
            InitializeComponent();
        }

        public FrmMain (string tenuser, string tennhanvien, string matkhau, string manql)
        {
            InitializeComponent();
            this.tenuser = tenuser;
            this.tennhanvien = tennhanvien;
            this.matkhau = matkhau;
            this.manql = manql;
        }
        private void ItmLogout_Click(object sender, EventArgs e)
        {
            /*
            private enum MessageBoxButtons;
            MessageBox.Show("Bạn chắc chắn muốn đăng xuất không?", "Đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (MessageBoxButtons = "Yes")
            this.Hide();
            Form1 f1 = new Form1();
            */
        }
    }
}
