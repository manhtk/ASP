using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DTOs;

namespace QuanLyGiaoVien.Page
{
    public partial class Login : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void cmdLogin_Click(object sender, EventArgs e)
        {
            TaiKhoanDTO tk = new TaiKhoanDTO(txtUserName.Text, txtPassword.Text);
            BUS.BackEnd.LoginBUS loginBUS = new BUS.BackEnd.LoginBUS();
            if (loginBUS.login(tk))
            {
                Response.Redirect("HomeBackEnd.aspx");
            }
            else
            {
                Response.Write("<script>alert('Đăng nhập thất bại')</script>");

            }

        }
        
    }
}