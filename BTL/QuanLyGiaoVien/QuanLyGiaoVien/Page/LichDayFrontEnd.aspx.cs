using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DALs;
using DTOs;
using BUS.FrontEnd;
namespace QuanLyGiaoVien.Page
{
    public partial class LichDayFrontEnd : System.Web.UI.Page
    {
        PhanCongDTO P = new PhanCongDTO();
        LichGiangDayFrontEnd GD = new LichGiangDayFrontEnd();
        public void HienThi()
        {
            dtgLichDay.DataSource = GD.ShowLichDay();
            dtgLichDay.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            HienThi();
        }
    }
}