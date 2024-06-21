using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace de1
{
    public partial class Form1 : Form
    {

        List<Ghe[,]> dsMangGhe;
        string[] dayGhe = { "A", "B", "C", "D", "E", "F" };
        ToolTip toolTip;

        public Form1()
        {
            InitializeComponent();
            toolTip = new ToolTip();
            toolTip.IsBalloon = true;
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void btThanhToan_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thanh toán không?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                int index = cboTenPhim.SelectedIndex;
                Ghe[,] ghes = dsMangGhe.ElementAt(index);
                for (int i = 0; i < 6; i++)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        if (ghes[i, j].BackColor == Color.Green)
                        {
                            ghes[i, j].BackColor = Color.Red;
                            ghes[i, j].Enabled = false;
                        }

                    }
                }
                lbTien.Text = "Thành tiền: " + tinhTien() + "đ";
            }
        }

        private void cboTenPhim_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbTenPhim.Text = cboTenPhim.Text;
            loadGhe();
            lbTien.Text = "Thành tiền: " + tinhTien() + "đ";
        }


        private void loadGhe()
        {
            int id = cboTenPhim.SelectedIndex;
            Ghe[,] arr = dsMangGhe.ElementAt(id);
            tlpGhe.Controls.Clear();
            for(int i = 0; i < 6;i++)
            {
                for(int j = 0; j < 6; j++)
                {
                    tlpGhe.Controls.Add(arr[i,j] ,j ,i);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dsMangGhe = new List<Ghe[,]>();
            for(int k = 0; k < cboTenPhim.Items.Count; k++) {
                Ghe[,] mang = new Ghe[6, 6];
                int stt = 0;
                for (int i = 0; i < 6 ; i++){
                    for(int j = 0;j < 6 ; j++)
                    {
                        Ghe ghe = new Ghe();
                        ghe.mauMacDinh = tlpGhe.Controls[stt].BackColor;
                        stt++;
                        ghe.Text = dayGhe[i] + (j + 1).ToString();
                        ghe.BackColor = ghe.mauMacDinh;
                        if (i == 0) ghe.gia = 25000;
                        else if (i == 1) ghe.gia = 30000;
                        else if (i == 2) ghe.gia = 35000;
                        else if (i == 3) ghe.gia = 40000;
                        else if (i == 4) ghe.gia = 50000;
                        else if (i == 5) ghe.gia = 45000;
                        string caption = "Gia ghe nay la: " + ghe.gia;
                        toolTip.SetToolTip(ghe, caption);
                        ghe.Dock = DockStyle.Fill;
                        ghe.Click += new EventHandler(this.gheClick);
                        mang[i,j] = ghe;
                    }
            }
            }
        }
        private void gheClick(object sender, EventArgs eventArgs)
        {
            Ghe ghe = sender as Ghe;
            if (ghe.BackColor == ghe.mauMacDinh)
            {
                ghe.BackColor = Color.Green;
            }
            else
            {
                ghe.BackColor = ghe.mauMacDinh;
            }
            lbTien.Text = "Thành tiền: " + tinhTien() + "đ";
        }
        private int tinhTien()
        {
            int tongTien = 0;
            int id = cboTenPhim.SelectedIndex;
            Ghe[,] ghes = dsMangGhe.ElementAt(id);
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (ghes[i,j].BackColor == Color.Green)
                    {
                        tongTien += ghes[i, j].gia;

                    }
                }
                return tongTien;    
            }
        }
    }
}
