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
    public class GiaoVienBUS
    {
        Data da = new Data();
        public DataTable showbang()
        {
            string sql = "select * from GiaoVien";
            DataTable dt = new DataTable();
            dt = da.GetDataTable(sql);
            return dt;
        }
        public void insertGiaoVien(string ma, string ten, string sdt, string dc)
        {
            string sql = "insert GiaoVien values(N'" + ma + "',N'" + ten + "',N'" + sdt + "',N'" + dc + "')";
            da.ExcuteNonQuerry(sql);
        }
        public void deteleGiaoVien(string ma)
        {
            string sql = "delete GiaoVien where MaGiaoVien = N'" + ma + "'";
            da.ExcuteNonQuerry(sql);
        }
        public void updateGiaoVien(string ma, string ten, string sdt, string dc)
        {
            string sql = "update GiaoVien set MaGiaoVien=N'" + ma + "',TenGiaoVien = N'" + ten + "',SoDIenThoai=N'" + sdt + "',DiaChi=N'" + dc + "'  where MaGiaoVien='" + ma + "'";
            da.ExcuteNonQuerry(sql);
        }
    }
}
