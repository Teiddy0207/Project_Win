using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (txtLogin.Text == "a" && txtPass.Text == "1")
           {
                this.DialogResult = DialogResult.OK;
                this.Close();
                MessageBox.Show("Đăng nhập thành công!!");
            }
          else if(txtLogin.Text == "" && txtPass.Text == "")
    {
                MessageBox.Show("Ten dang nhap hoac mat khau khong duoc de trong");
            }
            
            
            else
           
            
            {
                MessageBox.Show("Sai mk hoac ten dang nhap");
            }
        }
    }
}
