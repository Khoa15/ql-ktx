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
            Database db = new Database();
            SqlDataReader rd = db.Select("SELECT MaSV, HoTen, DiaChi, GioiTinh, LOP, NgaySinh FROM SINHVIEN");
            while(rd.Read())
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
                sql += $"DELETE FROM SINHVIEN WHERE MaSV = ${sv.MaSV};GO;";
            });
            SqlCommand cmd = new SqlCommand(sql, db.Conn);
            int result = cmd.ExecuteNonQuery();
            db.Conn.Close();
            return result;
        }
    }
}
