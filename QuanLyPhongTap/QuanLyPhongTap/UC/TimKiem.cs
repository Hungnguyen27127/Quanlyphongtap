using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLyPhongTap.BUS;
using QuanLyPhongTap.DAL;
namespace QuanLyPhongTap.UC
{
    
    public partial class TimKiem : UserControl
    {
        SqlDataAdapter da;
        DataTable dt, dt1;
        public TimKiem()
        {
            InitializeComponent();
            
        }
        private void xuat()
        {    dt= BUS.BUS.xuat_ctdv();
            dgv_timkiem.DataSource = dt;
        }

        private void TimKiem_Load(object sender, EventArgs e)
        {
            xuat();
        }

        private void txt_tkten_TextChanged(object sender, EventArgs e)
        {
            string st = string.Format("[Tên Gói Tập] like '%{0}%'", txt_tkten.Text);
            dt.DefaultView.RowFilter = st;
        }

        private void txt_tkten_Click(object sender, EventArgs e)
        {
            txt_tkten.Text = "";
        }


        private void rbtn_gia_CheckedChanged(object sender, EventArgs e)
        {
            //dt = new DataTable();
            //dt = BUS.BUS.xuat_HH();
            //cmb_hh.DataSource = dt;
            //cmb_hh.DisplayMember = "Giá Bán";
            cmb_hh.Items.Clear();
            cmb_hh.Items.Add("<100000");
            cmb_hh.Items.Add("100000---500000");
            cmb_hh.Items.Add("<1000000");
            cmb_hh.Items.Add(">1000000");
            cmb_hh.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmb_hh.AutoCompleteSource = AutoCompleteSource.ListItems;

        }

        private void rbtn_chungloai_CheckedChanged(object sender, EventArgs e)
        {
            cmb_hh.Items.Clear();
            cmb_hh.Items.Add("Yoga comba 1 tháng");
            cmb_hh.Items.Add("Gym 3 tháng");
            cmb_hh.Items.Add("Gym 6 tháng");
            cmb_hh.Items.Add("Gym 12 tháng");
            cmb_hh.Items.Add("Gym 1 tháng");
            cmb_hh.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmb_hh.AutoCompleteSource = AutoCompleteSource.ListItems;
        }


        private void dulieu(string s)
        {
            SqlConnection con = new SqlConnection(@"Data Source=PC\THUYDUNG;Initial Catalog=QLPHONGTAPGYM;Integrated Security=True");
            con.Open();
            DataTable dt2 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(s, con);
            da.Fill(dt2);
            dgv_timkiem.DataSource = dt2;
        }


        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            if (cmb_hh.Text == null) throw new Exception();
            string chuoi_dau = cmb_hh.Text.Trim();
            if (chuoi_dau.Contains("---"))
            {
                string[] chuoi_tach = chuoi_dau.Split(new Char[] { '-' });
                string chuoi_ketqua = "";
                foreach (string s in chuoi_tach)
                {

                    if (s.Trim() != "")
                        chuoi_ketqua += s;
                }
                string b1 = chuoi_dau.Substring(0, 6);
                string b2 = chuoi_dau.Substring(9, 6);
                string s1 = "select CHITIETDICHVU_ID as[Mã Chi Tiết DV],TENDICHVU as[Tên Gói Tập],GIA as[Gía],LOAIDICHVU as[Loại Dịch Vụ],MADICHVU as [Mã Dịch Vụ]] from CTDICHVU where GIA > '" + int.Parse(b1) + "' and+ GIA<'" + int.Parse(b2) + "' ";
               
                dulieu(s1);
            }
            else if ((chuoi_dau.Contains("<")))
            {
                string b = chuoi_dau.Substring(1);
                string s = "select CHITIETDICHVU_ID as[Mã Chi Tiết DV],TENDICHVU as[Tên Gói Tập],GIA as[Gía],LOAIDICHVU as[Loại Dịch Vụ],MADICHVU as [Mã Dịch Vụ]] from CTDICHVU where GIA > '" + 0 + "' and+ Gia<'" + int.Parse(b) + "' ";
               // dgv_timkiem.DataSource = BUS.BUS.xuat_HH2(0,float.Parse(b));
                dulieu(s);
            }
            else if ((chuoi_dau.Contains(">")))
            {
                string b = chuoi_dau.Substring(1);
                string s = "select CHITIETDICHVU_ID as[Mã Chi Tiết DV],TENDICHVU as[Tên Gói Tập],GIA as[Gía],LOAIDICHVU as[Loại Dịch Vụ],MADICHVU as [Mã Dịch Vụ]] from CTDICHVU where GIA > '" + 0 + "' and+ Gia>'" + float.Parse(b) + "' ";
                
                dulieu(s);
            }else {
                //string a = cmb_hh.Text;
                //dgv_timkiem.DataSource = BUS.BUS.xuat_HH3(a);
                //dgv_timkiem.DataSource = dt1;

                string s = "select CHITIETDICHVU_ID as[Mã Chi Tiết DV],TENDICHVU as[Tên Gói Tập],GIA as[Gía],LOAIDICHVU as[Loại Dịch Vụ],MADICHVU as [Mã Dịch Vụ]] from CTDICHVU  where LOAIDICHVU = N'" + cmb_hh.Text + "'";
                dulieu(s);
              
            }

        }

    }
}
