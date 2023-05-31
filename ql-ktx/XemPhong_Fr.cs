using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using BLL;
using DTO;
namespace ql_ktx
{
    public partial class XemPhong_Fr : Form
    {
        HoaDon_BLL hoaDon_BLL= new HoaDon_BLL();
        Phong phong;
        List<HopDong> dsHopDong;
        List<HoaDon> dsHoaDon;
        public XemPhong_Fr(DataGridViewRow currentRow)
        {
            InitializeComponent();
            phong = currentRow.DataBoundItem as Phong;
        }

        private void XemPhong_Fr_Load(object sender, EventArgs e)
        {
            HopDong_BLL hopDong_bll = new HopDong_BLL();
            dsHopDong = hopDong_bll.Load(phong);
            dsHopDong = dsHopDong.Where(hd => hd.TrangThai != 0 && hd.TrangThai != 3).ToList();
            dataGridView_SinhVien.DataSource = dsHopDong;
            dsHoaDon = hoaDon_BLL.Load(phong);
            dsHoaDon.ForEach(hd =>
            {
                if (hd.Loai == true)
                {
                    textBox_NuocChiSoCu.Text = hd.ChiSoCu.ToString();
                    textBox_NuocChiSoMoi.Text = hd.ChiSoCu.ToString();
                    hd.Tongtien = thanhTien(hd.ChiSoCu, hd.ChiSoCu, hd.Loai);
                    textBox_DienThanhTien.Text = hd.Tongtien.ToString();
                }
                else
                {
                    textBox_DienChiSoCu.Text = hd.ChiSoCu.ToString();
                    textBox_DienChiSoMoi.Text = hd.ChiSoCu.ToString();
                    hd.Tongtien = thanhTien(hd.ChiSoCu, hd.ChiSoCu, hd.Loai);
                    textBox_NuocThanhTien.Text = hd.Tongtien.ToString();
                }
                textBox_MangChiPhi.Text = Mang.Gia.ToString();
                textBox_SoSV.Text = dsHopDong.Count.ToString();
                textBox_ChiPhiPhong.Text = Phong.GiaPhong.ToString();
            });
        }
        private int thanhTien(int cu, int moi, bool loai)
        {
            if(loai == true)
            {
                return (moi - cu) * Dien.giaTien;
            }
            return (moi - cu) * Nuoc.giaTien;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dsHoaDon.ForEach(hd =>
            {
                if (hd.Loai == true)
                {
                    hd.ChiSoMoi = Convert.ToInt32(textBox_NuocChiSoMoi.Text);
                }
                else
                {
                    hd.ChiSoMoi = Convert.ToInt32(textBox_DienChiSoMoi.Text);
                }
            });
            if (hoaDon_BLL.SendMail(dsHopDong, dsHoaDon, Convert.ToInt32(textBox_TongTien.Text)))
            {
                MessageBox.Show("Đã gửi mail!");
            }
        }

        private void button_Tinh_Click(object sender, EventArgs e)
        {
            int dien_Moi = int.Parse(textBox_DienChiSoMoi.Text);
            int dien_Cu = int.Parse(textBox_DienChiSoCu.Text);
            int nuoc_Moi = int.Parse(textBox_NuocChiSoMoi.Text);
            int nuoc_Cu = int.Parse(textBox_NuocChiSoCu.Text);
            if(dien_Cu > dien_Moi)
            {
                MessageBox.Show("Chỉ số điện không hợp lệ");
                return;
            }
            if(nuoc_Cu > nuoc_Moi)
            {
                MessageBox.Show("Chỉ số nước không hợp lệ");
                return;
            }
            textBox_DienThanhTien.Text = thanhTien(dien_Cu, dien_Moi, false).ToString();
            textBox_NuocThanhTien.Text = thanhTien(nuoc_Cu, nuoc_Moi, true).ToString();
            textBox_TongTien.Text = String.Format("{0:#,##0}",int.Parse(textBox_DienThanhTien.Text) + int.Parse(textBox_DienThanhTien.Text) + Mang.Gia + dsHopDong.Count * Phong.GiaPhong);
        }

        private void button_SaveXemPhong_Click(object sender, EventArgs e)
        {
            
            hoaDon_BLL.Save(dsHopDong, dsHoaDon);

        }

        private void textBox_DienChiSoMoi_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void textBox_NuocChiSoMoi_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void textBox_DienChiSoMoi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}