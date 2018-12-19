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
using BUS.BackEnd;
namespace QuanLyGiaoVien.Page
{
    public partial class LichDayBackEnd : System.Web.UI.Page
    {
        PhanCongDTO P = new PhanCongDTO();
        PhanCongBUS PhanCong = new PhanCongBUS();
        
        public void HienThi()
        {
            dtgPhanCong.DataSource = PhanCong.ShowPhanCong();
            dtgPhanCong.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            HienThi();
        }

        protected void btnThem_Click(object sender, EventArgs e)
        {
            P.MaPhanCong = txtMaPhanCong.Text;
            P.MaLop = DropTenlop.SelectedValue;
            P.MaMon = DropTenMon.SelectedValue;
            P.MaGiaoVien = DropTenGV.SelectedValue;
            P.Ngay = txtNgay.Text;
            P.TietHoc = txtTietHoc.Text;
            P.PhongHoc = txtPhong.Text;
            PhanCong.insertPhanCong(P.MaPhanCong, P.MaLop, P.MaMon, P.MaGiaoVien, P.Ngay, P.TietHoc, P.PhongHoc);
            HienThi();
            xoa();
           


        }
        private void xoa()
        {
            txtMaPhanCong.Focus();
            txtMaPhanCong.Text = "";
            txtNgay.Text = "";
            txtPhong.Text = "";
            txtTietHoc.Text="";

        }

        

      


        protected void btnSua_Click1(object sender, EventArgs e)
        {
            P.MaPhanCong = txtMaPhanCong.Text;
            P.MaLop = DropTenlop.SelectedValue;
            P.MaMon = DropTenMon.SelectedValue;
            P.MaGiaoVien = DropTenGV.SelectedValue;
            P.Ngay = txtNgay.Text;
            P.TietHoc = txtTietHoc.Text;
            P.PhongHoc = txtPhong.Text;
            PhanCong.updatePhanCong(P.MaPhanCong, P.MaLop, P.MaMon, P.MaGiaoVien, P.Ngay, P.TietHoc, P.PhongHoc);
            HienThi();
            xoa();
        }

        protected void btnXoa_Click1(object sender, EventArgs e)
        {
            P.MaPhanCong = txtMaPhanCong.Text;
            PhanCong.detelePhanCong(P.MaPhanCong);
            HienThi();
            xoa();
        }

        protected void dtgPhanCong_SelectedIndexChanged1(object sender, EventArgs e)
        {
            int dong = dtgPhanCong.SelectedIndex;
            txtMaPhanCong.Text = dtgPhanCong.Rows[dong].Cells[0].Text;
            DropTenlop.SelectedItem.Text = dtgPhanCong.Rows[dong].Cells[1].Text;
            DropTenMon.SelectedItem.Text = dtgPhanCong.Rows[dong].Cells[2].Text;
            DropTenGV.SelectedItem.Text = dtgPhanCong.Rows[dong].Cells[3].Text;
            txtNgay.Text = dtgPhanCong.Rows[dong].Cells[4].Text;
            txtTietHoc.Text = dtgPhanCong.Rows[dong].Cells[5].Text;
            txtPhong.Text = dtgPhanCong.Rows[dong].Cells[6].Text;
        }
    }
}