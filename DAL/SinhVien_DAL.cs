using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DAL
{
    public class SinhVien_DAL:Database
    {
        List<SinhVien> dsSinhVien = new List<SinhVien>();
        public SinhVien_DAL():base()
        {
        }
        public List<SinhVien> Load()
        {
            SqlDataReader rd = Query("SELECT * FROM SINHVIEN");
            while(rd.Read())
            {
                SinhVien sv = new SinhVien();
                sv.MaSV = rd["MaSV"].ToString();
                sv.HoTen = rd["HoTen"].ToString();
                sv.DiaChi = rd["DiaChi"].ToString();
                sv.GioiTinh = bool.Parse(rd["GioiTinh"].ToString());
                sv.NgaySinh = DateTime.Parse(rd["NgaySinh"].ToString());
                sv.Lop = rd["Lop"].ToString();
                dsSinhVien.Add(sv);
            }
            Conn.Close();
            return dsSinhVien;
        }
    }
}
