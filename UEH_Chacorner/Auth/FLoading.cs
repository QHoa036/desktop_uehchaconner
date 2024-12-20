using System;
using System.Windows.Forms;

namespace UEH_ChaCorner
{
    public partial class FLoading : Form
    {
        public FLoading()
        {
            InitializeComponent(); // Khởi tạo giao diện của form
        }

        private void FLoading_Load(object sender, EventArgs e)
        {
            // Bắt đầu chạy Timer khi form được tải
            Timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            // Kiểm tra nếu giá trị ProgressBar đã đạt đến giới hạn tối đa
            if (ProgressBar.Value >= ProgressBar.Maximum)
            {
                Timer.Stop(); // Dừng Timer khi hoàn thành
                Close(); // Đóng form loading
            }
            else
            {
                // Tăng giá trị ProgressBar lên 2 đơn vị
                ProgressBar.Increment(2);
            }
        }
    }
}
