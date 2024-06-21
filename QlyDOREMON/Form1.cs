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
namespace QlyDOREMON
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
      void load()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from truyen",conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dgvDetails.DataSource = dt;


            conn.Close();
        }
        public Form1()
        {
            InitializeComponent();
            load();
        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(txtSDT.Text, out _) && txtSDT.Text != "")
            {
                MessageBox.Show("Sai dinh dang");
            }
        }

        private void cboTenTruyen_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtGia.Text = listManga[cboTenTruyen.Text].ToString();
        }

        private void btnMuon_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO truyen (STT , TEN, SDT, TENTRUYEN, NGAYMUON, NOTE) VALUES (@STT ,@TEN, @SDT, @TENTRUYEN, @NGAYMUON, @NOTE)", conn);
            int stt = dgvDetails.RowCount + 1; // STT mới sẽ là số hàng + 1
            cmd.Parameters.AddWithValue("@STT", dgvDetails.RowCount.ToString());
            cmd.Parameters.AddWithValue("@TEN", txtTebKhach.Text);
            cmd.Parameters.AddWithValue( "@SDT", txtSDT.Text);
            cmd.Parameters.AddWithValue("@TENTRUYEN", cboTenTruyen.Text);
            cmd.Parameters.AddWithValue("@NGAYMUON", dtpMuon.Value.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@NOTE", "chua tra");

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dgvDetails.DataSource = dt;


            conn.Close();
            load();
        }

        private void dgvDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvDetails.Rows.Count)
            {
                txtTebKhach.Text = dgvDetails.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtSDT.Text = dgvDetails.Rows[e.RowIndex].Cells[2].Value.ToString();
                cboTenTruyen.Text = dgvDetails.Rows[e.RowIndex].Cells[3].Value.ToString();
                dtpMuon.Text = dgvDetails.Rows[e.RowIndex].Cells[4].Value.ToString();
                dtptra.Text = dgvDetails.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
            }

        private void btnTra_Click(object sender, EventArgs e)
        {
            TimeSpan songaymuon = dtptra.Value.Date - dtpMuon.Value.Date;

            int soNgay = songaymuon.Days;

            int dongia = int.Parse(txtGia.Text);

            int thanhtien = soNgay * dongia;

            conn.Open();
            SqlCommand cmd = new SqlCommand("update truyen set NGAYTRA = @NGAYTRA, TOTAL = @TOTAL , NOTE = @NOTE where STT = @STT" , conn);

            if (dgvDetails.SelectedRows.Count > 0)
            {
                int stt = int.Parse(dgvDetails.SelectedRows[0].Cells["STT"].Value.ToString());
            cmd.Parameters.AddWithValue("@STT", stt);
            cmd.Parameters.AddWithValue("@NGAYTRA", dtptra.Value.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@TOTAL", thanhtien);
            cmd.Parameters.AddWithValue("@NOTE",' ');

            cmd.ExecuteNonQuery();

            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng để thực hiện hành động 'Trả'.");
            }
            conn.Close();
            load();
        }
    }
}
