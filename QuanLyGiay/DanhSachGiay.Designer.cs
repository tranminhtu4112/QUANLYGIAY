
namespace QuanLyGiay
{
    partial class DanhSachGiay
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvDanhSach = new System.Windows.Forms.DataGridView();
            this.txbMa = new System.Windows.Forms.TextBox();
            this.txbTen = new System.Windows.Forms.TextBox();
            this.txbMota = new System.Windows.Forms.TextBox();
            this.txbGia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.cbbMaLoai = new System.Windows.Forms.ComboBox();
            this.btnThemMaLoai = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbGioiTinhGiay = new System.Windows.Forms.ComboBox();
            this.btnThenGioiTInhGiay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDanhSach
            // 
            this.dgvDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSach.Location = new System.Drawing.Point(23, 12);
            this.dgvDanhSach.Name = "dgvDanhSach";
            this.dgvDanhSach.RowTemplate.Height = 25;
            this.dgvDanhSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSach.Size = new System.Drawing.Size(618, 207);
            this.dgvDanhSach.TabIndex = 0;
            // 
            // txbMa
            // 
            this.txbMa.Location = new System.Drawing.Point(90, 249);
            this.txbMa.Name = "txbMa";
            this.txbMa.Size = new System.Drawing.Size(137, 23);
            this.txbMa.TabIndex = 1;
            // 
            // txbTen
            // 
            this.txbTen.Location = new System.Drawing.Point(90, 307);
            this.txbTen.Name = "txbTen";
            this.txbTen.Size = new System.Drawing.Size(137, 23);
            this.txbTen.TabIndex = 1;
            // 
            // txbMota
            // 
            this.txbMota.Location = new System.Drawing.Point(90, 371);
            this.txbMota.Name = "txbMota";
            this.txbMota.Size = new System.Drawing.Size(137, 23);
            this.txbMota.TabIndex = 1;
            // 
            // txbGia
            // 
            this.txbGia.Location = new System.Drawing.Point(90, 400);
            this.txbGia.Name = "txbGia";
            this.txbGia.Size = new System.Drawing.Size(137, 23);
            this.txbGia.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã giày";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã loại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 374);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mô tả";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 403);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Giá";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(90, 430);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(137, 23);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(248, 400);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(137, 23);
            this.btnSua.TabIndex = 4;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(248, 430);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(137, 23);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // cbbMaLoai
            // 
            this.cbbMaLoai.FormattingEnabled = true;
            this.cbbMaLoai.Location = new System.Drawing.Point(90, 278);
            this.cbbMaLoai.Name = "cbbMaLoai";
            this.cbbMaLoai.Size = new System.Drawing.Size(137, 23);
            this.cbbMaLoai.TabIndex = 5;
            // 
            // btnThemMaLoai
            // 
            this.btnThemMaLoai.Location = new System.Drawing.Point(248, 278);
            this.btnThemMaLoai.Name = "btnThemMaLoai";
            this.btnThemMaLoai.Size = new System.Drawing.Size(137, 23);
            this.btnThemMaLoai.TabIndex = 4;
            this.btnThemMaLoai.Text = "Thêm Mã Loại";
            this.btnThemMaLoai.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 340);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Giới tính";
            // 
            // cbbGioiTinhGiay
            // 
            this.cbbGioiTinhGiay.FormattingEnabled = true;
            this.cbbGioiTinhGiay.Location = new System.Drawing.Point(90, 340);
            this.cbbGioiTinhGiay.Name = "cbbGioiTinhGiay";
            this.cbbGioiTinhGiay.Size = new System.Drawing.Size(137, 23);
            this.cbbGioiTinhGiay.TabIndex = 7;
            // 
            // btnThenGioiTInhGiay
            // 
            this.btnThenGioiTInhGiay.Location = new System.Drawing.Point(248, 340);
            this.btnThenGioiTInhGiay.Name = "btnThenGioiTInhGiay";
            this.btnThenGioiTInhGiay.Size = new System.Drawing.Size(137, 23);
            this.btnThenGioiTInhGiay.TabIndex = 4;
            this.btnThenGioiTInhGiay.Text = "Thêm Giới Tính GIày";
            this.btnThenGioiTInhGiay.UseVisualStyleBackColor = true;
            // 
            // DanhSachGiay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 461);
            this.Controls.Add(this.cbbGioiTinhGiay);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbbMaLoai);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThenGioiTInhGiay);
            this.Controls.Add(this.btnThemMaLoai);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbGia);
            this.Controls.Add(this.txbTen);
            this.Controls.Add(this.txbMota);
            this.Controls.Add(this.txbMa);
            this.Controls.Add(this.dgvDanhSach);
            this.Name = "DanhSachGiay";
            this.Text = "Danh Sách Giày";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDanhSach;
        private System.Windows.Forms.TextBox txbMa;
        private System.Windows.Forms.TextBox txbTen;
        private System.Windows.Forms.TextBox txbMota;
        private System.Windows.Forms.TextBox txbGia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.ComboBox cbbMaLoai;
        private System.Windows.Forms.Button btnThemMaLoai;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbbGioiTinhGiay;
        private System.Windows.Forms.Button btnThenGioiTInhGiay;
    }
}

