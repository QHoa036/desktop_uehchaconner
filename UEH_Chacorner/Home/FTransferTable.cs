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
using BLL;
using DTO;
using Microsoft.Office.Interop.Word;

namespace UEH_Chacorner.Home
{
    public partial class FTransferTable : Form
    {
        private SqlConnection conn = new SqlConnection("Data Source=ADMIN-PC\\MAY01;Initial Catalog=UEHChaCorner;Integrated Security=True");
        private string currentTable;

        public FTransferTable(string tableName)
        {
            InitializeComponent();
            currentTable = tableName;  // Lưu tên bàn vào biến currentTable
            LoadTables();  // Load các bàn và gán giá trị cho ComboBox
        }
        private void LoadTables()
        {
            try
            {
                conn.Open();
                string query = "SELECT MaBan, Ten, TrangThai FROM Ban";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string tableName = reader["Ten"].ToString();
                    string status = reader["TrangThai"].ToString();
                    string tableId = reader["MaBan"].ToString();

                    cmbCurrentTable.Items.Add(tableName);  // Thêm tên bàn vào ComboBox

                    if (status == "Trống" && tableName != currentTable)
                    {
                        cmbNewTable.Items.Add(tableName);  // Thêm bàn trống vào ComboBox
                    }
                }

                if (cmbCurrentTable.Items.Contains(currentTable))
                {
                    cmbCurrentTable.SelectedItem = currentTable;  // Chọn tên bàn hiện tại trong ComboBox
                }
                else
                {
                    MessageBox.Show("Bàn hiện tại không có trong danh sách.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách bàn: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnConfirmTransfer_Click(object sender, EventArgs e)
        {
            string currentTable = cmbCurrentTable.SelectedItem.ToString();
            string newTable = cmbNewTable.SelectedItem.ToString();

            try
            {
                conn.Open();

                // Cập nhật thông tin bàn (Trạng thái, Thứ tự) cho bàn mới
                string transferQuery = @"
                BEGIN TRANSACTION;

                -- Cập nhật trạng thái và thứ tự của bàn mới
                UPDATE Ban
                SET TrangThai = (SELECT TrangThai FROM Ban WHERE Ten = @CurrentTable),
                    ThuTu = (SELECT ThuTu FROM Ban WHERE Ten = @CurrentTable)
                WHERE Ten = @NewTable;

                -- Cập nhật các món ăn từ bàn cũ sang bàn mới trong bảng CTHD
                UPDATE CTHD
                SET MaBan = (SELECT MaBan FROM Ban WHERE Ten = @NewTable)
                WHERE MaBan = (SELECT MaBan FROM Ban WHERE Ten = @CurrentTable);

                -- Cập nhật bàn cũ thành Trống
                UPDATE Ban SET TrangThai = 'Trống' WHERE Ten = @CurrentTable;

                COMMIT TRANSACTION;
                ";
        
        SqlCommand cmd = new SqlCommand(transferQuery, conn);
                cmd.Parameters.AddWithValue("@CurrentTable", currentTable);
                cmd.Parameters.AddWithValue("@NewTable", newTable);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Chuyển bàn thành công!");
                this.Close();  // Đóng form sau khi hoàn tất
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi chuyển bàn: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
