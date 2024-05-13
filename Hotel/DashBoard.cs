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
namespace Hotel
{
    public partial class DashBoard : Form
    {     
       
        
        SqlConnection connection = new SqlConnection("Data Source=TEDDY\\QUANGANH;Initial Catalog=Hotel;Integrated Security=True;");
        string tempcid;
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
      
        private void DashBoard_Load(object sender, EventArgs e)
        {

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
            SqlDataReader reader = cmd.ExecuteReader();
            cboRoomNoCus.Items.Clear();
            while (reader.Read())
            {
                cboRoomNoCus.Items.Add(reader["roomNo"]);
            }
            connection.Close();
        }

        private void cboRoomNoCus_SelectedIndexChanged(object sender, EventArgs e)
        {

            UpdatePrice();

        }
        private void cboBedCus_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdatePrice();
        }

      
        private void UpdatePrice()
        {
            if (cboBedCus.SelectedItem != null && cboRoomNoCus.SelectedItem != null)
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT price FROM rooms WHERE roomNo = @roomNo", connection);
                cmd.Parameters.AddWithValue("@roomNo", cboRoomNoCus.SelectedItem.ToString());
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtPriceCus.Text = reader["price"].ToString();
                }
                connection.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (dgvDetails != null)
            {
                string selectedRoom = cboRoomNoCus.Text;
                if (IsRoomBooked(selectedRoom))
                {
                    MessageBox.Show("Phòng đã có người đặt trước.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                connection.Open();
                SqlCommand cmd = new SqlCommand("UPDATE rooms SET booked = 'yes' WHERE roomNo = @roomNo", connection);
                cmd.Parameters.AddWithValue("@roomNo", selectedRoom);
                cmd.ExecuteNonQuery();

                // Chèn thông tin khách hàng vào bảng 'Customers'
                SqlCommand insertCmd = new SqlCommand("INSERT INTO customer (name,num,nat,gender,idproof,address,roomNo,timeCheckIn,checkin) VALUES (@name,@num,@nat,@gender,@idproof,@address,@roomNo,@timeCheckIn,@checkin)", connection);
                insertCmd.Parameters.AddWithValue("@name", txtNameCus.Text);
                insertCmd.Parameters.AddWithValue("@num", txtMobile.Text);
                insertCmd.Parameters.AddWithValue("@nat", txtNat.Text);
                insertCmd.Parameters.AddWithValue("@gender", cboGender.Text);
                insertCmd.Parameters.AddWithValue("@idproof", txtIdProof.Text);
                insertCmd.Parameters.AddWithValue("@address", txtAddress.Text);
                insertCmd.Parameters.AddWithValue("@roomNo", selectedRoom);
                insertCmd.Parameters.AddWithValue("@timeCheckIn", cboTimeCheckIn);
                insertCmd.Parameters.AddWithValue("@checkin", dtpkCheckIn.Value.ToString("yyyy-MM-dd"));

                insertCmd.ExecuteNonQuery();
                connection.Close();
                loadCus();
                load(); // Cập nhật lại danh sách phòng sau khi đặt
                LoadAvailableRooms(); // Cập nhật danh sách phòng chưa được đặt
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
            if (reader.Read())
            {
                string bookedStatus = reader["booked"].ToString();// trich xuat ket qua
                connection.Close();
                return bookedStatus == "yes";
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

           

            // Lấy roomNo của khách hàng đã xóa
            SqlCommand getRoomNoCmd = new SqlCommand("SELECT roomNo FROM customer WHERE idproof = @idproof", connection);
            getRoomNoCmd.Parameters.AddWithValue("@idproof", idProofToDelete);
            string roomNo = getRoomNoCmd.ExecuteScalar()?.ToString();

            // Thực hiện câu truy vấn DELETE để xóa khách hàng
            SqlCommand cmd = new SqlCommand("DELETE FROM customer WHERE idproof = @idproof", connection);
            cmd.Parameters.AddWithValue("@idproof", idProofToDelete);
            cmd.ExecuteNonQuery();

            // Nếu có roomNo, thực hiện cập nhật trạng thái booked của phòng sang "no"
            if (!string.IsNullOrEmpty(roomNo))
            {
                SqlCommand updateRoomCmd = new SqlCommand("UPDATE rooms SET booked = 'no' WHERE roomNo = @roomNo", connection);
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
    }

}

