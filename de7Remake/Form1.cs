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
namespace de7Remake
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=TEDDY\\QUANGANH;Initial Catalog=De7_QLCAFE;Integrated Security=True;");
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cboBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            int sum = 0;
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select SOBAN as [so ban], DOUONG as [Do uong], SOLUONG as [SO LUONG], GIA as [GIA] from DATHANG where SOBAN = @SOBAN",conn);
            cmd.Parameters.AddWithValue("@SOBAN", cboBan.Text);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);


            dgvDetails.DataSource = dt; 
            conn.Close();

            foreach (DataGridViewRow row in dgvDetails.Rows)
            {
                if (row.Cells[2].Value != null && row.Cells[3].Value != null)
                {
                    sum += (int.Parse(row.Cells[2].Value.ToString()) * int.Parse(row.Cells[3].Value.ToString()));
                }
            }
            txtThanhTien.Text = sum.ToString();
        }
    }
}
