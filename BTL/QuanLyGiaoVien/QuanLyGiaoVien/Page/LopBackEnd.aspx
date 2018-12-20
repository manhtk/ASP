<%@ Page Title="" Language="C#" MasterPageFile="~/Page/BackEnd.Master" AutoEventWireup="true" CodeBehind="LopBackEnd.aspx.cs" Inherits="QuanLyGiaoVien.Page.LopBackEnd" %>

<asp:Content ID="Content2" ContentPlaceHolderID="main_backEnd" runat="server">
    <table class="auto-style2">
        <tr>
            <td class="auto-style3">
                <asp:Label ID="Label1" runat="server" Text="Mã Lớp:"></asp:Label>
            </td>
            <td class="auto-style3">
                <asp:TextBox ID="tmalop" runat="server" Width="300px" required="true"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">
                <asp:Label ID="Label2" runat="server" Text="Tên Lớp:"></asp:Label>
            </td>
            <td class="auto-style4">
                <asp:TextBox ID="ttenlop" runat="server" Width="300px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">
                <asp:Label ID="Label3" runat="server" Text="Hệ đào tạo:"></asp:Label>
            </td>
            <td class="auto-style5">
                <asp:TextBox ID="thedaotao" runat="server" Width="300px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style6">
                <asp:Label ID="Label4" runat="server" Text="Sĩ Số:"></asp:Label>
            </td>
            <td class="auto-style6">
                <asp:TextBox ID="tsiso" runat="server" Width="300px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2" class="auto-style7">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Button ID="bthem" runat="server" OnClick="bthem_Click" Text="Thêm" Width="55px" />
&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="bsua" runat="server" OnClick="bsua_Click" Text="Sửa" Width="55px" />
&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="bxoa" runat="server" OnClick="bxoa_Click" Text="Xóa" Width="55px" />
            </td>
        </tr>
    </table>
    <p>
&nbsp;</p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label5" runat="server" Font-Size="Medium" ForeColor="Black" Text="Danh sách Lớp Học"></asp:Label>
    </p>
    <p>
        <asp:GridView ID="tb1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" Height="254px" OnPageIndexChanging="tb1_PageIndexChanging" OnSelectedIndexChanged="tb1_SelectedIndexChanged" Width="529px" AllowPaging="True" GridLines="Vertical">
            <AlternatingRowStyle BackColor="#DCDCDC" />
            <Columns>
                <asp:BoundField DataField="MaLop" HeaderText="Mã Lớp" />
                <asp:BoundField DataField="TenLop" HeaderText="Tên Lớp" />
                <asp:BoundField DataField="HeDaoTao" HeaderText="Hệ Đào Tạo" />
                <asp:BoundField DataField="SiSo" HeaderText="Sĩ Số" />
                <asp:CommandField HeaderText="Chọn dòng" ShowSelectButton="True" />
            </Columns>
            <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
            <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
            <RowStyle ForeColor="Black" BackColor="#EEEEEE" />
            <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#0000A9" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#000065" />
        </asp:GridView>
    </p>
</asp:Content>
<asp:Content ID="Content3" runat="server" contentplaceholderid="head">
    <style type="text/css">
        .auto-style2 {
            width: 99%;
        }
        .auto-style3 {
            height: 31px;
        }
        .auto-style4 {
            height: 35px;
        }
        .auto-style5 {
            height: 28px;
        }
        .auto-style6 {
            height: 30px;
        }
        .auto-style7 {
            height: 40px;
        }
    </style>
</asp:Content>

