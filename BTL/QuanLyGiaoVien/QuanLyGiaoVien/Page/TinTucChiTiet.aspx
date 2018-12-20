<%@ Page Title="" Language="C#" MasterPageFile="~/Page/FrontEnd.Master" AutoEventWireup="true" CodeBehind="TinTucChiTiet.aspx.cs" Inherits="QuanLyGiaoVien.Page.TinTucChiTiet" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 18px;
        }
        .auto-style3 {
            height: 17px;
        }
        .auto-style4 {
            width: 114px;
        }
    </style>

</asp:Content>
<asp:Content ID="Content2" runat="server" contentplaceholderid="main_body">
    <asp:DataList ID="DataList1" runat="server">
        <ItemTemplate>
            <table class="auto-style1">
                <tr>
                    <td>
                        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/Page/TinTucFrontEnd.aspx">Quay lại</asp:HyperLink>
                    </td>
                </tr>
                <tr>
                    <td>
                        <h1><asp:Literal ID="Literal1" runat="server" Text='<%#Eval("TieuDe") %>'></asp:Literal></h1>
                    </td>
                </tr>
                <tr>
                    <td>
                        <h3><asp:Literal ID="Literal2" runat="server" Text='<%#Eval("TomTat") %>'></asp:Literal></h3>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3" style="width:auto">
                        <asp:Image ID="Image1" runat="server" ImageUrl='<%#Eval("HinhAnh") %>' Width="100%"
                           />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Literal ID="Literal3" runat="server" Text='<%#Eval("NoiDung") %>'></asp:Literal>
                    </td>
                </tr>
                <tr>
                    <td>
                        <table class="auto-style1">
                            <tr>
                                <td class="auto-style4" style="width:80%">&nbsp;</td>
                                <td>
                                    <asp:Literal ID="Literal4" runat="server" Text='<%# string.Format("dd/MM/yyyy HH:mm",Eval("NgayViet")) %>'></asp:Literal>
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Page/TinTucFrontEnd.aspx">Quay lại</asp:HyperLink>
                    </td>
                </tr>
            </table>
        </ItemTemplate>
    </asp:DataList>
</asp:Content>

