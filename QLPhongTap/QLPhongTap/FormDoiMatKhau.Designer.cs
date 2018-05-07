namespace QLPhongTap
{
    partial class FormDoiMatKhau
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
            this.txtMatKhauCu = new System.Windows.Forms.TextBox();
            this.txtMatKhauMoi = new System.Windows.Forms.TextBox();
            this.txtXacNhanMatKhau = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDoiMatKhau = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMatKhauCu
            // 
            this.txtMatKhauCu.Location = new System.Drawing.Point(270, 17);
            this.txtMatKhauCu.Name = "txtMatKhauCu";
            this.txtMatKhauCu.PasswordChar = '*';
            this.txtMatKhauCu.Size = new System.Drawing.Size(211, 22);
            this.txtMatKhauCu.TabIndex = 2;
            // 
            // txtMatKhauMoi
            // 
            this.txtMatKhauMoi.Location = new System.Drawing.Point(270, 49);
            this.txtMatKhauMoi.Name = "txtMatKhauMoi";
            this.txtMatKhauMoi.PasswordChar = '*';
            this.txtMatKhauMoi.Size = new System.Drawing.Size(211, 22);
            this.txtMatKhauMoi.TabIndex = 4;
            // 
            // txtXacNhanMatKhau
            // 
            this.txtXacNhanMatKhau.Location = new System.Drawing.Point(270, 85);
            this.txtXacNhanMatKhau.Name = "txtXacNhanMatKhau";
            this.txtXacNhanMatKhau.PasswordChar = '*';
            this.txtXacNhanMatKhau.Size = new System.Drawing.Size(211, 22);
            this.txtXacNhanMatKhau.TabIndex = 6;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Navy;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnThoat.Location = new System.Drawing.Point(303, 19);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(108, 35);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(57, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Xác Nhận Mật Khẩu ";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(57, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mật Khẩu Mới";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(57, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mật Khẩu Cũ";
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.BackColor = System.Drawing.Color.Navy;
            this.btnDoiMatKhau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoiMatKhau.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoiMatKhau.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDoiMatKhau.Location = new System.Drawing.Point(15, 19);
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.Size = new System.Drawing.Size(97, 35);
            this.btnDoiMatKhau.TabIndex = 0;
            this.btnDoiMatKhau.Text = "Đổi Mật Khẩu";
            this.btnDoiMatKhau.UseVisualStyleBackColor = false;
            this.btnDoiMatKhau.Click += new System.EventHandler(this.btnDoiMatKhau_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnHuy);
            this.groupBox2.Controls.Add(this.btnThoat);
            this.groupBox2.Controls.Add(this.btnDoiMatKhau);
            this.groupBox2.Location = new System.Drawing.Point(59, 175);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(429, 68);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.Navy;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnHuy.Location = new System.Drawing.Point(155, 19);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(97, 35);
            this.btnHuy.TabIndex = 8;
            this.btnHuy.Text = "Huỷ";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMatKhauCu);
            this.groupBox1.Controls.Add(this.txtMatKhauMoi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtXacNhanMatKhau);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Location = new System.Drawing.Point(22, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(506, 139);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Đổi mật khẩu";
            // 
            // FormDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 270);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormDoiMatKhau";
            this.Text = "FrmDoiMatKhau";
            this.Load += new System.EventHandler(this.FormDoiMatKhau_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtMatKhauCu;
        private System.Windows.Forms.TextBox txtMatKhauMoi;
        private System.Windows.Forms.TextBox txtXacNhanMatKhau;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDoiMatKhau;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnHuy;
    }
}