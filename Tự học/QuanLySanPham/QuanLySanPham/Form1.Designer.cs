namespace QuanLySanPham
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_TKTenSP = new System.Windows.Forms.TextBox();
            this.textBox_TKMaSP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView_KetQua = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button_Huy = new System.Windows.Forms.Button();
            this.richTextBox_GhiChu = new System.Windows.Forms.RichTextBox();
            this.textBox_DonGia = new System.Windows.Forms.TextBox();
            this.textBox_DonVi = new System.Windows.Forms.TextBox();
            this.dateTimePicker_NgayHH = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_NgaySX = new System.Windows.Forms.DateTimePicker();
            this.textBox_TenSP = new System.Windows.Forms.TextBox();
            this.textBox_MaSP = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_TimKiem = new System.Windows.Forms.Button();
            this.button_Thoat = new System.Windows.Forms.Button();
            this.button_Xoa = new System.Windows.Forms.Button();
            this.button_Sua = new System.Windows.Forms.Button();
            this.button_Them = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_KetQua)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(414, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ SẢN PHẨM";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.textBox_TKTenSP);
            this.groupBox1.Controls.Add(this.textBox_TKMaSP);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(13, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(755, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // textBox_TKTenSP
            // 
            this.textBox_TKTenSP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_TKTenSP.Location = new System.Drawing.Point(412, 41);
            this.textBox_TKTenSP.Name = "textBox_TKTenSP";
            this.textBox_TKTenSP.Size = new System.Drawing.Size(134, 20);
            this.textBox_TKTenSP.TabIndex = 1;
            // 
            // textBox_TKMaSP
            // 
            this.textBox_TKMaSP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_TKMaSP.Location = new System.Drawing.Point(75, 40);
            this.textBox_TKMaSP.Name = "textBox_TKMaSP";
            this.textBox_TKMaSP.Size = new System.Drawing.Size(134, 20);
            this.textBox_TKMaSP.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(360, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên SP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã SP:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView_KetQua);
            this.groupBox2.Location = new System.Drawing.Point(13, 148);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(755, 502);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kết quả";
            // 
            // dataGridView_KetQua
            // 
            this.dataGridView_KetQua.AllowUserToAddRows = false;
            this.dataGridView_KetQua.AllowUserToDeleteRows = false;
            this.dataGridView_KetQua.AllowUserToResizeColumns = false;
            this.dataGridView_KetQua.AllowUserToResizeRows = false;
            this.dataGridView_KetQua.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_KetQua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_KetQua.Location = new System.Drawing.Point(6, 19);
            this.dataGridView_KetQua.Name = "dataGridView_KetQua";
            this.dataGridView_KetQua.ReadOnly = true;
            this.dataGridView_KetQua.Size = new System.Drawing.Size(743, 477);
            this.dataGridView_KetQua.TabIndex = 0;
            this.dataGridView_KetQua.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_KetQua_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.button_Huy);
            this.groupBox3.Controls.Add(this.richTextBox_GhiChu);
            this.groupBox3.Controls.Add(this.textBox_DonGia);
            this.groupBox3.Controls.Add(this.textBox_DonVi);
            this.groupBox3.Controls.Add(this.dateTimePicker_NgayHH);
            this.groupBox3.Controls.Add(this.dateTimePicker_NgaySX);
            this.groupBox3.Controls.Add(this.textBox_TenSP);
            this.groupBox3.Controls.Add(this.textBox_MaSP);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(774, 41);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(263, 609);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chi tiết";
            // 
            // button_Huy
            // 
            this.button_Huy.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_Huy.Location = new System.Drawing.Point(94, 447);
            this.button_Huy.Name = "button_Huy";
            this.button_Huy.Size = new System.Drawing.Size(75, 23);
            this.button_Huy.TabIndex = 9;
            this.button_Huy.Text = "Hủy";
            this.button_Huy.UseVisualStyleBackColor = false;
            this.button_Huy.Click += new System.EventHandler(this.button_Huy_Click);
            // 
            // richTextBox_GhiChu
            // 
            this.richTextBox_GhiChu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox_GhiChu.Location = new System.Drawing.Point(78, 319);
            this.richTextBox_GhiChu.Name = "richTextBox_GhiChu";
            this.richTextBox_GhiChu.Size = new System.Drawing.Size(179, 92);
            this.richTextBox_GhiChu.TabIndex = 8;
            this.richTextBox_GhiChu.Text = "";
            // 
            // textBox_DonGia
            // 
            this.textBox_DonGia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_DonGia.Location = new System.Drawing.Point(78, 267);
            this.textBox_DonGia.Name = "textBox_DonGia";
            this.textBox_DonGia.Size = new System.Drawing.Size(179, 20);
            this.textBox_DonGia.TabIndex = 7;
            // 
            // textBox_DonVi
            // 
            this.textBox_DonVi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_DonVi.Location = new System.Drawing.Point(78, 217);
            this.textBox_DonVi.Name = "textBox_DonVi";
            this.textBox_DonVi.Size = new System.Drawing.Size(179, 20);
            this.textBox_DonVi.TabIndex = 6;
            // 
            // dateTimePicker_NgayHH
            // 
            this.dateTimePicker_NgayHH.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker_NgayHH.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_NgayHH.Location = new System.Drawing.Point(78, 163);
            this.dateTimePicker_NgayHH.Name = "dateTimePicker_NgayHH";
            this.dateTimePicker_NgayHH.Size = new System.Drawing.Size(179, 20);
            this.dateTimePicker_NgayHH.TabIndex = 5;
            // 
            // dateTimePicker_NgaySX
            // 
            this.dateTimePicker_NgaySX.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker_NgaySX.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_NgaySX.Location = new System.Drawing.Point(78, 113);
            this.dateTimePicker_NgaySX.Name = "dateTimePicker_NgaySX";
            this.dateTimePicker_NgaySX.Size = new System.Drawing.Size(179, 20);
            this.dateTimePicker_NgaySX.TabIndex = 4;
            // 
            // textBox_TenSP
            // 
            this.textBox_TenSP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_TenSP.Location = new System.Drawing.Point(78, 63);
            this.textBox_TenSP.Name = "textBox_TenSP";
            this.textBox_TenSP.Size = new System.Drawing.Size(179, 20);
            this.textBox_TenSP.TabIndex = 3;
            // 
            // textBox_MaSP
            // 
            this.textBox_MaSP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_MaSP.Location = new System.Drawing.Point(78, 13);
            this.textBox_MaSP.Name = "textBox_MaSP";
            this.textBox_MaSP.Size = new System.Drawing.Size(179, 20);
            this.textBox_MaSP.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 322);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Ghi chú";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 271);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Đơn giá";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 220);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Đơn vị";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Ngày HH";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Ngày SX";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tên SP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mã SP";
            // 
            // button_TimKiem
            // 
            this.button_TimKiem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_TimKiem.Location = new System.Drawing.Point(88, 670);
            this.button_TimKiem.Name = "button_TimKiem";
            this.button_TimKiem.Size = new System.Drawing.Size(75, 23);
            this.button_TimKiem.TabIndex = 10;
            this.button_TimKiem.Text = "Tìm kiếm";
            this.button_TimKiem.UseVisualStyleBackColor = false;
            // 
            // button_Thoat
            // 
            this.button_Thoat.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_Thoat.Location = new System.Drawing.Point(508, 670);
            this.button_Thoat.Name = "button_Thoat";
            this.button_Thoat.Size = new System.Drawing.Size(75, 23);
            this.button_Thoat.TabIndex = 14;
            this.button_Thoat.Text = "Thoát";
            this.button_Thoat.UseVisualStyleBackColor = false;
            // 
            // button_Xoa
            // 
            this.button_Xoa.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_Xoa.Enabled = false;
            this.button_Xoa.Location = new System.Drawing.Point(403, 670);
            this.button_Xoa.Name = "button_Xoa";
            this.button_Xoa.Size = new System.Drawing.Size(75, 23);
            this.button_Xoa.TabIndex = 13;
            this.button_Xoa.Text = "Xóa";
            this.button_Xoa.UseVisualStyleBackColor = false;
            this.button_Xoa.Click += new System.EventHandler(this.button_Xoa_Click);
            // 
            // button_Sua
            // 
            this.button_Sua.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_Sua.Enabled = false;
            this.button_Sua.Location = new System.Drawing.Point(298, 670);
            this.button_Sua.Name = "button_Sua";
            this.button_Sua.Size = new System.Drawing.Size(75, 23);
            this.button_Sua.TabIndex = 12;
            this.button_Sua.Text = "Sửa";
            this.button_Sua.UseVisualStyleBackColor = false;
            // 
            // button_Them
            // 
            this.button_Them.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_Them.Location = new System.Drawing.Point(193, 670);
            this.button_Them.Name = "button_Them";
            this.button_Them.Size = new System.Drawing.Size(75, 23);
            this.button_Them.TabIndex = 11;
            this.button_Them.Text = "Thêm";
            this.button_Them.UseVisualStyleBackColor = false;
            this.button_Them.Click += new System.EventHandler(this.button_Them_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 705);
            this.Controls.Add(this.button_Them);
            this.Controls.Add(this.button_Sua);
            this.Controls.Add(this.button_Xoa);
            this.Controls.Add(this.button_Thoat);
            this.Controls.Add(this.button_TimKiem);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý sản phẩm (Chu Xuân Tùng - 2251172551)";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_KetQua)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_TKTenSP;
        private System.Windows.Forms.TextBox textBox_TKMaSP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView_KetQua;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_Huy;
        private System.Windows.Forms.RichTextBox richTextBox_GhiChu;
        private System.Windows.Forms.TextBox textBox_DonGia;
        private System.Windows.Forms.TextBox textBox_DonVi;
        private System.Windows.Forms.DateTimePicker dateTimePicker_NgayHH;
        private System.Windows.Forms.DateTimePicker dateTimePicker_NgaySX;
        private System.Windows.Forms.TextBox textBox_TenSP;
        private System.Windows.Forms.TextBox textBox_MaSP;
        private System.Windows.Forms.Button button_TimKiem;
        private System.Windows.Forms.Button button_Thoat;
        private System.Windows.Forms.Button button_Xoa;
        private System.Windows.Forms.Button button_Sua;
        private System.Windows.Forms.Button button_Them;
    }
}

