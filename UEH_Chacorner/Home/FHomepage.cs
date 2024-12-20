using System;
using System.Windows.Forms;
using UEH_Chacorner.Home;
using UEH_ChaCorner.Home;

namespace UEH_ChaCorner
{
    public partial class FHomepage : Form
    {
        public static FHomepage MainMenu;

        // Khởi tạo các form con
        private FRevenue _thongke = new FRevenue();
        private FStaff _nhanvien = new FStaff();
        private FAccount _taikhoan = new FAccount();
        private FCategory _danhmuc = new FCategory();
        private FMenu _menu = new FMenu();
        private FTable _table = new FTable();

        private Form _activeForm; // Form con đang hiển thị
        private string _manv = "", _quyennv = "", _tennv = "", _tentk = ""; // Thông tin tài khoản người dùng
        private bool _isCategory = false; // Trạng thái form danh mục
        private bool _isProfile = false; // Trạng thái form tài khoản
        private bool _isStaff = false; // Trạng thái form nhân viên
        private bool _isChart = false; // Trạng thái form thống kê
        private bool _isMenu = false; // Trạng thái form menu
        private bool _isTable = false; // Trạng thái form quản lý bàn
        private bool _isHome = true; // Trạng thái form trang chủ

        public FHomepage()
        {
            InitializeComponent(); // Khởi tạo giao diện
            MainMenu = this; // Gán form chính cho biến tĩnh MainMenu
        }

        private void FHomepage_Load(object sender, EventArgs e)
        {
            // Sự kiện xảy ra khi form chính được tải
            // Kiểm tra các form đã dispose chưa và được khởi tạo chưa
            if (_taikhoan == null || _taikhoan.IsDisposed)
            {
                _taikhoan = new FAccount();
            }
            if (_danhmuc == null || _danhmuc.IsDisposed)
            {
                _danhmuc = new FCategory();
            }
            if (_nhanvien == null || _nhanvien.IsDisposed)
            {
                _nhanvien = new FStaff();
            }
            if (_thongke == null || _thongke.IsDisposed)
            {
                _thongke = new FRevenue();
            }
            if (_menu == null || _menu.IsDisposed)
            {
                _menu = new FMenu();
            }
            if (_table == null || _table.IsDisposed)
            {
                _table = new FTable();
            }
        }

        private void FMainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Reset form
            _isCategory = false;
            _isProfile = false;
            _isStaff = false;
            _isChart = false;
            _isMenu = false;
            _isTable = false;
            _isHome = true;
            _activeForm?.Hide();

            // Hiển thị form đăng nhập khi form chính bị đóng
            var fLogin = new FLogin();
            fLogin.Show();
        }

        private void OpenChildForm(Form childForm)
        {
            // Đóng form con đang hiển thị (nếu có)
            _activeForm?.Hide();
            _activeForm = childForm;

            // Thiết lập và hiển thị form con mới
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        internal void setVisible(string quyennv, string tennv, string tentk, string manv)
        {
            // Lấy thông tin tài khoản người dùng
            _manv = manv;
            _quyennv = quyennv;
            _tennv = lbUsername.Text = tennv;
            _tentk = tentk;

            // Hiển thị các chức năng phù hợp với quyền (Admin hoặc nhân viên)
            if (string.Equals(quyennv.ToLower(), "admin", StringComparison.OrdinalIgnoreCase))
            {
                btHome.Visible = true;
                btCategory.Visible = true;
                btAccount.Visible = true;
                btStaff.Visible = true;
                btStatistic.Visible = true;
                btMenu.Visible = true;
                btManage.Visible = true;
                btExit.Visible = true;
            }
            else
            {
                btCategory.Visible = false;
                btStaff.Visible = false;
                btStatistic.Visible = false;
                btMenu.Visible = false;
                btExit.Visible = true;
            }
        }

        private void btHome_Click(object sender, EventArgs e)
        {
            // Hiển thị form trang chủ
            if (_isHome) return;

            // Ẩn tất cả các form con đang hiển thị và bật trạng thái Home
            if (_isProfile)
            {
                _isProfile = false;
                _isHome = true;
                _taikhoan.Hide();
            }
            if (_isTable)
            {
                _isTable = false;
                _isHome = true;
                _table.Hide();
            }
            if (_isCategory)
            {
                _isCategory = false;
                _isHome = true;
                _danhmuc.Hide();
            }
            if (_isMenu)
            {
                _isMenu = false;
                _isHome = true;
                _menu.Hide();
            }
            if (_isStaff)
            {
                _isStaff = false;
                _isHome = true;
                _nhanvien.Hide();
            }
            if (_isChart)
            {
                _isChart = false;
                _isHome = true;
                _thongke.Hide();
            }
        }

        private void btAccount_Click(object sender, EventArgs e)
        {
            // Hiển thị form tài khoản
            if (_isProfile) return;

            // Ẩn các form khác nếu đang hiển thị
            if (_isHome)
            {
                _isHome = false;
                _isProfile = true;
                _taikhoan.Hide();
                _taikhoan.TenNV = _tennv;
                _taikhoan.Quyen = _quyennv;
                _taikhoan.MaNV = _manv;
                _taikhoan.TenTK = _tentk;
                OpenChildForm(_taikhoan);
            }

            // Kiểm tra và đóng các form khác để mở form tài khoản
            if (_isTable)
            {
                _isTable = false;
                _isProfile = true;
                _table.Hide();
                OpenChildForm(_taikhoan);
            }
            if (_isCategory)
            {
                _isCategory = false;
                _isProfile = true;
                _danhmuc.Hide();
                OpenChildForm(_taikhoan);
            }
            if (_isMenu)
            {
                _isMenu = false;
                _isProfile = true;
                _menu.Hide();
                OpenChildForm(_taikhoan);
            }
            if (_isStaff)
            {
                _isStaff = false;
                _isProfile = true;
                _nhanvien.Hide();
                OpenChildForm(_taikhoan);
            }
            if (_isChart)
            {
                _isChart = false;
                _isProfile = true;
                _thongke.Hide();
                OpenChildForm(_taikhoan);
            }
        }

        private void btManage_Click(object sender, EventArgs e)
        {
            // Hiển thị form quản lý bàn
            if (_isTable) return;

            // Đóng các form khác nếu đang hiển thị
            if (_isHome)
            {
                _isHome = false;
                _isTable = true;
                _table.MaNV = _manv;
                OpenChildForm(_table);
            }
            if (_isCategory)
            {
                _isCategory = false;
                _isTable = true;
                _danhmuc.Hide();
                OpenChildForm(_table);
            }
            if (_isProfile)
            {
                _isProfile = false;
                _isTable = true;
                _taikhoan.Hide();
                OpenChildForm(_table);
            }
            if (_isStaff)
            {
                _isStaff = false;
                _isTable = true;
                _nhanvien.Hide();
                OpenChildForm(_table);
            }
            if (_isMenu)
            {
                _isMenu = false;
                _isTable = true;
                _menu.Hide();
                OpenChildForm(_table);
            }
            if (_isChart)
            {
                _isChart = false;
                _isTable = true;
                _thongke.Hide();
                OpenChildForm(_table);
            }
        }

        private void btMenu_Click(object sender, EventArgs e)
        {
            // Hiển thị form menu
            if (_isMenu) return;

            // Đóng các form khác nếu đang hiển thị
            if (_isHome)
            {
                _isHome = false;
                _isMenu = true;
                OpenChildForm(_menu);
            }
            if (_isProfile)
            {
                _isProfile = false;
                _isMenu = true;
                _taikhoan.Hide();
                OpenChildForm(_menu);
            }
            if (_isCategory)
            {
                _isCategory = false;
                _isMenu = true;
                _danhmuc.Hide();
                OpenChildForm(_menu);
            }
            if (_isStaff)
            {
                _isStaff = false;
                _isMenu = true;
                _nhanvien.Hide();
                OpenChildForm(_menu);
            }
            if (_isTable)
            {
                _isTable = false;
                _isMenu = true;
                _table.Hide();
                OpenChildForm(_menu);
            }
            if (_isChart)
            {
                _isChart = false;
                _isMenu = true;
                _thongke.Hide();
                OpenChildForm(_menu);
            }
        }

        private void btCategory_Click(object sender, EventArgs e)
        {
            // Hiển thị form danh mục
            if (_isCategory) return;

            // Đóng các form khác nếu đang hiển thị
            if (_isHome)
            {
                _isHome = false;
                _isCategory = true;
                OpenChildForm(_danhmuc);
            }
            if (_isProfile)
            {
                _isProfile = false;
                _isCategory = true;
                _taikhoan.Hide();
                OpenChildForm(_danhmuc);
            }
            if (_isStaff)
            {
                _isStaff = false;
                _isCategory = true;
                _nhanvien.Hide();
                OpenChildForm(_danhmuc);
            }
            if (_isTable)
            {
                _isTable = false;
                _isCategory = true;
                _table.Hide();
                OpenChildForm(_danhmuc);
            }
            if (_isMenu)
            {
                _isMenu = false;
                _isCategory = true;
                _menu.Hide();
                OpenChildForm(_danhmuc);
            }
            if (_isChart)
            {
                _isChart = false;
                _isCategory = true;
                _thongke.Hide();
                OpenChildForm(_danhmuc);
            }
        }

        private void btStaff_Click(object sender, EventArgs e)
        {
            // Hiển thị form nhân viên
            if (_isStaff) return;

            // Đóng các form khác nếu đang hiển thị
            if (_isHome)
            {
                _isHome = false;
                _isStaff = true;
                OpenChildForm(_nhanvien);
            }
            if (_isProfile)
            {
                _isProfile = false;
                _isStaff = true;
                _taikhoan.Hide();
                OpenChildForm(_nhanvien);
            }
            if (_isCategory)
            {
                _isCategory = false;
                _isStaff = true;
                _danhmuc.Hide();
                OpenChildForm(_nhanvien);
            }
            if (_isTable)
            {
                _isTable = false;
                _isStaff = true;
                _table.Hide();
                OpenChildForm(_nhanvien);
            }
            if (_isMenu)
            {
                _isMenu = false;
                _isStaff = true;
                _menu.Hide();
                OpenChildForm(_nhanvien);
            }
            if (_isChart)
            {
                _isChart = false;
                _isStaff = true;
                _thongke.Hide();
                OpenChildForm(_nhanvien);
            }
        }

        private void btStatistic_Click(object sender, EventArgs e)
        {
            // Hiển thị form thống kê
            if (_isChart) return;

            // Đóng các form khác nếu đang hiển thị
            if (_isHome)
            {
                _isHome = false;
                _isChart = true;
                OpenChildForm(_thongke);
            }
            if (_isCategory)
            {
                _isCategory = false;
                _isChart = true;
                _danhmuc.Hide();
                OpenChildForm(_thongke);
            }
            if (_isProfile)
            {
                _isProfile = false;
                _isChart = true;
                _taikhoan.Hide();
                OpenChildForm(_thongke);
            }
            if (_isTable)
            {
                _isTable = false;
                _isChart = true;
                _table.Hide();
                OpenChildForm(_thongke);
            }
            if (_isMenu)
            {
                _isMenu = false;
                _isChart = true;
                _menu.Hide();
                OpenChildForm(_thongke);
            }
            if (_isStaff)
            {
                _isStaff = false;
                _isChart = true;
                _thongke.Hide();
                OpenChildForm(_thongke);
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            // Đóng ứng dụng
            CloseChildForm();
            Close();

        }

        private void CloseChildForm()
        {
            if (_activeForm != null)
            {
                _activeForm.Close();
                _activeForm = null;
            }
        }
    }
}
