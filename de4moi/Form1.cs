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
namespace de4moi
{
    public partial class Form1 : Form
    {

        SqlConnection conn = new SqlConnection("Data Source=TEDDY\\QUANGANH;Initial Catalog=QLy_Diem;Integrated Security=True;");
        Dictionary<string, string> listHsinh = new Dictionary<string, string>()
        {
            {"1", "quang" },
            {"2", "hung" }

        };
        void load()
        {
            SqlCommand cmd = new SqlCommand("select ID as [Ma SV], name as [Ho va ten], toan as [diem toan], van as [diem van], anh as [diem van], diemTB as [diem TB] from diem",conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;

            conn.Close();
        
        }
        public Form1()
        {
            InitializeComponent();
           load();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox_MaSV_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox_HoTenSV.Text = listHsinh[comboBox_MaSV.Text];
            textBox_HoTenSV.Enabled = false;
        }

        private void textBox_DiemToan_TextChanged(object sender, EventArgs e)
        {
            float diem;

            if(float.TryParse(textBox_DiemToan.Text, out diem))
                {
                if(diem < 0 || diem > 10)
                {
                    MessageBox.Show("Vui long nhap dung dinh dang", "loi me may r");
                }
            } else if(textBox_DiemToan.Text != "")
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng", "Lỗi");
                textBox_DiemToan.Clear();
                textBox_DiemToan.Focus();
            }
        }

        private void button_Them_Click(object sender, EventArgs e)
        {
          conn.Open();

            SqlCommand cmd = new SqlCommand("Insert into diem values(@id, @name,@toam, @van, @anh, @diemTB)",conn);

            cmd.Parameters.AddWithValue("@id", comboBox_MaSV.Text);
            cmd.Parameters.AddWithValue("@name", textBox_HoTenSV.Text);
            cmd.Parameters.AddWithValue("@toam", textBox_DiemToan.Text);
            cmd.Parameters.AddWithValue("@van", textBox_DiemVan.Text);
            cmd.Parameters.AddWithValue("@anh", textBox_DiemNN.Text);

            float dtb = (float.Parse(textBox_DiemToan.Text) + float.Parse(textBox_DiemVan.Text) + float.Parse(textBox_DiemNN.Text))/3;
            cmd.Parameters.AddWithValue("@diemTB", dtb);
            cmd.ExecuteNonQuery();

            conn.Close();
            load();    

        }

        private void button_ThongKe_Click(object sender, EventArgs e)
        {
            if (comboBox_ThongKe.Text == "Sinh viên đạt loại Giỏi")
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("select * from diem where diemTB >= 8", conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView_ThongKe.DataSource = dt;

                conn.Close();
            }
            else if(comboBox_ThongKe.Text == "Sinh viên đạt loại Khá")
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("select * from diem where (diemTB < 8 and diemTB >= 6.5)", conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView_ThongKe.DataSource = dt;

                conn.Close();
            }
            else
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("select * from diem where (diemTB < 6.5)", conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView_ThongKe.DataSource = dt;

                conn.Close();
            }
   
        }

        private void comboBox_ThongKe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView_ThongKe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox_DiemVan_TextChanged(object sender, EventArgs e)
        {
            float diem;
           if(float.TryParse(textBox_DiemVan.Text, out diem))
            {
                if(diem < 0 || diem > 10)
                {
                    MessageBox.Show("Sai dinh dang me may r", "loi me may");
                }
            }else if (textBox_DiemVan.Text != ""){

                MessageBox.Show("Sai dinh dang me may r", "loi me may");
            }
           
        }

        private void button_Them_Click_1(object sender, EventArgs e)
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand("Insert into diem values(@id, @name,@toam, @van, @anh, @diemTB)", conn);

            cmd.Parameters.AddWithValue("@id", comboBox_MaSV.Text);
            cmd.Parameters.AddWithValue("@name", textBox_HoTenSV.Text);
            cmd.Parameters.AddWithValue("@toam", textBox_DiemToan.Text);
            cmd.Parameters.AddWithValue("@van", textBox_DiemVan.Text);
            cmd.Parameters.AddWithValue("@anh", textBox_DiemNN.Text);

            float dtb = (float.Parse(textBox_DiemToan.Text) + float.Parse(textBox_DiemVan.Text) + float.Parse(textBox_DiemNN.Text)) / 3;
            cmd.Parameters.AddWithValue("@diemTB", dtb);
            cmd.ExecuteNonQuery();

            conn.Close();
            load();
        }

        private void comboBox_MaSV_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            textBox_HoTenSV.Text = listHsinh[comboBox_MaSV.Text];
        }

        private void textBox_DiemNN_TextChanged(object sender, EventArgs e)
        {
            float diem;
            if (float.TryParse(textBox_DiemNN.Text, out diem))
            {
                if (diem < 0 || diem > 10)
                {
                    MessageBox.Show("sai dinh dang so", "loi");
                }
               
            }
            else if (textBox_DiemNN.Text != "")
            {
                MessageBox.Show("Sai dinh dang", "loi");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            comboBox_MaSV.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString() ;
            textBox_HoTenSV.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString() ;   
            textBox_DiemToan.Text= dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString() ;
            textBox_DiemVan.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString() ;
            textBox_DiemNN.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString() ;
         }

        private void button_Xoa_Click(object sender, EventArgs e)
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand("delete from diem where ID = @ID",conn);

            cmd.Parameters.AddWithValue("@ID", comboBox_MaSV.Text);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            //DataTable dt = new DataTable();
            //adapter.Fill(dt);
            //dataGridView_ThongKe.DataSource = dt;

            cmd.ExecuteNonQuery();

            conn.Close();
            load();
            comboBox_MaSV.Text = "";
            textBox_HoTenSV.Clear();
            textBox_DiemToan.Clear();
            textBox_DiemVan.Clear();
            textBox_DiemNN.Clear();
        }

        private void button_Sua_Click(object sender, EventArgs e)
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand("update diem set toan = @toan, van = @van, anh = @anh, diemTB = @diemTB where ID = @ID", conn);
            cmd.Parameters.AddWithValue("ID", comboBox_MaSV.Text);
            cmd.Parameters.AddWithValue("@toan", textBox_DiemToan.Text);
            cmd.Parameters.AddWithValue("@van", textBox_DiemVan.Text);
            cmd.Parameters.AddWithValue("@anh", textBox_DiemNN.Text);


            float diemtb = (float.Parse(textBox_DiemToan.Text) + float.Parse(textBox_DiemVan.Text) + float.Parse(textBox_DiemNN.Text)) / 3;



            cmd.Parameters.AddWithValue("@diemTB", diemtb);

            cmd.ExecuteNonQuery();

            conn.Close();
            load();

        }
    }
}
