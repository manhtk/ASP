using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTOs;
using DALs;

namespace BUS.BackEnd
{
    public class TinTucBUS
    {
        Data da = new Data();
        public DataTable showNews()
        {
            string sql = "SELECT * FROM TinTuc";
            return da.GetDataTable(sql);
        }

        public bool insertNews(TinTucDTO tinTucDTO)
        {
            string sql = "INSERT INTO TinTuc VALUES ('" + tinTucDTO.MaTinTuc + "',N'" + tinTucDTO.TieuDe
                + "',N'" + tinTucDTO.NoiDung + "','" + tinTucDTO.HinhAnh + "','" + tinTucDTO.NgayViet + "')";
            return da.ExcuteNonQuerry(sql);
        }
        public bool updateNews(TinTucDTO tinTuc)
        {
            string sql = "UPDATE TinTuc set TieuDe=N'" + tinTuc.TieuDe + "', NoiDung = N'" + tinTuc.NoiDung + "', HinhAnh='" + tinTuc.HinhAnh +
                "', NgayViet='" + tinTuc.NgayViet.ToString("MM/dd/yyyy HH:mm") +"' WHERE MaTinTuc='"+tinTuc.MaTinTuc+"'";
            return da.ExcuteNonQuerry(sql);
        }

        public bool deleteNews(string maTinTuc)
        {
            string sql = "DELETE FROM TinTuc WHERE MatinTuc='" + maTinTuc + "'";
            return da.ExcuteNonQuerry(sql);
        }

        public DataTable getNews(string ID)
        {
            string sql = "SELECT * FROM TinTuc WHERE MaTinTuc='" + ID + "'";
            return da.GetDataTable(sql);
        }
    }
}
