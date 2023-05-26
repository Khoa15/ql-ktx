using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DAL
{
    public class SinhVien_DAL
    {
        List<SinhVien> dsSinhVien = new List<SinhVien>();
        public SinhVien_DAL()
        {
        }
        public List<SinhVien> Load()
        {
            dsSinhVien.Clear();
            Database db = new Database();
            SqlDataReader rd = db.Select("SELECT MaSV, HoTen, DiaChi, GioiTinh, LOP, NgaySinh, Email FROM SINHVIEN");
            while(rd.Read())
            {
                SinhVien sv = new SinhVien();
                sv.MaSV = int.Parse(rd["MaSV"].ToString());
                sv.HoTen = rd["HoTen"].ToString();
                sv.DiaChi = rd["DiaChi"].ToString();
                sv.GioiTinh = bool.Parse(rd["GioiTinh"].ToString());
                sv.NgaySinh = DateTime.Parse(rd["NgaySinh"].ToString());
                sv.Lop = rd["Lop"].ToString();
                sv.Email = rd["EMAIL"].ToString();
                dsSinhVien.Add(sv);
            }
            db.Close();
            return dsSinhVien;
        }
        public List<SinhVien> Load(Phong phong)
        {
            dsSinhVien.Clear();
            Database db = new Database();
            SqlDataReader rd = db.Select($"SELECT SINHVIEN.* FROM HOPDONG INNER JOIN SINHVIEN ON SINHVIEN.MASV = HOPDONG.MASV AND HOPDONG.MA_PHONG = {phong.MaPhong} AND HOPDONG.MA_DAY = {phong.MaDay} AND HOPDONG.TANG = {phong.Tang}");
            while (rd.Read())
            {
                SinhVien sv = new SinhVien();
                sv.MaSV = int.Parse(rd["MaSV"].ToString());
                sv.HoTen = rd["HoTen"].ToString();
                sv.DiaChi = rd["DiaChi"].ToString();
                sv.GioiTinh = bool.Parse(rd["GioiTinh"].ToString());
                sv.NgaySinh = DateTime.Parse(rd["NgaySinh"].ToString());
                sv.Lop = rd["Lop"].ToString();
                dsSinhVien.Add(sv);
            }
            db.Close();
            return dsSinhVien;
        }
        public int Update(List<SinhVien> dsSinhVien)
        {
            Database db = new Database();
            db.Conn.Open();
            string sql = "";
            dsSinhVien.ForEach(sv =>
            {
                sql += $"UPDATE SINHVIEN SET HoTen = '${sv.HoTen}', DiaChi = '${sv.DiaChi}', GioiTinh =${sv.GioiTinh}, LOP = '${sv.Lop}', NgaySinh='${sv.NgaySinh}' WHERE MaSV = ${sv.MaSV}; GO;";
            });
            SqlCommand cmd = new SqlCommand(sql, db.Conn);
            int result = cmd.ExecuteNonQuery();
            db.Conn.Close();
            return result;
        }
        public int Delete(List<SinhVien> dsSinhVien)
        {
            Database db = new Database();
            db.Conn.Open();
            string sql = "";
            dsSinhVien.ForEach(sv =>
            {
                sql += $"DELETE FROM SINHVIEN WHERE MaSV = {sv.MaSV};GO;";
            });
            SqlCommand cmd = new SqlCommand(sql, db.Conn);
            int result = cmd.ExecuteNonQuery();
            db.Conn.Close();
            return result;
        }
        public int Insert(HopDong hd)
        {
            SinhVien sv = new SinhVien(hd);
            return this.Insert(sv);
        }
        public int Insert(SinhVien sv)
        {
            Database db = new Database();
            db.Conn.Open();
            string sql = $"INSERT INTO SINHVIEN ([HOTEN] ,[DIACHI] ,[GIOITINH] ,[NGAYSINH] ,[LOP], [EMAIL]) VALUES (N'{sv.HoTen}', N'{sv.DiaChi}', {((sv.GioiTinh == true) ? 1 : 0)}, '{sv.NgaySinh.ToShortDateString()}', '{sv.Lop}', '{sv.Email}')";
            SqlCommand cmd = new SqlCommand(sql, db.Conn);
            int result = cmd.ExecuteNonQuery();
            db.Conn.Close();
            if (result != 0)
            {
                db.Conn.Open();
                sql = $"SELECT TOP 1 MASV FROM SINHVIEN WHERE EMAIL='{sv.Email}'";
                cmd = new SqlCommand(sql , db.Conn);
                SqlDataReader rd = cmd.ExecuteReader();
                while(rd.Read())
                {
                    result = int.Parse(rd["MASV"].ToString());
                }
                db.Conn.Close();
            }
            return result;
        }
    }
}
