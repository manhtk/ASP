using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class LopDTO
    {
        public string MaLop { get; set; }
        public string TenLop { get; set; }
        public string HeDaoTao { get; set; }
        public int SiSo { get; set; }
        public LopDTO()
        {

        }
        public LopDTO(string maLop, string tenLop, string heDaoTao, int siSo)
        {
            MaLop = maLop;
            TenLop = tenLop;
            HeDaoTao = heDaoTao;
            siSo = siSo;
        }
    }
}
