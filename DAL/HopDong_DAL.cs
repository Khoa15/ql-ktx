using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class HopDong_DAL
    {
        List<HopDong> dsHopDong = new List<HopDong>();
        public HopDong_DAL()
        {
        }
        public List<HopDong> Load()
        {
            Database db = new Database();
            SqlDataReader rd = db.Select("SELECT  HOPDONG.MASV, HOTEN, LOP, GIOITINH, NGAYSINH, TRANGTHAI, TUNGAY, DENNGAY, MA_PHONG, MA_DAY, TANG, CONCAT(CAST(MA_DAY AS VARCHAR(1)), '.', CAST(TANG AS VARCHAR(1)), CAST(FORMAT(MA_PHONG, '00') AS VARCHAR(2))) AS TENPHONG  FROM HOPDONG INNER JOIN SINHVIEN ON HOPDONG.MASV = SINHVIEN.MASV");
            while(rd.Read())
            {
                HopDong hd = new HopDong();
                hd.MaSV = int.Parse(rd["MASV"].ToString());
                hd.MaPhong = int.Parse(rd["MA_PHONG"].ToString());
                hd.MaDay = int.Parse(rd["MA_DAY"].ToString());
                hd.Tang = int.Parse(rd["Tang"].ToString());
                hd.NgayBatDau = DateTime.Parse(rd["TUNGAY"].ToString());
                hd.NgayHetHan = DateTime.Parse(rd["DENNGAY"].ToString());
                hd.TenPhong = rd["TENPHONG"].ToString();
                hd.HoTen = rd["HoTen"].ToString();
                hd.MaSV = int.Parse(rd["MASV"].ToString());
                hd.Lop = rd["LOP"].ToString();
                hd.GioiTinh = bool.Parse(rd["GioiTinh"].ToString());
                hd.NgaySinh = DateTime.Parse(rd["NGAYSINH"].ToString());
                hd.TrangThai = int.Parse(rd["TRANGTHAI"].ToString());
                dsHopDong.Add(hd);
            }
            db.Conn.Close();
            return dsHopDong;
        }
        public int Save(HopDong hd)
        {
            Database db = new Database();
            db.Conn.Open();
            SqlCommand cmd = new SqlCommand($"INSERT INTO HOPDONG ([MASV], [MA_PHONG], [MA_DAY], [TANG], [TUNGAY], [DENNGAY], [TRANGTHAI]) VALUES( ${hd.MaSV}, ${hd.MaPhong}, ${hd.MaDay}, ${hd.Tang}, ${hd.NgayBatDau}, ${hd.NgayHetHan}, ${hd.TrangThai})");
            int result = cmd.ExecuteNonQuery();
            db.Conn.Close();
            return result;
        }
    }
}
