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
using System.Data.Entity;
using System.Data.Entity.Core;
using CNPM.Models;

namespace CNPM
{
    public partial class frmNhaCungCap : DevExpress.XtraEditors.XtraForm
    {
        public HangHoaDBContext context = new HangHoaDBContext();
        public frmNhaCungCap()
        {
            InitializeComponent();
        }
        //Load nhà cung cấp lên datagridview khi mở form
        private void frmNhaCungCap_Load(object sender, EventArgs e)
        {
            List<NhaCungCap1> listNhaCungCap = context.NhaCungCaps.ToList();
            BindGrid(listNhaCungCap);
        }
        //Hàm binding gridView list nhà cung cấp
        private void BindGrid(List<NhaCungCap1> listNhaCungCap)
        {
            dgvDanhSachNhaCungCap.Rows.Clear();
            foreach (var item in listNhaCungCap)
            {
                int index = dgvDanhSachNhaCungCap.Rows.Add();
                dgvDanhSachNhaCungCap.Rows[index].Cells[0].Value = item.MaNCC;
                dgvDanhSachNhaCungCap.Rows[index].Cells[1].Value = item.TenNCC;
                dgvDanhSachNhaCungCap.Rows[index].Cells[2].Value = item.sdt;
            }
        }
        //hàm reset về giá trị mặc định
        public void resetNull()
        {
            txtMaNCC.Text = txtTenNCC.Text = txtSDT.Text = string.Empty;
        }
        //hàm thêm
        public void insert(int row)
        {
            NhaCungCap1 ncc = new NhaCungCap1()
            {
                MaNCC = txtMaNCC.Text,
                TenNCC = txtTenNCC.Text,
                sdt = txtSDT.Text,
            };
            context.NhaCungCaps.Add(ncc);
            context.SaveChanges();
        }
        //hàm sửa
        public void update(int row)
        {
            List<NhaCungCap1> listNhaCungCap = context.NhaCungCaps.ToList(); //lấy danh sách nhà cung cấp   
            NhaCungCap1 dbUpdate = context.NhaCungCaps.FirstOrDefault(p => p.MaNCC == txtMaNCC.Text);
            if (dbUpdate != null)
            {
                dbUpdate.TenNCC = txtTenNCC.Text;
                dbUpdate.sdt = txtSDT.Text;
                context.SaveChanges();
                BindGrid(listNhaCungCap);
            }
        }
        //hàm kiểm tra ms khoa đã có chưa
        private int GetSelectedRow(string MaNCC)
        {
            for (int i = 0; i < dgvDanhSachNhaCungCap.Rows.Count; i++)
            {
                if (dgvDanhSachNhaCungCap.Rows[i].Cells[0].Value.ToString() == MaNCC)
                {
                    return i;
                }
            }
            return -1;
        }
        //hàm thêm\sửa hàng hóa
        private void btnThemSua_Click(object sender, EventArgs e)
        {
            int row = GetSelectedRow(txtMaNCC.Text);
            
            if (row == -1)
            {
                row = dgvDanhSachNhaCungCap.Rows.Add();
                insert(row);
                List<NhaCungCap1> listNhaCungCap = context.NhaCungCaps.ToList();
                BindGrid(listNhaCungCap);
                resetNull();
                MessageBox.Show("Đã thêm thành công", "Thông báo");
            }
            else
            {
                update(row);
                resetNull();
                MessageBox.Show("Đã sửa thành công", "Thông báo");
            }
        }
        //hàm xóa
        private void btnXoa_Click(object sender, EventArgs e)
        {
            NhaCungCap1 dbDelete = context.NhaCungCaps.FirstOrDefault(p => p.MaNCC == txtMaNCC.Text);
            if (dbDelete != null)
            {
                DialogResult dr = MessageBox.Show("Bạn chắc muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    //kiểm tra trong khoa còn sinh viên hay ko
                    //Khoa còn sinh viên
                    if (dbDelete != null && context.HangTons.Count(s => s.MaNCC == dbDelete.MaNCC) > 0)
                    {
                        DialogResult d = MessageBox.Show("Mặt hàng này vẫn còn, nếu xóa thì  mục nhà cung cấp của hàng tồn đó sẽ thành [Chưa có]. Bạn vẫn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (d == DialogResult.Yes)
                        {
                            //xóa sinh viên rồi xóa khoa
                            NhaCungCap1 ncc = context.NhaCungCaps.Include(n => n.HangTons).FirstOrDefault(n => n.MaNCC == dbDelete.MaNCC);
                            dbDelete.TenNCC = "[Chưa có]";
                            context.NhaCungCaps.Remove(dbDelete);
                            context.SaveChanges();
                            List<NhaCungCap1> listNhaCungCap = context.NhaCungCaps.ToList();
                            BindGrid(listNhaCungCap);
                            resetNull();
                            MessageBox.Show("Đã xóa thành công", "Thông báo", MessageBoxButtons.OK);
                        }
                    }
                    else
                    {
                        //xóa khoa
                        context.NhaCungCaps.Remove(dbDelete);
                        context.SaveChanges();
                        List<NhaCungCap1> listNhaCungCap = context.NhaCungCaps.ToList();
                        BindGrid(listNhaCungCap);
                        resetNull();
                        MessageBox.Show("Đã xóa thành công", "Thông báo", MessageBoxButtons.OK);
                    }
                }
            }
        }
        //hàm thoát
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            frmKhoHang f = new frmKhoHang();
            f.Show();
        }
        //Hàm chuyển dữ liệu khi click vào 1 hàng trong datagridview sang các textbox trong thông tin nhà cung cấp
        private void dgvDanhSachNhaCungCap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = int.Parse(e.RowIndex.ToString());
            txtMaNCC.Text = dgvDanhSachNhaCungCap[0, index].Value.ToString();
            txtTenNCC.Text = dgvDanhSachNhaCungCap[1, index].Value.ToString();
            txtSDT.Text = dgvDanhSachNhaCungCap[2, index].Value.ToString();
        }
        //hàm kiểm tra ký tự đặc biệt
        private bool IsSpecialCharacter(char character)
        {
            // Kiểm tra ký tự đặc biệt
            char[] specialChars = { '@', '/', ':', ';', '%', '&', '(', ')', '^', '#', '$', '*', '-', '_', '.' };
            return specialChars.Contains(character);
        }
        //hàm kiểm tra mã nhà cung cấp ko được nhập ký tự đặc biệt
        private void txtMaNCC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (IsSpecialCharacter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Không được nhập ký tư đăc biệt", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
        //hàm kiểm tra số điện thoại ko được nhập ký tự đặc biệt và chỉ được nhập số
        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (IsSpecialCharacter(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Không được nhập ký tư đăc biệt và chỉ được nhập số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
        //hàm kiểm tra tên nhà cung cấp ko được nhập ký tự đặc biệt và chỉ được nhập chữ
        private void txtTenNCC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (IsSpecialCharacter(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Không được nhập ký tư đăc biệt và chỉ được nhập chữ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
    }
}  