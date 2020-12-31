using BUS_QuanLyGiay;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_QuayLyGiay;
using System.IO;
using System.Drawing.Imaging;

namespace QuanLyGiay
{
    public partial class DanhSachGiay : Form
    {
       /* private BUS_Giay busGiay = new BUS_Giay();
        private BUS_MaLoai busMaLoai = new BUS_MaLoai();
        private BUS_GioiTinh busGioiTinh = new BUS_GioiTinh();*/
        public DanhSachGiay()
        {
            InitializeComponent();
          /*  loadDataGiay();
            loadDataMaLoai();
            loadDataGioiTinh();
            loadDataListViewGiay();*/
        }
        public void loadDataGiay()
        {
          //  dgvDanhSach.DataSource = busGiay.getAllInfoGiay();
        }
        public void loadDataListViewGiay()
        {/*
            ltvGiay.FullRowSelect = true;
            ltvGiay.View = View.Details;
            ImageList imgs = new ImageList();
            imgs.ImageSize = new Size(50, 50);
            foreach (DataRow row in busGiay.getAllGiay().Rows)
            {
                    MemoryStream memoryStream = new MemoryStream((Byte[])row[6]);
                    Image img = Image.FromStream(memoryStream);
                    imgs.Images.Add(img);
            }
            int stt = 0;
            ltvGiay.SmallImageList = imgs;
            foreach (DataRow row in busGiay.getAllGiay().Rows)
            {
                stt++;
                ListViewItem item = new ListViewItem("");
                item.SubItems.Add(stt.ToString());
                item.SubItems.Add(row[1].ToString());
                item.SubItems.Add(row[2].ToString());
                item.SubItems.Add(row[3].ToString());
                item.SubItems.Add(row[4].ToString());
                item.SubItems.Add(row[5].ToString());
                item.SubItems.Add(row[7].ToString());

                item.ImageIndex = stt - 1;
                ltvGiay.Items.Add(item);
            }*/
        }
        public void loadDataMaLoai()
        {
           /* foreach (DataRow row in busMaLoai.getAllMaLoai().Rows)
            {
                cbbMaLoai.Items.Add(row[1].ToString());
            }
            cbbMaLoai.SelectedIndex = 0;*/
        }
        public void loadDataGioiTinh()
        {
            /*Dictionary<string, string> comboSource = new Dictionary<string, string>();
            cbbGioiTinhGiay.DisplayMember = "Value";
            cbbGioiTinhGiay.ValueMember = "Key";
            foreach (DataRow row in busGioiTinh.getAllGioiTinh().Rows)
            {
                comboSource.Add(row[0].ToString(), row[1].ToString());
            }
            cbbGioiTinhGiay.DataSource = new BindingSource(comboSource, null);*/
        }
        //public Object checkAndReturnGiay()
        //{
           /* if (txbMa.Text == "")
                return "Mã không được trống!";
            if (cbbMaLoai.Text == "")
                return "Mã loại không được trống!";
            if (txbTen.Text == "")
                return "Tên không được trống!";
            if (cbbGioiTinhGiay.Text == "")
                return "Giới tính giày không được trống!";
            if (txbMota.Text == "")
                return "Mô tả không được trống!";
            if (ptbImg.Image == null)
                return "Ảnh không được trống!";
            if (txbGia.Text == "")
                return "Giá không được trống!";
            String ma = txbMa.Text.ToString();
            String maLoai = cbbMaLoai.Text.ToString();
            String ten = txbTen.Text.ToString();
            int gioiTinh = int.Parse(((KeyValuePair<string, string>)cbbGioiTinhGiay.SelectedItem).Key);
            String moTa = txbMota.Text.ToString();

            MemoryStream stream = new MemoryStream();
            ptbImg.Image.Save(stream, ImageFormat.Png);
            byte[] hinhAnh = stream.ToArray();
            
            float gia = float.Parse(txbGia.Text);
            return null;*/
      //  }
        private void btnThem_Click(object sender, EventArgs e)
        {
            /*try
            {
                Object obj = checkAndReturnGiay();
                if (obj is String)
                    MessageBox.Show(obj.ToString());
                else
                {
                    busGiay.AddGiay((DTO_Giay)obj);
                    loadDataGiay();
                    loadDataListViewGiay();
                }
            }
            catch (Exception ex)
            {
                ex.ToString();
                MessageBox.Show("Lỗi Phầm mềm!");
            }*/
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
           /* OpenFileDialog openFileDialog = new OpenFileDialog();
            try
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string fileName;
                    fileName = openFileDialog.FileName;
                    Image m = Image.FromFile(fileName); /// bitmap(fileName)
                    ptbImg.Image = m;
                }
            }
            catch(Exception ex)
            {
                ex.ToString();
                MessageBox.Show("FIle không đúng!");
            }*/
        }
        private void btnGetImg_Click(object sender, EventArgs e)
        {

        }
    }
}
