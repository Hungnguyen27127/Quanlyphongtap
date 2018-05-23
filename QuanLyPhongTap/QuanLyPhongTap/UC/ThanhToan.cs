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
using QuanLyPhongTap.DT0;

namespace QuanLyPhongTap.UC
{
    public partial class ThanhToan : UserControl
    {
        public ThanhToan()
        {
            InitializeComponent();
        }
        bool themhd;
        bool themct;
        private void xuat()
        {
            dgv_hoadon.DataSource = BUS.BUS.xuat_HD();
            string ma = dgv_hoadon.CurrentRow.Cells[0].Value.ToString();
            dgv_ct.DataSource = BUS.BUS.xuat_cthd(ma);
            DataTable dt, dt1, dt2 = new DataTable();
            dt = BUS.BUS.xuat_GDV();
            dt1 = BUS.BUS.xuat_NV();
            dt2 = BUS.BUS.xuat_KH();
            cbo_tensp.DataSource = dt;
            cmb_tennv.DataSource = dt1;
            cmb_kh.DataSource = dt2;
            cmb_tennv.DisplayMember = "Tên NV";
            cmb_tennv.ValueMember = "Mã NV";
            cbo_tensp.ValueMember = "Mã sản phẩm";
            cbo_tensp.DisplayMember = "Tên sản phẩm";
            cbo_tengoitap.ValueMember = "Mã gói tập";
            cbo_tengoitap.DisplayMember = "Tên gói tập";
            cmb_kh.ValueMember = "Mã Khách hàng";
            cmb_kh.DisplayMember = "Tên Khách hàng";
            cbo_tensp.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbo_tensp.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbo_tengoitap.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbo_tengoitap.AutoCompleteSource = AutoCompleteSource.ListItems;
            txt_mahd.Enabled = false;
            txt_macthd.Enabled = false;
            themhd = false;
            themct = false;
        }

        private void ThanhToan_Load(object sender, EventArgs e)
        {
            xuat();

        }

        private void dgv_hoadon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string ma = dgv_hoadon.CurrentRow.Cells[0].Value.ToString();
            dgv_ct.DataSource = BUS.BUS.xuat_cthd(ma);
            txt_mahd.Text = dgv_hoadon.CurrentRow.Cells[0].Value.ToString();
            cmb_tennv.Text = dgv_hoadon.CurrentRow.Cells[1].Value.ToString();
            cmb_kh.Text = dgv_hoadon.CurrentRow.Cells[2].Value.ToString();
            dtp_ngaylap.Text = dgv_hoadon.CurrentRow.Cells[3].Value.ToString();

            txt_tongtien.Text = dgv_hoadon.CurrentRow.Cells[4].Value.ToString();
        }

        private void cbo_tengoitap_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (cbo_tengoitap.SelectedValue == null)
                return;
            string ma = cbo_tengoitap.SelectedValue.ToString();

            DataTable dt1 = new DataTable();
            dt1 = BUS.BUS.xuat_ctdv(ma);

            cmb_gia.DataSource = dt1;

            cmb_gia.DisplayMember = "Giá dịch vụ";
        }
        void tinhtien()
        {
            int soluong = 0;
            float dongia = 0;
            float thanhtien = 0;
            try
            {
                int.TryParse(txt_sl.Text, out soluong);
                float.TryParse(cmb_gia.Text, out dongia);
                thanhtien = dongia * soluong;
                int y = (int)thanhtien;
                txt_tien.Text = y.ToString();


            }
            catch (Exception ex)
            {
                MessageBox.Show("loi" + ex.Message);
            }
        }
        private void txt_sl_TextChanged(object sender, EventArgs e)
        {
            tinhtien();

        }

        private void txt_tien_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgv_ct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_macthd.Text = dgv_ct.CurrentRow.Cells[0].Value.ToString();
            cbo_tensp.Text = dgv_ct.CurrentRow.Cells[1].Value.ToString();
            cbo_tengoitap.Text = dgv_ct.CurrentRow.Cells[2].Value.ToString();
            txt_sl.Text = dgv_ct.CurrentRow.Cells[3].Value.ToString();
            cmb_gia.Text = dgv_ct.CurrentRow.Cells[4].Value.ToString();
            txt_tien.Text = dgv_ct.CurrentRow.Cells[5].Value.ToString();
        }

        private void cmb_gia_SelectedIndexChanged(object sender, EventArgs e)
        {
            tinhtien();
        }
        void tongtien()
        {
            int sum = 0;
            for (int i = 0; i < dgv_ct.Rows.Count; i++)
            {
                sum += Convert.ToInt32(dgv_ct["Tiền", i].Value);
            }
            txt_tongtien.Text = sum.ToString();
        }


        private void reset1()
        {
            txt_mahd.ResetText();
            cmb_tennv.ResetText();
            cmb_kh.ResetText();
            dtp_ngaylap.ResetText();

        }
        private void reset2()
        {
            txt_macthd.ResetText();
            cbo_tensp.ResetText();
            txt_sl.ResetText();
            cbo_tengoitap.ResetText();
            cmb_gia.ResetText();
            txt_tien.ResetText();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            txt_mahd.Enabled = true;
            reset1();
            themhd = true;
        }
        private void btn_reset_Click(object sender, EventArgs e)
        {
            reset1();
            reset2();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            Hoadon a = new Hoadon();
            a.Mahd = txt_mahd.Text.Trim();
            a.Manv = cmb_tennv.SelectedValue.ToString();
            a.Makh = cmb_kh.SelectedValue.ToString();
            a.Ngaylap = dtp_ngaylap.Value;
            a.Tongtien = float.Parse(txt_tongtien.Text);
            if (a.Mahd == null || a.Mahd == "") throw new Exception();
            if (BUS.BUS.sua_hd(a) == 1)
            {
                MessageBox.Show("Sửa thành công");
                txt_mahd.Enabled = false;
            }
            xuat();
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            Hoadon a = new Hoadon();
            a.Mahd = txt_mahd.Text.Trim();
            if (BUS.BUS.xoa_hd(a) != 1)
                MessageBox.Show("Không xóa được");
            else
            {

                MessageBox.Show("Xóa Thành Công");
            }
            reset1();
            reset2();
            xuat();
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (themhd)
            {

                Hoadon a = new Hoadon();
                a.Mahd = txt_mahd.Text.Trim();
                a.Manv = cmb_tennv.SelectedValue.ToString();
                a.Makh = cmb_kh.SelectedValue.ToString();
                a.Ngaylap = dtp_ngaylap.Value;

                a.Tongtien = float.Parse(txt_tongtien.Text);
                // txt_tongtien.Text = "0";
                if (a.Mahd == null || a.Mahd == "") throw new Exception();
                if (BUS.BUS.them_hd(a) == 1)
                {
                    MessageBox.Show("Thêm Thành Công");
                    txt_mahd.Enabled = false;
                }
                xuat();
            }
        
            else if (themct)
            {
                CTHoadon b = new CTHoadon();
                b.Macthd = txt_macthd.Text.Trim();
                b.Masp = txt_mahd.Text.Trim();
                b.Madv = cbo_tengoitap.SelectedValue.ToString();
                b.Dongia = float.Parse(cmb_gia.Text);
                b.Soluong = int.Parse(txt_sl.Text);
                b.Tien = float.Parse(txt_tien.Text);
                if (BUS.BUS.them_cthd(b) == 1)
                {
                    MessageBox.Show("Thêm Thành Công");
                    txt_macthd.Enabled = false;
                }
                string ma = txt_mahd.Text;
                dgv_ct.DataSource = BUS.BUS.xuat_cthd(ma);
                txt_macthd.Enabled = false;
                tongtien();
            }
            else
            {
                if (txt_tongtien.Text != "0" && txt_tongtien.Text != null)
                {
                    if (MessageBox.Show("Bạn có muốn lưu tổng tiền ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        luutien();
                        MessageBox.Show("đã lưu tổng tiền");
                    }
                }
            }
        }
    
        //Chi tiết hóa đơn
        //Thêm
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            txt_macthd.Enabled = true;
            reset2();
            themct = true;
        }
        //Sửa
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

            CTHoadon b = new CTHoadon();
            b.Macthd = txt_macthd.Text.Trim();
            b.Masp = cbo_tensp.SelectedValue.ToString();
            b.Madv = cbo_tengoitap.SelectedValue.ToString();
            b.Dongia = float.Parse(cmb_gia.Text);
            b.Soluong = int.Parse(txt_sl.Text);
            b.Tien = float.Parse(txt_tien.Text);

            if (b.Macthd == null || b.Macthd == "") throw new Exception();
            if (BUS.BUS.sua_cthd(b) == 1)
            {
                MessageBox.Show("Sửa thành công");
                txt_macthd.Enabled = false;
            }
            // else { MessageBox.Show("lỗi"); }
            string ma = txt_mahd.Text;
            dgv_ct.DataSource = BUS.BUS.xuat_cthd(ma);
            txt_macthd.Enabled = false;
            tongtien();
        }
        //Xóa
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            CTHoadon a = new CTHoadon();
            a.Macthd = txt_macthd.Text.Trim();
            if (BUS.BUS.xoa_cthd(a) != 1)
                MessageBox.Show("Không xóa được");
            else
            {

                MessageBox.Show("Xóa Thành Công");
            }
            reset1();
            reset2();
            string ma = txt_mahd.Text;
            dgv_ct.DataSource = BUS.BUS.xuat_cthd(ma);
            txt_macthd.Enabled = false;
            tongtien();
        }
        private void luutien()
        {
            Hoadon a = new Hoadon();
            a.Mahd = txt_mahd.Text.Trim(); 
            string b = txt_tongtien.Text;
            a.Tongtien = float.Parse(b);
            if (BUS.BUS.sua_hoadon1(a) == 1)
            {

                xuat();
            }
        }

        private void txt_tongtien_TextChanged(object sender, EventArgs e)
        {
            if (txt_tongtien.Text != "0" && txt_tongtien.Text != null)
            {
                luutien();
            }
        }

    }
}
