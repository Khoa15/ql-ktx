using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDon: DichVu
    {
        string ma;
        string ma_HopDong;
        string ma_DichVu;
        double tongtien;
        DateTime ngayCap;
        DateTime ngayThanhToan;
        public HoaDon()
        {
        }

        public HoaDon(double tongtien, DateTime ngayCap, string ma_HopDong = null, string ma_DichVu = null, DateTime ngayThanhToan = default)
        {
            this.tongtien = tongtien;
            this.ngayCap = ngayCap;
            this.ma_HopDong = ma_HopDong;
            this.ma_DichVu = ma_DichVu;
            this.NgayThanhToan = ngayThanhToan;
        }

        public string Ma { get => ma; set => ma = value; }
        public double Tongtien { get => tongtien; set => tongtien = value; }
        public DateTime NgayCap { get => ngayCap; set => ngayCap = value; }
        public string Ma_HopDong { get => ma_HopDong; set => ma_HopDong = value; }
        public string Ma_DichVu { get => ma_DichVu; set => ma_DichVu = value; }
        public DateTime NgayThanhToan { get => ngayThanhToan; set => ngayThanhToan = value; }

        public double TinhTien()
        {
            throw new NotImplementedException();
        }
    }
}
