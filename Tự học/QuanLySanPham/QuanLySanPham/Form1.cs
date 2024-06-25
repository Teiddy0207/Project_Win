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

namespace QuanLySanPham
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Tung_TLU\\TLU_Hoc\\2023_2024(Nam 2)\\Ki_2\\Lap Trinh Windows (C#)\\Tự học\\QuanLySanPham\\QuanLySanPham.mdf\";Integrated Security=True;Connect Timeout=30;");
        SqlCommand cmd;

        public Form1()
        {
            InitializeComponent();

            load();
        }

        void load()
        {
            conn.Open();

            cmd = new SqlCommand("SELECT * FROM SanPham", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView_KetQua.DataSource = dt;

            conn.Close();
        }

        private void button_Huy_Click(object sender, EventArgs e)
        {
            textBox_MaSP.Clear();
            textBox_TenSP.Clear();
            dateTimePicker_NgaySX.Value = DateTime.Now;
            dateTimePicker_NgayHH.Value = DateTime.Now;
            textBox_DonVi.Clear();
            textBox_DonGia.Clear();
            richTextBox_GhiChu.Clear();
        }

        private void dataGridView_KetQua_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            button_Sua.Enabled = true;
            button_Xoa.Enabled = true;

            textBox_MaSP.Text = dataGridView_KetQua.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox_TenSP.Text = dataGridView_KetQua.Rows[e.RowIndex].Cells[1].Value.ToString();
            dateTimePicker_NgaySX.Text = dataGridView_KetQua.Rows[e.RowIndex].Cells[2].Value.ToString();
            dateTimePicker_NgayHH.Text = dataGridView_KetQua.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBox_DonVi.Text = dataGridView_KetQua.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBox_DonGia.Text = dataGridView_KetQua.Rows[e.RowIndex].Cells[5].Value.ToString();
            richTextBox_GhiChu.Text = dataGridView_KetQua.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void button_Them_Click(object sender, EventArgs e)
        {
            conn.Open();

            cmd = new SqlCommand("INSERT INTO SanPham VALUES (@MaSP, @TenSP, @NgaySX, @NgayHH, @DonVi, @DonGia, @GhiChu)", conn);
            cmd.Parameters.AddWithValue("@MaSP", textBox_MaSP.Text);
            cmd.Parameters.AddWithValue("@TenSP", textBox_TenSP.Text);
            cmd.Parameters.AddWithValue("@NgaySX", dateTimePicker_NgaySX.Value.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@NgayHH", dateTimePicker_NgayHH.Value.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@DonVi", textBox_DonVi.Text);
            cmd.Parameters.AddWithValue("@DonGia", textBox_DonGia.Text);
            cmd.Parameters.AddWithValue("@GhiChu", richTextBox_GhiChu.Text);
            cmd.ExecuteNonQuery();

            conn.Close();
            load();

            textBox_MaSP.Clear();
            textBox_TenSP.Clear();
            dateTimePicker_NgaySX.Value = DateTime.Now;
            dateTimePicker_NgayHH.Value = DateTime.Now;
            textBox_DonVi.Clear();
            textBox_DonGia.Clear();
            richTextBox_GhiChu.Clear();
        }

        private void button_Xoa_Click(object sender, EventArgs e)
        {
            conn.Open();

            cmd = new SqlCommand("DELETE FROM SanPham WHERE MaSP = @MaSP", conn);
            cmd.Parameters.AddWithValue("@MaSP", textBox_MaSP.Text);
            cmd.ExecuteNonQuery();

            conn.Close();
            load();
        }
    }
}
