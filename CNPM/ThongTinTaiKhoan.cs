using CNPM.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DevExpress.XtraEditors.Mask.MaskSettings;

namespace CNPM
{
    public partial class ThongTinTaiKhoan : Form
    {
        private TaiKhoan taiKhoan;

        public ThongTinTaiKhoan(TaiKhoan user)
        {
            InitializeComponent();
            taiKhoan = user;
        }

        private void ThongTinTaiKhoan_Load(object sender, EventArgs e)
        {
            txtTenDangNhap.Text = taiKhoan.TenDangNhap;
            txtMatKhau.Text = taiKhoan.MatKhau;
            txtEmail.Text = taiKhoan.Email;
        }

        private void btnTroLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
