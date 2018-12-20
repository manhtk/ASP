using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DALs
{
    public class Data
    {
        public SqlConnection GetSqlConnection()
        {
            return new SqlConnection(@"Data Source=DUCTHANH-PC\SQLEXPRESS;Initial Catalog=QuanLyGiaoVien;Integrated Security=True");
        }
        public DataTable GetDataTable(string sql)
        {
            try
            {
                SqlConnection conn = GetSqlConnection();
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                cmd.Dispose();
                conn.Close();
                conn.Dispose();
                return dt;
            }
            catch
            {
                return null;
            }
        }
        public bool ExcuteNonQuerry(string sql)
        {
            try
            {
                SqlConnection conn = GetSqlConnection();
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                int check = cmd.ExecuteNonQuery();
                cmd.Dispose();
                conn.Close();
                conn.Dispose();
                if (check == 0)
                    return false;
                return true;
            }
            catch
            {
                return false;
            }

        }
    }
}
