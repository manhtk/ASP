<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Login.ascx.cs" Inherits="QuanLyGiaoVien.Page.Login" %>
<table width="200px">
<tr>
<td align="center" style="background-color:yellowgreen; color:White;font-weight:bold">
Đăng nhập
</td>
</tr>
<tr>
<td>
User name: <br />
<asp:TextBox runat="server" ID="txtUserName" Width="92%"> </asp:TextBox> <br />
Password: <br />
<asp:TextBox runat="server" ID="txtPassword" Width="92%"></asp:TextBox> <br />
</td>
</tr>
<tr>
<td align="center">
<asp:Button runat="server" ID="cmdLogin" Text="Đăng nhập" />
</td>
</tr>
</table>
