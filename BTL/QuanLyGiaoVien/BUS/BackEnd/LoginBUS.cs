using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DALs;
using DTOs;

namespace BUS.BackEnd
{
    public class LoginBUS
    {
        Data da = new Data();
        public bool login(TaiKhoanDTO tk)
        {
            string sql = "SELECT * FROM TaiKhoan WHERE TaiKhoan='" + tk.TaiKhoan + "' AND MatKhau = '" + tk.MatKhau + "'";
            if (da.GetDataTable(sql).Rows.Count!=0)
                return true;
            return false;
        }
    }
}
