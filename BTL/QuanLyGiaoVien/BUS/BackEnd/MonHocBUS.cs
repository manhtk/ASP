using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALs;
using System.Data;
using System.Data.SqlClient;

namespace BUS.BackEnd
{
    public class MonHocBUS
    {
        Data da = new Data();
        public DataTable showbang()
        {
            string sql = "select * from MonHoc";
            DataTable dt = new DataTable();
            dt = da.GetDataTable(sql);
            return dt;
        }
        public void insertMonHoc(string ma,string ten,int stc)
        {
            string sql = "insert MonHoc values(N'" + ma + "',N'" + ten + "',N'" + stc + "')";
            da.ExcuteNonQuerry(sql);
        }
        public void deteleMonHoc(string ma)
        {
            string sql = "delete MonHoc where MaMon = N'" + ma + "'";
            da.ExcuteNonQuerry(sql);
        }
        public void updateMonHoc(string ma, string ten, int stc)
        {
            string sql = "update MonHoc set MaMon=N'" + ma + "',TenMon = N'" + ten + "',SoTinChi=N'" + stc + "' where MaMon='"+ma+"'";
            da.ExcuteNonQuerry(sql);
        }
    }
}
