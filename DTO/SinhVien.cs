using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SinhVien: Phong
    {
        /// <summary>
        /// gioiTinh {0: Nam, 1: Nữ}
        /// </summary>
        int maSV;
        string lop;
        string hoTen;
        string diaChi;
        DateTime ngaySinh;
        bool gioiTinh;
        public SinhVien() { }
        public SinhVien(int maSV, string lop, string hoTen, string diaChi, DateTime ngaySinh, bool gioiTinh)
        {
            this.maSV = maSV;
            this.lop = lop;
            this.hoTen = hoTen;
            this.diaChi = diaChi;
            this.ngaySinh = ngaySinh;
            this.gioiTinh = gioiTinh;
        }
        public SinhVien(HopDong hd)
        {
            this.maSV = hd.maSV;
            this.lop = hd.lop;
            this.hoTen = hd.hoTen;
            this.diaChi = hd.diaChi;
            this.ngaySinh = hd.ngaySinh;
            this.gioiTinh= hd.gioiTinh;
        }

        public int MaSV { get => maSV; set => maSV = value; }
        public string Lop { get => lop; set => lop = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public bool GioiTinh { get => gioiTinh; set => gioiTinh = value; }
    }
}
