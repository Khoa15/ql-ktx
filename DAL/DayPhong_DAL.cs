using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DayPhong_DAL
    {
        List<DayPhong> dsDay = new List<DayPhong>();
        public DayPhong_DAL() { }
        public List<DayPhong> Load()
        {
            Database db = new Database();
            db.Conn.Open();
            SqlDataReader rd = db.Select("SELECT * FROM DAYPHONG");
            while (rd.Read())
            {
                DayPhong d = new DayPhong();
                d.MaDay = int.Parse(rd["MA"].ToString());
                d.TenDay = rd["TEN"].ToString();
                dsDay.Add(d);
            }
            db.Conn.Close();
            return dsDay;
        }
    }
}
