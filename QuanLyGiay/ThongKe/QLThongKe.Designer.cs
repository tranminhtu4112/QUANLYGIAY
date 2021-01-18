
namespace GUI_QuanLyGiay.ThongKe
{
    partial class QLThongKe
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QLThongKe));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbLoai = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rbtNgay = new System.Windows.Forms.RadioButton();
            this.dtpNgay = new System.Windows.Forms.DateTimePicker();
            this.rbtThang = new System.Windows.Forms.RadioButton();
            this.dtpThang = new System.Windows.Forms.DateTimePicker();
            this.rbtTuNgay = new System.Windows.Forms.RadioButton();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.lblDen = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.lvwThongKe = new System.Windows.Forms.ListView();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(395, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 32);
            this.label1.TabIndex = 13;
            this.label1.Text = "Thống kê";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(63, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Loại:";
            // 
            // cbbLoai
            // 
            this.cbbLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLoai.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbbLoai.FormattingEnabled = true;
            this.cbbLoai.Location = new System.Drawing.Point(105, 97);
            this.cbbLoai.Name = "cbbLoai";
            this.cbbLoai.Size = new System.Drawing.Size(160, 23);
            this.cbbLoai.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(384, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Thời gian";
            // 
            // rbtNgay
            // 
            this.rbtNgay.AutoSize = true;
            this.rbtNgay.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbtNgay.Location = new System.Drawing.Point(479, 98);
            this.rbtNgay.Name = "rbtNgay";
            this.rbtNgay.Size = new System.Drawing.Size(58, 20);
            this.rbtNgay.TabIndex = 18;
            this.rbtNgay.TabStop = true;
            this.rbtNgay.Text = "Ngày";
            this.rbtNgay.UseVisualStyleBackColor = true;
            this.rbtNgay.CheckedChanged += new System.EventHandler(this.rbtNgay_CheckedChanged);
            // 
            // dtpNgay
            // 
            this.dtpNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgay.Location = new System.Drawing.Point(560, 96);
            this.dtpNgay.Name = "dtpNgay";
            this.dtpNgay.Size = new System.Drawing.Size(137, 23);
            this.dtpNgay.TabIndex = 19;
            // 
            // rbtThang
            // 
            this.rbtThang.AutoSize = true;
            this.rbtThang.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbtThang.Location = new System.Drawing.Point(479, 130);
            this.rbtThang.Name = "rbtThang";
            this.rbtThang.Size = new System.Drawing.Size(67, 20);
            this.rbtThang.TabIndex = 18;
            this.rbtThang.TabStop = true;
            this.rbtThang.Text = "Tháng";
            this.rbtThang.UseVisualStyleBackColor = true;
            this.rbtThang.CheckedChanged += new System.EventHandler(this.rbtThang_CheckedChanged);
            // 
            // dtpThang
            // 
            this.dtpThang.CustomFormat = "MM/yyyy";
            this.dtpThang.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpThang.Location = new System.Drawing.Point(560, 128);
            this.dtpThang.Name = "dtpThang";
            this.dtpThang.Size = new System.Drawing.Size(137, 23);
            this.dtpThang.TabIndex = 19;
            // 
            // rbtTuNgay
            // 
            this.rbtTuNgay.AutoSize = true;
            this.rbtTuNgay.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbtTuNgay.Location = new System.Drawing.Point(479, 163);
            this.rbtTuNgay.Name = "rbtTuNgay";
            this.rbtTuNgay.Size = new System.Drawing.Size(77, 20);
            this.rbtTuNgay.TabIndex = 18;
            this.rbtTuNgay.TabStop = true;
            this.rbtTuNgay.Text = "Từ ngày";
            this.rbtTuNgay.UseVisualStyleBackColor = true;
            this.rbtTuNgay.CheckedChanged += new System.EventHandler(this.rbtTuNgay_CheckedChanged);
            // 
            // dtpFrom
            // 
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(560, 161);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(137, 23);
            this.dtpFrom.TabIndex = 19;
            // 
            // lblDen
            // 
            this.lblDen.AutoSize = true;
            this.lblDen.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDen.Location = new System.Drawing.Point(713, 165);
            this.lblDen.Name = "lblDen";
            this.lblDen.Size = new System.Drawing.Size(32, 16);
            this.lblDen.TabIndex = 17;
            this.lblDen.Text = "đến";
            // 
            // dtpTo
            // 
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(750, 161);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(137, 23);
            this.dtpTo.TabIndex = 19;
            // 
            // btnThongKe
            // 
            this.btnThongKe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(121)))), ((int)(((byte)(255)))));
            this.btnThongKe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThongKe.FlatAppearance.BorderSize = 0;
            this.btnThongKe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKe.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnThongKe.ForeColor = System.Drawing.Color.White;
            this.btnThongKe.Image = ((System.Drawing.Image)(resources.GetObject("btnThongKe.Image")));
            this.btnThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKe.Location = new System.Drawing.Point(783, 214);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(104, 36);
            this.btnThongKe.TabIndex = 20;
            this.btnThongKe.Text = "      Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = false;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // lvwThongKe
            // 
            this.lvwThongKe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lvwThongKe.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lvwThongKe.GridLines = true;
            this.lvwThongKe.HideSelection = false;
            this.lvwThongKe.HoverSelection = true;
            this.lvwThongKe.Location = new System.Drawing.Point(63, 214);
            this.lvwThongKe.Name = "lvwThongKe";
            this.lvwThongKe.Size = new System.Drawing.Size(693, 366);
            this.lvwThongKe.TabIndex = 21;
            this.lvwThongKe.UseCompatibleStateImageBehavior = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(348, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 23);
            this.label4.TabIndex = 17;
            this.label4.Text = "Bảng thống kê";
            // 
            // QLThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.lvwThongKe);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.dtpThang);
            this.Controls.Add(this.dtpNgay);
            this.Controls.Add(this.rbtTuNgay);
            this.Controls.Add(this.rbtThang);
            this.Controls.Add(this.rbtNgay);
            this.Controls.Add(this.lblDen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbbLoai);
            this.Controls.Add(this.label1);
            this.Name = "QLThongKe";
            this.Size = new System.Drawing.Size(953, 613);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbLoai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbtNgay;
        private System.Windows.Forms.DateTimePicker dtpNgay;
        private System.Windows.Forms.RadioButton rbtThang;
        private System.Windows.Forms.DateTimePicker dtpThang;
        private System.Windows.Forms.RadioButton rbtTuNgay;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label lblDen;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.ListView lvwThongKe;
        private System.Windows.Forms.Label label4;
    }
}
