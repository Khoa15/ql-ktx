using DTO;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DAL
{
    public class Phong_DAL
    {
        List<Phong> dsPhong = new List<Phong>();
        public Phong_DAL()
        {
        }
        public List<Phong> Load()
        {
            dsPhong.Clear();
            Database db = new Database();
            SqlDataReader rd = db.Select("SELECT PHONG.MA, MA_DAY, TANG, DAYPHONG.TEN, CONCAT(CAST(PHONG.MA_DAY AS VARCHAR(1)), '.', CAST(TANG AS VARCHAR(1)), CAST(FORMAT(PHONG.MA, '00') AS VARCHAR(2))) AS TENPHONG FROM PHONG INNER JOIN DAYPHONG ON PHONG.MA_DAY = DAYPHONG.MA ORDER BY TENPHONG");
            while(rd.Read())
            {
                Phong p = new Phong();
                p.MaPhong = int.Parse(rd["Ma"].ToString());
                p.MaDay = int.Parse(rd["Ma_Day"].ToString());
                p.Tang = int.Parse(rd["Tang"].ToString());
                p.TenDay = rd["TEN"].ToString();
                p.TenPhong = rd["TENPHONG"].ToString();
                dsPhong.Add(p);
            }
            db.Conn.Close();
            return dsPhong;
        }
        public Phong Load(int id)
        {
            Phong p = new Phong();
            Database db = new Database();
            db.Conn.Open();
            SqlDataReader rd = db.Select($"SELECT TOP (1) * FROM Phong WHERE MA = ${id}");
            while (rd.Read())
            {
                p.MaPhong = int.Parse(rd["Ma"].ToString());
                p.MaDay = int.Parse(rd["MaDay"].ToString());
                p.Tang = int.Parse(rd["Tang"].ToString());
            }
            db.Conn.Close();
            return p;
        }
        
    }
}
