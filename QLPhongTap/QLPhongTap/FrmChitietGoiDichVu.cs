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
    public partial class FrmChitietGoiDichVu : Form
    {
        public FrmChitietGoiDichVu()
        {
            InitializeComponent();
        }
        ConnectSQL conn = new ConnectSQL();
        public static string themsua;
        public static string madichvu;
        
        private void FrmChitietGoiDichVu_Load(object sender, EventArgs e)
        {
            conn.KetNoi();
            hienthi();
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
        }
        public void Load_ListView(ListView lvwName, DataTable tb)
        {
            listView1.Items.Clear();
            for (int i = 0; i < tb.Rows.Count; i++)
            {
                string[] col = new string[tb.Columns.Count];
                for (int j = 0; j < tb.Columns.Count; j++)
                {
                    col[j] = tb.Rows[i][j].ToString();
                }
                ListViewItem lvItem = new ListViewItem(col);
                lvwName.Items.Add(lvItem);
            }
        }
        public void hienthi()
        {
            string str;
            str = "SELECT CHITIETDICHVU_ID,MADICHVU,TENDICHVU,GIA,LOAIDICHVU FROM ChiTietDichVu,DichVu WHERE MADICHVU=MADICHVU ";
            DataTable tb = new DataTable();
            tb.Load(conn.ThucHienReader(str));
            Load_ListView(listView1, tb);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            themsua = "them";
          //  Form frm = new FrmThemSuaChiTietDichVu();
            //frm.ShowDialog();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            themsua = "sua";
          //  Form frm = new FrmThemSuaChiTietDichVu();
           // frm.ShowDialog();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string str;
            str = "DELETE FROM CHITIETDICHVU WHERE CHITIETDICHVU_ID='" + madichvu.Trim() + "'";
            DialogResult result = MessageBox.Show("Bạn có chắc là muốn xóa Dịch Vụ này khỏi danh sách không ?", "Xóa Dịch Vụ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                conn.RunSQL(str);
                MessageBox.Show("Dịch Vụ đã được xóa thành công.", "Xóa Dịch Vụ");
                hienthi();
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
           // Form frm = new FrmTimKiemChiTietDichVu();
            //frm.ShowDialog();
        }
    }
}
