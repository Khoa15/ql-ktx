using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DichVu_DAL
    {
        List<DichVu> dsDichVu= new List<DichVu>();
        public DichVu_DAL()
        {

        }
        public List<DichVu> Load()
        {
            Database db = new Database();
            db.Conn.Open();
            string sql = $"";
            SqlCommand cmd = new SqlCommand(sql, db.Conn);
            SqlDataReader rd = cmd.ExecuteReader();
            while(rd.Read())
            {

            }
            db.Conn.Close();
            return dsDichVu;
        }
    }
}
