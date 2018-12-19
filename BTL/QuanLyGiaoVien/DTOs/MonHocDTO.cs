using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class MonHocDTO
    {
        public string MaMon { get; set; }
        public string TenMon { get; set; }
        public int SoTinChi { get; set; }
        public MonHocDTO()
        {

        }
        public MonHocDTO(string maMon, string tenMon, int soTinChi)
        {
            MaMon = maMon;
            TenMon = tenMon;
            SoTinChi = soTinChi;
        }
    }
}
