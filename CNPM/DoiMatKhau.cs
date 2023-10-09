using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using CNPM.Models;

namespace CNPM
{
    public partial class DoiMatKhau : Form
    {
        static TiemTapHoaContextDB context = new TiemTapHoaContextDB();
        public DoiMatKhau()
        {
            InitializeComponent();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            TaiKhoan taiKhoan = context.TaiKhoans.FirstOrDefault(pass => pass.MatKhau == txtOldPass.Text);

            if (txtOldPass.Text != null)
            {
                if (txtOldPass.Text == taiKhoan.MatKhau)
                {
                    if (txtNewPass.Text == txtNewPass2.Text)
                    {
                        lbVerify.ForeColor = Color.Green;
                        lbVerify.Text = "Mật khẩu trùng khớp";

                        taiKhoan.MatKhau = txtNewPass.Text;
                        context.SaveChanges();

                        MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        this.Close();
                        // Hiển thị lại Form1 sau khi đổi mật khẩu thành công
                        Form1 login = Application.OpenForms.OfType<Form1>().FirstOrDefault();
                        if (login != null)
                        {
                            login.Show();
                        }
                    }
                    else
                    {
                        lbVerify.ForeColor = Color.Red;
                        lbVerify.Text = "Mật khẩu chưa khớp";
                        MessageBox.Show("Mật khẩu mới chưa khớp! Vui lòng nhập lại mật khẩu mới.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Mật khẩu đã nhập không khớp với mật khẩu cũ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập mật khẩu cũ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
