namespace QuanLyPhongTap.UC
{
    partial class TimKiem
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
            this.dgv_timkiem = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_tkten = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_hh = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtn_chungloai = new System.Windows.Forms.RadioButton();
            this.rbtn_gia = new System.Windows.Forms.RadioButton();
            this.btn_timkiem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_timkiem)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_timkiem
            // 
            this.dgv_timkiem.AllowUserToAddRows = false;
            this.dgv_timkiem.AllowUserToDeleteRows = false;
            this.dgv_timkiem.AllowUserToResizeRows = false;
            this.dgv_timkiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_timkiem.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.dgv_timkiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_timkiem.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_timkiem.Location = new System.Drawing.Point(0, 211);
            this.dgv_timkiem.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_timkiem.Name = "dgv_timkiem";
            this.dgv_timkiem.RowTemplate.Height = 24;
            this.dgv_timkiem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_timkiem.Size = new System.Drawing.Size(667, 205);
            this.dgv_timkiem.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tên";
            // 
            // txt_tkten
            // 
            this.txt_tkten.Location = new System.Drawing.Point(73, 55);
            this.txt_tkten.Margin = new System.Windows.Forms.Padding(2);
            this.txt_tkten.Name = "txt_tkten";
            this.txt_tkten.Size = new System.Drawing.Size(160, 20);
            this.txt_tkten.TabIndex = 4;
            this.txt_tkten.Text = "Nhập Tên Gói Tập";
            this.txt_tkten.Click += new System.EventHandler(this.txt_tkten_Click);
            this.txt_tkten.TextChanged += new System.EventHandler(this.txt_tkten_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(280, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Gói Tập";
            // 
            // cmb_hh
            // 
            this.cmb_hh.FormattingEnabled = true;
            this.cmb_hh.Location = new System.Drawing.Point(359, 54);
            this.cmb_hh.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_hh.Name = "cmb_hh";
            this.cmb_hh.Size = new System.Drawing.Size(151, 21);
            this.cmb_hh.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.rbtn_chungloai);
            this.groupBox1.Controls.Add(this.rbtn_gia);
            this.groupBox1.Location = new System.Drawing.Point(185, 97);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(186, 66);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // rbtn_chungloai
            // 
            this.rbtn_chungloai.AutoSize = true;
            this.rbtn_chungloai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_chungloai.Location = new System.Drawing.Point(13, 41);
            this.rbtn_chungloai.Margin = new System.Windows.Forms.Padding(2);
            this.rbtn_chungloai.Name = "rbtn_chungloai";
            this.rbtn_chungloai.Size = new System.Drawing.Size(96, 20);
            this.rbtn_chungloai.TabIndex = 1;
            this.rbtn_chungloai.TabStop = true;
            this.rbtn_chungloai.Text = "Loại gói tập";
            this.rbtn_chungloai.UseVisualStyleBackColor = true;
            this.rbtn_chungloai.CheckedChanged += new System.EventHandler(this.rbtn_chungloai_CheckedChanged);
            // 
            // rbtn_gia
            // 
            this.rbtn_gia.AutoSize = true;
            this.rbtn_gia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_gia.Location = new System.Drawing.Point(13, 17);
            this.rbtn_gia.Margin = new System.Windows.Forms.Padding(2);
            this.rbtn_gia.Name = "rbtn_gia";
            this.rbtn_gia.Size = new System.Drawing.Size(91, 20);
            this.rbtn_gia.TabIndex = 0;
            this.rbtn_gia.TabStop = true;
            this.rbtn_gia.Text = "Giá gói tập";
            this.rbtn_gia.UseVisualStyleBackColor = true;
            this.rbtn_gia.CheckedChanged += new System.EventHandler(this.rbtn_gia_CheckedChanged);
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_timkiem.Location = new System.Drawing.Point(541, 50);
            this.btn_timkiem.Margin = new System.Windows.Forms.Padding(2);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(94, 24);
            this.btn_timkiem.TabIndex = 8;
            this.btn_timkiem.Text = "Tìm Kiếm";
            this.btn_timkiem.UseVisualStyleBackColor = true;
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // TimKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.Controls.Add(this.btn_timkiem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmb_hh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_tkten);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_timkiem);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TimKiem";
            this.Size = new System.Drawing.Size(667, 416);
            this.Load += new System.EventHandler(this.TimKiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_timkiem)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_timkiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_tkten;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_hh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtn_chungloai;
        private System.Windows.Forms.RadioButton rbtn_gia;
        private System.Windows.Forms.Button btn_timkiem;
    }
}
