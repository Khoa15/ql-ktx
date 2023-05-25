using System;

namespace DTO
{
    public class HopDong: SinhVien
    {
        int maHD;
        int maPhong;
        int maDay;
        int tang;
        DateTime ngayBatDau;
        DateTime ngayHetHan;
        int trangThai;
        public HopDong(): base()
        {
        }
        public HopDong(int maSV, string lop, string hoTen, string diaChi, DateTime ngaySinh, bool gioiTinh, int maPhong, DateTime ngayBatDau, DateTime ngayHetHan, int trangThai, int tang, int maDay, int maHD) : base(maSV, lop, hoTen, diaChi, ngaySinh, gioiTinh)
        {
            this.MaPhong = maPhong;
            this.MaDay = maDay;
            this.Tang = tang;
            this.NgayBatDau = ngayBatDau;
            this.NgayHetHan = ngayHetHan;
            this.TrangThai = trangThai;
            this.MaHD = maHD;
        }

        public int MaPhong { get => maPhong; set => maPhong = value; }
        public DateTime NgayBatDau { get => ngayBatDau; set => ngayBatDau = value; }
        public DateTime NgayHetHan { get => ngayHetHan; set => ngayHetHan = value; }
        public int TrangThai { get => trangThai; set => trangThai = value; }
        public int MaDay { get => maDay; set => maDay = value; }
        public int Tang { get => tang; set => tang = value; }
        public int MaHD { get => maHD; set => maHD = value; }

        public string TenTrangThai()
        {
            string ten = String.Empty;
            if(trangThai == 0)
            {
                ten = "Đã hủy";
            }else if (trangThai == 1)
            {
                ten = "Chờ cọc";
            }
            else if (trangThai == 2)
            {
                ten = "Đang ở";
            }
            else if (trangThai == 3)
            {
                ten = "Hết hạn";
            }
            return ten;
        }
    }
}
