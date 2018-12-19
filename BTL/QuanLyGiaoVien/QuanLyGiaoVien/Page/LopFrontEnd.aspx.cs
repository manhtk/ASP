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
    public partial class LopFrontEnd : System.Web.UI.Page
    {
        LopDTO L = new LopDTO();
        DsLopFrontEnd Lop = new DsLopFrontEnd();
        public void HienThi()
        {
            dtgDsLop.DataSource = Lop.ShowDsLop();
            dtgDsLop.DataBind();

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            HienThi();
        }
    }
}