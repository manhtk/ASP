using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BUS;
using BUS.BackEnd;
using DTOs;
using System.Windows.Forms;

namespace QuanLyGiaoVien.Page
{
    public partial class GiaoVienBackEnd : System.Web.UI.Page
    {
        GiaoVienDTO dto = new GiaoVienDTO();
        GiaoVienBUS bus = new GiaoVienBUS();
        protected void Page_Load(object sender, EventArgs e)
        {
            hienthi();
        }
        public void hienthi()
        {
            tb1.DataSource = bus.showbang();
            tb1.DataBind();
        }

        protected void bthem_Click(object sender, EventArgs e)
        {
            dto.MaGiaoVien = tmagv.Text;
            dto.TenGiaoVien = ttengv.Text;
            dto.SoDienThoai = tsdt.Text;
            dto.DiaChi = tdc.Text;
            if (dto.SoDienThoai.Length > 11 || dto.SoDienThoai.Length < 10)
                MessageBox.Show("Nhập sai số điện thoại");
            else
            {
                DialogResult rs = MessageBox.Show("Thêm Giáo Viên?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    bus.insertGiaoVien(dto.MaGiaoVien, dto.TenGiaoVien, dto.SoDienThoai, dto.DiaChi);
                    hienthi();
                }
            }
        }

        protected void bsua_Click(object sender, EventArgs e)
        {
            dto.MaGiaoVien = tmagv.Text;
            dto.TenGiaoVien = ttengv.Text;
            dto.SoDienThoai = tsdt.Text;
            dto.DiaChi = tdc.Text;
            if (dto.SoDienThoai.Length > 11 || dto.SoDienThoai.Length < 10)
                MessageBox.Show("Nhập sai số điện thoại");
            else
            {
                DialogResult rs = MessageBox.Show("Sửa Giáo Viên?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    bus.updateGiaoVien(dto.MaGiaoVien, dto.TenGiaoVien, dto.SoDienThoai, dto.DiaChi);
                    hienthi();
                }
            }
        }

        protected void bxoa_Click(object sender, EventArgs e)
        {
            dto.MaGiaoVien = tmagv.Text;
            DialogResult rs = MessageBox.Show("Xóa Giáo Viên?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                bus.deteleGiaoVien(dto.MaGiaoVien);
                hienthi();
            }
        }

        protected void tb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int n = tb1.SelectedIndex;
            tmagv.Text = tb1.Rows[n].Cells[0].Text.ToString();
            ttengv.Text = tb1.Rows[n].Cells[1].Text.ToString();
            tsdt.Text = tb1.Rows[n].Cells[2].Text.ToString();
            tdc.Text = tb1.Rows[n].Cells[3].Text.ToString();
        }

        protected void tb1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            tb1.PageIndex = e.NewPageIndex;
            hienthi();
        }
    }
}