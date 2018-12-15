using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DALs;
using DTOs;
namespace BUS.FrontEnd
{
  public  class DsLopFrontEnd
    {
        Data da = new Data();
        LopDTO GV = new LopDTO();
        public DataTable ShowDsLop()
        {
            string sql = "select * from Lop";
            DataTable dt = new DataTable();
            dt = da.GetDataTable(sql);
            return dt;
        }
    }
}
