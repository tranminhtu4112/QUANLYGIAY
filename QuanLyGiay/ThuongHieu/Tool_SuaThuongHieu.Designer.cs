
namespace GUI_QuanLyGiay
{
    partial class Tool_SuaThuongHieu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tool_SuaThuongHieu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ptbHinh = new System.Windows.Forms.PictureBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuuMoi = new System.Windows.Forms.Button();
            this.btnChonAnh = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txbMoTa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbTenThuongHieu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbMaThuongHieu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbHinh)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.ptbHinh);
            this.panel1.Controls.Add(this.btnHuy);
            this.panel1.Controls.Add(this.btnLuuMoi);
            this.panel1.Controls.Add(this.btnChonAnh);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txbMoTa);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txbTenThuongHieu);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txbMaThuongHieu);
            this.panel1.Location = new System.Drawing.Point(5, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(598, 300);
            this.panel1.TabIndex = 0;
            // 
            // ptbHinh
            // 
            this.ptbHinh.Location = new System.Drawing.Point(402, 66);
            this.ptbHinh.Name = "ptbHinh";
            this.ptbHinh.Size = new System.Drawing.Size(146, 118);
            this.ptbHinh.TabIndex = 3;
            this.ptbHinh.TabStop = false;
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.Gainsboro;
            this.btnHuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHuy.FlatAppearance.BorderSize = 0;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHuy.Location = new System.Drawing.Point(306, 250);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(113, 38);
            this.btnHuy.TabIndex = 2;
            this.btnHuy.Text = "Hủy bỏ";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuuMoi
            // 
            this.btnLuuMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnLuuMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuuMoi.FlatAppearance.BorderSize = 0;
            this.btnLuuMoi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(126)))), ((int)(((byte)(20)))));
            this.btnLuuMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuuMoi.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLuuMoi.Location = new System.Drawing.Point(456, 250);
            this.btnLuuMoi.Name = "btnLuuMoi";
            this.btnLuuMoi.Size = new System.Drawing.Size(113, 38);
            this.btnLuuMoi.TabIndex = 2;
            this.btnLuuMoi.Text = "Lưu mới";
            this.btnLuuMoi.UseVisualStyleBackColor = false;
            this.btnLuuMoi.Click += new System.EventHandler(this.btnLuuMoi_Click);
            // 
            // btnChonAnh
            // 
            this.btnChonAnh.Location = new System.Drawing.Point(402, 37);
            this.btnChonAnh.Name = "btnChonAnh";
            this.btnChonAnh.Size = new System.Drawing.Size(146, 23);
            this.btnChonAnh.TabIndex = 2;
            this.btnChonAnh.Text = "Chọn ảnh";
            this.btnChonAnh.UseVisualStyleBackColor = true;
            this.btnChonAnh.Click += new System.EventHandler(this.btnChonAnh_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(45, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Mô tả";
            // 
            // txbMoTa
            // 
            this.txbMoTa.Location = new System.Drawing.Point(160, 162);
            this.txbMoTa.Name = "txbMoTa";
            this.txbMoTa.Size = new System.Drawing.Size(173, 23);
            this.txbMoTa.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(45, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên thương hiệu";
            // 
            // txbTenThuongHieu
            // 
            this.txbTenThuongHieu.Location = new System.Drawing.Point(161, 100);
            this.txbTenThuongHieu.Name = "txbTenThuongHieu";
            this.txbTenThuongHieu.Size = new System.Drawing.Size(173, 23);
            this.txbTenThuongHieu.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(45, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã thương hiệu";
            // 
            // txbMaThuongHieu
            // 
            this.txbMaThuongHieu.Location = new System.Drawing.Point(160, 38);
            this.txbMaThuongHieu.Name = "txbMaThuongHieu";
            this.txbMaThuongHieu.ReadOnly = true;
            this.txbMaThuongHieu.Size = new System.Drawing.Size(173, 23);
            this.txbMaThuongHieu.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(216, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thông tin thương hiệu";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(126)))), ((int)(((byte)(20)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(566, -2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 38);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Tool_SuaThuongHieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.ClientSize = new System.Drawing.Size(609, 343);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Tool_SuaThuongHieu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tool_SuaThuongHieu";
            this.Load += new System.EventHandler(this.Tool_SuaThuongHieu_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Tool_SuaThuongHieu_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Tool_SuaThuongHieu_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Tool_SuaThuongHieu_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbHinh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox ptbHinh;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuuMoi;
        private System.Windows.Forms.Button btnChonAnh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbMoTa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbTenThuongHieu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbMaThuongHieu;
    }
}