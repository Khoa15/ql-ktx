using DTO;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace DAL
{
    public class Phong_DAL
    {
        List<Phong> dsPhong = new List<Phong>();
        public Phong_DAL()
        {
        }

        public List<Phong> DsPhong { get => dsPhong; set => dsPhong = value; }

        public List<Phong> Load()
        {
            DsPhong.Clear();
            Database db = new Database();
            SqlDataReader rd = db.Select("SELECT PHONG.MA, MA_DAY, TANG, DAYPHONG.TEN, TENPHONG FROM PHONG INNER JOIN DAYPHONG ON PHONG.MA_DAY = DAYPHONG.MA ORDER BY TENPHONG");
            while(rd.Read())
            {
                Phong p = new Phong();
                p.MaPhong = int.Parse(rd["Ma"].ToString());
                p.MaDay = int.Parse(rd["Ma_Day"].ToString());
                p.Tang = int.Parse(rd["Tang"].ToString());
                p.TenDay = rd["TEN"].ToString();
                p.TenPhong = rd["TENPHONG"].ToString();
                DsPhong.Add(p);
            }
            db.Conn.Close();
            rd = db.Select("SELECT PHONG.TENPHONG, COUNT(HOPDONG.MASV) AS SOLUONG FROM PHONG LEFT JOIN HOPDONG ON HOPDONG.MA_PHONG = PHONG.MA AND HOPDONG.MA_DAY = PHONG.MA_DAY AND HOPDONG.TANG = PHONG.TANG GROUP BY (TENPHONG) ORDER BY TENPHONG ASC");
            while (rd.Read())
            {
                DsPhong.Where(phong => phong.TenPhong == rd["TENPHONG"].ToString()).ToList().ForEach(phong => phong.SoSv = int.Parse(rd["SOLUONG"].ToString()));
            }
            db.Conn.Close();
            return DsPhong;
        }
        public Phong Load(int id)
        {
            Phong p = new Phong();
            Database db = new Database();
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
