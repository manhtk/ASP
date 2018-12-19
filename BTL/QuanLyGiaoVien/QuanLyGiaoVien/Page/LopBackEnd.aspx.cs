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
    public partial class LopBackEnd : System.Web.UI.Page
    {
        LopDTO dto = new LopDTO();
        LopBUS bus = new LopBUS();
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
            dto.MaLop = tmalop.Text;
            dto.TenLop = ttenlop.Text;
            dto.HeDaoTao = thedaotao.Text;
            try
            {
                dto.SiSo = int.Parse(tsiso.Text);
                if (dto.SiSo < 1 || dto.SiSo > 200)
                {
                    MessageBox.Show("Nhập sai sĩ số");
                }
                else
                {
                    DialogResult rs = MessageBox.Show("Thêm Lớp?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (rs == DialogResult.Yes)
                    {
                        bus.insertLop(dto.MaLop, dto.TenLop, dto.HeDaoTao, dto.SiSo);
                        hienthi();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Nhập sai sĩ số","Message");
            }
        }

        protected void bsua_Click(object sender, EventArgs e)
        {
            dto.MaLop = tmalop.Text;
            dto.TenLop = ttenlop.Text;
            dto.HeDaoTao = thedaotao.Text;
            try
            {
                dto.SiSo = int.Parse(tsiso.Text);
                if (dto.SiSo < 1 || dto.SiSo > 200)
                {
                    MessageBox.Show("Nhập sai sĩ số");
                }
                else
                {
                    DialogResult rs = MessageBox.Show("Sửa Lớp?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (rs == DialogResult.Yes)
                    {
                        bus.updateLop(dto.MaLop, dto.TenLop, dto.HeDaoTao, dto.SiSo);
                        hienthi();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Nhập sai sĩ số");
            }
        }

        protected void bxoa_Click(object sender, EventArgs e)
        {
            dto.MaLop = tmalop.Text;
            DialogResult rs = MessageBox.Show("Xóa Lớp?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                bus.deteleLop(dto.MaLop);
                hienthi();
            }
        }

        protected void tb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int n = tb1.SelectedIndex;
            tmalop.Text = tb1.Rows[n].Cells[0].Text.ToString();
            ttenlop.Text = tb1.Rows[n].Cells[1].Text.ToString();
            thedaotao.Text = tb1.Rows[n].Cells[2].Text.ToString();
            tsiso.Text = tb1.Rows[n].Cells[3].Text.ToString();
        }

        protected void tb1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            tb1.PageIndex = e.NewPageIndex;
            hienthi();
        }
    }
}