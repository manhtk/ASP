using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data.SqlClient;
using System.Data;
using System.Web.UI.WebControls;
using BUS;
using DTOs;
namespace QuanLyGiaoVien.Page
{
    public partial class TinTucBackEnd : System.Web.UI.Page
    {
        BUS.BackEnd.TinTucBUS TucBUS = new BUS.BackEnd.TinTucBUS();
        protected void Page_Load(object sender, EventArgs e)
        {
            hienThi();
        }

        private void hienThi()
        {
        }

        private TinTucDTO GetTinTucDTO()
        {
            try
            {
                return new TinTucDTO(txtMaTinTuc.Text, txtTieuDe.Text, txtTomTat.Text, txtNoiDung.Text,
                    "~/Images/News/" + fileHinhAnh.FileName, DateTime.Parse(txtNgayViet.Text));
            }
            catch
            {
                return null;
            }
        }

        private void savePhoto()
        {
            string pathFile="";
            if (fileHinhAnh.FileName != "")
            {
                pathFile = Server.MapPath("../Images/News/" + fileHinhAnh.FileName);
                fileHinhAnh.PostedFile.SaveAs(pathFile);
            }
        }
        protected void btnAdd_Click(object sender, EventArgs e)
        {
            TinTucDTO t = GetTinTucDTO();
            if( t != null && TucBUS.insertNews(t))
            {
                Response.Write("<script>alert('Thêm thành công')</script>");
            }
            else
            {
                Response.Write("<script>alert('Thêm thất bại')</script>");
            }
            hienThi();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtMaTinTuc.Text != "" && TucBUS.deleteNews(txtMaTinTuc.Text))
            {
                Response.Write("<script>alert('Xóa thành công')</script>");
            }
            else
            {
                Response.Write("<script>alert('Xóa thất bại')</script>");
            }
            hienThi();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            TinTucDTO t = GetTinTucDTO();
            if (t != null && TucBUS.updateNews(t))
            {
                Response.Write("<script>alert('Sửa thành công')</script>");
            }
            else
            {
                Response.Write("<script>alert('Sửa thất bại')</script>");
            }
            hienThi();

        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            txtMaTinTuc.Text = "";
            txtNgayViet.Text = "";
            txtNoiDung.Text = "";
            txtTieuDe.Text = "";
            txtTomTat.Text = "";
        }
    }
}