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

namespace Quanlyphongtap
{
    public partial class DanhsachKhachhang : Form
    {
        ConnectToSQL conn = new ConnectToSQL();
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable table = new DataTable();
        SqlConnection con;
        public DanhsachKhachhang()
        {
            InitializeComponent();

        }

        public void ShowDataGridView()
        {
            try
            {
                con = conn.Connection;
                con.Open();
                conn.OpenConn();
                cmd = new SqlCommand("select * from HOIVIEN", con);
                da = new SqlDataAdapter(cmd);
                table = new DataTable();
                da.Fill(table);
                dgvListCustomer.DataSource = table;
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối vui lòng kiểm tra lại");
            }
        }
        private void DanhsachKhachhang_Load(object sender, EventArgs e)
        {
            ShowDataGridView();
        }
    }
}
