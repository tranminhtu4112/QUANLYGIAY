namespace QuanLyGiay
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.btnHoaDon = new System.Windows.Forms.Button();
            this.btnDonDatHang = new System.Windows.Forms.Button();
            this.btnKhuyenMai = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnQLGioiTinh = new System.Windows.Forms.Button();
            this.btnQLThuongHieu = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txbChaoNhanVien = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTenHeThong = new System.Windows.Forms.Label();
            this.button13 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.qlGioiTinh1 = new GUI_QuanLyGiay.GioiTinh.QLGioiTinh();
            this.qlThuongHieu1 = new GUI_QuanLyGiay.QLThuongHieu();
            this.qlHoaDon1 = new GUI_QuanLyGiay.HoaDon.QLHoaDon();
            this.qlSanPham1 = new GUI_QuanLyGiay.QLSanPham();
            this.qlKhuyenMai1 = new GUI_QuanLyGiay.KhuyenMai.QLKhuyenMai();
            this.trangChu1 = new GUI_QuanLyGiay.TrangChu();
            this.qlThongKe1 = new GUI_QuanLyGiay.ThongKe.QLThongKe();
            this.qlDonDatHang1 = new GUI_QuanLyGiay.DonDatHang.QLDonDatHang();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnThongKe);
            this.panel1.Controls.Add(this.SidePanel);
            this.panel1.Controls.Add(this.btnHoaDon);
            this.panel1.Controls.Add(this.btnDonDatHang);
            this.panel1.Controls.Add(this.btnKhuyenMai);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnQLGioiTinh);
            this.panel1.Controls.Add(this.btnQLThuongHieu);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(244, 673);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(64, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(98, 67);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btnThongKe
            // 
            this.btnThongKe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThongKe.FlatAppearance.BorderSize = 0;
            this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKe.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnThongKe.ForeColor = System.Drawing.Color.White;
            this.btnThongKe.Image = ((System.Drawing.Image)(resources.GetObject("btnThongKe.Image")));
            this.btnThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKe.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnThongKe.Location = new System.Drawing.Point(13, 510);
            this.btnThongKe.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(230, 62);
            this.btnThongKe.TabIndex = 5;
            this.btnThongKe.Text = "       Thống kê doanh thu";
            this.btnThongKe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.SidePanel.Location = new System.Drawing.Point(1, 70);
            this.SidePanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(12, 62);
            this.SidePanel.TabIndex = 4;
            // 
            // btnHoaDon
            // 
            this.btnHoaDon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHoaDon.FlatAppearance.BorderSize = 0;
            this.btnHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoaDon.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHoaDon.ForeColor = System.Drawing.Color.White;
            this.btnHoaDon.Image = ((System.Drawing.Image)(resources.GetObject("btnHoaDon.Image")));
            this.btnHoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHoaDon.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnHoaDon.Location = new System.Drawing.Point(14, 442);
            this.btnHoaDon.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnHoaDon.Name = "btnHoaDon";
            this.btnHoaDon.Size = new System.Drawing.Size(230, 62);
            this.btnHoaDon.TabIndex = 4;
            this.btnHoaDon.Text = "       Hóa đơn";
            this.btnHoaDon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHoaDon.UseVisualStyleBackColor = true;
            this.btnHoaDon.Click += new System.EventHandler(this.btnHoaDon_Click);
            // 
            // btnDonDatHang
            // 
            this.btnDonDatHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDonDatHang.FlatAppearance.BorderSize = 0;
            this.btnDonDatHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDonDatHang.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDonDatHang.ForeColor = System.Drawing.Color.White;
            this.btnDonDatHang.Image = ((System.Drawing.Image)(resources.GetObject("btnDonDatHang.Image")));
            this.btnDonDatHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDonDatHang.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDonDatHang.Location = new System.Drawing.Point(14, 380);
            this.btnDonDatHang.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDonDatHang.Name = "btnDonDatHang";
            this.btnDonDatHang.Size = new System.Drawing.Size(230, 62);
            this.btnDonDatHang.TabIndex = 4;
            this.btnDonDatHang.Text = "       Đơn đặt hàng";
            this.btnDonDatHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDonDatHang.UseVisualStyleBackColor = true;
            this.btnDonDatHang.Click += new System.EventHandler(this.btnDonDatHang_Click);
            // 
            // btnKhuyenMai
            // 
            this.btnKhuyenMai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKhuyenMai.FlatAppearance.BorderSize = 0;
            this.btnKhuyenMai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKhuyenMai.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnKhuyenMai.ForeColor = System.Drawing.Color.White;
            this.btnKhuyenMai.Image = ((System.Drawing.Image)(resources.GetObject("btnKhuyenMai.Image")));
            this.btnKhuyenMai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKhuyenMai.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnKhuyenMai.Location = new System.Drawing.Point(14, 317);
            this.btnKhuyenMai.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnKhuyenMai.Name = "btnKhuyenMai";
            this.btnKhuyenMai.Size = new System.Drawing.Size(230, 62);
            this.btnKhuyenMai.TabIndex = 4;
            this.btnKhuyenMai.Text = "       Khuyến mãi";
            this.btnKhuyenMai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKhuyenMai.UseVisualStyleBackColor = true;
            this.btnKhuyenMai.Click += new System.EventHandler(this.btnKhuyenMai_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(14, 70);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(230, 62);
            this.button1.TabIndex = 4;
            this.button1.Text = "       Trang chủ";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnQLGioiTinh
            // 
            this.btnQLGioiTinh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQLGioiTinh.FlatAppearance.BorderSize = 0;
            this.btnQLGioiTinh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLGioiTinh.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnQLGioiTinh.ForeColor = System.Drawing.Color.White;
            this.btnQLGioiTinh.Image = ((System.Drawing.Image)(resources.GetObject("btnQLGioiTinh.Image")));
            this.btnQLGioiTinh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLGioiTinh.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnQLGioiTinh.Location = new System.Drawing.Point(14, 255);
            this.btnQLGioiTinh.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnQLGioiTinh.Name = "btnQLGioiTinh";
            this.btnQLGioiTinh.Size = new System.Drawing.Size(230, 62);
            this.btnQLGioiTinh.TabIndex = 4;
            this.btnQLGioiTinh.Text = "       Loại giày";
            this.btnQLGioiTinh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQLGioiTinh.UseVisualStyleBackColor = true;
            this.btnQLGioiTinh.Click += new System.EventHandler(this.btnQLGioiTinh_Click);
            // 
            // btnQLThuongHieu
            // 
            this.btnQLThuongHieu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQLThuongHieu.FlatAppearance.BorderSize = 0;
            this.btnQLThuongHieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLThuongHieu.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnQLThuongHieu.ForeColor = System.Drawing.Color.White;
            this.btnQLThuongHieu.Image = ((System.Drawing.Image)(resources.GetObject("btnQLThuongHieu.Image")));
            this.btnQLThuongHieu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLThuongHieu.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnQLThuongHieu.Location = new System.Drawing.Point(14, 193);
            this.btnQLThuongHieu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnQLThuongHieu.Name = "btnQLThuongHieu";
            this.btnQLThuongHieu.Size = new System.Drawing.Size(230, 62);
            this.btnQLThuongHieu.TabIndex = 4;
            this.btnQLThuongHieu.Text = "       Thương hiệu";
            this.btnQLThuongHieu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQLThuongHieu.UseVisualStyleBackColor = true;
            this.btnQLThuongHieu.Click += new System.EventHandler(this.btnQLThuongHieu_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button2.Location = new System.Drawing.Point(14, 130);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(230, 62);
            this.button2.TabIndex = 4;
            this.button2.Text = "       Sản phẩm";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel2.Controls.Add(this.btnDangXuat);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.txbChaoNhanVien);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblTenHeThong);
            this.panel2.Controls.Add(this.button13);
            this.panel2.Controls.Add(this.button11);
            this.panel2.Controls.Add(this.button12);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(244, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(953, 64);
            this.panel2.TabIndex = 1;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDangXuat.FlatAppearance.BorderSize = 0;
            this.btnDangXuat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangXuat.Image = ((System.Drawing.Image)(resources.GetObject("btnDangXuat.Image")));
            this.btnDangXuat.Location = new System.Drawing.Point(148, 7);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(53, 47);
            this.btnDangXuat.TabIndex = 7;
            this.btnDangXuat.UseVisualStyleBackColor = true;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(203, -14);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 78);
            this.panel3.TabIndex = 6;
            // 
            // txbChaoNhanVien
            // 
            this.txbChaoNhanVien.AutoSize = true;
            this.txbChaoNhanVien.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbChaoNhanVien.ForeColor = System.Drawing.Color.White;
            this.txbChaoNhanVien.Location = new System.Drawing.Point(47, 14);
            this.txbChaoNhanVien.Name = "txbChaoNhanVien";
            this.txbChaoNhanVien.Size = new System.Drawing.Size(36, 30);
            this.txbChaoNhanVien.TabIndex = 5;
            this.txbChaoNhanVien.Text = "Tú";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Chào";
            // 
            // lblTenHeThong
            // 
            this.lblTenHeThong.AutoSize = true;
            this.lblTenHeThong.Font = new System.Drawing.Font("Sitka Small", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTenHeThong.ForeColor = System.Drawing.Color.Transparent;
            this.lblTenHeThong.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTenHeThong.Location = new System.Drawing.Point(270, 2);
            this.lblTenHeThong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenHeThong.Name = "lblTenHeThong";
            this.lblTenHeThong.Size = new System.Drawing.Size(399, 48);
            this.lblTenHeThong.TabIndex = 3;
            this.lblTenHeThong.Text = "Hệ Thống Quản Lý Giày";
            this.lblTenHeThong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.button13.FlatAppearance.BorderSize = 0;
            this.button13.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button13.ForeColor = System.Drawing.Color.White;
            this.button13.Image = ((System.Drawing.Image)(resources.GetObject("button13.Image")));
            this.button13.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button13.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button13.Location = new System.Drawing.Point(919, 0);
            this.button13.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(36, 31);
            this.button13.TabIndex = 4;
            this.button13.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button11.ForeColor = System.Drawing.Color.Transparent;
            this.button11.Image = ((System.Drawing.Image)(resources.GetObject("button11.Image")));
            this.button11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button11.Location = new System.Drawing.Point(842, 0);
            this.button11.Margin = new System.Windows.Forms.Padding(0);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(36, 31);
            this.button11.TabIndex = 4;
            this.button11.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click_1);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button12.ForeColor = System.Drawing.Color.White;
            this.button12.Image = ((System.Drawing.Image)(resources.GetObject("button12.Image")));
            this.button12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button12.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button12.Location = new System.Drawing.Point(880, 0);
            this.button12.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(38, 31);
            this.button12.TabIndex = 4;
            this.button12.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button12.UseVisualStyleBackColor = false;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // qlGioiTinh1
            // 
            this.qlGioiTinh1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(153)))));
            this.qlGioiTinh1.Location = new System.Drawing.Point(244, 60);
            this.qlGioiTinh1.Name = "qlGioiTinh1";
            this.qlGioiTinh1.Size = new System.Drawing.Size(953, 623);
            this.qlGioiTinh1.TabIndex = 2;
            // 
            // qlThuongHieu1
            // 
            this.qlThuongHieu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(240)))));
            this.qlThuongHieu1.Location = new System.Drawing.Point(244, 60);
            this.qlThuongHieu1.Name = "qlThuongHieu1";
            this.qlThuongHieu1.Size = new System.Drawing.Size(953, 613);
            this.qlThuongHieu1.TabIndex = 3;
            // 
            // qlHoaDon1
            // 
            this.qlHoaDon1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(229)))));
            this.qlHoaDon1.Location = new System.Drawing.Point(244, 60);
            this.qlHoaDon1.Name = "qlHoaDon1";
            this.qlHoaDon1.Size = new System.Drawing.Size(953, 613);
            this.qlHoaDon1.TabIndex = 4;
            // 
            // qlSanPham1
            // 
            this.qlSanPham1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(204)))));
            this.qlSanPham1.Location = new System.Drawing.Point(244, 60);
            this.qlSanPham1.Name = "qlSanPham1";
            this.qlSanPham1.Size = new System.Drawing.Size(953, 613);
            this.qlSanPham1.TabIndex = 5;
            // 
            // qlKhuyenMai1
            // 
            this.qlKhuyenMai1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.qlKhuyenMai1.Location = new System.Drawing.Point(244, 60);
            this.qlKhuyenMai1.Name = "qlKhuyenMai1";
            this.qlKhuyenMai1.Size = new System.Drawing.Size(953, 613);
            this.qlKhuyenMai1.TabIndex = 6;
            // 
            // trangChu1
            // 
            this.trangChu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.trangChu1.Location = new System.Drawing.Point(244, 60);
            this.trangChu1.Name = "trangChu1";
            this.trangChu1.Size = new System.Drawing.Size(953, 613);
            this.trangChu1.TabIndex = 7;
            // 
            // qlThongKe1
            // 
            this.qlThongKe1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.qlThongKe1.Location = new System.Drawing.Point(244, 60);
            this.qlThongKe1.Name = "qlThongKe1";
            this.qlThongKe1.Size = new System.Drawing.Size(953, 613);
            this.qlThongKe1.TabIndex = 8;
            // 
            // qlDonDatHang1
            // 
            this.qlDonDatHang1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.qlDonDatHang1.Location = new System.Drawing.Point(244, 60);
            this.qlDonDatHang1.Name = "qlDonDatHang1";
            this.qlDonDatHang1.Size = new System.Drawing.Size(953, 613);
            this.qlDonDatHang1.TabIndex = 9;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 673);
            this.Controls.Add(this.qlDonDatHang1);
            this.Controls.Add(this.qlThongKe1);
            this.Controls.Add(this.trangChu1);
            this.Controls.Add(this.qlKhuyenMai1);
            this.Controls.Add(this.qlSanPham1);
            this.Controls.Add(this.qlHoaDon1);
            this.Controls.Add(this.qlThuongHieu1);
            this.Controls.Add(this.qlGioiTinh1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button btnHoaDon;
        private System.Windows.Forms.Button btnDonDatHang;
        private System.Windows.Forms.Button btnKhuyenMai;
        private System.Windows.Forms.Button btnQLGioiTinh;
        private System.Windows.Forms.Button btnQLThuongHieu;
        private System.Windows.Forms.Label lblTenHeThong;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        public System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label txbChaoNhanVien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.PictureBox pictureBox1;
        private GUI_QuanLyGiay.GioiTinh.QLGioiTinh qlGioiTinh1;
        private GUI_QuanLyGiay.QLThuongHieu qlThuongHieu1;
        private GUI_QuanLyGiay.QLSanPham qlSanPham1;
        private GUI_QuanLyGiay.HoaDon.QLHoaDon qlHoaDon1;
        private GUI_QuanLyGiay.KhuyenMai.QLKhuyenMai qlKhuyenMai1;
        private GUI_QuanLyGiay.DonDatHang.QLDonDatHang qlDonDatHang1;
        private GUI_QuanLyGiay.ThongKe.QLThongKe qlThongKe1;
        private GUI_QuanLyGiay.TrangChu trangChu1;
    }
}

