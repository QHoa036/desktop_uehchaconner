using System;
using System.Windows.Forms;
using UEH_ChaCorner.Home;

namespace UEH_ChaCorner
{
    public partial class FHomepage : Form
    {
        public static FHomepage MainMenu;

        private readonly FRevenue _thongke = new FRevenue();
        private readonly FManageStaff _nhanvien = new FManageStaff();

        private Form _activeForm;
        private bool _bbanan, _bmenu, _bnhanvien, _bthongke, _bhomepage;
        private string _manv = "", _quyennv = "", _tennv = "";

        public FHomepage()
        {
            InitializeComponent();
            MainMenu = this;
        }

        private void FMainMenu_Load(object sender, EventArgs e)
        {
            initialVisible();
            var dn = new FLogin();
            dn.FormClosing += dn.FLogin_FormClosing;
            dn.ShowDialog();
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

        private void initialVisible()
        {
            btStaff.Visible = false;
            btStatistic.Visible = false;
            btMenu.Visible = false;
            btManage.Visible = false;
            btExit.Visible = false;
        }

        internal void setVisible(string quyennv, string tennv, string idnv)
        {
            // Lấy thông tin tài khoản
            _manv = idnv;
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

        private void btAccount_Click(object sender, EventArgs e)
        {
            var dn = new FAccount { TenNV = _tennv, Quyen = _quyennv, MaNV = _manv };
            dn.FormClosing += dn.FAccount_FormClosing;
            dn.ShowDialog();
        }

        private void btHome_Click(object sender, EventArgs e)
        {
            // trở về trang chủ
            if (_bnhanvien)
            {
                _bnhanvien = false;
                _nhanvien.Hide();
                _bhomepage = true;
            }
            else if (_bthongke)
            {
                _bthongke = false;
                _thongke.Hide();
                _bhomepage = true;
            }
            else if (_bmenu)
            {
                _bmenu = false;
                _bhomepage = true;
            }
            else if (_bbanan)
            {
                _bbanan = false;
                _bhomepage = true;
            }
            else
            {
                _bhomepage = true;
            }
        }

        private void btStaff_Click(object sender, EventArgs e)
        {
            if (_bmenu)
            {
                _bmenu = false;
                _bnhanvien = true;
                OpenChildForm(_nhanvien);
            }
            else if (_bbanan)
            {
                _bbanan = false;
                _bnhanvien = true;
                OpenChildForm(_nhanvien);
            }
            else if (_bthongke)
            {
                _bthongke = false;
                _thongke.Hide();
                _bnhanvien = true;
                OpenChildForm(_nhanvien);
            }
            else
            {
                _bnhanvien = true;
                OpenChildForm(_nhanvien);
            }
        }

        private void btStatistic_Click(object sender, EventArgs e)
        {
            if (_bbanan)
            {
                _bbanan = false;
                _bthongke = true;
                OpenChildForm(_thongke);
            }
            else if (_bmenu)
            {
                _bmenu = false;
                _bthongke = true;
                OpenChildForm(_thongke);
            }
            else if (_bnhanvien)
            {
                _bnhanvien = false;
                _nhanvien.Hide();
                _bthongke = true;
                OpenChildForm(_thongke);
            }
            else
            {
                _bthongke = true;
                OpenChildForm(_thongke);
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Hide();
            var h = new FHomepage();
            h.ShowDialog();
            Application.Exit();
        }
    }
}