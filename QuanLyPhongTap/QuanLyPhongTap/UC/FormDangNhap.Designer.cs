namespace QuanLyPhongTap
{
    partial class Form_dangnhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_dangnhap));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_x = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_tk = new System.Windows.Forms.TextBox();
            this.txt_mk = new System.Windows.Forms.TextBox();
            this.checkBox_hienmk = new System.Windows.Forms.CheckBox();
            this.errortk = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_dangnhap = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errortk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.lbl_x);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(506, 60);
            this.panel1.TabIndex = 0;
            // 
            // lbl_x
            // 
            this.lbl_x.AutoSize = true;
            this.lbl_x.BackColor = System.Drawing.Color.Black;
            this.lbl_x.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_x.ForeColor = System.Drawing.Color.White;
            this.lbl_x.Location = new System.Drawing.Point(479, 9);
            this.lbl_x.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_x.Name = "lbl_x";
            this.lbl_x.Size = new System.Drawing.Size(20, 24);
            this.lbl_x.TabIndex = 2;
            this.lbl_x.Text = "x";
            this.lbl_x.Click += new System.EventHandler(this.lbl_x_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(234, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // txt_tk
            // 
            this.txt_tk.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tk.Location = new System.Drawing.Point(199, 97);
            this.txt_tk.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_tk.Multiline = true;
            this.txt_tk.Name = "txt_tk";
            this.txt_tk.Size = new System.Drawing.Size(217, 33);
            this.txt_tk.TabIndex = 2;
            this.txt_tk.Text = "User name";
            this.txt_tk.Click += new System.EventHandler(this.txt_tk_Click);
            this.txt_tk.TextChanged += new System.EventHandler(this.txt_tk_TextChanged);
            this.txt_tk.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_tk_KeyDown);
            this.txt_tk.Leave += new System.EventHandler(this.txt_tk_Leave);
            // 
            // txt_mk
            // 
            this.txt_mk.Font = new System.Drawing.Font("Arial Black", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mk.Location = new System.Drawing.Point(199, 150);
            this.txt_mk.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_mk.Multiline = true;
            this.txt_mk.Name = "txt_mk";
            this.txt_mk.PasswordChar = '*';
            this.txt_mk.Size = new System.Drawing.Size(217, 30);
            this.txt_mk.TabIndex = 3;
            this.txt_mk.Text = "Password";
            this.txt_mk.Click += new System.EventHandler(this.txt_mk_Click);
            this.txt_mk.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_mk_KeyDown);
            // 
            // checkBox_hienmk
            // 
            this.checkBox_hienmk.AutoSize = true;
            this.checkBox_hienmk.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_hienmk.ForeColor = System.Drawing.Color.Black;
            this.checkBox_hienmk.Location = new System.Drawing.Point(199, 197);
            this.checkBox_hienmk.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkBox_hienmk.Name = "checkBox_hienmk";
            this.checkBox_hienmk.Size = new System.Drawing.Size(120, 18);
            this.checkBox_hienmk.TabIndex = 5;
            this.checkBox_hienmk.Text = "Show password";
            this.checkBox_hienmk.UseVisualStyleBackColor = true;
            this.checkBox_hienmk.CheckedChanged += new System.EventHandler(this.checkBox_hienmk_CheckedChanged);
            // 
            // errortk
            // 
            this.errortk.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errortk.ContainerControl = this;
            this.errortk.Icon = ((System.Drawing.Icon)(resources.GetObject("errortk.Icon")));
            this.errortk.RightToLeft = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::QuanLyPhongTap.Properties.Resources.user_482;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(44, 89);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(51, 41);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::QuanLyPhongTap.Properties.Resources.Security_Password_2_icon1;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(44, 165);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(51, 41);
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(72, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 47);
            this.button1.TabIndex = 10;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel3.Controls.Add(this.lbl_dangnhap);
            this.panel3.Location = new System.Drawing.Point(288, 221);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(128, 62);
            this.panel3.TabIndex = 11;
            // 
            // lbl_dangnhap
            // 
            this.lbl_dangnhap.AutoSize = true;
            this.lbl_dangnhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_dangnhap.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dangnhap.ForeColor = System.Drawing.Color.White;
            this.lbl_dangnhap.Location = new System.Drawing.Point(15, 17);
            this.lbl_dangnhap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_dangnhap.Name = "lbl_dangnhap";
            this.lbl_dangnhap.Size = new System.Drawing.Size(91, 32);
            this.lbl_dangnhap.TabIndex = 1;
            this.lbl_dangnhap.Text = "Log In";
            this.lbl_dangnhap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_dangnhap.Click += new System.EventHandler(this.lbl_dangnhap_Click);
            // 
            // Form_dangnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::QuanLyPhongTap.Properties.Resources.loginstyle13;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(506, 364);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.checkBox_hienmk);
            this.Controls.Add(this.txt_mk);
            this.Controls.Add(this.txt_tk);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form_dangnhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_dangnhap";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errortk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_x;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_tk;
        private System.Windows.Forms.TextBox txt_mk;
        private System.Windows.Forms.CheckBox checkBox_hienmk;
        private System.Windows.Forms.ErrorProvider errortk;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_dangnhap;
    }
}