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
using System.Security.Policy;
using System.Data.Common;
using System.Collections.ObjectModel;
using System.Text.RegularExpressions;
using System.Reflection.Emit;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
namespace Hotel
{
    public partial class DashBoard : Form
    {     
       
        
        SqlConnection connection = new SqlConnection("Data Source=TEDDY\\QUANGANH;Initial Catalog=Hotel;Integrated Security=True;");
        string tempcid;// tao 1 bien
        void load()
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("Select * from rooms", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dgvDetails.DataSource = table;
            connection.Close();
        }
       void loadCus()
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Customer", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dgvCusCheck.DataSource = table;
            connection.Close();
        }

        public DashBoard()
        {
            InitializeComponent();
            load();
            loadCus();
            LoadAvailableRooms();


        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
         


            connection.Open();
            SqlCommand cmd = new SqlCommand("Insert into rooms (roomNo, roomType, bed, price) values (@roomNo, @roomType, @bed, @price) ", connection);
            cmd.Parameters.AddWithValue("@roomNo", txtRoomNumber.Text);
            cmd.Parameters.AddWithValue("@RoomType", cboRoomType.Text);
            cmd.Parameters.AddWithValue("@bed", cboBed.Text);
            cmd.Parameters.AddWithValue("@price", txtPrice.Text);

            cmd.ExecuteNonQuery();
            connection.Close();

            load();
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //    }
            //    finally
            //    {
            //        connection.Close();
            //    }
            //}
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void dgvDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboRoomTypeCus_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboRoomNoCus.Items.Clear();
            string selectedRoomType = cboRoomTypeCus.Text;
            connection.Open();
            SqlCommand cmd = new SqlCommand("SELECT roomNo, price FROM rooms WHERE roomType = @roomType AND bed = @bed", connection);
            cmd.Parameters.AddWithValue("@bed", cboBedCus.Text);
            cmd.Parameters.AddWithValue("@roomType", selectedRoomType);
            //sau khi chpn giuong va loai giuong, app se hien thi phong tuong ung de co the dat
           

            SqlDataReader reader = cmd.ExecuteReader();
            cboRoomNoCus.Items.Clear();
            while (reader.Read())
            {
                cboRoomNoCus.Items.Add(reader["roomNo"]);
            }
            connection.Close();
        }
        //Đoạn mã này nhằm mục đích cập nhật danh sách các mã phòng(roomNo) trong cboRoomNoCus dựa trên loại phòng và loại giường đã chọn.Khi người dùng chọn một loại phòng và loại giường,
        //    ứng dụng sẽ truy vấn cơ sở dữ liệu để lấy các phòng tương ứng và hiển thị chúng trong cboRoomNoCus để người dùng có thể chọn đặt phòng.
        private void cboRoomNoCus_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdatePrice();
        }
        private void cboBedCus_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdatePrice();
        }

      
        private void UpdatePrice() // ham cap nhat gia
        {
            if (cboBedCus.SelectedItem != null && cboRoomNoCus.SelectedItem != null)
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT price FROM rooms WHERE roomNo = @roomNo", connection);
                cmd.Parameters.AddWithValue("@roomNo", cboRoomNoCus.SelectedItem.ToString());
                SqlDataReader reader = cmd.ExecuteReader();  //Dòng này thực thi truy vấn và trả về một SqlDataReader để đọc kết quả.
                if (reader.Read())
                {
                    txtPriceCus.Text = reader["price"].ToString();
                }

                //Sử dụng phương thức Read() của SqlDataReader để di chuyển đến hàng đầu tiên của kết quả và kiểm tra xem có hàng nào hay không. Nếu có,
                //lấy giá trị của cột price từ hàng đó và
                //gán cho thuộc tính Text của txtPriceCus.
                connection.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNameCus.Text) ||
                string.IsNullOrWhiteSpace(txtMobile.Text) ||            
                string.IsNullOrWhiteSpace(txtIdProof.Text) ||        
                string.IsNullOrWhiteSpace(cboRoomNoCus.Text))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dgvDetails != null)
            {
                string selectedRoom = cboRoomNoCus.Text;
                if (IsRoomBooked(selectedRoom))
                {
                    MessageBox.Show("Phòng đã có người đặt trước.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                connection.Open();
                SqlCommand cmd = new SqlCommand("UPDATE rooms SET booked = 'YES' WHERE roomNo = @roomNo", connection);
                cmd.Parameters.AddWithValue("@roomNo", selectedRoom);
                cmd.ExecuteNonQuery();

                SqlCommand insertCmd = new SqlCommand("INSERT INTO customer (name, num, nat, gender, idproof, address, roomNo, checkin) VALUES (@name, @num, @nat, @gender, @idproof, @address, @roomNo, @checkin)", connection);
                insertCmd.Parameters.AddWithValue("@name", txtNameCus.Text);
                insertCmd.Parameters.AddWithValue("@num", txtMobile.Text);
                insertCmd.Parameters.AddWithValue("@nat", txtNat.Text);
                insertCmd.Parameters.AddWithValue("@gender", cboGender.Text);
                insertCmd.Parameters.AddWithValue("@idproof", txtIdProof.Text);
                insertCmd.Parameters.AddWithValue("@address", txtAddress.Text);
                insertCmd.Parameters.AddWithValue("@roomNo", selectedRoom);
                insertCmd.Parameters.AddWithValue("@checkin", dtpkCheckIn.Value.ToString("yyyy-MM-dd"));

                insertCmd.ExecuteNonQuery();
                connection.Close();
                loadCus();
                load();
                LoadAvailableRooms();
                MessageBox.Show("Đặt phòng thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không thể tìm thấy DataGridView.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            txtNameCus.Clear();
            txtMobile.Clear();
            txtNat.Clear();
            txtIdProof.Clear();
            txtAddress.Clear();
            cboGender.Text = "";
            cboBedCus.Text = "";
            cboRoomNoCus.Text = "";
        }
        private bool IsRoomBooked(string roomNumber)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("SELECT booked FROM rooms WHERE roomNo = @roomNo", connection);
            cmd.Parameters.AddWithValue("@roomNo", roomNumber);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())   //Kiểm tra xem có dữ liệu trả về từ truy vấn hay không bằng cách gọi phương thức Read() của đối tượng SqlDataReader. Nếu có dữ liệu, điều kiện trong dấu ngoặc nhọn sẽ được thực thi.
            {
                string bookedStatus = reader["booked"].ToString();// trich xuat ket quarích xuất giá trị của cột "booked" từ dòng dữ liệu đầu tiên mà SqlDataReader đọc được và gán vào
                                                                  // biến bookedStatus.
                                                                  // Dòng này chuyển đổi giá trị từ kiểu object sang kiểu string bằng cách gọi phương thức 
                connection.Close();
                return bookedStatus == "YES";
            }
            connection.Close();
            return false;
        }
        private void LoadAvailableRooms()
        {
            cboRoomNoCus.Items.Clear();
            string selectedRoomType = cboRoomTypeCus.Text;
            connection.Open();
            SqlCommand cmd = new SqlCommand("SELECT roomNo, price FROM rooms WHERE roomType = @roomType AND bed = @bed AND booked = 'no'", connection);
            cmd.Parameters.AddWithValue("@bed", cboBedCus.Text);
            cmd.Parameters.AddWithValue("@roomType", selectedRoomType);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cboRoomNoCus.Items.Add(reader["roomNo"]);
            }
            connection.Close();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {

            connection.Open();
            // Lấy idproof của khách hàng cần xóa
            string idProofToDelete = tempcid.ToString();
            // Lấy roomNo của khách hàng chuan bi duoc xo xóa
            SqlCommand getRoomNoCmd = new SqlCommand("SELECT roomNo FROM customer WHERE idproof = @idproof", connection);
            getRoomNoCmd.Parameters.AddWithValue("@idproof", idProofToDelete);
            string roomNo = getRoomNoCmd.ExecuteScalar().ToString();
            //thực thi lệnh và trả về giá trị đầu tiên của cột roomNo tương ứng,
            //sau đó chuyển đổi giá trị này thành chuỗi và gán cho biến roomNo


            // Thực hiện câu truy vấn DELETE để xóa khách hàng
            SqlCommand cmd = new SqlCommand("DELETE FROM customer WHERE idproof = @idproof", connection);
            cmd.Parameters.AddWithValue("@idproof", idProofToDelete);
            cmd.ExecuteNonQuery();
            // Nếu có roomNo, thực hiện cập nhật trạng thái booked của phòng sang "no"
            //thanh toan xong thi chuyen trang thai phong sang khong ai dat
            if (!string.IsNullOrEmpty(roomNo))
            {
                SqlCommand updateRoomCmd = new SqlCommand("UPDATE rooms SET booked = 'NO' WHERE roomNo = @roomNo", connection);
                updateRoomCmd.Parameters.AddWithValue("@roomNo", roomNo);
                updateRoomCmd.ExecuteNonQuery();
            }
            connection.Close();
            MessageBox.Show("Thanh toán thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            loadCus();
            load(); // Cập nhật lại dgvDetails


        }

        private void dgvCusCheck_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tempcid = dgvCusCheck.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtNameCheck.Text = dgvCusCheck.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtRoomNoCheck.Text = dgvCusCheck.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            connection.Open();

            SqlCommand cmd = new SqlCommand("select * from customer where idproof = @idproof",connection);
            cmd.Parameters.AddWithValue("@idproof", txtIdCheck.Text);
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(table);

            connection.Close();
            dgvCusCheck.DataSource = table;
        }

        private void btnFix_Click(object sender, EventArgs e)
        {
            connection.Open();

            SqlCommand cmd = new SqlCommand("update rooms set roomNo = @roomNo, roomType = @roomType, bed = @bed, price = @price where roomNo = @roomNo",connection);
            cmd.Parameters.AddWithValue("@roomNo", txtRoomNumber.Text);
            cmd.Parameters.AddWithValue("@roomType",cboRoomType.Text);
            cmd.Parameters.AddWithValue("@bed", cboBed.Text);
            cmd.Parameters.AddWithValue("@price",txtPrice.Text);
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            cmd.ExecuteNonQuery();


            connection.Close();
            load();

        }

        private void dgvDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtRoomNumber.Text = dgvDetails.Rows[e.RowIndex].Cells[0].Value.ToString();
            cboRoomType.Text = dgvDetails.Rows[e.RowIndex].Cells[1].Value.ToString();
            cboBed.Text = dgvDetails.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtPrice.Text = dgvDetails.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void txtNameCus_TextChanged(object sender, EventArgs e)
        {
            bool hasNumber = txtNameCus.Text.Any(char.IsDigit);

            // Hiển thị hoặc ẩn label23 dựa trên kết quả kiểm tra
            if (label23.Visible = hasNumber)
            {
                label23.Text = "Sai định dạng tên";
            }
        }

        private void txtIdProof_TextChanged(object sender, EventArgs e)
        {
            string text = txtIdProof.Text;

            // Kiểm tra độ dài của chuỗi
            if (text.Length != 12)
            {
                lb_ID.Text = "Số căn cước không hợp lệ!";
                lb_ID.Visible = true;
            }
            else
            {
                lb_ID.Visible = false;
            }
        }

        private void txtMobile_TextChanged(object sender, EventArgs e)
        {
            string text = txtMobile.Text;

            // Kiểm tra độ dài của chuỗi
            if (text.Length > 10 || text.Length < 8)
            {
                lb_DT.Text = "SĐT không đúng định dạng!";
                lb_DT.Visible = true;
            }
            else
            {
                lb_DT.Visible = false;
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void dtpkCheckIn_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void cboGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtNat_TextChanged(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void lb_ID_Click(object sender, EventArgs e)
        {

        }

        private void lb_DT_Click(object sender, EventArgs e)
        {

        }

        private void txtRoomNumber_TextChanged(object sender, EventArgs e)
        {
            bool hasOnlyDigits = txtRoomNumber.Text.All(char.IsDigit);

            if (hasOnlyDigits)
            {
                lb_SP.Text = "";
            }
            else
            {
                lb_SP.Text = "Số phòng sai định dạng";
            }

        }
    }

}

