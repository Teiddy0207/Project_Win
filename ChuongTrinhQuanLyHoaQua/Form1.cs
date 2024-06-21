using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace ChuongTrinhQuanLyHoaQua
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=TEDDY\\QUANGANH;Initial Catalog=Qly_HoaQua1;Integrated Security=True;");
        DataTable dt = new DataTable();
        Dictionary<string, int> ListHang = new Dictionary<string, int>()
        {
        {"tao", 20000},
            {"le", 30000 },
            {"xoai", 20000 },
            {"oi", 15000 }
};
        int tongtien = 0;
        int rowIndex;
        
      
        public Form1()
        {
         
            InitializeComponent();
       
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtDonGia.Text = ListHang[cboHoaQua.Text].ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int thanhtien = (int.Parse(txtDonGia.Text) * int.Parse(nmSoLuong.Value.ToString()));
            dgvDetail.Rows.Add(dgvDetail.RowCount, cboHoaQua.Text, txtDonGia.Text, nmSoLuong.Value.ToString(), thanhtien);
            tongtien += thanhtien;

            txtTongTienPhaiTra.Text = tongtien.ToString();


            cboHoaQua.Text = string.Empty;
            txtDonGia.Clear();
            nmSoLuong.Value = 0;
        }

        private void dgvDetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex + 1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
       
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if(!int.TryParse(txtSoTienKhachDua.Text,out int tienkhachdua ) && txtSoTienKhachDua.Text != "")
            {
                MessageBox.Show("Loi dinh dang", "Loi");

            }
            else
            {
                txtSoTienTraLai.Text = (tienkhachdua - tongtien).ToString();    
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (rowIndex < 0 || rowIndex >= dgvDetail.Rows.Count)
            {
                MessageBox.Show("Chọn hàng để xóa!", "Lỗi");
                return;
            }

            try {
                tongtien -= int.Parse(dgvDetail.Rows[rowIndex - 1].Cells[4].Value.ToString());
                txtTongTienPhaiTra.Text = tongtien.ToString();
                foreach (DataGridViewRow row in dgvDetail.Rows)
                {
                    if (row.Cells[0].Value != null && int.Parse(row.Cells[0].Value.ToString()) > rowIndex) {
                        row.Cells[0].Value = (int.Parse(row.Cells[0].Value.ToString()) - 1).ToString();
                    }
                }
                dgvDetail.Rows.RemoveAt(rowIndex - 1);
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Co loi:" + ex.Message );
                    }
            }
        
    }
}
