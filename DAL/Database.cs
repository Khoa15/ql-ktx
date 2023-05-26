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
        string strcon = @"Data Source=Mun\SQLEXPRESS;Initial Catalog=QL_KTX_OWN;Integrated Security=True";
        SqlConnection conn;
        public Database() {
            Conn = new SqlConnection(strcon);
        }
        public Database(string strCon)
        {
            Conn = new SqlConnection(strCon);
        }

        public SqlConnection Conn { get => conn; set => conn = value; }

        public SqlDataReader Select(string sql)
        {
            Conn.Open();
            SqlCommand cmd = new SqlCommand(sql, Conn);
            SqlDataReader r = cmd.ExecuteReader();
            return r;
        }
        public int Insert(string table, string data)
        {
            Conn.Open();
            string sql = $"INSERT INTO ${table} () VALUES ()";
            SqlCommand cmd = new SqlCommand(sql, Conn);
            return cmd.ExecuteNonQuery();
        }
        public int Update(string table, string data, string where)
        {
            Conn.Open();
            string sql = $"UPDATE ${table} SET ${data} WHERE ${where}"; 
            SqlCommand cmd = new SqlCommand(sql, Conn);
            return cmd.ExecuteNonQuery();
        }
        public int Delete(string sql)
        {
            Conn.Open();
            SqlCommand cmd = new SqlCommand(sql, Conn);
            return cmd.ExecuteNonQuery();
        }
        public void Close()
        {
            Conn.Close();
        }
    }
}
