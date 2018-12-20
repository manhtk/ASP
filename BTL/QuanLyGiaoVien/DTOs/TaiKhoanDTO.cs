using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class TaiKhoanDTO
    {
        public TaiKhoanDTO()
        {

        }
        public TaiKhoanDTO(string taiKhoan, string matKhau)
        {
            TaiKhoan = taiKhoan;
            MatKhau = matKhau;
        }

        public string TaiKhoan { get; set; }
        public string MatKhau { get; set; }

    }
}
