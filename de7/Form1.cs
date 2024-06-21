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
namespace de7
{
    public partial class Form1 : Form
    {
    
        SqlConnection connection = new SqlConnection("Data Source=TEDDY\\QUANGANH;Initial Catalog=De7_QLCAFE;Integrated Security=True;");
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
            connection.Open();

            SqlCommand cmd = new SqlCommand("select SOBAN as [so ban], DOUONG as [do uong], SOLUONG as [so luong], GIA as [don gia] from DATHANG WHERE SOBAN = @SOBAN", connection);
            cmd.Parameters.AddWithValue("@SOBAN", cboBan.Text);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            adapter.Fill(dt);
            dgvDetails.DataSource = dt;
            foreach (DataGridViewRow row in dgvDetails.Rows)
            {
                int soluong, gia;
                if (row.Cells["so luong"].Value != null && row.Cells["don gia"].Value != null)
                {
                    if (int.TryParse(row.Cells["so luong"].Value.ToString(),out soluong) && int.TryParse(row.Cells["don gia"].Value.ToString(), out gia))
                    {
                        sum += (soluong * gia);
                    }
                }
            }


            txtThanhTien.Text = sum.ToString();
            connection.Close();
        
        }
    }
}
