using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class TinTucDTO
    {
        public TinTucDTO()
        {

        }
        public TinTucDTO(string maTinTuc, string tieuDe, string noiDung, string hinhAnh, DateTime ngayViet)
        {
            MaTinTuc = maTinTuc;
            TieuDe = tieuDe;
            NoiDung = noiDung;
            HinhAnh = hinhAnh;
            NgayViet = ngayViet;
        }

        public string MaTinTuc { get; set; }
        public string TieuDe { get; set; }
        public string NoiDung { get; set; }
        public string HinhAnh { get; set; }
        public DateTime NgayViet { get; set; }
    }
}
