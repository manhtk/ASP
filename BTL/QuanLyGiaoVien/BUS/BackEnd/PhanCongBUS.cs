using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTOs;
using DALs;
using System.Data.SqlClient;
using System.Data;
namespace BUS
{
   public class PhanCongBUS
    {
        Data da = new Data();
        PhanCongDTO P = new PhanCongDTO();
        public DataTable ShowPhanCong()
        {
            string sql = " select MaPhanCong,TenLop,TenMon,TenGiaoVien,Ngay,TietHoc,PhongHoc from PhanCong" +
                " inner join Lop on PhanCong.MaLop = Lop.MaLop" +
                " inner join MonHoc on PhanCong.MaMon = MonHoc.MaMon" +
                " inner join GiaoVien on PhanCong.MaGiaoVien = GiaoVien.MaGiaoVien";
            DataTable dt = new DataTable();
            dt = da.GetDataTable(sql);
            return dt;
        }
        public void insertPhanCong( string mpc,string ml,string mm,string mgv,string ngay,string tiet,string phong)
        {
            string sql = "insert PhanCong values(N'" + mpc + "',N'" + ml + "',N'" + mm + "',N'" + mgv + "',N'" + ngay + "',N'" + tiet + "',N'" + phong + "')";
            da.ExcuteNonQuerry(sql);
        }
        public void detelePhanCong(string mpc)
        {
            string sql = "delete PhanCong where MaPhanCong = N'" + mpc + "'";
            da.ExcuteNonQuerry(sql);
        }
        public void updatePhanCong(string mpc, string ml, string mm, string mgv, string ngay, string tiet, string phong)
        {
            string sql = "update PhanCong set MaLop=N'" + ml + "',MaMon = N'" + mm + "',MaGiaoVien=N'" + mgv + "',Ngay=N'" + ngay + "',TietHoc=N'" + tiet + "',PhongHoc=N'" + phong + "' where MaPhanCong =N'"+mpc+"'";
            da.ExcuteNonQuerry(sql);
        }


    }
}
