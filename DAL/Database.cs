using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Database
    {
        string strcon = @"Data Source=DESKTOP-L3D0UJ9\SQLEXPRESS;Initial Catalog=QL_KTX_OWN;Integrated Security=True";
        SqlConnection conn;
        public Database() {
            Conn = new SqlConnection(strcon);
        }
        public Database(string strCon)
        {
            Conn = new SqlConnection(strCon);
        }

        public SqlConnection Conn { get => conn; set => conn = value; }

        public SqlDataReader Query(string sql)
        {
            Conn.Open();
            SqlCommand cmd = new SqlCommand(sql, Conn);
            SqlDataReader r = cmd.ExecuteReader();
            //Conn.Close();
            return r;
        }
    }
}
