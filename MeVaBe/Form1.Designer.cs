namespace MeVaBe
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lsvDanhSach = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.cmbMatHang = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ngườiDùngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNdDangNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNdDoiMatKhau = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNdDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNdThemNguoiDung = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDm = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDmMatHang = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDmNhaCungCap = new System.Windows.Forms.ToolStripMenuItem();
            this.nhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBc = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBcNhapHang = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBcXuatHang = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuBcTonKho = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuBcDoanhThu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTg = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTgCachSuDung = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTgGioiThieu = new System.Windows.Forms.ToolStripMenuItem();
            this.lblXinChao = new System.Windows.Forms.Label();
            this.lblLoiChuc = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblThoiGian = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lsvDanhSach
            // 
            this.lsvDanhSach.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lsvDanhSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvDanhSach.FullRowSelect = true;
            this.lsvDanhSach.GridLines = true;
            this.lsvDanhSach.HideSelection = false;
            this.lsvDanhSach.Location = new System.Drawing.Point(12, 92);
            this.lsvDanhSach.Name = "lsvDanhSach";
            this.lsvDanhSach.Size = new System.Drawing.Size(666, 221);
            this.lsvDanhSach.TabIndex = 7;
            this.lsvDanhSach.UseCompatibleStateImageBehavior = false;
            this.lsvDanhSach.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Đơn giá";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Số lượng";
            this.columnHeader4.Width = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mặt hàng(*)";
            // 
            // cmbMatHang
            // 
            this.cmbMatHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMatHang.FormattingEnabled = true;
            this.cmbMatHang.Location = new System.Drawing.Point(225, 45);
            this.cmbMatHang.Name = "cmbMatHang";
            this.cmbMatHang.Size = new System.Drawing.Size(295, 28);
            this.cmbMatHang.TabIndex = 6;
            this.cmbMatHang.SelectedIndexChanged += new System.EventHandler(this.cmbMatHang_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ngườiDùngToolStripMenuItem,
            this.menuDm,
            this.menuBc,
            this.menuTg});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(690, 27);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ngườiDùngToolStripMenuItem
            // 
            this.ngườiDùngToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ngườiDùngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNdDangNhap,
            this.menuNdDoiMatKhau,
            this.menuNdDangXuat,
            this.menuNdThemNguoiDung});
            this.ngườiDùngToolStripMenuItem.Image = global::MeVaBe.Properties.Resources.App;
            this.ngườiDùngToolStripMenuItem.Name = "ngườiDùngToolStripMenuItem";
            this.ngườiDùngToolStripMenuItem.Size = new System.Drawing.Size(110, 23);
            this.ngườiDùngToolStripMenuItem.Text = "Người dùng";
            // 
            // menuNdDangNhap
            // 
            this.menuNdDangNhap.Image = global::MeVaBe.Properties.Resources.PasswordOn;
            this.menuNdDangNhap.Name = "menuNdDangNhap";
            this.menuNdDangNhap.Size = new System.Drawing.Size(187, 24);
            this.menuNdDangNhap.Text = "Đăng nhập";
            this.menuNdDangNhap.Click += new System.EventHandler(this.menuNdDangNhap_Click);
            // 
            // menuNdDoiMatKhau
            // 
            this.menuNdDoiMatKhau.Image = global::MeVaBe.Properties.Resources.logoff;
            this.menuNdDoiMatKhau.Name = "menuNdDoiMatKhau";
            this.menuNdDoiMatKhau.Size = new System.Drawing.Size(187, 24);
            this.menuNdDoiMatKhau.Text = "Đổi mật khẩu";
            this.menuNdDoiMatKhau.Click += new System.EventHandler(this.menuNdDoiMatKhau_Click);
            // 
            // menuNdDangXuat
            // 
            this.menuNdDangXuat.Image = global::MeVaBe.Properties.Resources.exit;
            this.menuNdDangXuat.Name = "menuNdDangXuat";
            this.menuNdDangXuat.Size = new System.Drawing.Size(187, 24);
            this.menuNdDangXuat.Text = "Close";
            this.menuNdDangXuat.Click += new System.EventHandler(this.menuNdDangXuat_Click);
            // 
            // menuNdThemNguoiDung
            // 
            this.menuNdThemNguoiDung.Image = global::MeVaBe.Properties.Resources.generic_messenger;
            this.menuNdThemNguoiDung.Name = "menuNdThemNguoiDung";
            this.menuNdThemNguoiDung.Size = new System.Drawing.Size(187, 24);
            this.menuNdThemNguoiDung.Text = "Thêm người dùng";
            this.menuNdThemNguoiDung.Click += new System.EventHandler(this.menuNdThemNguoiDung_Click);
            // 
            // menuDm
            // 
            this.menuDm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.menuDm.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDmMatHang,
            this.menuDmNhaCungCap,
            this.nhToolStripMenuItem});
            this.menuDm.Image = global::MeVaBe.Properties.Resources.folder_open_16;
            this.menuDm.Name = "menuDm";
            this.menuDm.Size = new System.Drawing.Size(100, 23);
            this.menuDm.Text = "Danh mục";
            // 
            // menuDmMatHang
            // 
            this.menuDmMatHang.Name = "menuDmMatHang";
            this.menuDmMatHang.Size = new System.Drawing.Size(152, 24);
            this.menuDmMatHang.Text = "Sản phẩm";
            this.menuDmMatHang.Click += new System.EventHandler(this.menuDmMatHang_Click);
            // 
            // menuDmNhaCungCap
            // 
            this.menuDmNhaCungCap.Image = global::MeVaBe.Properties.Resources.Home;
            this.menuDmNhaCungCap.Name = "menuDmNhaCungCap";
            this.menuDmNhaCungCap.Size = new System.Drawing.Size(152, 24);
            this.menuDmNhaCungCap.Text = "Shop";
            this.menuDmNhaCungCap.Click += new System.EventHandler(this.menuDmNhaCungCap_Click);
            // 
            // nhToolStripMenuItem
            // 
            this.nhToolStripMenuItem.Image = global::MeVaBe.Properties.Resources.App1;
            this.nhToolStripMenuItem.Name = "nhToolStripMenuItem";
            this.nhToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.nhToolStripMenuItem.Text = "Nhân viên";
            this.nhToolStripMenuItem.Click += new System.EventHandler(this.nhToolStripMenuItem_Click);
            // 
            // menuBc
            // 
            this.menuBc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.menuBc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuBcNhapHang,
            this.menuBcXuatHang,
            this.toolStripMenuItem1,
            this.menuBcTonKho,
            this.toolStripMenuItem2,
            this.menuBcDoanhThu});
            this.menuBc.Image = global::MeVaBe.Properties.Resources.Thongke;
            this.menuBc.Name = "menuBc";
            this.menuBc.Size = new System.Drawing.Size(85, 23);
            this.menuBc.Text = "Báo cáo";
            // 
            // menuBcNhapHang
            // 
            this.menuBcNhapHang.Image = global::MeVaBe.Properties.Resources.window_plus;
            this.menuBcNhapHang.Name = "menuBcNhapHang";
            this.menuBcNhapHang.Size = new System.Drawing.Size(152, 24);
            this.menuBcNhapHang.Text = "Nhập hàng";
            this.menuBcNhapHang.Click += new System.EventHandler(this.menuBcNhapHang_Click);
            // 
            // menuBcXuatHang
            // 
            this.menuBcXuatHang.Image = global::MeVaBe.Properties.Resources.text;
            this.menuBcXuatHang.Name = "menuBcXuatHang";
            this.menuBcXuatHang.Size = new System.Drawing.Size(152, 24);
            this.menuBcXuatHang.Text = "Xuất hàng";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // menuBcTonKho
            // 
            this.menuBcTonKho.Image = global::MeVaBe.Properties.Resources.PrintPreview;
            this.menuBcTonKho.Name = "menuBcTonKho";
            this.menuBcTonKho.Size = new System.Drawing.Size(152, 24);
            this.menuBcTonKho.Text = "Tồn kho";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(149, 6);
            // 
            // menuBcDoanhThu
            // 
            this.menuBcDoanhThu.Image = global::MeVaBe.Properties.Resources.ok;
            this.menuBcDoanhThu.Name = "menuBcDoanhThu";
            this.menuBcDoanhThu.Size = new System.Drawing.Size(152, 24);
            this.menuBcDoanhThu.Text = "Danh thu";
            // 
            // menuTg
            // 
            this.menuTg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.menuTg.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuTgCachSuDung,
            this.menuTgGioiThieu});
            this.menuTg.Image = global::MeVaBe.Properties.Resources.help;
            this.menuTg.Name = "menuTg";
            this.menuTg.Size = new System.Drawing.Size(87, 23);
            this.menuTg.Text = "Trợ giúp";
            // 
            // menuTgCachSuDung
            // 
            this.menuTgCachSuDung.Image = global::MeVaBe.Properties.Resources.d2;
            this.menuTgCachSuDung.Name = "menuTgCachSuDung";
            this.menuTgCachSuDung.Size = new System.Drawing.Size(220, 24);
            this.menuTgCachSuDung.Text = "Cách sử dụng";
            // 
            // menuTgGioiThieu
            // 
            this.menuTgGioiThieu.Image = global::MeVaBe.Properties.Resources.text1;
            this.menuTgGioiThieu.Name = "menuTgGioiThieu";
            this.menuTgGioiThieu.Size = new System.Drawing.Size(220, 24);
            this.menuTgGioiThieu.Text = "Giới thiệu chương trình";
            // 
            // lblXinChao
            // 
            this.lblXinChao.AutoSize = true;
            this.lblXinChao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXinChao.Location = new System.Drawing.Point(573, 31);
            this.lblXinChao.Name = "lblXinChao";
            this.lblXinChao.Size = new System.Drawing.Size(71, 15);
            this.lblXinChao.TabIndex = 8;
            this.lblXinChao.Text = "Xin chào: ";
            // 
            // lblLoiChuc
            // 
            this.lblLoiChuc.AutoSize = true;
            this.lblLoiChuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoiChuc.Location = new System.Drawing.Point(539, 318);
            this.lblLoiChuc.Name = "lblLoiChuc";
            this.lblLoiChuc.Size = new System.Drawing.Size(0, 17);
            this.lblLoiChuc.TabIndex = 9;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblThoiGian
            // 
            this.lblThoiGian.AutoSize = true;
            this.lblThoiGian.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThoiGian.Location = new System.Drawing.Point(9, 318);
            this.lblThoiGian.Name = "lblThoiGian";
            this.lblThoiGian.Size = new System.Drawing.Size(0, 17);
            this.lblThoiGian.TabIndex = 9;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(690, 338);
            this.Controls.Add(this.lblThoiGian);
            this.Controls.Add(this.lblLoiChuc);
            this.Controls.Add(this.lblXinChao);
            this.Controls.Add(this.lsvDanhSach);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbMatHang);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shop_Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lsvDanhSach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem menuTgGioiThieu;
        private System.Windows.Forms.ToolStripMenuItem menuTgCachSuDung;
        private System.Windows.Forms.ToolStripMenuItem menuTg;
        private System.Windows.Forms.ToolStripMenuItem menuBcDoanhThu;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem menuBcTonKho;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menuBcXuatHang;
        private System.Windows.Forms.ComboBox cmbMatHang;
        private System.Windows.Forms.ToolStripMenuItem menuBcNhapHang;
        private System.Windows.Forms.ToolStripMenuItem menuDmNhaCungCap;
        private System.Windows.Forms.ToolStripMenuItem menuDmMatHang;
        private System.Windows.Forms.ToolStripMenuItem menuDm;
        private System.Windows.Forms.ToolStripMenuItem menuNdThemNguoiDung;
        private System.Windows.Forms.ToolStripMenuItem menuNdDangXuat;
        private System.Windows.Forms.ToolStripMenuItem menuNdDoiMatKhau;
        private System.Windows.Forms.ToolStripMenuItem menuNdDangNhap;
        private System.Windows.Forms.ToolStripMenuItem ngườiDùngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuBc;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ToolStripMenuItem nhToolStripMenuItem;
        private System.Windows.Forms.Label lblXinChao;
        private System.Windows.Forms.Label lblLoiChuc;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblThoiGian;

    }
}

