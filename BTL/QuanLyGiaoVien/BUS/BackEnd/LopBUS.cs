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
    public class LopBUS
    {
        Data da = new Data();
        public DataTable showbang()
        {
            string sql = "select * from Lop";
            DataTable dt = new DataTable();
            dt = da.GetDataTable(sql);
            return dt;
        }
        public void insertLop(string ma, string ten, string hdt, int siso)
        {
            string sql = "insert Lop values(N'" + ma + "',N'" + ten + "',N'" + hdt + "',N'" + siso + "')";
            da.ExcuteNonQuerry(sql);
        }
        public void deteleLop(string ma)
        {
            string sql = "delete Lop where MaLop = N'" + ma + "'";
            da.ExcuteNonQuerry(sql);
        }
        public void updateLop(string ma, string ten, string hdt, int siso)
        {
            string sql = "update Lop set MaLop=N'" + ma + "',TenLop = N'" + ten + "',HeDaoTao=N'" + hdt + "',SiSo=N'" + siso + "'  where MaLop='" + ma + "'";
            da.ExcuteNonQuerry(sql);
        }
    }
}
