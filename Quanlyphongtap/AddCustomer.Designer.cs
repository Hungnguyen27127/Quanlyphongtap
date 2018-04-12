namespace Quanlyphongtap
{
    partial class AddCustomer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.dtpBirthdayCustomer = new System.Windows.Forms.DateTimePicker();
            this.txtPhoneCustomer = new DevExpress.XtraEditors.TextEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAdressCustomer = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdCustomer = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNameCustomer = new DevExpress.XtraEditors.TextEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.cbxService = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.txtgioitinhKH = new DevExpress.XtraEditors.TextEdit();
            this.lblmaDichvu = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhoneCustomer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdressCustomer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdCustomer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNameCustomer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtgioitinhKH.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.MaxItemId = 0;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(817, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 424);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(817, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 424);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(817, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 424);
            // 
            // groupControl1
            // 
            this.groupControl1.CaptionLocation = DevExpress.Utils.Locations.Top;
            this.groupControl1.Controls.Add(this.txtgioitinhKH);
            this.groupControl1.Controls.Add(this.dtpBirthdayCustomer);
            this.groupControl1.Controls.Add(this.txtPhoneCustomer);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.txtAdressCustomer);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.txtIdCustomer);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.txtNameCustomer);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(817, 178);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "Thông tin khách hàng";
            // 
            // dtpBirthdayCustomer
            // 
            this.dtpBirthdayCustomer.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirthdayCustomer.Location = new System.Drawing.Point(91, 51);
            this.dtpBirthdayCustomer.Name = "dtpBirthdayCustomer";
            this.dtpBirthdayCustomer.Size = new System.Drawing.Size(200, 21);
            this.dtpBirthdayCustomer.TabIndex = 14;
            // 
            // txtPhoneCustomer
            // 
            this.txtPhoneCustomer.Location = new System.Drawing.Point(91, 115);
            this.txtPhoneCustomer.MenuManager = this.barManager1;
            this.txtPhoneCustomer.Name = "txtPhoneCustomer";
            this.txtPhoneCustomer.Size = new System.Drawing.Size(124, 20);
            this.txtPhoneCustomer.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Số Điện Thoại";
            // 
            // txtAdressCustomer
            // 
            this.txtAdressCustomer.Location = new System.Drawing.Point(91, 84);
            this.txtAdressCustomer.MenuManager = this.barManager1;
            this.txtAdressCustomer.Name = "txtAdressCustomer";
            this.txtAdressCustomer.Size = new System.Drawing.Size(602, 20);
            this.txtAdressCustomer.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Ngày Sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(351, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Giới Tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Địa Chỉ";
            // 
            // txtIdCustomer
            // 
            this.txtIdCustomer.Location = new System.Drawing.Point(462, 26);
            this.txtIdCustomer.MenuManager = this.barManager1;
            this.txtIdCustomer.Name = "txtIdCustomer";
            this.txtIdCustomer.Size = new System.Drawing.Size(157, 20);
            this.txtIdCustomer.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(351, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã Khách Hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Họ Tên";
            // 
            // txtNameCustomer
            // 
            this.txtNameCustomer.Location = new System.Drawing.Point(91, 23);
            this.txtNameCustomer.MenuManager = this.barManager1;
            this.txtNameCustomer.Name = "txtNameCustomer";
            this.txtNameCustomer.Size = new System.Drawing.Size(229, 20);
            this.txtNameCustomer.TabIndex = 0;
            this.txtNameCustomer.EditValueChanged += new System.EventHandler(this.textEdit1_EditValueChanged);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.lblmaDichvu);
            this.groupControl2.Controls.Add(this.dateTimePicker2);
            this.groupControl2.Controls.Add(this.cbxService);
            this.groupControl2.Controls.Add(this.label8);
            this.groupControl2.Controls.Add(this.label7);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl2.Location = new System.Drawing.Point(0, 178);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(817, 120);
            this.groupControl2.TabIndex = 5;
            this.groupControl2.Text = "Thông tin gói dịch vụ";
            this.groupControl2.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl2_Paint);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(96, 68);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 21);
            this.dateTimePicker2.TabIndex = 18;
            // 
            // cbxService
            // 
            this.cbxService.FormattingEnabled = true;
            this.cbxService.Location = new System.Drawing.Point(96, 33);
            this.cbxService.Name = "cbxService";
            this.cbxService.Size = new System.Drawing.Size(200, 21);
            this.cbxService.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Ngày Đăng Ký";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Tên Dịch Vụ";
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(443, 321);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(161, 40);
            this.btnAddCustomer.TabIndex = 10;
            this.btnAddCustomer.Text = "Thêm Mới";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // txtgioitinhKH
            // 
            this.txtgioitinhKH.Location = new System.Drawing.Point(462, 52);
            this.txtgioitinhKH.MenuManager = this.barManager1;
            this.txtgioitinhKH.Name = "txtgioitinhKH";
            this.txtgioitinhKH.Size = new System.Drawing.Size(100, 20);
            this.txtgioitinhKH.TabIndex = 15;
            // 
            // lblmaDichvu
            // 
            this.lblmaDichvu.AutoSize = true;
            this.lblmaDichvu.Location = new System.Drawing.Point(370, 40);
            this.lblmaDichvu.Name = "lblmaDichvu";
            this.lblmaDichvu.Size = new System.Drawing.Size(0, 13);
            this.lblmaDichvu.TabIndex = 19;
            // 
            // AddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 424);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "AddCustomer";
            this.Text = "AddCustomer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AddCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhoneCustomer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdressCustomer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdCustomer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNameCustomer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtgioitinhKH.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtNameCustomer;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.TextEdit txtPhoneCustomer;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.TextEdit txtAdressCustomer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit txtIdCustomer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ComboBox cbxService;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpBirthdayCustomer;
        private DevExpress.XtraEditors.TextEdit txtgioitinhKH;
        private System.Windows.Forms.Label lblmaDichvu;
    }
}