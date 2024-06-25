namespace QlySanPham
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
            this.components = new System.ComponentModel.Container();
            this.button_ThanhToan = new System.Windows.Forms.Button();
            this.textBox_TongTien = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView_DonHang = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_TenKhach = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown_SoLuong = new System.Windows.Forms.NumericUpDown();
            this.button_Xoa = new System.Windows.Forms.Button();
            this.button_Them = new System.Windows.Forms.Button();
            this.button_TaoDon = new System.Windows.Forms.Button();
            this.label_LoaiHang = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView_LoaiHang = new System.Windows.Forms.DataGridView();
            this.comboBox_TheLoai = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.đổiMàuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DonHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_LoaiHang)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_ThanhToan
            // 
            this.button_ThanhToan.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_ThanhToan.Location = new System.Drawing.Point(1094, 551);
            this.button_ThanhToan.Margin = new System.Windows.Forms.Padding(4);
            this.button_ThanhToan.Name = "button_ThanhToan";
            this.button_ThanhToan.Size = new System.Drawing.Size(100, 28);
            this.button_ThanhToan.TabIndex = 31;
            this.button_ThanhToan.Text = "Thanh toán";
            this.button_ThanhToan.UseVisualStyleBackColor = false;
            this.button_ThanhToan.Click += new System.EventHandler(this.button_ThanhToan_Click);
            // 
            // textBox_TongTien
            // 
            this.textBox_TongTien.Enabled = false;
            this.textBox_TongTien.Location = new System.Drawing.Point(755, 503);
            this.textBox_TongTien.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_TongTien.Name = "textBox_TongTien";
            this.textBox_TongTien.Size = new System.Drawing.Size(437, 22);
            this.textBox_TongTien.TabIndex = 30;
            this.textBox_TongTien.TextChanged += new System.EventHandler(this.textBox_TongTien_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(676, 506);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 16);
            this.label6.TabIndex = 29;
            this.label6.Text = "Tổng tiền";
            // 
            // dataGridView_DonHang
            // 
            this.dataGridView_DonHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_DonHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_DonHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView_DonHang.Location = new System.Drawing.Point(676, 140);
            this.dataGridView_DonHang.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_DonHang.Name = "dataGridView_DonHang";
            this.dataGridView_DonHang.ReadOnly = true;
            this.dataGridView_DonHang.RowHeadersWidth = 51;
            this.dataGridView_DonHang.Size = new System.Drawing.Size(865, 356);
            this.dataGridView_DonHang.TabIndex = 28;
            this.dataGridView_DonHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_DonHang_CellClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "STT";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 63;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên hàng";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Số lượng";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Đơn giá";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Thành tiền";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(672, 98);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 16);
            this.label5.TabIndex = 27;
            this.label5.Text = "Chi tiết đơn hàng";
            // 
            // textBox_TenKhach
            // 
            this.textBox_TenKhach.Location = new System.Drawing.Point(755, 52);
            this.textBox_TenKhach.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_TenKhach.Name = "textBox_TenKhach";
            this.textBox_TenKhach.Size = new System.Drawing.Size(437, 22);
            this.textBox_TenKhach.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(672, 56);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 25;
            this.label4.Text = "Tên khách";
            // 
            // numericUpDown_SoLuong
            // 
            this.numericUpDown_SoLuong.Location = new System.Drawing.Point(514, 175);
            this.numericUpDown_SoLuong.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown_SoLuong.Name = "numericUpDown_SoLuong";
            this.numericUpDown_SoLuong.Size = new System.Drawing.Size(69, 22);
            this.numericUpDown_SoLuong.TabIndex = 24;
            this.numericUpDown_SoLuong.ValueChanged += new System.EventHandler(this.numericUpDown_SoLuong_ValueChanged);
            // 
            // button_Xoa
            // 
            this.button_Xoa.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_Xoa.Location = new System.Drawing.Point(511, 210);
            this.button_Xoa.Margin = new System.Windows.Forms.Padding(4);
            this.button_Xoa.Name = "button_Xoa";
            this.button_Xoa.Size = new System.Drawing.Size(119, 36);
            this.button_Xoa.TabIndex = 23;
            this.button_Xoa.Text = "<<";
            this.button_Xoa.UseVisualStyleBackColor = false;
            this.button_Xoa.Click += new System.EventHandler(this.button_Xoa_Click);
            // 
            // button_Them
            // 
            this.button_Them.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_Them.Location = new System.Drawing.Point(591, 172);
            this.button_Them.Margin = new System.Windows.Forms.Padding(4);
            this.button_Them.Name = "button_Them";
            this.button_Them.Size = new System.Drawing.Size(39, 31);
            this.button_Them.TabIndex = 22;
            this.button_Them.Text = ">>";
            this.button_Them.UseVisualStyleBackColor = false;
            this.button_Them.Click += new System.EventHandler(this.button_Them_Click);
            // 
            // button_TaoDon
            // 
            this.button_TaoDon.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_TaoDon.Location = new System.Drawing.Point(514, 49);
            this.button_TaoDon.Margin = new System.Windows.Forms.Padding(4);
            this.button_TaoDon.Name = "button_TaoDon";
            this.button_TaoDon.Size = new System.Drawing.Size(116, 50);
            this.button_TaoDon.TabIndex = 21;
            this.button_TaoDon.Text = "Tạo đơn";
            this.button_TaoDon.UseVisualStyleBackColor = false;
            this.button_TaoDon.Click += new System.EventHandler(this.button_TaoDon_Click);
            // 
            // label_LoaiHang
            // 
            this.label_LoaiHang.AutoSize = true;
            this.label_LoaiHang.Location = new System.Drawing.Point(216, 98);
            this.label_LoaiHang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_LoaiHang.Name = "label_LoaiHang";
            this.label_LoaiHang.Size = new System.Drawing.Size(16, 16);
            this.label_LoaiHang.TabIndex = 20;
            this.label_LoaiHang.Text = "...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Các hàng thuộc loại:";
            // 
            // dataGridView_LoaiHang
            // 
            this.dataGridView_LoaiHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_LoaiHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_LoaiHang.Location = new System.Drawing.Point(64, 127);
            this.dataGridView_LoaiHang.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_LoaiHang.Name = "dataGridView_LoaiHang";
            this.dataGridView_LoaiHang.ReadOnly = true;
            this.dataGridView_LoaiHang.RowHeadersWidth = 51;
            this.dataGridView_LoaiHang.Size = new System.Drawing.Size(376, 439);
            this.dataGridView_LoaiHang.TabIndex = 18;
            this.dataGridView_LoaiHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_LoaiHang_CellClick);
            this.dataGridView_LoaiHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_LoaiHang_CellContentClick);
            // 
            // comboBox_TheLoai
            // 
            this.comboBox_TheLoai.FormattingEnabled = true;
            this.comboBox_TheLoai.Items.AddRange(new object[] {
            "banh keo",
            "hoa qua ",
            "sach"});
            this.comboBox_TheLoai.Location = new System.Drawing.Point(144, 52);
            this.comboBox_TheLoai.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_TheLoai.Name = "comboBox_TheLoai";
            this.comboBox_TheLoai.Size = new System.Drawing.Size(315, 24);
            this.comboBox_TheLoai.TabIndex = 17;
            this.comboBox_TheLoai.SelectedIndexChanged += new System.EventHandler(this.comboBox_TheLoai_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Thể loại";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đổiMàuToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(211, 56);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            this.contextMenuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStrip1_ItemClicked);
            // 
            // đổiMàuToolStripMenuItem
            // 
            this.đổiMàuToolStripMenuItem.Name = "đổiMàuToolStripMenuItem";
            this.đổiMàuToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.đổiMàuToolStripMenuItem.Text = "Đổi màu";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1569, 613);
            this.Controls.Add(this.button_ThanhToan);
            this.Controls.Add(this.textBox_TongTien);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView_DonHang);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_TenKhach);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDown_SoLuong);
            this.Controls.Add(this.button_Xoa);
            this.Controls.Add(this.button_Them);
            this.Controls.Add(this.button_TaoDon);
            this.Controls.Add(this.label_LoaiHang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView_LoaiHang);
            this.Controls.Add(this.comboBox_TheLoai);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DonHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_LoaiHang)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_ThanhToan;
        private System.Windows.Forms.TextBox textBox_TongTien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView_DonHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_TenKhach;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown_SoLuong;
        private System.Windows.Forms.Button button_Xoa;
        private System.Windows.Forms.Button button_Them;
        private System.Windows.Forms.Button button_TaoDon;
        private System.Windows.Forms.Label label_LoaiHang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView_LoaiHang;
        private System.Windows.Forms.ComboBox comboBox_TheLoai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem đổiMàuToolStripMenuItem;
    }
}

