﻿using System;
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
    public partial class ThemHopDong_Fr : Form
    {
        SinhVien_BLL sinhVien_bll = new SinhVien_BLL();
        public ThemHopDong_Fr()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void ThemHopDong_Fr_Load(object sender, EventArgs e)
        {
            loadPhong();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button_TimSV_Click(object sender, EventArgs e)
        {
            List<SinhVien> dsSinhVien = sinhVien_bll.Load();
            SinhVien found = dsSinhVien.Find(sv => sv.MaSV == int.Parse(textBox_MaSV.Text));
            if (found == null)
            {
                MessageBox.Show("Không tìm thấy sinh viên!");
            }
            else
            {
                textBox_HoVaTen.Text = found.HoTen.ToString();
                textBox_Lop.Text = found.Lop.ToString();
                richTextBox_DiaChi.Text= found.DiaChi.ToString();
                dateTimePicker_NgaySinh.Text = found.NgaySinh.ToString();
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
            HopDong hd = new HopDong();
            hd.MaSV = int.Parse(textBox_MaSV.Text);
            hd.HoTen = textBox_HoVaTen.Text;
            hd.Lop = textBox_Lop.Text;
            hd.DiaChi = richTextBox_DiaChi.Text;
            hd.NgaySinh = DateTime.ParseExact(dateTimePicker_NgaySinh.Text, "dd/MM/yyyy", CultureInfo.CurrentCulture);
            hd.NgayBatDau = DateTime.ParseExact(dateTimePicker_NgayBatDau.Text, "dd/MM/yyyy", CultureInfo.CurrentCulture);
            hd.NgayHetHan = DateTime.ParseExact(dateTimePicker_NgayHetHan.Text, "dd/MM/yyyy", CultureInfo.CurrentCulture);
            Phong phong = new Phong(textBox_TenPhong.Text);
            hd.MaPhong = phong.MaPhong;
            hd.MaDay = phong.MaDay;
            hd.Tang = phong.Tang;
            hd.TrangThai = comboBox_TrangThai.SelectedIndex;
            hd.TenPhong = textBox_TenPhong.Text;
            HopDong_BLL hd_bll = new HopDong_BLL();
            if (hd_bll.Save(hd) != 0)
            {
                MessageBox.Show("Đã thêm hợp đồng!");
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
