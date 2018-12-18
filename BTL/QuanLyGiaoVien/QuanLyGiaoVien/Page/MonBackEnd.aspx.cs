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
    public partial class MonBackEnd : System.Web.UI.Page
    {
        MonHocDTO dto = new MonHocDTO();
        MonHocBUS bus = new MonHocBUS();
        public void hienthi()
        {
            GridView1.DataSource = bus.showbang();
            GridView1.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            hienthi();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            dto.MaMon = tmamon.Text;
            dto.TenMon = ttenmon.Text;
            try
            {
                dto.SoTinChi = int.Parse(tsotinchi.Text);
                if (dto.SoTinChi > 100 || dto.SoTinChi < 10)
                    MessageBox.Show("Nhập sai số tín chỉ");
                else
                {
                    DialogResult rs = MessageBox.Show("Thêm Môn Học?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (rs == DialogResult.Yes)
                    {
                        bus.insertMonHoc(dto.MaMon, dto.TenMon, dto.SoTinChi);
                        hienthi();
                    }
                }
            }

            catch
            {
                MessageBox.Show("Nhập sai số tín chỉ");
            }
        }

        protected void bsua_Click(object sender, EventArgs e)
        {
            dto.MaMon = tmamon.Text;
            dto.TenMon = ttenmon.Text;
            try
            {
                dto.SoTinChi = int.Parse(tsotinchi.Text);
                if (dto.SoTinChi > 100 || dto.SoTinChi < 10)
                    MessageBox.Show("Nhập sai số tín chỉ");
                else
                {
                    DialogResult rs = MessageBox.Show("Sửa Môn Học?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (rs == DialogResult.Yes)
                    {
                        bus.updateMonHoc(dto.MaMon, dto.TenMon, dto.SoTinChi);
                        hienthi();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Nhập sai sô tín chỉ");
            }
        }

        protected void bxoa_Click(object sender, EventArgs e)
        {
            dto.MaMon = tmamon.Text;
            DialogResult rs = MessageBox.Show("Xóa Môn Học?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                bus.deteleMonHoc(dto.MaMon);
                hienthi();
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int n = GridView1.SelectedIndex;
            tmamon.Text = GridView1.Rows[n].Cells[0].Text.ToString();
            ttenmon.Text = GridView1.Rows[n].Cells[1].Text.ToString();
            tsotinchi.Text = GridView1.Rows[n].Cells[2].Text.ToString();
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            hienthi();
        }
    }
}