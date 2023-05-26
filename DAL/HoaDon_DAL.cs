using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class HoaDon_DAL
    {
        List<HoaDon> dsHoaDon = new List<HoaDon>();
        public HoaDon_DAL()
        {

        }
        public List<HoaDon> Load()
        {
            dsHoaDon.Clear();
            Database db = new Database();
            db.Conn.Open();
            string sql = $"SELECT MA, MA_HOPDONG, MA_DICHVU, TONGTIEN, NGAYCAP, NGAYTHANHTOAN FROM HOADON";
            SqlCommand cmd = new SqlCommand(sql, db.Conn);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                HoaDon ds = new HoaDon();
                ds.Ma = rd["MA"].ToString();
                ds.Ma_DichVu = rd["MA_DICHVU"].ToString();
                ds.Ma_HopDong = rd["MA_HOPDONG"].ToString();
                ds.Tongtien = double.Parse(rd["TONGTIEN"].ToString());
                ds.NgayCap = DateTime.Parse(rd["NGAYCAP"].ToString());
                dsHoaDon.Add(ds);
            }
            db.Conn.Close();
            return dsHoaDon;
        }
        public List<HoaDon> Load(int MaPhong, int MaDay, int Tang)
        {
            dsHoaDon.Clear();
            //string sql = $"SELECT * FROM DICHVU INNER JOIN DIEN_NUOC ON DIEN_NUOC.MA_DICHVU = DICHVU.MA INNER JOIN HOADON ON HOADON.MA_DICHVU = DICHVU.MA WHERE MONTH(HOADON.NGAYCAP) = 5 AND DICHVU.MA_PHONG = {MaPhong} AND DICHVU.MA_DAY = {MaDay} AND DICHVU.TANG = {Tang}";
            //string sql = $"SELECT CHISO, NGAY FROM DIEN_NUOC WHERE MONTH(NGAY) = {DateTime.Now.Month.ToString()}";
            string sql = $"SELECT DISTINCT DICHVU.MA, MA_PHONG, MA_DAY, TANG, LOAI, CHISO FROM DICHVU INNER JOIN DIEN_NUOC ON DIEN_NUOC.MA_DICHVU = DICHVU.MA WHERE MONTH(DIEN_NUOC.NGAY) >= {DateTime.Now.Month.ToString()} AND DICHVU.MA_PHONG = {MaPhong} AND DICHVU.MA_DAY = {MaDay} AND DICHVU.TANG = {Tang}";
            Database db = new Database();
            db.Conn.Open();
            SqlCommand cmd = new SqlCommand(sql, db.Conn);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                HoaDon hd = new HoaDon();
                hd.Ma_DichVu = rd["MA"].ToString();
                hd.Loai = bool.Parse(rd["Loai"].ToString());
                hd.MaPhong = int.Parse(rd["MA_PHONG"].ToString());
                hd.MaDay = int.Parse(rd["MA_DAY"].ToString());
                hd.Tang = int.Parse(rd["Tang"].ToString()) ;
                hd.ChiSoCu = int.Parse(rd["CHISO"].ToString());
                hd.ChiSoMoi = hd.ChiSoCu;
                dsHoaDon.Add(hd);
            }
            db.Conn.Close();
            return dsHoaDon;

        }
    }
}
