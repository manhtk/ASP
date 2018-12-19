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
  public  class LichGiangDayFrontEnd
    {
        Data da = new Data();
        PhanCongDTO P = new PhanCongDTO(); 
        public DataTable ShowLichDay()
        {
            string sql = " select MaPhanCong,TenLop,TenMon,TenGiaoVien,Ngay,TietHoc,PhongHoc from PhanCong" +
                " inner join Lop on PhanCong.MaLop = Lop.MaLop" +
                " inner join MonHoc on PhanCong.MaMon = MonHoc.MaMon" +
                " inner join GiaoVien on PhanCong.MaGiaoVien = GiaoVien.MaGiaoVien";
            DataTable dt = new DataTable();
            dt = da.GetDataTable(sql);
            return dt;
        }
    }
}
