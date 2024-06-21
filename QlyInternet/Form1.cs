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
using System.Reflection;
namespace QlyInternet
{
    public partial class Form1 : Form
    {
        private Button[] may;
        private TextBox[] giovao;
        private TextBox[] giora;
        private TextBox[] tongtien;
        private Button[] thanhtoan;
        
        
        
        SqlConnection conn = new SqlConnection("Data Source=TEDDY\\QUANGANH;Initial Catalog=QlyInternet;Integrated Security=True;");

        void load()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from may",conn);
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


            may = new Button[]
            {
                btnMay1, btnMay2,btnMay3, btnMay4, btnMay5
            };

            giovao = new TextBox[]
            {
                txtGioVao1, txtGioVao2, txtGioVao3, txtGioVao4, txtGioVao5
            };
            giora = new TextBox[]
            {
                txtGioRa1, txtGioRa2, txtGioRa3, txtGioRa4, txtGioRa5
            };
            tongtien = new TextBox[]
            {
                txtTotal1, txtTotal2, txtTotal3, txtTotal4, txtTotal5
            };
            thanhtoan = new Button[]
            {
                btnThanhToan1, btnThanhToan2, btnThanhToan3, btnThanhToan4, btnThanhToan5
            };
        }

        private void btnMay1_Click(object sender, EventArgs e)
        {
            //int id = Array.IndexOf(may, sender);
            //if (giovao[id].Text != "" && giora[id].Text != "")
            //{
            //    if (may[id].BackColor == Color.Red)
            //    {
            //   MessageBox.Show("Máy đang được dùng", "Thông báo");
            //    }
            //    else
            //    {
            //        may[id].BackColor = Color.Red;
            //    }
            //}  else
            //{
            //    MessageBox.Show("Nhap gio choi di em");
            //}

            int id = Array.IndexOf(may, sender);

            if (giovao[id].Text != "" && giora[id].Text != "") // su kien neu gio vao va gio ra da duoc nhap
            {
                if (may[id].BackColor == Color.Red) // neu dang co mau do
                {
                    MessageBox.Show("Da co cho ngoi roi"); // khi an vao se co thong bao da co cho ngoi
                }
                else
                {
                    may[id].BackColor = Color.Red; // chua an thi an vao se co mau do
                }
                
               
            }else
                MessageBox.Show("Nhap so gio di thim");
        }

        private void txtGioVao1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtGioVao1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back) // neu khong phai so nguyen va khong phep nhap dau cacch
            {
                MessageBox.Show("Loi dinh dang");
            e.Handled = true;  
            }
        }

        private void txtGioRa1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGioRa1_KeyPress(object sender, KeyPressEventArgs e)
        {
          // giai quyet khi go dau ra sai dinh dang
         if(!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                MessageBox.Show("sai dinh dang");
                e.Handled = true;
            }


            // h giai quyet vde tong tien
            int id = Array.IndexOf(giora, sender);

            int agiovao = int.Parse(giovao[id].Text);
            int agiora = int.Parse(giora[id].Text.ToString() + e.KeyChar);

            tongtien[id].Text = ((agiora - agiovao) * 5000).ToString();
        
        }

        private void btnThanhToan1_Click(object sender, EventArgs e)
        {
            int id = Array.IndexOf(thanhtoan, sender);

            if (tongtien[id].Text != "") // neu cot tong tien k rong
            {
                conn.Open(); // bat dau mo ket noi
                if (may[id].BackColor == Color.Red)// khi may dang duoc su dung
                {
                    int giosudung = (int.Parse(giora[id].Text) - int.Parse(giovao[id].Text));
                    SqlCommand cmd = new SqlCommand("insert into may (STT, SOMAY,GIOVAO,GIORA,TOTAL,DONGIA,THANHTIEN) values (@STT, @SOMAY,@GIOVAO,@GIORA,@TOTAL,@DONGIA,@THANHTIEN) ", conn);

                    cmd.Parameters.AddWithValue("STT", dgvDetails.RowCount.ToString());
                    cmd.Parameters.AddWithValue("@SOMAY", may[id].Text);
                    cmd.Parameters.AddWithValue("@GIOVAO", giovao[id].Text);
                    cmd.Parameters.AddWithValue("@GIORA", giora[id].Text);
                    cmd.Parameters.AddWithValue("@TOTAL", giosudung);
                    cmd.Parameters.AddWithValue("@DONGIA", "5000");
                    cmd.Parameters.AddWithValue("@THANHTIEN", giosudung * 5000);

                    cmd.ExecuteNonQuery();
                    conn.Close();

                }

                load();
                may[id].BackColor = Color.LightGray;
                giovao[id].Clear();
                giora[id].Clear();
                tongtien[id].Clear();
            }

       



        }

        private void txtGioVao1_TextChanged_1(object sender, EventArgs e)
        {
         
        }
    }
}
