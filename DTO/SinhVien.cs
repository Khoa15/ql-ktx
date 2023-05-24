using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SinhVien
    {
        string maSV;
        string lop;
        string hoTen;
        string diaChi;
        DateTime ngaySinh;
        bool gioiTinh;
        public SinhVien() { }
        public SinhVien(string maSV, string lop, string hoTen, string diaChi, DateTime ngaySinh, bool gioiTinh)
        {
            this.maSV = maSV;
            this.lop = lop;
            this.hoTen = hoTen;
            this.diaChi = diaChi;
            this.ngaySinh = ngaySinh;
            this.gioiTinh = gioiTinh;
        }

        public string MaSV { get => maSV; set => maSV = value; }
        public string Lop { get => lop; set => lop = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public bool GioiTinh { get => gioiTinh; set => gioiTinh = value; }
    }
}
