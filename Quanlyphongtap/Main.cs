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
    public partial class Main : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        string tenuser = "", tennhanvien = "", matkhau = "", manql = "", quyen = "";

        private void btnAddCustomer_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool _isActive = false;
            foreach (Form form in Application.OpenForms.OfType<Form>().ToList())
            {
                if(form.GetType() == typeof(AddCustomer))
                {
                    form.Activate();
                    _isActive = true;
                }
            }

            if (!_isActive)
            {
                AddCustomer addCustomer = new AddCustomer();
                addCustomer.MdiParent = this;
                addCustomer.Show();
            }
        }

        private void btnListCustomer_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool _isActive = false;
            foreach (Form form in Application.OpenForms.OfType<Form>().ToList())
            {
                if(form.GetType() == typeof(DanhsachKhachhang))
                {
                    form.Activate();
                    _isActive = true;
                }
            }

            if (!_isActive)
            {
                DanhsachKhachhang danhsachKhachhang = new DanhsachKhachhang();
                danhsachKhachhang.MdiParent = this;
                danhsachKhachhang.Show();
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool _isActive = false;
            foreach (Form form in Application.OpenForms.OfType<Form>().ToList())
            {
                if(form.GetType() == typeof(Updatecs))
                {
                    form.Activate();
                    _isActive = true;
                }
            }
            if (!_isActive)
            {
                Updatecs updatecs = new Updatecs();
                updatecs.MdiParent = this;
                updatecs.Show();
            }
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {
        }

        public Main()
        {
            InitializeComponent();
        }

        public Main(string tenuser, string tennhanvien, string matkhau, string manql, string quyen)
        {
            InitializeComponent();
            this.tenuser = tenuser;
            this.tennhanvien = tennhanvien;
            this.matkhau = matkhau;
            this.manql = manql;
            this.quyen = quyen;
        }
        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}
