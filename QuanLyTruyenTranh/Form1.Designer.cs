namespace QuanLyTruyenTranh
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
            this.dgvDetails = new System.Windows.Forms.DataGridView();
            this.btnTra = new System.Windows.Forms.Button();
            this.btnMuon = new System.Windows.Forms.Button();
            this.dtptra = new System.Windows.Forms.DateTimePicker();
            this.dtpMuon = new System.Windows.Forms.DateTimePicker();
            this.cboTenTruyen = new System.Windows.Forms.ComboBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtTebKhach = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDetails
            // 
            this.dgvDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetails.Location = new System.Drawing.Point(30, 219);
            this.dgvDetails.Name = "dgvDetails";
            this.dgvDetails.RowHeadersWidth = 51;
            this.dgvDetails.RowTemplate.Height = 24;
            this.dgvDetails.Size = new System.Drawing.Size(728, 216);
            this.dgvDetails.TabIndex = 31;
            this.dgvDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetails_CellContentClick);
            // 
            // btnTra
            // 
            this.btnTra.Location = new System.Drawing.Point(650, 179);
            this.btnTra.Name = "btnTra";
            this.btnTra.Size = new System.Drawing.Size(108, 23);
            this.btnTra.TabIndex = 30;
            this.btnTra.Text = "tra truyen";
            this.btnTra.UseVisualStyleBackColor = true;
            this.btnTra.Click += new System.EventHandler(this.btnTra_Click);
            // 
            // btnMuon
            // 
            this.btnMuon.Location = new System.Drawing.Point(650, 145);
            this.btnMuon.Name = "btnMuon";
            this.btnMuon.Size = new System.Drawing.Size(108, 23);
            this.btnMuon.TabIndex = 29;
            this.btnMuon.Text = "muon truyen";
            this.btnMuon.UseVisualStyleBackColor = true;
            this.btnMuon.Click += new System.EventHandler(this.btnMuon_Click);
            // 
            // dtptra
            // 
            this.dtptra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtptra.Location = new System.Drawing.Point(458, 174);
            this.dtptra.Name = "dtptra";
            this.dtptra.Size = new System.Drawing.Size(164, 22);
            this.dtptra.TabIndex = 28;
            this.dtptra.ValueChanged += new System.EventHandler(this.dtptra_ValueChanged);
            // 
            // dtpMuon
            // 
            this.dtpMuon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpMuon.Location = new System.Drawing.Point(458, 146);
            this.dtpMuon.Name = "dtpMuon";
            this.dtpMuon.Size = new System.Drawing.Size(164, 22);
            this.dtpMuon.TabIndex = 27;
            this.dtpMuon.ValueChanged += new System.EventHandler(this.dtpMuon_ValueChanged);
            // 
            // cboTenTruyen
            // 
            this.cboTenTruyen.FormattingEnabled = true;
            this.cboTenTruyen.Items.AddRange(new object[] {
            "doremon",
            "7 vien ngoc rong",
            "1 manh",
            "ban gai chung nha"});
            this.cboTenTruyen.Location = new System.Drawing.Point(458, 84);
            this.cboTenTruyen.Name = "cboTenTruyen";
            this.cboTenTruyen.Size = new System.Drawing.Size(300, 24);
            this.cboTenTruyen.TabIndex = 26;
            this.cboTenTruyen.SelectedIndexChanged += new System.EventHandler(this.cboTenTruyen_SelectedIndexChanged);
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(458, 114);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(300, 22);
            this.txtGia.TabIndex = 25;
            this.txtGia.TextChanged += new System.EventHandler(this.txtGia_TextChanged);
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(471, 50);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(300, 22);
            this.txtSDT.TabIndex = 24;
            this.txtSDT.TextChanged += new System.EventHandler(this.txtSDT_TextChanged);
            // 
            // txtTebKhach
            // 
            this.txtTebKhach.Location = new System.Drawing.Point(458, 19);
            this.txtTebKhach.Name = "txtTebKhach";
            this.txtTebKhach.Size = new System.Drawing.Size(300, 22);
            this.txtTebKhach.TabIndex = 23;
            this.txtTebKhach.TextChanged += new System.EventHandler(this.txtTebKhach_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(348, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 16);
            this.label6.TabIndex = 22;
            this.label6.Text = "ngay tra";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(348, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "ngay muon";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(348, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Don gia/ngay";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(348, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Ten Truyen";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(348, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "SDT";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(348, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Ten khach";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(30, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(285, 179);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvDetails);
            this.Controls.Add(this.btnTra);
            this.Controls.Add(this.btnMuon);
            this.Controls.Add(this.dtptra);
            this.Controls.Add(this.dtpMuon);
            this.Controls.Add(this.cboTenTruyen);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtTebKhach);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDetails;
        private System.Windows.Forms.Button btnTra;
        private System.Windows.Forms.Button btnMuon;
        private System.Windows.Forms.DateTimePicker dtptra;
        private System.Windows.Forms.DateTimePicker dtpMuon;
        private System.Windows.Forms.ComboBox cboTenTruyen;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtTebKhach;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

