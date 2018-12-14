using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class PhanCongDTO
    {
        public string MaPhanCong { get; set; }
        public string MaLop { get; set; }
        public string MaMon { get; set; }
        public string MaGiaoVien { get; set; }
        public string Ngay { get; set; }
        public string TietHoc { get; set; }
        public string PhongHoc { get; set; }
        public PhanCongDTO()
        {

        }

        public PhanCongDTO(string maPhanCong,string maLop, string maMon, string maGiaoVien, string ngay, string tietHoc, string phongHoc)
        {
            MaPhanCong = maPhanCong;
            MaLop = maLop;
            MaMon = maMon;
            MaGiaoVien = maGiaoVien;
            Ngay = ngay;
            TietHoc = tietHoc;
            PhongHoc = phongHoc;
        }
    }
}
