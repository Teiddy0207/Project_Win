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
namespace de8
{
    
    
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=TEDDY\\QUANGANH;Initial Catalog=De8_QLCAFE;Integrated Security=True;");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
           
            if(cbDoUong.Checked && cbDate.Checked) { 
            int sum = 0;
            conn.Open();

            SqlCommand cmd = new SqlCommand("select * FROM DATHANG WHERE DOUONG = @DOUONG AND NGAY BETWEEN @TUNGAY AND @DENNGAY", conn);
            cmd.Parameters.AddWithValue("@DOUONG" , cboDoUong.Text);
            cmd.Parameters.AddWithValue("@TuNgay", dtpFrom.Value.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@DenNGay", dtpTo.Value.ToString("yyyy-MM-dd"));
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            adapter.Fill(dt);

            dgvDetails.DataSource = dt;

            foreach (DataGridViewRow row in dgvDetails.Rows) 
            {
                if (row.Cells["SOLUONG"].Value != null && row.Cells["Gia"].Value != null)
                {
                    int soluog, gia;
                    if (int.TryParse(row.Cells["SOLUONG"].Value.ToString(), out soluog) && int.TryParse(row.Cells["GIA"].Value.ToString(),out gia))

                    {
                        sum += (soluog * gia);
                    }
                }
            }

            txtDoanhThu.Text = sum.ToString();

            conn.Close();
            }
            else if(cbDoUong.Checked)
            {

                int sum = 0;
                conn.Open();

                SqlCommand cmd = new SqlCommand("Select * from DATHANG WHERE DOUONG = @DOUONG",conn);

                cmd.Parameters.AddWithValue("@DOUONG", cboDoUong.Text);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvDetails.DataSource = dt;

                foreach(DataGridViewRow row in dgvDetails.Rows)
                {
                    if (row.Cells["SOLUONG"].Value != null && row.Cells["GIa"].Value!= null)
                    {
                        int soluong, gia;

                        if (int.TryParse(row.Cells["SOLUONG"].Value.ToString(), out soluong ) && int.TryParse(row.Cells["GIA"].Value.ToString(),out gia))
                    {
                            sum += (soluong * gia);
                        }
                                
                                }
                }

                txtDoanhThu.Text=sum.ToString();
            conn.Close ();


            }
            else if(cbDate.Checked)
            {

                int sum = 0;
                conn.Open();

                SqlCommand cmd = new SqlCommand("Select * from DATHANG where NGAY  BETWEEN @TUNGAY AND @DENNGAY",conn);
                cmd.Parameters.AddWithValue("@TuNgay", dtpFrom.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@DenNGay", dtpTo.Value.ToString("yyyy-MM-dd"));
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvDetails.DataSource = dt;


                foreach(DataGridViewRow row in dgvDetails.Rows)
                {
                    if (row.Cells["SOLUONG"].Value != null && row.Cells["GIA"].Value != null)
                    {
                        int soluong, gia;
                        if (int.TryParse(row.Cells["SOLUONG"].Value.ToString(), out soluong) && int.TryParse(row.Cells["GIA"].Value.ToString(), out gia))
                        {
                            sum += (soluong * gia);
                        }
                    }
                }
                txtDoanhThu.Text = sum.ToString();  
                conn.Close ();

            }
            else
            {
                cboDoUong.Text = "";
                dtpFrom.Value = DateTime.Now;
                dtpTo.Value = DateTime.Now;
                dgvDetails.DataSource = null;
                txtDoanhThu.Clear ();
            }
        }

        
    }
}
