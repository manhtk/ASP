using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTOs;
using DALs;
namespace BUS.FrontEnd
{
  public  class DsMonHocFrontEnd

    {
        Data da = new Data();
        MonHocDTO MH = new MonHocDTO();
        public DataTable ShowDsMon()
        {
            string sql = "select * from MonHoc";
            DataTable dt = new DataTable();
            dt = da.GetDataTable(sql);
            return dt;
        }
    }
}
