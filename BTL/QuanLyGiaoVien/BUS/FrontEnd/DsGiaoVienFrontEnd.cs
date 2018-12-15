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
    public class DsGiaoVienFrontEnd
    {
        Data da = new Data();
        GiaoVienDTO GV = new GiaoVienDTO();
        public DataTable ShowDsGiaoVien()
        {
            string sql = "select * from GiaoVien";
            DataTable dt = new DataTable();
            dt = da.GetDataTable(sql);
            return dt;
        }
    }
}
