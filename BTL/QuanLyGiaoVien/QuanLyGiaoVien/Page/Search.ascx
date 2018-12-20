<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Search.ascx.cs" Inherits="QuanLyGiaoVien.Page.Search" %>
<table width="200px">
    <tr>
    <td align="center" style="background-color:yellowgreen; color:White;font-weight:bold">
    Tìm kiếm
    </td>
    </tr>
    <tr>
    <td>Nhập tên cần tìm: <br />
        <asp:TextBox runat="server" ID="txtten" Width="92%"> </asp:TextBox> <br />
    </td>
</tr>
    <tr>
         <td align="center">
           <asp:Button runat="server" ID="cmdTim" Text="Tìm kiếm" />
         </td>
    </tr>
</table>
