<%@ Page Title="" Language="C#" MasterPageFile="~/Page/BackEnd.Master" AutoEventWireup="true" CodeBehind="LichDayBackEnd.aspx.cs" Inherits="QuanLyGiaoVien.Page.LichDayBackEnd" %>

<asp:Content ID="Content2" ContentPlaceHolderID="main_backEnd" runat="server">
    <div style="padding-left:90px;">
        
        <table  cellpadding="0" cellspacing="0" class="auto-style2" style=" " border="1">
            <tr>
                <td>Mã Phân Công</td>
                <td>
                    <asp:TextBox ID="txtMaPhanCong" runat="server" Width="154px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Tên Lớp</td>
                <td>
                    <asp:DropDownList ID="DropTenlop" runat="server" DataSourceID="SqlDataSource1" DataTextField="TenLop" DataValueField="MaLop" Width="160px">
                    </asp:DropDownList>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:QuanLyGiaoVienConnectionString4 %>" SelectCommand="SELECT * FROM [Lop]"></asp:SqlDataSource>
                </td>
            </tr>
            <tr>
                <td>Tên Môn</td>
                <td>
                    <asp:DropDownList ID="DropTenMon" runat="server" Width="160px" DataSourceID="SqlDataSource2" DataTextField="TenMon" DataValueField="MaMon">
                    </asp:DropDownList>
                    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:QuanLyGiaoVienConnectionString2 %>" SelectCommand="SELECT * FROM [MonHoc]"></asp:SqlDataSource>
                </td>
            </tr>
            <tr>
                <td>Tên Giáo Viên</td>
                <td>
                    <asp:DropDownList ID="DropTenGV" runat="server" Width="160px" DataSourceID="SqlDataSource3" DataTextField="TenGiaoVien" DataValueField="MaGiaoVien">
                    </asp:DropDownList>
                    <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:QuanLyGiaoVienConnectionString5 %>" SelectCommand="SELECT * FROM [GiaoVien]"></asp:SqlDataSource>
                </td>
            </tr>
            <tr>
                <td>Ngày</td>
                <td>
                    <asp:TextBox ID="txtNgay" runat="server" Width="154px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Tiết Học</td>
                <td>
                    <asp:TextBox ID="txtTietHoc" runat="server" Width="153px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Phòng Học</td>
                <td>
                    <asp:TextBox ID="txtPhong" runat="server" Width="154px"></asp:TextBox>
                </td>
            </tr>
        </table>
        <br />
        
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnThem" runat="server" Text="Thêm" OnClick="btnThem_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnSua" runat="server" Text="Sửa" OnClick="btnSua_Click" style="height: 26px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnXoa" runat="server" Text="Xóa" OnClick="btnXoa_Click" />
        <br />
        <br />
   </div>
        <asp:GridView ID="dtgPhanCong" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical" Height="345px" OnSelectedIndexChanged="dtgPhanCong_SelectedIndexChanged" Width="517px">
            <AlternatingRowStyle BackColor="#DCDCDC" />
            <Columns>
                <asp:BoundField DataField="MaPhanCong" HeaderText="Mã PC" />
                <asp:BoundField DataField="TenLop" HeaderText="Tên Lớp" />
                <asp:BoundField DataField="TenMon" HeaderText="Tên Môn" />
                <asp:BoundField DataField="TenGiaoVien" HeaderText="Tên Giáo Viên" />
                <asp:BoundField DataField="Ngay" HeaderText="Ngày" />
                <asp:BoundField DataField="TietHoc" HeaderText="Tiết Học" />
                <asp:BoundField DataField="PhongHoc" HeaderText="Phòng" />
                <asp:CommandField ShowSelectButton="True" />
            </Columns>
            <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
            <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
            <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
            <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#0000A9" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#000065" />
        </asp:GridView>
        <br />
        
    
</asp:Content>
<asp:Content ID="Content3" runat="server" contentplaceholderid="head">
    <style type="text/css">
    .auto-style2 {
        width: 70%;
    }
</style>
</asp:Content>

