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


namespace QlyBanMayTinh
{
    public partial class Form1 : Form
    {
SqlConnection conn = new SqlConnection("Data Source=TEDDY\\QUANGANH;Initial Catalog=Qly_BanMayTinh;Integrated Security=True;");


        void load()
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand("Select * from pc",conn);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);

            dgvDetails.DataSource = table;

            conn.Close();
        }
        public Form1()
        {
            InitializeComponent();
            load();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtDonGia_TextChanged(object sender, EventArgs e)
        {
            if(!int.TryParse(txtDonGia.Text, out _) && txtDonGia.Text != "") {
                MessageBox.Show("Sai dinh dang");
              
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int tong = 0;
            conn.Open();

            SqlCommand cmd = new SqlCommand("insert into pc (MaHD, TenKH, NgayBan,LoaiMay,TenMay,DonGia,SoLuong,ToTal) values(@MaHD, @TenKH, @NgayBan,@LoaiMay,@TenMay,@DonGia,@SoLuong,@ToTal)",conn);
            cmd.Parameters.AddWithValue("@MaHD", txtMaHD.Text);
            cmd.Parameters.AddWithValue("@TenKH", txtTenKhach.Text);
            cmd.Parameters.AddWithValue("@NgayBan", dtpNgayBan.Value.ToString("yyyy-MM-dd"));
            if (rbDeBan.Checked)
            {
                cmd.Parameters.AddWithValue("@LoaiMay", rbDeBan.Text);
            }else if(rbXachTay.Checked){
                cmd.Parameters.AddWithValue("@LoaiMay", rbXachTay.Text);
            }

            cmd.Parameters.AddWithValue("@TenMay", txtTenMay.Text);
            cmd.Parameters.AddWithValue("@DonGia", txtDonGia.Text);
            cmd.Parameters.AddWithValue("@SoLuong", nmSoLuong.Value.ToString());
            tong = int.Parse(txtDonGia.Text) * int.Parse(nmSoLuong.Text);         
            cmd.Parameters.AddWithValue("@ToTal", tong.ToString());
            cmd.ExecuteNonQuery();
            conn.Close();
            load();


            txtMaHD.Text = "";
            txtTenKhach.Text = "";
            dtpNgayBan.Value = DateTime.Now;
            nmSoLuong.Value = 1;
            txtDonGia.Text = "";

        }

        private void dgvDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaHD.Text = dgvDetails.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtTenKhach.Text = dgvDetails.Rows[e.RowIndex].Cells[1].Value.ToString();
            dtpNgayBan.Text = dgvDetails.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtTenMay.Text = dgvDetails.Rows[e.RowIndex].Cells[4].Value.ToString();
              txtDonGia.Text = dgvDetails.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
           
            conn.Open();
            SqlCommand cmd = new SqlCommand("Delete from pc where MaHD = @MaHD", conn);
            cmd.Parameters.AddWithValue("@MaHD", txtMaHD.Text);

            cmd.ExecuteNonQuery();
            conn.Close();
            load();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int tong = 0;
            conn.Open();

            SqlCommand cmd = new SqlCommand("update pc set MaHD = @MaHD, TenKH = @TenKH, NgayBan = @NgayBan,LoaiMay = @LoaiMay,TenMay =@TenMay,DonGia = @DonGia,SoLuong = @SoLuong,ToTal = @ToTal where MaHD = @MaHD", conn);
            cmd.Parameters.AddWithValue("@MaHD", txtMaHD.Text);
            cmd.Parameters.AddWithValue("@TenKH", txtTenKhach.Text);
            cmd.Parameters.AddWithValue("@NgayBan", dtpNgayBan.Value.ToString("yyyy-MM-dd"));
            if (rbDeBan.Checked)
            {
                cmd.Parameters.AddWithValue("@LoaiMay", rbDeBan.Text);
            }
            else if (rbXachTay.Checked)
            {
                cmd.Parameters.AddWithValue("@LoaiMay", rbXachTay.Text);
            }

            cmd.Parameters.AddWithValue("@TenMay", txtTenMay.Text);
            cmd.Parameters.AddWithValue("@DonGia", txtDonGia.Text);
            cmd.Parameters.AddWithValue("@SoLuong", nmSoLuong.Value.ToString());
            tong = int.Parse(txtDonGia.Text) * int.Parse(nmSoLuong.Text);
            cmd.Parameters.AddWithValue("@ToTal", tong.ToString());
            cmd.ExecuteNonQuery();
            conn.Close();
            load();
        }
    }
}
