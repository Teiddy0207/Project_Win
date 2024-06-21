using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace de2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataTable dt = new DataTable();
        private void Form1_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("STT");
            dt.Columns.Add("Tên hàng");
            dt.Columns.Add("Số lượng");
            dt.Columns.Add("Đơn giá");
            dt.Columns.Add("Thành tiền");

            dgvDetails.DataSource = dt;
        }
        int stt = 1;
        private void bt_them_Click(object sender, EventArgs e)
        {
            int thanhTien = int.Parse(nmSoLuong.Value.ToString()) * int.Parse(txtDonGia.Text);
            dt.Rows.Add(stt,cb_tenhang.Text, nmSoLuong.Value, txtDonGia.Text,thanhTien);
            stt++;


        }

        private void cb_tenhang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cb_tenhang.SelectedIndex == 0)
            {
                txtDonGia.Text = "10";
            }
            else if (cb_tenhang.SelectedIndex == 1)
            {
                txtDonGia.Text = "12";
            }
            else if (cb_tenhang.SelectedIndex == 2)
            {
                txtDonGia.Text = "15";
            }
        }

        private void tb_tenkhach_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_taodon_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
