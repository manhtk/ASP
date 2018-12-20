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
    public class ThongKeBUS
    {
        Data da = new Data();
        public void addVisitorCount()
        {
            string sql = "UPDATE ThongKe set LuotTruyCap = LuotTruyCap + 1 WHERE Id='TC1'";
            da.ExcuteNonQuerry(sql);
        }

        public int getVisitorCount()
        {
            string sql = "Select * from ThongKe";
            return int.Parse(da.GetDataTable(sql).Rows[0][1].ToString());
        }
    }
}
