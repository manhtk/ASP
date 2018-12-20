using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuanLyGiaoVien.Page
{
    public partial class ThongKe : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BUS.BackEnd.ThongKeBUS thongKeBUS = new BUS.BackEnd.ThongKeBUS();
            TruyCap.Text = thongKeBUS.getVisitorCount().ToString();
            Online.Text = Application["CurrentUsers"].ToString();  
        }
    }
}