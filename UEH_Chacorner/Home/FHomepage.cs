using System;
using System.Windows.Forms;
using UEH_Chacorner.Home;
using UEH_ChaCorner.Home;

namespace UEH_ChaCorner
{
    public partial class FHomepage : Form
    {
        public static FHomepage MainMenu;

        private readonly FRevenue _thongke = new FRevenue();
        private readonly FStaff _nhanvien = new FStaff();
        private readonly FAccount _taikhoan = new FAccount();
        private readonly FCategory _danhmuc = new FCategory();
        private readonly FMenu _menu = new FMenu();
        private readonly FTable _table = new FTable();

        private Form _activeForm;
        private string _manv = "", _quyennv = "", _tennv = "", _tentk = "";
        private bool _isCategory = false;
        private bool _isProfile = false;
        private bool _isStaff = false;
        private bool _isChart = false;
        private bool _isMenu = false;
        private bool _isTable = false;
        private bool _isHome = true;

        public FHomepage()
        {
            InitializeComponent();
            MainMenu = this;
        }

        private void FHomepage_Load(object sender, EventArgs e)
        {
        }

        private void FMainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            var fLogin = new FLogin();
            fLogin.Show();
        }

        private void OpenChildForm(Form childForm)
        {
            _activeForm?.Hide();
            _activeForm = childForm;
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
            // Lấy thông tin tài khoản
            _manv = manv;
            _quyennv = quyennv;
            _tennv = lbUsername.Text = tennv;
            _tentk = tentk;

            // Hiển thị chức năng tương ứng với quyền
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
            if (_isHome) return;
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
            if (_isProfile) return;
            if (_isHome)
            {
                _isHome = false;
                _isProfile = true;
                _taikhoan.TenNV = _tennv;
                _taikhoan.Quyen = _quyennv;
                _taikhoan.MaNV = _manv;
                _taikhoan.TenTK = _tentk;
                OpenChildForm(_taikhoan);
            }
            if (_isTable)
            {
                _isTable = false;
                _isProfile = true;
                _table.Hide();
                _taikhoan.TenNV = _tennv;
                _taikhoan.Quyen = _quyennv;
                _taikhoan.MaNV = _manv;
                _taikhoan.TenTK = _tentk;
                OpenChildForm(_taikhoan);
            }
            if (_isCategory)
            {
                _isTable = false;
                _isProfile = true;
                _danhmuc.Hide();
                _taikhoan.TenNV = _tennv;
                _taikhoan.Quyen = _quyennv;
                _taikhoan.MaNV = _manv;
                _taikhoan.TenTK = _tentk;
                OpenChildForm(_taikhoan);
            }
            if (_isMenu)
            {
                _isMenu = false;
                _isProfile = true;
                _menu.Hide();
                _taikhoan.TenNV = _tennv;
                _taikhoan.Quyen = _quyennv;
                _taikhoan.MaNV = _manv;
                _taikhoan.TenTK = _tentk;
                OpenChildForm(_taikhoan);
            }
            if (_isStaff)
            {
                _isStaff = false;
                _isProfile = true;
                _nhanvien.Hide();
                _taikhoan.TenNV = _tennv;
                _taikhoan.Quyen = _quyennv;
                _taikhoan.MaNV = _manv;
                _taikhoan.TenTK = _tentk;
                OpenChildForm(_taikhoan);
            }
            if (_isChart)
            {
                _isChart = false;
                _isProfile = true;
                _thongke.Hide();
                _taikhoan.TenNV = _tennv;
                _taikhoan.Quyen = _quyennv;
                _taikhoan.MaNV = _manv;
                _taikhoan.TenTK = _tentk;
                OpenChildForm(_taikhoan);
            }
        }

        private void btManage_Click(object sender, EventArgs e)
        {
            if (_isTable) return;
            if (_isHome)
            {
                _isHome = false;
                _isTable = true;
                _table.MaNV = _manv;
                OpenChildForm(_table);
            }
            if(_isCategory)
            {
                _isCategory = false;
                _isTable = true;
                _danhmuc.Hide();
                _table.MaNV = _manv;
                OpenChildForm(_table);
            }
            if (_isProfile)
            {
                _isProfile = false;
                _isTable = true;
                _taikhoan.Hide();
                _table.MaNV = _manv;
                OpenChildForm(_table);
            }
            if (_isStaff)
            {
                _isStaff = false;
                _isTable = true;
                _nhanvien.Hide();
                _table.MaNV = _manv;
                OpenChildForm(_table);
            }
            if (_isMenu)
            {
                _isMenu = false;
                _isTable = true;
                _menu.Hide();
                _table.MaNV = _manv;
                OpenChildForm(_table);
            }
            if (_isChart)
            {
                _isChart = false;
                _isTable = true;
                _thongke.Hide();
                _table.MaNV = _manv;
                OpenChildForm(_table);
            }

        }

        private void btMenu_Click(object sender, EventArgs e)
        {
            if (_isMenu) return;
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
            if(_isCategory)
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
            if(_isCategory) return;
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
            if (_isStaff) return;
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
            if (_isChart) return;
            if (_isHome)
            {
                _isHome = false;
                _isChart = true;
                _thongke.Hide();
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
            Close();
        }
    }
}