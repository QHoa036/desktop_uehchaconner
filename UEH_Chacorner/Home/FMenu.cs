using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UEH_ChaCorner.Home
{
    public partial class FMenu : Form
    {
        private readonly SANPHAM_BLL _sanphamBll = new SANPHAM_BLL();
        private readonly DANHMUCSANPHAM_BLL _danhMucBll = new DANHMUCSANPHAM_BLL();
        private DataTable _menuData;
        public FMenu()
        {
            InitializeComponent();
        }

        private void LoadMenu()
        {
            _menuData = _sanphamBll.Load_SanPham();
        }

        // Event Load form
        private void FMenu_Load(object sender, EventArgs e)
        {
            LoadMenu();
        }
      
    }
}

