using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace De2Moi
{
    public partial class Form1 : Form
    {
       DataTable dt = new DataTable();
        public Form1()
        {
            InitializeComponent();
            ContextMenuStrip contextMenuStrip1 = new ContextMenuStrip();
            ToolStripMenuItem doiMauToolStripMenuItem = new ToolStripMenuItem("Đổi màu");
            doiMauToolStripMenuItem.Click += new EventHandler(doiMauToolStripMenuItem_Click);
            contextMenuStrip1.Items.Add(doiMauToolStripMenuItem);
        

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("STT");
            dt.Columns.Add("Ten Hang");
            dt.Columns.Add("So Luong");
            dt.Columns.Add("Don Gia");
            dt.Columns.Add("Thanh Tien");

            dgvDetails.DataSource = dt; 
        }
        int STT = 1;
        private void btnThem_Click(object sender, EventArgs e)
        {
            int thanTien = int.Parse(nmrSoLuong.Value.ToString()) * int.Parse(txtDonGia.Text);
            dt.Rows.Add(STT, cboTenHang.Text, nmrSoLuong.Value, txtDonGia.Text, thanTien);
            STT++;
        }

        private void cboTenHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboTenHang.SelectedIndex == 0)
            {
                txtDonGia.Text = "10";
            } else if (cboTenHang.SelectedIndex == 1)
            {
                txtDonGia.Text = "20";
            }
            else if (cboTenHang.SelectedIndex == 2)
            {
                txtDonGia.Text = "15";
            }
        }

        private void btnTaoDon_Click(object sender, EventArgs e)
        {
          dt.Clear();
            STT = 1;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
         if(dgvDetails.Rows.Count > 0)
            {
                foreach(DataGridViewRow row in dgvDetails.SelectedRows)
                {
                    if (!row.IsNewRow)
                    {
                        dgvDetails.Rows.Remove(row);
                    }
                }
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            int TongTien = 0;
            foreach (DataRow row in dt.Rows)
            {
                TongTien += Convert.ToInt32(row["Thanh Tien"]);
            }
            txtTongTien.Text = TongTien.ToString(); 
    }

        private void changeColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void doiMauToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
