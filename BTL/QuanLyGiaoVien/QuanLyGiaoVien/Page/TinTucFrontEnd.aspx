<%@ Page Title="" Language="C#" MasterPageFile="~/Page/FrontEnd.Master" AutoEventWireup="true" CodeBehind="TinTucFrontEnd.aspx.cs" Inherits="QuanLyGiaoVien.Page.TinTucFrontEnd" %>

<asp:Content ID="Content2" ContentPlaceHolderID="main_body" runat="server">

    <asp:DataList ID="DataList1" runat="server" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4" GridLines="Both">
        <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
        <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
        <ItemStyle BackColor="White" ForeColor="#330099" />
        <ItemTemplate>
            <table class="auto-style1">
                <tr>
                    <td rowspan="3" >
                        <asp:Image ID="Image1" ImageUrl='<%#Eval("HinhAnh") %>' runat="server" Width="100px" Height="100px" style="margin-right:10px"/>
                    </td>
                    <td>
                        <h3><asp:Literal ID="Literal1" runat="server" Text='<%#Eval("TieuDe") %>'></asp:Literal></h3>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Literal ID="Literal2" runat="server" Text='<%#Eval("TomTat") %>'></asp:Literal>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%#"~/Page/TinTucChiTiet.aspx?ID="+Eval("MaTinTuc") %>'>Xem chi tiết</asp:HyperLink>
                    </td>
                </tr>
            </table>
        </ItemTemplate>
        <SelectedItemStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
    </asp:DataList>

</asp:Content>
<asp:Content ID="Content3" runat="server" contentplaceholderid="head">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</asp:Content>

