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
    public partial class AddCustomer : DevExpress.XtraEditors.XtraForm
    {
        ConnectToSQL conn = new ConnectToSQL();
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;
        SqlConnection con;
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void showCbxService()
        {
            con = conn.Connection;
            con.Open();
            conn.OpenConn();
            cmd = new SqlCommand("select MADICHVU, TENDICHVU from GOIDICHVU", con);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds);
            cbxService.DataSource = ds.Tables[0];
            cbxService.DisplayMember = "TENDICHVU";
            cbxService.ValueMember = "MADICHVU";
            
        }

        private void AddCustomer_Load(object sender, EventArgs e)
        {
            this.showCbxService();
        }

        private void groupControl2_Paint(object sender, PaintEventArgs e)
        {

        }


        string add;
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                con = conn.Connection;
                con.Open();
                conn.OpenConn();
                add = "insert into HOIVIEN values ('"+txtIdCustomer.Text+"','"+txtNameCustomer.Text+"','','','"+txtAdressCustomer.Text+"','"+txtPhoneCustomer.Text+"')";
                SqlCommand cmd = new SqlCommand(add, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm mới thành công","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Thêm mới thất bại","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
    }
}
