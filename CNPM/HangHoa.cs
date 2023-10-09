using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNPM
{
    public partial class HangHoa : DevExpress.XtraEditors.XtraForm
    {
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
        }
    }
}