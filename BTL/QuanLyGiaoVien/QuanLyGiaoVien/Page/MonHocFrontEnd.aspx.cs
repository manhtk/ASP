using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DALs;
using DTOs;
using BUS.FrontEnd;
using System.Data;
using System.Data.SqlClient;
namespace QuanLyGiaoVien.Page
{
    public partial class MonHocFrontEnd : System.Web.UI.Page
    {
        MonHocDTO M = new MonHocDTO();
        DsMonHocFrontEnd MH = new DsMonHocFrontEnd();
        public void HienThi()
        {
            dtgDsMon.DataSource = MH.ShowDsMon();
            dtgDsMon.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            HienThi();
        }
    }
}