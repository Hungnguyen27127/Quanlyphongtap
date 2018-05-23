namespace QuanLyPhongTap.UC
{
    partial class ThanhToan
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThanhToan));
            this.panel_banhang = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgv_ct = new System.Windows.Forms.DataGridView();
            this.chitiethoadon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.them1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sua1 = new System.Windows.Forms.ToolStripMenuItem();
            this.xoa1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgv_hoadon = new System.Windows.Forms.DataGridView();
            this.hoadon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.thêmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sửaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_luu = new System.Windows.Forms.Button();
            this.txt_tongtien = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmb_kh = new System.Windows.Forms.ComboBox();
            this.dtp_ngaylap = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_tennv = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_mahd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbo_tengoitap = new System.Windows.Forms.ComboBox();
            this.txt_sl = new System.Windows.Forms.TextBox();
            this.cbo_tensp = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cmb_gia = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_tien = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_macthd = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel_banhang.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ct)).BeginInit();
            this.chitiethoadon.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hoadon)).BeginInit();
            this.hoadon.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_banhang
            // 
            this.panel_banhang.Controls.Add(this.panel5);
            this.panel_banhang.Controls.Add(this.panel4);
            this.panel_banhang.Controls.Add(this.panel3);
            this.panel_banhang.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_banhang.Location = new System.Drawing.Point(0, 218);
            this.panel_banhang.Margin = new System.Windows.Forms.Padding(2);
            this.panel_banhang.Name = "panel_banhang";
            this.panel_banhang.Size = new System.Drawing.Size(850, 272);
            this.panel_banhang.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dgv_ct);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(420, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(430, 232);
            this.panel5.TabIndex = 6;
            // 
            // dgv_ct
            // 
            this.dgv_ct.AllowUserToAddRows = false;
            this.dgv_ct.AllowUserToDeleteRows = false;
            this.dgv_ct.AllowUserToResizeRows = false;
            this.dgv_ct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ct.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_ct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ct.ContextMenuStrip = this.chitiethoadon;
            this.dgv_ct.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_ct.Location = new System.Drawing.Point(0, 0);
            this.dgv_ct.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_ct.Name = "dgv_ct";
            this.dgv_ct.RowTemplate.Height = 24;
            this.dgv_ct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ct.Size = new System.Drawing.Size(430, 232);
            this.dgv_ct.TabIndex = 3;
            this.dgv_ct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ct_CellContentClick);
            // 
            // chitiethoadon
            // 
            this.chitiethoadon.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.chitiethoadon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.them1,
            this.sua1,
            this.xoa1});
            this.chitiethoadon.Name = "hoadon";
            this.chitiethoadon.Size = new System.Drawing.Size(110, 82);
            // 
            // them1
            // 
            this.them1.Image = global::QuanLyPhongTap.Properties.Resources.Add;
            this.them1.Name = "them1";
            this.them1.Size = new System.Drawing.Size(109, 26);
            this.them1.Text = "Thêm";
            this.them1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // sua1
            // 
            this.sua1.Image = global::QuanLyPhongTap.Properties.Resources._1489101110_Edit2;
            this.sua1.Name = "sua1";
            this.sua1.Size = new System.Drawing.Size(109, 26);
            this.sua1.Text = "Sửa";
            this.sua1.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // xoa1
            // 
            this.xoa1.Image = global::QuanLyPhongTap.Properties.Resources.baoloi;
            this.xoa1.Name = "xoa1";
            this.xoa1.Size = new System.Drawing.Size(109, 26);
            this.xoa1.Text = "Xóa";
            this.xoa1.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgv_hoadon);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(420, 232);
            this.panel4.TabIndex = 5;
            // 
            // dgv_hoadon
            // 
            this.dgv_hoadon.AllowUserToAddRows = false;
            this.dgv_hoadon.AllowUserToDeleteRows = false;
            this.dgv_hoadon.AllowUserToResizeRows = false;
            this.dgv_hoadon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_hoadon.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_hoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_hoadon.ContextMenuStrip = this.hoadon;
            this.dgv_hoadon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_hoadon.Location = new System.Drawing.Point(0, 0);
            this.dgv_hoadon.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_hoadon.Name = "dgv_hoadon";
            this.dgv_hoadon.RowTemplate.Height = 24;
            this.dgv_hoadon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_hoadon.Size = new System.Drawing.Size(420, 232);
            this.dgv_hoadon.TabIndex = 2;
            this.dgv_hoadon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_hoadon_CellContentClick);
            // 
            // hoadon
            // 
            this.hoadon.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.hoadon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmToolStripMenuItem,
            this.sửaToolStripMenuItem,
            this.xóaToolStripMenuItem});
            this.hoadon.Name = "hoadon";
            this.hoadon.Size = new System.Drawing.Size(110, 82);
            // 
            // thêmToolStripMenuItem
            // 
            this.thêmToolStripMenuItem.Image = global::QuanLyPhongTap.Properties.Resources.Add;
            this.thêmToolStripMenuItem.Name = "thêmToolStripMenuItem";
            this.thêmToolStripMenuItem.Size = new System.Drawing.Size(109, 26);
            this.thêmToolStripMenuItem.Text = "Thêm";
            // 
            // sửaToolStripMenuItem
            // 
            this.sửaToolStripMenuItem.Image = global::QuanLyPhongTap.Properties.Resources._1489101110_Edit2;
            this.sửaToolStripMenuItem.Name = "sửaToolStripMenuItem";
            this.sửaToolStripMenuItem.Size = new System.Drawing.Size(109, 26);
            this.sửaToolStripMenuItem.Text = "Sửa";
            // 
            // xóaToolStripMenuItem
            // 
            this.xóaToolStripMenuItem.Image = global::QuanLyPhongTap.Properties.Resources.baoloi;
            this.xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
            this.xóaToolStripMenuItem.Size = new System.Drawing.Size(109, 26);
            this.xóaToolStripMenuItem.Text = "Xóa";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnXoa);
            this.panel3.Controls.Add(this.btnSua);
            this.panel3.Controls.Add(this.btnThem);
            this.panel3.Controls.Add(this.btn_reset);
            this.panel3.Controls.Add(this.btn_luu);
            this.panel3.Controls.Add(this.txt_tongtien);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 232);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(850, 40);
            this.panel3.TabIndex = 4;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.Black;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(499, 5);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(82, 32);
            this.btnXoa.TabIndex = 128;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click_1);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.Black;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(386, 5);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(80, 31);
            this.btnSua.TabIndex = 127;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.Black;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(276, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(86, 33);
            this.btnThem.TabIndex = 126;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.Image = global::QuanLyPhongTap.Properties.Resources.refresh_forward;
            this.btn_reset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_reset.Location = new System.Drawing.Point(759, 4);
            this.btn_reset.Margin = new System.Windows.Forms.Padding(2);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(77, 28);
            this.btn_reset.TabIndex = 17;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_luu
            // 
            this.btn_luu.Image = global::QuanLyPhongTap.Properties.Resources.badge_save;
            this.btn_luu.Location = new System.Drawing.Point(629, 5);
            this.btn_luu.Margin = new System.Windows.Forms.Padding(2);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(83, 28);
            this.btn_luu.TabIndex = 16;
            this.btn_luu.UseVisualStyleBackColor = true;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // txt_tongtien
            // 
            this.txt_tongtien.Enabled = false;
            this.txt_tongtien.Location = new System.Drawing.Point(100, 9);
            this.txt_tongtien.Margin = new System.Windows.Forms.Padding(2);
            this.txt_tongtien.Name = "txt_tongtien";
            this.txt_tongtien.Size = new System.Drawing.Size(146, 20);
            this.txt_tongtien.TabIndex = 11;
            this.txt_tongtien.Text = "0";
            this.txt_tongtien.TextChanged += new System.EventHandler(this.txt_tongtien_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 14);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Tổng Tiền";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.cmb_kh);
            this.panel1.Controls.Add(this.dtp_ngaylap);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cmb_tennv);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_mahd);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(416, 218);
            this.panel1.TabIndex = 2;
            // 
            // cmb_kh
            // 
            this.cmb_kh.FormattingEnabled = true;
            this.cmb_kh.Location = new System.Drawing.Point(64, 139);
            this.cmb_kh.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_kh.Name = "cmb_kh";
            this.cmb_kh.Size = new System.Drawing.Size(111, 21);
            this.cmb_kh.TabIndex = 12;
            // 
            // dtp_ngaylap
            // 
            this.dtp_ngaylap.Location = new System.Drawing.Point(290, 63);
            this.dtp_ngaylap.Margin = new System.Windows.Forms.Padding(2);
            this.dtp_ngaylap.Name = "dtp_ngaylap";
            this.dtp_ngaylap.Size = new System.Drawing.Size(115, 20);
            this.dtp_ngaylap.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(9, 2);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(147, 15);
            this.label12.TabIndex = 10;
            this.label12.Tag = "";
            this.label12.Text = "THÔNG TIN HÓA ĐƠN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(216, 63);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Ngày lập";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(2, 140);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = " Tên KH";
            // 
            // cmb_tennv
            // 
            this.cmb_tennv.FormattingEnabled = true;
            this.cmb_tennv.Location = new System.Drawing.Point(290, 133);
            this.cmb_tennv.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_tennv.Name = "cmb_tennv";
            this.cmb_tennv.Size = new System.Drawing.Size(111, 21);
            this.cmb_tennv.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(216, 139);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên NV";
            // 
            // txt_mahd
            // 
            this.txt_mahd.Location = new System.Drawing.Point(64, 67);
            this.txt_mahd.Margin = new System.Windows.Forms.Padding(2);
            this.txt_mahd.Name = "txt_mahd";
            this.txt_mahd.Size = new System.Drawing.Size(111, 20);
            this.txt_mahd.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã HD";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MistyRose;
            this.panel2.Controls.Add(this.cbo_tengoitap);
            this.panel2.Controls.Add(this.txt_sl);
            this.panel2.Controls.Add(this.cbo_tensp);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.cmb_gia);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.txt_tien);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txt_macthd);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(424, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(426, 212);
            this.panel2.TabIndex = 3;
            // 
            // cbo_tengoitap
            // 
            this.cbo_tengoitap.FormattingEnabled = true;
            this.cbo_tengoitap.Location = new System.Drawing.Point(88, 152);
            this.cbo_tengoitap.Name = "cbo_tengoitap";
            this.cbo_tengoitap.Size = new System.Drawing.Size(102, 21);
            this.cbo_tengoitap.TabIndex = 21;
            this.cbo_tengoitap.SelectedIndexChanged += new System.EventHandler(this.cbo_tengoitap_SelectedIndexChanged);
            // 
            // txt_sl
            // 
            this.txt_sl.Location = new System.Drawing.Point(310, 40);
            this.txt_sl.Margin = new System.Windows.Forms.Padding(2);
            this.txt_sl.Name = "txt_sl";
            this.txt_sl.Size = new System.Drawing.Size(102, 20);
            this.txt_sl.TabIndex = 20;
            this.txt_sl.TextChanged += new System.EventHandler(this.txt_sl_TextChanged);
            // 
            // cbo_tensp
            // 
            this.cbo_tensp.FormattingEnabled = true;
            this.cbo_tensp.Location = new System.Drawing.Point(87, 92);
            this.cbo_tensp.Name = "cbo_tensp";
            this.cbo_tensp.Size = new System.Drawing.Size(102, 21);
            this.cbo_tensp.TabIndex = 19;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(4, 93);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 15);
            this.label15.TabIndex = 16;
            this.label15.Text = "Tên SP";
            // 
            // cmb_gia
            // 
            this.cmb_gia.Enabled = false;
            this.cmb_gia.FormattingEnabled = true;
            this.cmb_gia.Location = new System.Drawing.Point(310, 86);
            this.cmb_gia.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_gia.Name = "cmb_gia";
            this.cmb_gia.Size = new System.Drawing.Size(102, 21);
            this.cmb_gia.TabIndex = 15;
            this.cmb_gia.SelectedIndexChanged += new System.EventHandler(this.cmb_gia_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(214, 45);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 15);
            this.label14.TabIndex = 13;
            this.label14.Text = "Số lượng DV";
            // 
            // txt_tien
            // 
            this.txt_tien.Enabled = false;
            this.txt_tien.Location = new System.Drawing.Point(310, 152);
            this.txt_tien.Margin = new System.Windows.Forms.Padding(2);
            this.txt_tien.Name = "txt_tien";
            this.txt_tien.Size = new System.Drawing.Size(102, 20);
            this.txt_tien.TabIndex = 12;
            this.txt_tien.TextChanged += new System.EventHandler(this.txt_tien_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(214, 143);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 15);
            this.label13.TabIndex = 11;
            this.label13.Text = "Thành tiền";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "CHI TIẾT HÓA ĐƠN";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(214, 92);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 15);
            this.label11.TabIndex = 8;
            this.label11.Text = "Giá";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(4, 158);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 15);
            this.label9.TabIndex = 4;
            this.label9.Text = "Tên gói tập";
            // 
            // txt_macthd
            // 
            this.txt_macthd.Enabled = false;
            this.txt_macthd.Location = new System.Drawing.Point(88, 40);
            this.txt_macthd.Margin = new System.Windows.Forms.Padding(2);
            this.txt_macthd.Name = "txt_macthd";
            this.txt_macthd.Size = new System.Drawing.Size(102, 20);
            this.txt_macthd.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(4, 45);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 15);
            this.label8.TabIndex = 2;
            this.label8.Text = "Mã  CTHD";
            // 
            // ThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_banhang);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ThanhToan";
            this.Size = new System.Drawing.Size(850, 490);
            this.Load += new System.EventHandler(this.ThanhToan_Load);
            this.panel_banhang.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ct)).EndInit();
            this.chitiethoadon.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hoadon)).EndInit();
            this.hoadon.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_banhang;
        private System.Windows.Forms.DataGridView dgv_ct;
        private System.Windows.Forms.DataGridView dgv_hoadon;
        private System.Windows.Forms.ContextMenuStrip hoadon;
        private System.Windows.Forms.ToolStripMenuItem thêmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sửaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip chitiethoadon;
        private System.Windows.Forms.ToolStripMenuItem them1;
        private System.Windows.Forms.ToolStripMenuItem sua1;
        private System.Windows.Forms.ToolStripMenuItem xoa1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmb_tennv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_mahd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_tongtien;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_macthd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_tien;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmb_gia;
        private System.Windows.Forms.DateTimePicker dtp_ngaylap;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.ComboBox cmb_kh;
        private System.Windows.Forms.TextBox txt_sl;
        private System.Windows.Forms.ComboBox cbo_tensp;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cbo_tengoitap;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
    }
}
