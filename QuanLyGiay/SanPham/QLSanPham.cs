using BUS_QuanLyGiay;
using DTO_QuayLyGiay;
using GUI_QuanLyGiay.SanPham;
using GUI_QuanLyGiay.ThuongHieu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace GUI_QuanLyGiay
{
    public partial class QLSanPham : UserControl
    {
        BUS_Giay busGiay = new BUS_Giay();
        public QLSanPham()
        {
            InitializeComponent();
            loadDataGiay();
        }
        public void loadDataGiay()
        {
            lvwGiay.Clear();
            lvwGiay.Columns.Add("Hình ảnh", 110);
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
            imgList.ImageSize = new Size(110, 110);

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
        
        private void btnThem_Click(object sender, EventArgs e)
        {
            Tool_ThemGiay toolThemGiay = new Tool_ThemGiay();
            toolThemGiay.ShowDialog();
            if (toolThemGiay.isClickThem)
            {
                loadDataGiay();
            }
            
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lvwGiay.SelectedItems.Count > 0)
            {
                ListViewItem item = lvwGiay.SelectedItems[0];
                DTO_Giay dtoGiay = new DTO_Giay();
                dtoGiay.maGiay = item.SubItems[2].Text;
                dtoGiay.TenGiay = item.SubItems[3].Text;
                dtoGiay.moTa = item.SubItems[6].Text;
                dtoGiay.soLuong = int.Parse(item.SubItems[8].Text);
                dtoGiay.gia = float.Parse(item.SubItems[9].Text);

                DTO_GioiTinh dtoGioiTinh = new DTO_GioiTinh();
                DTO_ThuongHieu dtoThuongHieu = new DTO_ThuongHieu();
                DTO_KhuyenMai dtoKhuyenMai = new DTO_KhuyenMai();
                dtoGioiTinh.tenGioiTinh = item.SubItems[4].Text;
                dtoThuongHieu.tenThuongHieu = item.SubItems[5].Text;
                dtoKhuyenMai.phanTramGiamGia = float.Parse(item.SubItems[7].Text); 


                Tool_SuaGiay toolSuaGiayy = new Tool_SuaGiay(dtoGiay, dtoGioiTinh, dtoThuongHieu, dtoKhuyenMai );
                toolSuaGiayy.ShowDialog();
                if (toolSuaGiayy.isClickSua)
                {
                    loadDataGiay();
                }
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lvwGiay.SelectedItems.Count > 0)
            {
                TBXoa tbXoa = new TBXoa();
                tbXoa.ShowDialog();
                if (tbXoa.isClickXoa)
                {
                    ListViewItem item = lvwGiay.SelectedItems[0];
                    if (busGiay.deleteGiay(item.SubItems[2].Text))
                    {
                        String thongBao = "Xóa thành công!";
                        TBThemSuaXoa tBThemSuaXoa = new TBThemSuaXoa(thongBao);
                        tBThemSuaXoa.ShowDialog();
                        loadDataGiay();
                    }
                    else
                    {
                        MessageBox.Show("Lỗi phần mềm!");
                    }
                }
            }
        }
    }
}
