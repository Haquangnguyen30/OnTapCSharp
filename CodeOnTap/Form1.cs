using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeOnTap
{
    public partial class Form1 : Form
    {
        QLBGEntities QLBG = new QLBGEntities();
        public string connectionString = "Data Source=DESKTOP-EVA6OFD\\SQLEXPRESS;Initial Catalog=QLBG;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadComboBox();
            // LoadDataGridView();
            TestLINQ();

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

        public void TestLINQ()
        {
            
            var queryPublishers = from item in QLBG.khachHangs
                                  select item;
            dvKH.DataSource = queryPublishers.ToList();

            //join
            //var queryPublishers = from sp in QLBG.sanPhams
            //                      join spkc in
            //                       QLBG.sanPham_KichCo on sp.maSP equals spkc.maSP
            //                      where spkc.maSP.Equals("G001")
            //                      select sp;
            //SELECT sp.*
            //FROM sanPhams sp
            //INNER JOIN sanPham_KichCo spkc ON sp.maSP = spkc.maSP
            //WHERE spkc.maSP = 'G001';
            //dvKH.DataSource = queryPublishers.ToList();
        }
        public void ThemLINQ()
        {
            khachHang kh = new khachHang();
            kh.maKH= newmaKH();
            kh.tenKH = txtTenKH.Text;
            kh.sdt = txtSDT.Text;
            QLBG.khachHangs.Add(kh);
            QLBG.SaveChanges();
            TestLINQ();

        }

        public void SuaLINQ()
        {
            khachHang kh = new khachHang();
            kh.maKH = int.Parse(txtMaKH.Text);
            kh.tenKH = txtTenKH.Text;
            kh.sdt = txtSDT.Text;
            QLBG.khachHangs.AddOrUpdate(kh);
            QLBG.SaveChanges();
            TestLINQ();

        }
        public void DeleteLINQ()
        {

            int makh=int.Parse(txtMaKH.Text);

            var queryPublishers = from item in QLBG.khachHangs where item.maKH == makh
                                  select item;
            QLBG.khachHangs.Remove(queryPublishers.First());
            QLBG.SaveChanges();
            TestLINQ();

        }
        public void TimkiemLINQ(string tk)
        {


            var queryPublishers = from item in QLBG.khachHangs
                                  where (item.tenKH.Contains(tk) || item.sdt.Contains(tk))
                                  select item;
            dvKH.DataSource = queryPublishers.ToList();

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
            string query = "UPDATE khachHang set tenKH = @tenKH, sdt = @sdt where maKH = @maKH";
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
            string query = "DELETE FROM khachHang WHERE maKH = @maKH";
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
            //add();
            ThemLINQ();
        }

        private void dvKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem có chọn đúng dòng không (tránh header)
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dvKH.Rows[e.RowIndex];

                // Gán giá trị từ các ô vào TextBox
                txtMaKH.Text = row.Cells["maKH"].Value.ToString();
                txtTenKH.Text = row.Cells["tenKH"].Value.ToString();
                txtSDT.Text = row.Cells["sdt"].Value.ToString();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            //update();
            SuaLINQ();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //delete();
            DeleteLINQ();
        }

        private void txtTk_TextChanged(object sender, EventArgs e)
        {
            TimkiemLINQ(txtTk.Text);
        }
    }
}
