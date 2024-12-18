using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeOnTap
{
    public partial class Form1 : Form
    {
        public string connectionString = "Data Source=WINDOWS-10\\SQLEXPRESS;Initial Catalog=QLBG;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadComboBox();
            LoadDataGridView();
        }

        public void LoadComboBox()
        {
            string query = "SELECT maKH,tenKH,sdt FROM khachHang";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();

                try
                {
                    connection.Open();
                    adapter.Fill(dt);

                    cbKH.DataSource = dt;
                    cbKH.DisplayMember = "tenKH"; // Tên cột hiển thị
                    cbKH.ValueMember = "maKH";   // Giá trị tương ứng
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        public void LoadDataGridView()
        {
            string query = "SELECT maKH,tenKH,sdt FROM khachHang";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();

                try
                {
                    connection.Open();
                    adapter.Fill(dt);

                    dvKH.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        //CRUD ADO.NET
        //ADD
        public void add()
        {
            string query = "INSERT INTO khachHang (maKH, tenKH, sdt) VALUES (@maKH, @tenKH, @sdt)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query,connection);
                int maKH = newmaKH();
                command.Parameters.AddWithValue("@maKH", maKH);
                command.Parameters.AddWithValue("@tenKH",txtTenKH.Text);
                command.Parameters.AddWithValue("@sdt",txtSDT.Text);
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Thêm thành công!");
                    LoadDataGridView();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                connection.Close();
            }
        }
        //Update
        public void update()
        {
            string query = "UPDATE khachHang set @tenKH = tenKH, @sdt = sdt where @maKH = maKH";
            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query,connection);
                cmd.Parameters.AddWithValue("@maKH",txtMaKH.Text);
                cmd.Parameters.AddWithValue("@tenKH", txtTenKH.Text);
                cmd.Parameters.AddWithValue("@sdt", txtSDT.Text);
                try
                {
                    connection.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Cập nhật thành công!");
                        LoadDataGridView(); // Refresh DataGridView
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy dữ liệu cần sửa!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        //Delete
        public void delete()
        {
            string query = "DELETE FROM khachHang WHERE @maKH = maKH";
            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query,connection);
                command.Parameters.AddWithValue("@maKH", txtMaKH.Text);
                try
                {
                    connection.Open();
                    int rows = command.ExecuteNonQuery();
                    if(rows > 0)
                    {
                        MessageBox.Show("Xoá thành công!");
                        LoadDataGridView();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy dữ liệu cần xoá!");
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        public int newmaKH()
        {
            string query = "SELECT MAX(maKH) FROM khachHang";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                //SqlDataAdapter adapter = new SqlDataAdapter(command);
                connection.Open();
                object result = command.ExecuteScalar(); 
                return (int)result + 1;
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            add();
        }
    }
}
