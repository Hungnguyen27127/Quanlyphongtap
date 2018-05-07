using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace QLPhongTap
{
    class ConnectSQL
    {
        public static SqlConnection cn;
       // SqlConnection cn = new SqlConnection();
        public void KetNoi()
        {
            cn = new SqlConnection();
            string str = @"Data Source=PC\THUYDUNG;Initial Catalog=QLPHONGTAPGYM;Integrated Security=True";
            cn.ConnectionString = str;
            cn.Open();
        }
        public  void DongKetNoi()
        {
            cn.Close();
        }

        public DataSet FillDataSet(string sql)
        {
            DataSet dataset = new DataSet();
            SqlDataAdapter DataAdap = new SqlDataAdapter();
            DataAdap.Fill(dataset);
            DataAdap.Dispose();
            return dataset;
        }

        public void RunSQL(string sql)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;//chỉ định câu lệnh SQL
            cmd.Connection = cn;
            try
            {
                cmd.ExecuteNonQuery(); //Thực hiện câu lệnh SQL
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            cmd.Dispose();//Giải phóng bộ nhớ
            cmd = null;
        }

        public SqlDataReader ThucHienReader(string sql)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;
            cmd.Connection = cn;
            cmd.CommandText = sql;
            reader = cmd.ExecuteReader();
            return reader;
        }
        public  void RunSqlDel(string sql)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = ConnectSQL.cn;
            cmd.CommandText = sql;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Dữ liệu đang được dùng, không thể xoá...", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                MessageBox.Show(ex.ToString());
            }
            cmd.Dispose();
            cmd = null;
        }

        //Kiểm tra khoá trùng
        public bool CheckKey(string sql)
        {
            SqlDataAdapter Mydata = new SqlDataAdapter(sql, cn);
            DataTable table = new DataTable();
            Mydata.Fill(table);
            if (table.Rows.Count > 0)
            {
                return true;

            }
            else return false;
        }

    }
}
