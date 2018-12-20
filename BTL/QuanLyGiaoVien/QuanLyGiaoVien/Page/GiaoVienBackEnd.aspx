<%@ Page Title="" Language="C#" MasterPageFile="~/Page/BackEnd.Master" AutoEventWireup="true" CodeBehind="GiaoVienBackEnd.aspx.cs" Inherits="QuanLyGiaoVien.Page.GiaoVienBackEnd" %>

<asp:Content ID="Content2" ContentPlaceHolderID="main_backEnd" runat="server">
    <table class="auto-style2">
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Mã Giáo Viên :"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="tmagv" runat="server" Width="300px" required="true"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="sdfsdfs" runat="server" Text="Tên Giáo Viên:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="ttengv" runat="server" Width="300px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="dfwc" runat="server" Text="Số Điện Thoại:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="tsdt" runat="server" Width="300px" TextMode="Number"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="sdfwc" runat="server" Text="Địa Chỉ"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="tdc" runat="server" Width="300px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Button ID="bthem" runat="server" OnClick="bthem_Click" Text="Thêm" Width="55px" />
&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
                <asp:Button ID="bsua" runat="server" OnClick="bsua_Click" Text="Sửa" Width="55px" />
&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
                <asp:Button ID="bxoa" runat="server" OnClick="bxoa_Click" Text="Xóa" Width="55px" />
            </td>
        </tr>
    </table>
&nbsp;&nbsp;
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label5" runat="server" Font-Size="Medium" Text="Danh Sách Giáo viên "></asp:Label>
&nbsp;<asp:GridView ID="tb1" runat="server" AllowPaging="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" Height="239px" OnPageIndexChanging="tb1_PageIndexChanging" OnSelectedIndexChanged="tb1_SelectedIndexChanged" Width="527px" GridLines="Vertical">
        <AlternatingRowStyle BackColor="#DCDCDC" />
        <Columns>
            <asp:BoundField DataField="MaGiaoVien" HeaderText="Mã Giáo Viên" />
            <asp:BoundField DataField="TenGiaoVien" HeaderText="Tên Giáo Viên" />
            <asp:BoundField DataField="SoDienThoai" HeaderText="Số Điện Thoại" />
            <asp:BoundField DataField="DiaChi" HeaderText="Địa Chỉ" />
            <asp:CommandField HeaderText="Chọn Dòng" ShowSelectButton="True" />
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
</asp:Content>
<asp:Content ID="Content3" runat="server" contentplaceholderid="head">
    <style type="text/css">
        .auto-style2 {
            width: 97%;
            height: 126px;
        }
    </style>
</asp:Content>

