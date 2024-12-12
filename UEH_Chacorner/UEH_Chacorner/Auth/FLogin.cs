using System;
using System.Threading;
using System.Windows.Forms;

using BLL;
using DTO;

namespace UEH_Chacorner
{
    public partial class FLogin : Form
    {
        private const int CpNocloseButton = 0x200;
        private readonly TAIKHOAN_BLL _accountBll = new TAIKHOAN_BLL();
        private string _quyen = "", _ten = "", _manv = "";

        public FLogin()
        {
            InitializeComponent();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                var myCp = base.CreateParams;
                myCp.ClassStyle |= CpNocloseButton;
                return myCp;
            }
        }

        private void FLogin_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
            AcceptButton = btnLogin;
        }

        public void FLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            FHomepage.Mainmenu.EnableQuyen(_quyen, _ten, _manv);
        }

        private void ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var accountPublic = new TAIKHOAN_DTO { TenTK = txtUsername.Text, MatKhau = txtPassword.Text };
            var checkPass = _accountBll.check_taikhoan(accountPublic);
            switch (checkPass)
            {
                default:
                    {
                        MessageBox.Show(@"Sai tên tài khoản hoặc mật khẩu.", @"Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtUsername.Focus();
                        break;
                    }
                case 1:
                    {
                        var dgvRoleAndName = _accountBll.get_tenvaquyen_taikhoan(accountPublic);
                        _quyen = dgvRoleAndName.Rows[0][0].ToString().Trim();
                        _ten = dgvRoleAndName.Rows[0][1].ToString().Trim();
                        _manv = dgvRoleAndName.Rows[0][2].ToString().Trim();

                        var t = new Thread(splash);
                        t.Start();
                        Thread.Sleep(5600);
                        t.Abort();
                        Close();
                        break;
                    }
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Close();
            var dk = new FRegister();
            dk.ShowDialog();
        }

        private void splash()
        {
            Application.Run(new FLoading());
        }
    }
}