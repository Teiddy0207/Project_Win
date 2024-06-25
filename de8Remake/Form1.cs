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
namespace de8Remake
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=TEDDY\\QUANGANH;Initial Catalog=QlyNhanSu;Integrated Security=True;");
        int id = 0;
        public Form1()
        {
            InitializeComponent();
            load();
        }

        void load()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from ns" ,conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dgvDetails.DataSource = dt;

            conn.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dgvDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(e.RowIndex.ToString()) +1;
            txtName.Text = dgvDetails.Rows[e.RowIndex].Cells[1].Value.ToString();
            cboQueQuan.Text = dgvDetails.Rows[e.RowIndex].Cells[3].Value.ToString();
            cboDonVi.Text = dgvDetails.Rows[e.RowIndex].Cells[4].Value.ToString();
            cboHocHam.Text = dgvDetails.Rows[e.RowIndex].Cells[5].Value.ToString();  
            //if (dgvDetails.Rows[e.RowIndex].Cells[2].Value.ToString() == "Nam")
            //{
            //    rbNam.Checked = true;
            //}

            //if (dgvDetails.Rows[e.RowIndex].Cells[2].Value.ToString() == "Nu")
            //{
            //    rbNu.Checked = true;
          //  }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into ns (id,ten,sex,que,donvi,hocvi) values(@id,@ten,@sex,@que,@donvi,@hocvi)", conn);
            cmd.Parameters.AddWithValue("@id", dgvDetails.RowCount.ToString());
            cmd.Parameters.AddWithValue("@ten", txtName.Text);
            if (rbNam.Checked)
            {
                cmd.Parameters.AddWithValue("@sex", rbNam.Text);
            }
            if (rbNu.Checked)
            {
                cmd.Parameters.AddWithValue("@sex", rbNu.Text);
            }
            cmd.Parameters.AddWithValue("@que", cboQueQuan.Text);
            cmd.Parameters.AddWithValue("@donvi", cboDonVi.Text);
            cmd.Parameters.AddWithValue("@hocvi", cboHocHam.Text);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dgvDetails.DataSource = dt;

            conn.Close();
            load();
        
        txtName.Clear();
            cboDonVi.Text = null;
            cboHocHam.Text = null;   
            cboDonVi.Text   =null;
            if(rbNam.Checked)
            {
                rbNam.Checked = false;
            }
            else if(rbNu.Checked)
            {
                rbNu.Checked = false;
            }
                    }

        private void cboHocHam_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("update ns set ten = @ten,sex = @sex,que = @que,donvi = @donvi , hocvi = @hocvi where id = @id", conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@ten", txtName.Text);
            if (rbNam.Checked)
            {
                cmd.Parameters.AddWithValue("@sex", "nam");
            }
            else if (rbNu.Checked)
            {
                cmd.Parameters.AddWithValue("@sex","nu");
            }
            cmd.Parameters.AddWithValue("@que", cboQueQuan.Text);
            cmd.Parameters.AddWithValue("@donvi", cboDonVi.Text);
            cmd.Parameters.AddWithValue("@hocvi", cboHocHam.Text);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

        
            cmd.ExecuteNonQuery();

            conn.Close();
            load();


            txtName.Clear();
            cboDonVi.Text = null;
            cboHocHam.Text = null;
            cboDonVi.Text = null;
            if (rbNam.Checked)
            {
                rbNam.Checked = false;
            }
            else if (rbNu.Checked)
            {
                rbNu.Checked = false;
            }
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            //Form2 table = new Form2();
            //table.ShowDialog();


            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM ns WHERE que = @que OR  donvi = @donvi OR  hocvi = @hocvi", conn);
            cmd.Parameters.AddWithValue("@que", cboQueQuan.Text);
            cmd.Parameters.AddWithValue("@donvi", cboDonVi.Text);
            cmd.Parameters.AddWithValue("@hocvi", cboHocHam.Text);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvDetails.DataSource = dt;
            conn.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            conn.Open();
            SqlCommand cmd = new SqlCommand("delete FROM ns WHERE id = @id", conn);
            cmd.Parameters.AddWithValue("@id", id);
            //SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            //DataTable dt = new DataTable();
            //adapter.Fill(dt);
            //dgvDetails.DataSource = dt;
            cmd.ExecuteNonQuery();
            conn.Close();

            load();
        }
    }
}
