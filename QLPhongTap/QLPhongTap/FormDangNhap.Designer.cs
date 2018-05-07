namespace QLPhongTap
{
    partial class FormDangNhap
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txttendangnhap = new System.Windows.Forms.TextBox();
            this.txtmatkhau = new System.Windows.Forms.TextBox();
            this.btndangnhap = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(275, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên đăng nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(275, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu";
            // 
            // txttendangnhap
            // 
            this.txttendangnhap.Location = new System.Drawing.Point(429, 89);
            this.txttendangnhap.Name = "txttendangnhap";
            this.txttendangnhap.Size = new System.Drawing.Size(153, 20);
            this.txttendangnhap.TabIndex = 2;
            // 
            // txtmatkhau
            // 
            this.txtmatkhau.Location = new System.Drawing.Point(429, 171);
            this.txtmatkhau.Name = "txtmatkhau";
            this.txtmatkhau.Size = new System.Drawing.Size(153, 20);
            this.txtmatkhau.TabIndex = 3;
            // 
            // btndangnhap
            // 
            this.btndangnhap.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btndangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndangnhap.Location = new System.Drawing.Point(265, 307);
            this.btndangnhap.Name = "btndangnhap";
            this.btndangnhap.Size = new System.Drawing.Size(104, 36);
            this.btndangnhap.TabIndex = 4;
            this.btndangnhap.Text = "Đăng nhập";
            this.btndangnhap.UseVisualStyleBackColor = false;
            this.btndangnhap.Click += new System.EventHandler(this.btndangnhap_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(465, 307);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 36);
            this.button2.TabIndex = 5;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(68, 307);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(104, 36);
            this.btnHuy.TabIndex = 7;
            this.btnHuy.Text = "Huỷ";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLPhongTap.Properties.Resources.main_icon;
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(26, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(223, 229);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // FormDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 372);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btndangnhap);
            this.Controls.Add(this.txtmatkhau);
            this.Controls.Add(this.txttendangnhap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmDangNhap";
            this.Load += new System.EventHandler(this.FormDangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttendangnhap;
        private System.Windows.Forms.TextBox txtmatkhau;
        private System.Windows.Forms.Button btndangnhap;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnHuy;
    }
}