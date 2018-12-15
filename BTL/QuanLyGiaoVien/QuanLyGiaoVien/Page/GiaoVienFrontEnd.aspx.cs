using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using DTOs;
using DALs;

using BUS.FrontEnd;

namespace QuanLyGiaoVien.Page
{
    public partial class GiaoVienFrontEnd : System.Web.UI.Page
    {
        GiaoVienDTO G = new GiaoVienDTO();
        DsGiaoVienFrontEnd ds = new DsGiaoVienFrontEnd();
        public void HienThi()
        {
            dtgDsGiaoVien.DataSource = ds.ShowDsGiaoVien();
            dtgDsGiaoVien.DataBind();
        }


        protected void Page_Load(object sender, EventArgs e)
        {
            HienThi();
        }

        protected void dtgDsGiaoVien_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}