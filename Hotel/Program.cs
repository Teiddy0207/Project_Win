using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace Hotel
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            Form1 loginForm = new Form1();// tao ra doi tuong de hien thi

            // Hiển thị form đăng nhập và kiểm tra kết quả đăng nhập
            //Hàm ShowDialog() được sử dụng để hiển thị form dưới dạng một hộp thoại modal, nghĩa là người dùng phải 
            //    tương tác với hộp thoại này trước 
            //    khi có thể quay lại tương tác với form khác. Hàm này sẽ trả về một giá trị thuộc kiểu DialogResult
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                // Nếu đăng nhập thành công, hiển thị form chính
                Application.Run(new DashBoard());
            }
            else
            {
                // Nếu đăng nhập thất bại, thoát ứng dụng
                Application.Exit();
            }
        }
    }
}
