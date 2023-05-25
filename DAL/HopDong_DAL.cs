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
            SqlDataReader rd = db.Select("SELECT HOPDONG.MA, HOPDONG.MASV, HOTEN, DIACHI, LOP, GIOITINH, NGAYSINH, TRANGTHAI, TUNGAY, DENNGAY, MA_PHONG, MA_DAY, TANG, CONCAT(CAST(MA_DAY AS VARCHAR(1)), CAST(TANG AS VARCHAR(1)), CAST(FORMAT(MA_PHONG, '00') AS VARCHAR(2))) AS TENPHONG  FROM HOPDONG INNER JOIN SINHVIEN ON HOPDONG.MASV = SINHVIEN.MASV ORDER BY DENNGAY ASC");
            while(rd.Read())
            {
                HopDong hd = new HopDong();
                hd.MaHD = int.Parse(rd["MA"].ToString());
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
                hd.DiaChi = rd["DIACHI"].ToString();
                hd.GioiTinh = bool.Parse(rd["GioiTinh"].ToString());
                hd.NgaySinh = DateTime.Parse(rd["NGAYSINH"].ToString());
                hd.TrangThai = int.Parse(rd["TRANGTHAI"].ToString());
                dsHopDong.Add(hd);
            }
            db.Conn.Close();
            return dsHopDong;
        }
        public List<HopDong> Load(Phong phong)
        {

            Database db = new Database();
            SqlDataReader rd = db.Select($"SELECT HOPDONG.MA, HOPDONG.MASV, HOPDONG.TRANGTHAI, HOPDONG.TUNGAY, HOPDONG.DENNGAY, HOTEN, LOP, GIOITINH, NGAYSINH  FROM HOPDONG INNER JOIN SINHVIEN ON HOPDONG.MASV = SINHVIEN.MASV AND HOPDONG.MA_PHONG = {phong.MaPhong} AND HOPDONG.MA_DAY={phong.MaDay} AND HOPDONG.TANG = {phong.Tang} ORDER BY DENNGAY ASC");
            while (rd.Read())
            {
                HopDong hd = new HopDong();
                hd.MaHD = int.Parse(rd["MA"].ToString());
                hd.MaSV = int.Parse(rd["MASV"].ToString());
                //hd.MaPhong = int.Parse(rd["MA_PHONG"].ToString());
                //hd.MaDay = int.Parse(rd["MA_DAY"].ToString());
                //hd.Tang = int.Parse(rd["Tang"].ToString());
                hd.NgayBatDau = DateTime.Parse(rd["TUNGAY"].ToString());
                hd.NgayHetHan = DateTime.Parse(rd["DENNGAY"].ToString());
                //hd.TenPhong = rd["TENPHONG"].ToString();
                hd.MaSV = int.Parse(rd["MASV"].ToString());
                hd.HoTen = rd["HoTen"].ToString();
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
            string sql = $"SELECT MASV FROM HOPDONG WHERE MASV = {hd.MaSV} AND MA_PHONG = {hd.MaPhong} AND TANG = {hd.Tang} AND TRANGTHAI != 0 AND TRANGTHAI != 3";
            SqlCommand cmd = new SqlCommand(sql, db.Conn);
            int result =  cmd.ExecuteReader().FieldCount;
            db.Conn.Close();
            if (result > 0)
            {
                db.Conn.Open();
                sql = $"UPDATE HOPDONG SET TRANGTHAI = {hd.TrangThai}, TUNGAY = '{hd.NgayBatDau.ToShortDateString()}', DENNGAY = '{hd.NgayHetHan.ToShortDateString()}' WHERE MASV = {hd.MaSV} AND MA_PHONG = {hd.MaPhong} AND TANG = {hd.Tang};";
                sql += $"UPDATE SINHVIEN SET HOTEN = N'{hd.HoTen}', DIACHI = N'{hd.DiaChi}', GIOITINH = {((hd.GioiTinh == true) ? 1 : 0)}, NGAYSINH = '{hd.NgaySinh}', LOP='{hd.Lop}' WHERE MASV = {hd.MaSV}";
                cmd = new SqlCommand(sql, db.Conn);
                result = cmd.ExecuteNonQuery() ;
                db.Conn.Close();
            }
            else
            {
                db.Conn.Open();
                sql = $"INSERT INTO HOPDONG ([MASV], [MA_PHONG], [MA_DAY], [TANG], [TUNGAY], [DENNGAY], [TRANGTHAI]) VALUES( {hd.MaSV}, {hd.MaPhong}, {hd.MaDay}, {hd.Tang}, '{hd.NgayBatDau}', '{hd.NgayHetHan}', {hd.TrangThai})";
                cmd = new SqlCommand(sql, db.Conn);
                result = cmd.ExecuteNonQuery();
                db.Conn.Close();
            }
            return result;
        }
        public int Count(int MaPhong, int MaDay, int Tang)
        {
            int soNguoiTrongPhong = dsHopDong.Count(hopdong => hopdong.TrangThai != 0 && hopdong.TrangThai != 3 && hopdong.MaPhong == MaPhong && hopdong.MaDay == MaDay && hopdong.Tang == Tang);
            return soNguoiTrongPhong;
        }
    }
}
