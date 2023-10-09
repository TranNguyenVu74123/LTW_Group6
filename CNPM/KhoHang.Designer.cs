namespace CNPM
{
    partial class frmKhoHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKhoHang));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbThem = new System.Windows.Forms.ToolStripButton();
            this.tsbSua = new System.Windows.Forms.ToolStripButton();
            this.tsbXoa = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tsbQLNhaCungCap = new System.Windows.Forms.ToolStripLabel();
            this.dgvHangHoa = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.cbxNhaCungCap = new System.Windows.Forms.ComboBox();
            this.txtSLNhap = new DevExpress.XtraEditors.TextEdit();
            this.label14 = new System.Windows.Forms.Label();
            this.txtGiaNhapHang = new DevExpress.XtraEditors.TextEdit();
            this.txtDVT = new DevExpress.XtraEditors.TextEdit();
            this.txtTenHT = new DevExpress.XtraEditors.TextEdit();
            this.txtMaHT = new DevExpress.XtraEditors.TextEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTimKiem = new DevExpress.XtraEditors.TextEdit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangHoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSLNhap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiaNhapHang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDVT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenHT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaHT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTimKiem.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbThem,
            this.tsbSua,
            this.tsbXoa,
            this.toolStripLabel1,
            this.tsbQLNhaCungCap});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1227, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbThem
            // 
            this.tsbThem.Image = global::CNPM.Properties.Resources._1024px_OOjs_UI_icon_add;
            this.tsbThem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbThem.Name = "tsbThem";
            this.tsbThem.Size = new System.Drawing.Size(123, 24);
            this.tsbThem.Text = "Thêm hàng hóa";
            this.tsbThem.Click += new System.EventHandler(this.tsbThem_Click);
            // 
            // tsbSua
            // 
            this.tsbSua.Image = ((System.Drawing.Image)(resources.GetObject("tsbSua.Image")));
            this.tsbSua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSua.Name = "tsbSua";
            this.tsbSua.Size = new System.Drawing.Size(113, 24);
            this.tsbSua.Text = "Sửa hàng hóa";
            this.tsbSua.Click += new System.EventHandler(this.tsbSua_Click);
            // 
            // tsbXoa
            // 
            this.tsbXoa.Image = ((System.Drawing.Image)(resources.GetObject("tsbXoa.Image")));
            this.tsbXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbXoa.Name = "tsbXoa";
            this.tsbXoa.Size = new System.Drawing.Size(114, 24);
            this.tsbXoa.Text = "Xóa hàng hóa";
            this.tsbXoa.Click += new System.EventHandler(this.tsbXoa_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLabel1.Image")));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(70, 24);
            this.toolStripLabel1.Text = "Quay về";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // tsbQLNhaCungCap
            // 
            this.tsbQLNhaCungCap.Image = ((System.Drawing.Image)(resources.GetObject("tsbQLNhaCungCap.Image")));
            this.tsbQLNhaCungCap.Name = "tsbQLNhaCungCap";
            this.tsbQLNhaCungCap.Size = new System.Drawing.Size(161, 24);
            this.tsbQLNhaCungCap.Text = "Quản lý Nhà Cung Cấp";
            this.tsbQLNhaCungCap.Click += new System.EventHandler(this.tsbQLNhaCungCap_Click);
            // 
            // dgvHangHoa
            // 
            this.dgvHangHoa.AllowUserToAddRows = false;
            this.dgvHangHoa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHangHoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHangHoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column8,
            this.Column7});
            this.dgvHangHoa.Location = new System.Drawing.Point(33, 315);
            this.dgvHangHoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvHangHoa.Name = "dgvHangHoa";
            this.dgvHangHoa.ReadOnly = true;
            this.dgvHangHoa.RowHeadersWidth = 51;
            this.dgvHangHoa.RowTemplate.Height = 24;
            this.dgvHangHoa.Size = new System.Drawing.Size(1140, 411);
            this.dgvHangHoa.TabIndex = 4;
            this.dgvHangHoa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHangHoa_CellClick);
            // 
            // Column1
            // 
            this.Column1.FillWeight = 51.58464F;
            this.Column1.HeaderText = "Mã hàng tồn";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 83.89371F;
            this.Column2.HeaderText = "Tên mặt hàng";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 79.32456F;
            this.Column3.HeaderText = "Đơn vị tính";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.FillWeight = 87.88004F;
            this.Column4.HeaderText = "Giá nhập hàng";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.FillWeight = 119.8671F;
            this.Column5.HeaderText = "Số lượng nhập";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Mã NCC";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.FillWeight = 123.6336F;
            this.Column7.HeaderText = "Nhà cung cấp";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 25F);
            this.label1.Location = new System.Drawing.Point(583, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 41);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kho Hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(326, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tìm kiếm";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.cbxNhaCungCap);
            this.groupControl1.Controls.Add(this.txtSLNhap);
            this.groupControl1.Controls.Add(this.label14);
            this.groupControl1.Controls.Add(this.txtGiaNhapHang);
            this.groupControl1.Controls.Add(this.txtDVT);
            this.groupControl1.Controls.Add(this.txtTenHT);
            this.groupControl1.Controls.Add(this.txtMaHT);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.label7);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Location = new System.Drawing.Point(33, 93);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1140, 203);
            this.groupControl1.TabIndex = 7;
            this.groupControl1.Text = "Thông tin hàng hóa";
            // 
            // cbxNhaCungCap
            // 
            this.cbxNhaCungCap.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxNhaCungCap.FormattingEnabled = true;
            this.cbxNhaCungCap.Location = new System.Drawing.Point(768, 148);
            this.cbxNhaCungCap.Name = "cbxNhaCungCap";
            this.cbxNhaCungCap.Size = new System.Drawing.Size(290, 27);
            this.cbxNhaCungCap.TabIndex = 2;
            // 
            // txtSLNhap
            // 
            this.txtSLNhap.Location = new System.Drawing.Point(768, 103);
            this.txtSLNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSLNhap.Name = "txtSLNhap";
            this.txtSLNhap.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSLNhap.Properties.Appearance.Options.UseFont = true;
            this.txtSLNhap.Size = new System.Drawing.Size(290, 26);
            this.txtSLNhap.TabIndex = 1;
            this.txtSLNhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSLNhap_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(645, 150);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(111, 19);
            this.label14.TabIndex = 0;
            this.label14.Text = "Nhà Cung Cấp";
            // 
            // txtGiaNhapHang
            // 
            this.txtGiaNhapHang.Location = new System.Drawing.Point(768, 63);
            this.txtGiaNhapHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGiaNhapHang.Name = "txtGiaNhapHang";
            this.txtGiaNhapHang.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaNhapHang.Properties.Appearance.Options.UseFont = true;
            this.txtGiaNhapHang.Size = new System.Drawing.Size(290, 26);
            this.txtGiaNhapHang.TabIndex = 1;
            this.txtGiaNhapHang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiaNhapHang_KeyPress);
            // 
            // txtDVT
            // 
            this.txtDVT.Location = new System.Drawing.Point(135, 148);
            this.txtDVT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDVT.Name = "txtDVT";
            this.txtDVT.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDVT.Properties.Appearance.Options.UseFont = true;
            this.txtDVT.Size = new System.Drawing.Size(270, 26);
            this.txtDVT.TabIndex = 1;
            this.txtDVT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDVT_KeyPress);
            // 
            // txtTenHT
            // 
            this.txtTenHT.Location = new System.Drawing.Point(135, 103);
            this.txtTenHT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenHT.Name = "txtTenHT";
            this.txtTenHT.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenHT.Properties.Appearance.Options.UseFont = true;
            this.txtTenHT.Size = new System.Drawing.Size(311, 26);
            this.txtTenHT.TabIndex = 1;
            this.txtTenHT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTenHT_KeyPress);
            // 
            // txtMaHT
            // 
            this.txtMaHT.Location = new System.Drawing.Point(135, 63);
            this.txtMaHT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaHT.Name = "txtMaHT";
            this.txtMaHT.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHT.Properties.Appearance.Options.UseFont = true;
            this.txtMaHT.Size = new System.Drawing.Size(270, 26);
            this.txtMaHT.TabIndex = 1;
            this.txtMaHT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaHT_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(645, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Giá nhập hàng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(645, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "Số lượng nhập";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Đơn vị tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tên hàng hóa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã hàng hóa";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(11, 34);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtTimKiem.Properties.Appearance.Options.UseFont = true;
            this.txtTimKiem.Size = new System.Drawing.Size(309, 26);
            this.txtTimKiem.TabIndex = 2;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // frmKhoHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1227, 756);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvHangHoa);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmKhoHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KhoHang";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmKhoHang_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangHoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSLNhap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiaNhapHang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDVT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenHT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaHT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTimKiem.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbThem;
        private System.Windows.Forms.ToolStripButton tsbSua;
        private System.Windows.Forms.ToolStripButton tsbXoa;
        private DevExpress.XtraEditors.TextEdit txtTimKiem;
        private System.Windows.Forms.DataGridView dgvHangHoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit txtSLNhap;
        private DevExpress.XtraEditors.TextEdit txtGiaNhapHang;
        private DevExpress.XtraEditors.TextEdit txtDVT;
        private DevExpress.XtraEditors.TextEdit txtTenHT;
        private DevExpress.XtraEditors.TextEdit txtMaHT;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.ComboBox cbxNhaCungCap;
        private System.Windows.Forms.ToolStripLabel tsbQLNhaCungCap;
    }
}