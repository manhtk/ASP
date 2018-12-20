using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuanLyGiaoVien.Page
{
    public partial class TinTucChiTiet : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BUS.BackEnd.TinTucBUS tinTucBUS = new BUS.BackEnd.TinTucBUS();
            DataList1.DataSource = tinTucBUS.getNews(Request.QueryString["ID"].ToString());
            DataList1.DataBind();
        }
    }
}