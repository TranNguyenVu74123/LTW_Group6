<<<<<<< HEAD
﻿using CNPM.Models;
using DevExpress.XtraEditors;
=======
﻿using DevExpress.XtraEditors;
>>>>>>> 75f0c27dec2f7ddd1064c30c9c7fa0f52557fa47
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
<<<<<<< HEAD
using System.Runtime.Remoting.Contexts;
=======
>>>>>>> 75f0c27dec2f7ddd1064c30c9c7fa0f52557fa47
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNPM
{
    public partial class HangHoa : DevExpress.XtraEditors.XtraForm
    {
<<<<<<< HEAD
        static TiemTapHoaContextDB context = new TiemTapHoaContextDB();
        public bool isThoat = true;
        public event EventHandler DangXuat;
        private TaiKhoan taiKhoan;
        public HangHoa(TaiKhoan loggedInUser)
        {
            InitializeComponent();
            taiKhoan = loggedInUser;
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DangXuat(this, new EventArgs());
        }

        private void HangHoa_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isThoat)
                Application.Exit();
        }

        private void HangHoa_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isThoat)
            {
                if (MessageBox.Show("Bạn muốn thoát chương trình", "Cảnh báo", MessageBoxButtons.YesNo) != DialogResult.Yes)
                {
                    e.Cancel = true;
                }
            }
        }

        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongTinTaiKhoan tttk = new ThongTinTaiKhoan(taiKhoan);
            tttk.ShowDialog();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult tb = MessageBox.Show("Bạn có muốn thoát hay không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (tb == DialogResult.OK)
            {
                Application.Exit();
            }
=======
        public HangHoa()
        {
            InitializeComponent();
        }
        //Sự kiện sửa hàng
        private void btnSuaHang_Click(object sender, EventArgs e)
        {
            ThemXoaHang txh = new ThemXoaHang();
            txh.Show();
        }
        //Sự kiện thêm hàng
        private void btnThemHang_Click(object sender, EventArgs e)
        {
            ThemXoaHang txh = new ThemXoaHang();
            txh.Show();
        }
        /*
        //Hàm kiểm tra tên mặt hàng đã có tên trong danh sách hay chưa
        private int GetSelectedRow(string TenKH)//sửa
        {
            for (int i = 0; i < edgvDanhSachKhachHang.Rows.Count; i++)//sửa
            {
                if (dgvDanhSachKhachHang.Rows[i].Cells[0].Value.ToString() == TenKH)//sửa
                {
                    return i;
                }
            }
            return -1;
        }*/
        //Sự kiện xóa hàng
        private void btnXoaHang_Click(object sender, EventArgs e)
        {
            /*try
            {
                int selectedRow = GetSelectedRow(txtTenKH.Text);//sửa
                if(selectedRow == -1)
                {
                    throw new Exception("Không tìm thấy mặt hàng cần xóa");
                }
                else
                {
                    DialogResult dr = MessageBox.Show("Bạn có muốn xóa?", "YES/NO", MessageBoxButtons.YesNo);
                    if(dr == DialogResult.Yes) {
                        dgvStudent.Rows.RemoveAt(selectedRow); //Xóa thông tin mặt hàng (sửa)
                        MessageBox.Show("Xóa mặt hàng thành công!", "Thông báo", MessageBoxButtons.OK);
                    }
                }
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); //có thể sửa
            }*/
>>>>>>> 75f0c27dec2f7ddd1064c30c9c7fa0f52557fa47
        }
    }
}