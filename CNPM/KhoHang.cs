using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
<<<<<<< HEAD
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNPM
{
    public partial class KhoHang : DevExpress.XtraEditors.XtraForm
    {
        public KhoHang()
        {
            InitializeComponent();
        }

        private void tsbQuanLi_Click(object sender, EventArgs e)
        {

=======
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using CNPM.Model1;

namespace CNPM
{
    public partial class frmKhoHang : DevExpress.XtraEditors.XtraForm
    {
        public HangHoaDBContext context = new HangHoaDBContext();
        
        public frmKhoHang()
        {
            InitializeComponent();
        }
        //Load hàng tồn lên datagridview khi mở form
        private void frmKhoHang_Load(object sender, EventArgs e)
        {
            List<NhaCungCap1> listNhaCungCap = context.NhaCungCaps.ToList(); //lấy nhà cung cấp
            List<HangTon> listHangTon = context.HangTons.ToList(); //láy hàng tồn
            FillFalcultyCombobox(listNhaCungCap);
            BindGrid(listHangTon);
        }
        //hàm reset về giá trị mặc định
        public void resetNull()
        {
            txtMaHT.Text = txtTenHT.Text = txtDVT.Text = txtGiaNhapHang.Text = txtSLNhap.Text = string.Empty;
            cbxNhaCungCap.SelectedIndex = 0;
        }
        //Hàm binding list có tên là tên nhà cung cấp, giá trị là Mã nhà cung cấp
        private void FillFalcultyCombobox(List<NhaCungCap1> listNhaCungCap)
        {
            this.cbxNhaCungCap.DataSource = listNhaCungCap;
            this.cbxNhaCungCap.DisplayMember = "TenNCC";
            this.cbxNhaCungCap.ValueMember = "MaNCC";
        }
        //Hàm binding gridView list hàng tồn
        private void BindGrid(List<HangTon> listHangTon)
        {
            dgvHangHoa.Rows.Clear();
            foreach (var item in listHangTon)
            {
                int index = dgvHangHoa.Rows.Add();
                dgvHangHoa.Rows[index].Cells[0].Value = item.MaHT;
                dgvHangHoa.Rows[index].Cells[1].Value = item.TenHT;
                dgvHangHoa.Rows[index].Cells[2].Value = item.DVT;
                dgvHangHoa.Rows[index].Cells[3].Value = item.GiaNhapHang;
                dgvHangHoa.Rows[index].Cells[4].Value = item.SLHT;
                dgvHangHoa.Rows[index].Cells[5].Value = item.MaNCC;
                dgvHangHoa.Rows[index].Cells[6].Value = item.NhaCungCap.TenNCC;

            }
        }
        //hàm thêm hàng hóa
        private void tsbThem_Click(object sender, EventArgs e)
        {
            HangTon s = new HangTon();
            s.MaHT = txtMaHT.Text;
            s.TenHT = txtTenHT.Text;
            s.DVT = txtDVT.Text;
            s.GiaNhapHang = double.Parse(txtGiaNhapHang.Text);
            s.SLHT = int.Parse(txtSLNhap.Text);
            s.MaNCC = cbxNhaCungCap.SelectedValue.ToString();
            //lưu hàng hóa đã thêm
            context.HangTons.Add(s);
            context.SaveChanges();
            //láy hàng tồn
            List<HangTon> listHangTon = context.HangTons.ToList();
            List<NhaCungCap1> listNhaCungCap = context.NhaCungCaps.ToList();
            FillFalcultyCombobox(listNhaCungCap);
            BindGrid(listHangTon);
            resetNull();
            MessageBox.Show("Đã thêm thành công", "Thông báo", MessageBoxButtons.OK);
        }
        //hàm sửa
        private void tsbSua_Click(object sender, EventArgs e)
        {
            HangTon dbUpdate = context.HangTons.FirstOrDefault(p => p.MaHT == txtMaHT.Text);
            if (dbUpdate != null)
            {
                dbUpdate.TenHT = txtTenHT.Text;
                dbUpdate.DVT = txtDVT.Text;
                dbUpdate.GiaNhapHang = double.Parse(txtGiaNhapHang.Text);
                dbUpdate.SLHT = int.Parse(txtSLNhap.Text);
                dbUpdate.MaNCC = cbxNhaCungCap.SelectedValue.ToString();
                context.SaveChanges();
                List<HangTon> listHangTon = context.HangTons.ToList();
                List<NhaCungCap1> listNhaCungCap = context.NhaCungCaps.ToList();
                FillFalcultyCombobox(listNhaCungCap);
                BindGrid(listHangTon);
                resetNull();
                MessageBox.Show("Đã sửa thành công", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Mã hàng hóa chưa tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        //hàm quay về
        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            Close();
        }
        //hàm xóa hàng hóa
        private void tsbXoa_Click(object sender, EventArgs e)
        {
            HangTon dbDelete = context.HangTons.FirstOrDefault(p => p.MaHT == txtMaHT.Text);
            if (dbDelete != null)
            {
                DialogResult dr = MessageBox.Show("Bạn chắc muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    context.HangTons.Remove(dbDelete);
                    context.SaveChanges();
                    List<HangTon> listHangTon = context.HangTons.ToList();
                    List<NhaCungCap1> listNhaCungCap = context.NhaCungCaps.ToList();
                    FillFalcultyCombobox(listNhaCungCap);
                    BindGrid(listHangTon);
                    resetNull();
                    MessageBox.Show("Đã xóa hàng hóa!", "Thông báo",MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy hàng hóa để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        //tìm kiếm hàng hóa thông qua tên hàng hóa và mã hàng hóa
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            var timkiem  = context.HangTons.Where(p => p.TenHT.Contains(txtTimKiem.Text) || p.MaHT.Equals(txtTimKiem.Text)).ToList();
            BindGrid(timkiem);
        }
        //Hàm chuyển dữ liệu khi click vào 1 hàng trong datagridview sang các textbox trong thông tin hàng hóa
        private void dgvHangHoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = int.Parse(e.RowIndex.ToString());
            txtMaHT.Text= dgvHangHoa[0, index].Value.ToString();
            txtTenHT.Text = dgvHangHoa[1, index].Value.ToString();
            txtDVT.Text = dgvHangHoa[2, index].Value.ToString();
            txtGiaNhapHang.Text = dgvHangHoa[3, index].Value.ToString();
            txtSLNhap.Text = dgvHangHoa[4, index].Value.ToString();
            cbxNhaCungCap.Text = dgvHangHoa[5, index].Value.ToString();
        }
        //mở form quản lý nhà cung cấp
        private void tsbQLNhaCungCap_Click(object sender, EventArgs e)
        {
            frmNhaCungCap ncc = new frmNhaCungCap();
            ncc.Show();
            this.Hide();
        }
        //hàm kiểm tra mã hàng hóa ko được nhập ký tự đặc biệt
        private void txtMaHT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (IsSpecialCharacter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Không được nhập ký tư đăc biệt", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
        //hàm kiểm tra ký tự đặc biệt
        private bool IsSpecialCharacter(char character)
        {
            // Kiểm tra ký tự đặc biệt
            char[] specialChars = { '@', '/', ':', ';','%','&','(', ')','^', '#', '$','*','-', '_', '.'};
            return specialChars.Contains(character);
        }
        //hàm kiểm tra tên hàng hóa ko được nhập ký tự đặc biệt
        private void txtTenHT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (IsSpecialCharacter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Không được nhập ký tư đăc biệt", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
        //hàm kiểm tra đơn vị tính ko được nhập ký tự đặc biệt
        private void txtDVT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (IsSpecialCharacter(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Không được nhập ký tư đăc biệt và chỉ được nhập chữ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
        //hàm kiểm tra giá nhập hàng ko được nhập ký tự đặc biệt và chỉ được nhập bằng số
        private void txtGiaNhapHang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (IsSpecialCharacter(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
                MessageBox.Show("Không được nhập ký tư đăc biệt và chỉ được nhập số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
        //hàm kiểm tra số lượng nhập ko được nhập ký tự đặc biệt và chỉ được nhập bằng số
        private void txtSLNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (IsSpecialCharacter(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Không được nhập ký tư đăc biệt và chỉ được nhập số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
>>>>>>> 75f0c27dec2f7ddd1064c30c9c7fa0f52557fa47
        }
    }
}