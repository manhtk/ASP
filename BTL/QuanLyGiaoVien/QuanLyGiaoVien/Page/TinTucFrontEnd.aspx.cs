using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using BUS;
namespace QuanLyGiaoVien.Page
{
    public partial class TinTucFrontEnd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            hienThi();
        }
        private void hienThi()
        {
            BUS.BackEnd.TinTucBUS tinTucBUS = new BUS.BackEnd.TinTucBUS();
            DataList1.DataSource = tinTucBUS.showNews();
            DataList1.DataBind();
        }
    }
}