using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace QuanLyTruyenTranh
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=TEDDY\\QUANGANH;Initial Catalog=Qly_truyen;Integrated Security=True;");

        Dictionary<string, int> listManga = new Dictionary<string, int>()
        {

            {"doremon", 18000 },
            {"7 vien ngoc rong", 20000 },
            {"1 manh", 30000 },
            {"ban gai chung nha", 50000 }
        };
        
        public Form1()
        {
            InitializeComponent();
            
        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {
            if(!int.TryParse(txtSDT.Text, out _))
            {
                MessageBox.Show("Sai dinh dang so");
            }
        }

        private void btnTra_Click(object sender, EventArgs e)
        {

        }

        private void btnMuon_Click(object sender, EventArgs e)
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand("insert into truyen (STT , TEN, SDT, TENTRUYEN, NGAYMUON, NOTE ) VALUES (@STT ,@TEN, @SDT, @TENTRUYEN, @NGAYMUON, @NOTE)", conn);

        }

        private void dtptra_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtpMuon_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cboTenTruyen_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtGia.Text = listManga[cboTenTruyen.Text].ToString();
        }

        private void txtGia_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtTebKhach_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
