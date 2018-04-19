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
    public partial class Updatecs : Form
    {
        public Updatecs()
        {
            InitializeComponent();
        }

        private void ketnoi()
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-EADVFVM\HUNG27127;Initial Catalog=QLPHONGTAPGYM;Persist Security Info=True;User ID=HungNguyen;Password=davinci123");
                con.Open();
                string sqlstr = "getCustomerInfo";
                SqlCommand cmd = new SqlCommand(sqlstr, con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvDanhsachKH.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("Lôi kêt nối");
            }
            finally
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-EADVFVM\HUNG27127;Initial Catalog=QLPHONGTAPGYM;Persist Security Info=True;User ID=HungNguyen;Password=davinci123");
                con.Close();
            }
        }

        private void Updatecs_Load(object sender, EventArgs e)
        {
            ketnoi();
        }

        int index;
        private void dgvDanhsachKH_Click(object sender, EventArgs e)
        {
            index = dgvDanhsachKH.CurrentRow.Index;
            txtmaKH.Text = dgvDanhsachKH.Rows[index].Cells[0].Value.ToString();
            txttenKH.Text = dgvDanhsachKH.Rows[index].Cells[1].Value.ToString();
            dtpngaysinhKH.Text = dgvDanhsachKH.Rows[index].Cells[2].Value.ToString();
            txtgioitinhKH.Text = dgvDanhsachKH.Rows[index].Cells[3].Value.ToString();
            txtdiachiKH.Text = dgvDanhsachKH.Rows[index].Cells[4].Value.ToString();
            txtsdtKH.Text = dgvDanhsachKH.Rows[index].Cells[5].Value.ToString();
        }

        string sua;
        private void btnThaydoiKH_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-EADVFVM\HUNG27127;Initial Catalog=QLPHONGTAPGYM;Persist Security Info=True;User ID=HungNguyen;Password=davinci123");
                con.Open();
                sua = "update HOIVIEN set MAHOIVIEN = '" + txtmaKH.Text + "', TENHOIVIEN = '" + txttenKH.Text + "', NGAYSINH = '"+ dtpngaysinhKH.Text + "', GIOITINH = '"+ txtgioitinhKH.Text + "', DIACHI = '"+ txtdiachiKH.Text + "', SDT = '"+ txtsdtKH.Text + "'";
                SqlCommand sqlup = new SqlCommand(sua, con);
                sqlup.ExecuteNonQuery();
                ketnoi();
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối");

            }
            finally
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-EADVFVM\HUNG27127;Initial Catalog=QLPHONGTAPGYM;Persist Security Info=True;User ID=HungNguyen;Password=davinci123");
                con.Close();
            }

        }

        private void dgvDanhsachKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
