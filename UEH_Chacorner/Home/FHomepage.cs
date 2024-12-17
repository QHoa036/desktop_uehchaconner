using System;
using System.Windows.Forms;
using UEH_ChaCorner.Home;

namespace UEH_ChaCorner
{
    public partial class FHomepage : Form
    {
        public static FHomepage MainMenu;

        private readonly FRevenue _thongke = new FRevenue();
        private readonly FStaff _nhanvien = new FStaff();
        private readonly FAccount _taikhoan = new FAccount();

        private Form _activeForm;
        private string _manv = "", _quyennv = "", _tennv = "";
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

        private void FMainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
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

        internal void setVisible(string quyennv, string tennv, string manv)
        {
            // Lấy thông tin tài khoản
            _manv = manv;
            _quyennv = quyennv;
            _tennv = lbUsername.Text = tennv;

            // Hiển thị chức năng tương ứng với quyền
            switch (quyennv)
            {
                case @"ADMIN":
                    btStaff.Visible = true;
                    btStatistic.Visible = true;
                    btMenu.Visible = true;
                    btManage.Visible = true;
                    btExit.Visible = true;
                    break;

                case @"NhanVien":
                    btManage.Visible = true;
                    btExit.Visible = true;
                    break;
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
                //_table.Hide();
            }
            if (_isMenu)
            {
                _isMenu = false;
                _isHome = true;
                //_menu.Hide();
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
                OpenChildForm(_taikhoan);
            }
            if (_isTable)
            {
                _isTable = false;
                _isProfile = true;
                //_table.Hide();
                _taikhoan.TenNV = _tennv;
                _taikhoan.Quyen = _quyennv;
                _taikhoan.MaNV = _manv;
                OpenChildForm(_taikhoan);
            }
            if (_isMenu)
            {
                _isMenu = false;
                _isProfile = true;
                //_menu.Hide();
                _taikhoan.TenNV = _tennv;
                _taikhoan.Quyen = _quyennv;
                _taikhoan.MaNV = _manv;
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
                OpenChildForm(_taikhoan);
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
            if (_isTable)
            {
                _isTable = false;
                _isStaff = true;
                //_table.Hide();
                OpenChildForm(_nhanvien);
            }
            if (_isMenu)
            {
                _isMenu = false;
                _isStaff = true;
                //_menu.Hide();
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
                //_table.Hide();
                OpenChildForm(_thongke);
            }
            if (_isMenu)
            {
                _isMenu = false;
                _isChart = true;
                //_menu.Hide();
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
            Hide();
            var fLogin = new FLogin();
            fLogin.ShowDialog();
        }
    }
}