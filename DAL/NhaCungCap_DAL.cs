using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class NhaCungCap_DAL
    {
        List<NhaCungCap> dsNhaCungCap = new List<NhaCungCap>();

        public NhaCungCap_DAL()
        {

        }
        public List<NhaCungCap> Load()
        {
            dsNhaCungCap.Clear();
            Database db = new Database();
            db.Conn.Open();
            string sql = $"";
            SqlCommand cmd = new SqlCommand(sql, db.Conn);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                NhaCungCap cap = new NhaCungCap();
                cap.Ma = rd["Ma"].ToString();
                cap.Ten = rd["Ten"].ToString();
                cap.HoTen = rd["HoTen"].ToString();
                cap.Sdt = rd["Sdt"].ToString();
            }
            db.Conn.Close();
            return dsNhaCungCap;
        }
    }
}
