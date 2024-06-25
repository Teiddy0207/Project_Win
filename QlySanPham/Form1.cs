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
namespace QlySanPham
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=TEDDY\\QUANGANH;Initial Catalog=Qly_SanPham;Integrated Security=True;");
        int sum;
        string ten;
        int gia;
        int stt;
        public Form1()
        {
            InitializeComponent();
            //loaditem();
        }
     
        private void comboBox_TheLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        
        conn.Open();
            SqlCommand cmd = new SqlCommand("Select ROW_NUMBER() OVER (ORDER BY TEN) AS STT, TEN as [Ten Hang], DONGIA as [Don Gia] from sp where THELOAI = @THELOAI", conn);

            cmd.Parameters.AddWithValue("@TheLoai", comboBox_TheLoai.Text);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView_LoaiHang.DataSource = dt;

            conn.Close();

            label_LoaiHang.Text = comboBox_TheLoai.Text;
        }

        private void dataGridView_LoaiHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
 
        }

        private void dataGridView_LoaiHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ten = dataGridView_LoaiHang.Rows[e.RowIndex].Cells[1].Value.ToString();
            gia = int.Parse(dataGridView_LoaiHang.Rows[e.RowIndex].Cells[2].Value.ToString());
        }

        private void dataGridView_DonHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            stt = e.RowIndex;
        }

        private void button_Xoa_Click(object sender, EventArgs e)
        {
              
            //    }
            dataGridView_DonHang.Rows.RemoveAt(stt);

            foreach(DataGridViewRow row in dataGridView_DonHang.Rows)
            {
                if (row.Cells[0].Value != null && int.Parse(row.Cells[0].Value.ToString()) >= stt + 1)
                {
                    row.Cells[0].Value = int.Parse(row.Cells[0].Value.ToString()) -1;
                }

            }
            }


        private void textBox_TongTien_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void button_ThanhToan_Click(object sender, EventArgs e)
        {
           

             sum = 0;
            foreach(DataGridViewRow row  in dataGridView_DonHang.Rows)
            {
                if (row.Cells[2].Value != null && row.Cells[3].Value != null)
                {
                    sum += (int.Parse(row.Cells[2].Value.ToString()) * int.Parse(row.Cells[3].Value.ToString() ) );
                }
            }
            textBox_TongTien.Text = sum.ToString();
        
        }

        private void button_TaoDon_Click(object sender, EventArgs e)
        {
           
            comboBox_TheLoai.Text = " ";
            textBox_TongTien.Clear();
            dataGridView_LoaiHang.DataSource = null;
            dataGridView_DonHang.Rows.Clear();
        }

        private void button_Them_Click(object sender, EventArgs e)
        {
            
            int thanhtien = int.Parse(numericUpDown_SoLuong.Value.ToString()) * gia;
          dataGridView_DonHang.Rows.Add(dataGridView_DonHang.RowCount,ten, numericUpDown_SoLuong.Value.ToString(),gia,thanhtien);
        
        }

        private void numericUpDown_SoLuong_ValueChanged(object sender, EventArgs e)
        {
 
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        //    Control click = contextMenuStrip1.SourceControl;


        //    contextMenuStrip1.Close();
        //ColorDialog color = new ColorDialog();

        //    if(color.ShowDialog() == DialogResult.OK)
        //    {
        //        if(click is Label) {
        //        click.ForeColor = color.Color;
        //        }else if(click is DataGridView)
        //        {
        //            DataGridView dgv = (DataGridView)click; 

        //            dgv.BackgroundColor = color.Color;
        //        }
        //        else
        //        {
        //            click.ForeColor = color.Color;
        //        }

        //    }
        }
    }
}
