using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class GiaoVienDTO
    {
        public string MaGiaoVien { get; set; }
        public string TenGiaoVien { get; set; }
        public string SoDienThoai { get; set; }
        public string DiaChi { get; set; }
        public GiaoVienDTO()
        {

        }
        public GiaoVienDTO(string maGiaoVien, string tenGiaoVien, string soDienThoai, string diaChi)
        {
            MaGiaoVien = maGiaoVien;
            TenGiaoVien = tenGiaoVien;
            SoDienThoai = soDienThoai;
            DiaChi = diaChi;
        }
    }
}
