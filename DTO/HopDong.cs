using System;

namespace DTO
{
    public class HopDong: SinhVien
    {
        int maPhong;
        int maDay;
        int tang;
        DateTime ngayBatDau;
        DateTime ngayHetHan;
        int trangThai;
        public HopDong(): base()
        {

        }
        public HopDong(string maSV, string lop, string hoTen, string diaChi, DateTime ngaySinh, bool gioiTinh, int maPhong, DateTime ngayBatDau, DateTime ngayHetHan, int trangThai, int tang, int maDay) : base(maSV, lop, hoTen, diaChi, ngaySinh, gioiTinh)
        {
            this.MaPhong = maPhong;
            this.MaDay = maDay;
            this.Tang = tang;
            this.NgayBatDau = ngayBatDau;
            this.NgayHetHan = ngayHetHan;
            this.TrangThai = trangThai;
        }

        public int MaPhong { get => maPhong; set => maPhong = value; }
        public DateTime NgayBatDau { get => ngayBatDau; set => ngayBatDau = value; }
        public DateTime NgayHetHan { get => ngayHetHan; set => ngayHetHan = value; }
        public int TrangThai { get => trangThai; set => trangThai = value; }
        public int MaDay { get => maDay; set => maDay = value; }
        public int Tang { get => tang; set => tang = value; }
    }
}
