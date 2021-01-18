using BUS_QuanLyGiay;
using DTO_QuayLyGiay;
using GUI_QuanLyGiay.SanPham;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace GUI_QuanLyGiay.HoaDon
{
    public partial class Tool_ChonSanPham : Form
    {
        int mov, movX, movY;
        public String maHoaDon { get; set; }
        BUS_Giay busGiay = new BUS_Giay();
        BUS_ThuongHieu busThuongHieu = new BUS_ThuongHieu();
        public bool isClickThoat { get; set; }
        public Tool_ChonSanPham()
        {
            InitializeComponent();
            loadDataGiay();
            loadDataSapXepCombobox();
            loadDataLocThuongHieuCombobox();
            this.isClickThoat = false;
        }
        public Tool_ChonSanPham(String maHoaDon)
        {
            InitializeComponent();
            loadDataGiay();
            loadDataSapXepCombobox();
            loadDataLocThuongHieuCombobox();
            this.maHoaDon = maHoaDon;
            this.isClickThoat = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void loadDataGiay()
        {
            lvwGiay.Clear();
            lvwGiay.Columns.Add("Hình ảnh", 80);
            lvwGiay.Columns.Add("STT", 50);
            lvwGiay.Columns.Add("Mã", 70);
            lvwGiay.Columns.Add("Tên", 100);
            lvwGiay.Columns.Add("Giới tính", 60);
            lvwGiay.Columns.Add("Thương hiệu", 110);
            lvwGiay.Columns.Add("Mô tả", 100);
            lvwGiay.Columns.Add("Khuyến mãi (%)", 100);
            lvwGiay.Columns.Add("Số lượng", 70);
            lvwGiay.Columns.Add("Giá (VND)", 100);

            lvwGiay.FullRowSelect = true;
            lvwGiay.View = View.Details;
            ImageList imgList = new ImageList();
            imgList.ImageSize = new Size(80, 80);

            int stt = 0;
            foreach (DataRow row in busGiay.getViewDetailGiay().Rows)
            {
                stt++;
                ListViewItem item = new ListViewItem();
                item.SubItems.Add(stt.ToString());
                item.SubItems.Add(row[0].ToString());
                item.SubItems.Add(row[1].ToString());
                item.SubItems.Add(row[2].ToString());
                item.SubItems.Add(row[3].ToString());
                item.SubItems.Add(row[4].ToString());
                item.SubItems.Add(row[6].ToString());
                item.SubItems.Add(row[7].ToString());
                item.SubItems.Add(row[8].ToString());

                MemoryStream memoryStream = new MemoryStream((Byte[])row[5]);
                Image img = Image.FromStream(memoryStream);
                imgList.Images.Add(img);
                lvwGiay.SmallImageList = imgList;
                item.ImageIndex = stt - 1;
                lvwGiay.Items.Add(item);
            }
        }
        private void QLSanPham_Load(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
        public void loadDataSapXepCombobox()
        {
            Dictionary<string, string> sapXeps = new Dictionary<string, string>();
            sapXeps.Add("GIAY.GIA ASC", "Giá tăng dần");
            sapXeps.Add("GIAY.GIA DESC", "Giá giảm dần");
            sapXeps.Add("GIAY.SOLUONG ASC", "Số lượng tăng dần");
            sapXeps.Add("GIAY.SOLUONG DESC", "Số lượng Giảm dần");
            sapXeps.Add("KHUYENMAI.PHANTRAMGIAMGIA ASC", "Khuyến mãi tăng dần");
            sapXeps.Add("KHUYENMAI.PHANTRAMGIAMGIA DESC", "Khuyến mãi giảm dần");
            cbbSapXep.DataSource = new BindingSource(sapXeps, null);
            cbbSapXep.DisplayMember = "Value";
            cbbSapXep.ValueMember = "Key";
        }
        public void loadDataLocThuongHieuCombobox()
        {
            List<DTO_ThuongHieu> thuongHieus = new List<DTO_ThuongHieu>();
            thuongHieus.Add(new DTO_ThuongHieu("THUONGHIEU.MATHUONGHIEU", "Tất cả"));
            foreach (DataRow row in busThuongHieu.getAllThuongHieu().Rows)
            {
                DTO_ThuongHieu th = new DTO_ThuongHieu();
                th.maThuongHieu = row["MATHUONGHIEU"].ToString();
                th.tenThuongHieu = row["TENTHUONGHIEU"].ToString();
                thuongHieus.Add(th);
            }
            cbbLocThuongHieu.DataSource = thuongHieus;
            cbbLocThuongHieu.DisplayMember = "tenThuongHieu";
        }
         private void cbbSapXep_SelectedIndexChanged(object sender, EventArgs e)
        {
            string value = ((KeyValuePair<string, string>)cbbSapXep.SelectedItem).Key;
            lvwGiay.Clear();
            lvwGiay.Columns.Add("Hình ảnh", 80);
            lvwGiay.Columns.Add("STT", 50);
            lvwGiay.Columns.Add("Mã", 70);
            lvwGiay.Columns.Add("Tên", 100);
            lvwGiay.Columns.Add("Giới tính", 60);
            lvwGiay.Columns.Add("Thương hiệu", 110);
            lvwGiay.Columns.Add("Mô tả", 100);
            lvwGiay.Columns.Add("Khuyến mãi (%)", 100);
            lvwGiay.Columns.Add("Số lượng", 70);
            lvwGiay.Columns.Add("Giá (VND)", 100);

            lvwGiay.FullRowSelect = true;
            lvwGiay.View = View.Details;
            ImageList imgList = new ImageList();
            imgList.ImageSize = new Size(80, 80);

            int stt = 0;
            foreach (DataRow row in busGiay.getSapXepTheo(value).Rows)
            {
                stt++;
                ListViewItem item = new ListViewItem();
                item.SubItems.Add(stt.ToString());
                item.SubItems.Add(row[0].ToString());
                item.SubItems.Add(row[1].ToString());
                item.SubItems.Add(row[2].ToString());
                item.SubItems.Add(row[3].ToString());
                item.SubItems.Add(row[4].ToString());
                item.SubItems.Add(row[6].ToString());
                item.SubItems.Add(row[7].ToString());
                item.SubItems.Add(row[8].ToString());

                MemoryStream memoryStream = new MemoryStream((Byte[])row[5]);
                Image img = Image.FromStream(memoryStream);
                imgList.Images.Add(img);
                lvwGiay.SmallImageList = imgList;
                item.ImageIndex = stt - 1;
                lvwGiay.Items.Add(item);
            }
        }
        private void cbbLocThuongHieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            String searchBy = ((DTO_ThuongHieu)cbbLocThuongHieu.SelectedItem).maThuongHieu;
            if (!searchBy.Equals("THUONGHIEU.MATHUONGHIEU"))
            {
                searchBy = "'" + searchBy + "'";
            }
            lvwGiay.Clear();
            lvwGiay.Columns.Add("Hình ảnh", 80);
            lvwGiay.Columns.Add("STT", 50);
            lvwGiay.Columns.Add("Mã", 70);
            lvwGiay.Columns.Add("Tên", 100);
            lvwGiay.Columns.Add("Giới tính", 60);
            lvwGiay.Columns.Add("Thương hiệu", 110);
            lvwGiay.Columns.Add("Mô tả", 100);
            lvwGiay.Columns.Add("Khuyến mãi (%)", 100);
            lvwGiay.Columns.Add("Số lượng", 70);
            lvwGiay.Columns.Add("Giá (VND)", 100);

            lvwGiay.FullRowSelect = true;
            lvwGiay.View = View.Details;
            ImageList imgList = new ImageList();
            imgList.ImageSize = new Size(80, 80);

            int stt = 0;
            foreach (DataRow row in busThuongHieu.getThuongHieuSearch(searchBy).Rows)
            {
                stt++;
                ListViewItem item = new ListViewItem();
                item.SubItems.Add(stt.ToString());
                item.SubItems.Add(row[0].ToString());
                item.SubItems.Add(row[1].ToString());
                item.SubItems.Add(row[2].ToString());
                item.SubItems.Add(row[3].ToString());
                item.SubItems.Add(row[4].ToString());
                item.SubItems.Add(row[6].ToString());
                item.SubItems.Add(row[7].ToString());
                item.SubItems.Add(row[8].ToString());

                MemoryStream memoryStream = new MemoryStream((Byte[])row[5]);
                Image img = Image.FromStream(memoryStream);
                imgList.Images.Add(img);
                lvwGiay.SmallImageList = imgList;
                item.ImageIndex = stt - 1;
                lvwGiay.Items.Add(item);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (lvwGiay.SelectedItems.Count > 0)
            {
                ListViewItem item = lvwGiay.SelectedItems[0];
                String maGiay = item.SubItems[2].Text;
                int soLuong = int.Parse(item.SubItems[8].Text);
                float gia = float.Parse(item.SubItems[9].Text);
                float phanTramGiamGia = float.Parse(item.SubItems[7].Text);

                Tool_NhapSoLuong toolNhapSoLuong = new Tool_NhapSoLuong(maGiay, soLuong, this.maHoaDon, phanTramGiamGia, gia);
                toolNhapSoLuong.ShowDialog();
                if(toolNhapSoLuong.isClickThem)
                {
                    loadDataGiay();
                }
            }
        }

        private void Tool_ChonSanPham_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void Tool_ChonSanPham_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void Tool_ChonSanPham_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }
    }
}
