using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;
namespace ql_ktx
{
    public partial class ThemSuaHopDong_Fr : Form
    {
        SinhVien_BLL sinhVien_bll = new SinhVien_BLL();
        HopDong hopDong;
        public ThemSuaHopDong_Fr()
        {
            InitializeComponent();
            hopDong = new HopDong();
            hopDong.MaSV = -1;
            hopDong.MaHD = -1;
        }
        public ThemSuaHopDong_Fr(HopDong hd)
        {
            InitializeComponent();
            hopDong = hd;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void ThemHopDong_Fr_Load(object sender, EventArgs e)
        {
            loadPhong();
            if(hopDong.MaHD != -1)
            {
                textBox_MaSV.Text = hopDong.MaSV.ToString();
                textBox_HoVaTen.Text = hopDong.HoTen.ToString();
                textBox_Lop.Text = hopDong.Lop.ToString();
                richTextBox_DiaChi.Text = hopDong.DiaChi.ToString();
                dateTimePicker_NgaySinh.Text = hopDong.NgaySinh.ToString();
                textBox_TenPhong.Text = hopDong.TenPhong.ToString();
                dateTimePicker_NgayBatDau.Text = hopDong.NgayBatDau.ToString();
                dateTimePicker_NgayHetHan.Text = hopDong.NgayHetHan.ToString();
                comboBox_TrangThai.SelectedIndex = hopDong.TrangThai;
                textBox_Email.Text = hopDong.Email;
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button_TimSV_Click(object sender, EventArgs e)
        {
            List<SinhVien> dsSinhVien = sinhVien_bll.Load();
            SinhVien sinhVien = dsSinhVien.Find(sv => sv.MaSV == int.Parse(textBox_MaSV.Text));
            if (sinhVien == null)
            {
                MessageBox.Show("Không tìm thấy sinh viên!");
            }
            else
            {
                textBox_HoVaTen.Text = sinhVien.HoTen.ToString();
                textBox_Lop.Text = sinhVien.Lop.ToString();
                richTextBox_DiaChi.Text = sinhVien.DiaChi.ToString();
                dateTimePicker_NgaySinh.Text = sinhVien.NgaySinh.ToString();
                textBox_Email.Text = sinhVien.Email.ToString();
            }
        }

        private void textBox_MaSV_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != 8;
        }

        private void dateTimePicker_NgayHetHan_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void button_LuuHopDong_Click(object sender, EventArgs e)
        {
            if(textBox_HoVaTen.Text.Length == 0 ||
                textBox_Email.Text.Length == 0 ||
                textBox_Lop.Text.Length == 0 ||
                richTextBox_DiaChi.Text.Length == 0 ||
                textBox_TenPhong.Text.Length == 0 )
            {
                MessageBox.Show("Cần điền đầy đủ thông tin");
                return;
            }

            hopDong.HoTen = textBox_HoVaTen.Text;
            hopDong.Email = textBox_Email.Text;
            hopDong.Lop = textBox_Lop.Text;
            hopDong.DiaChi = richTextBox_DiaChi.Text;
            hopDong.NgaySinh = DateTime.ParseExact(dateTimePicker_NgaySinh.Text, "dd/MM/yyyy", CultureInfo.CurrentCulture);
            hopDong.NgayBatDau = DateTime.ParseExact(dateTimePicker_NgayBatDau.Text, "dd/MM/yyyy", CultureInfo.CurrentCulture);
            hopDong.NgayHetHan = DateTime.ParseExact(dateTimePicker_NgayHetHan.Text, "dd/MM/yyyy", CultureInfo.CurrentCulture);
            Phong phong = new Phong(textBox_TenPhong.Text);
            hopDong.MaPhong = phong.MaPhong;
            hopDong.MaDay = phong.MaDay;
            hopDong.Tang = phong.Tang;
            hopDong.TrangThai = comboBox_TrangThai.SelectedIndex;
            hopDong.TenPhong = textBox_TenPhong.Text;
            HopDong_BLL hd_bll = new HopDong_BLL();
            if (hd_bll.Save(hopDong) != 0)
            {
                MessageBox.Show("Đã lưu hợp đồng!");
                loadPhong();
            }
            else
            {
                MessageBox.Show("Người anh em, không thể nhét thêm được đâu!");
            }
        }

        private void loadPhong()
        {
            panel_dsPhong.Controls.Clear();
            Phong_Fr phong_fr = new Phong_Fr();
            phong_fr.TopLevel = false;
            phong_fr.FormBorderStyle = FormBorderStyle.None;
            phong_fr.Dock = DockStyle.Fill;
            phong_fr.Height = 349;
            phong_fr.Width = 329;
            panel_dsPhong.Controls.Add(phong_fr);
            panel_dsPhong.Tag = phong_fr;
            phong_fr.BringToFront();
            phong_fr.Show();
            txtBox_TienPhong.Text = string.Format("{0:#,##0}", Phong.GiaPhong);
            comboBox_TrangThai.SelectedIndex = 1;
        }
    }
}
