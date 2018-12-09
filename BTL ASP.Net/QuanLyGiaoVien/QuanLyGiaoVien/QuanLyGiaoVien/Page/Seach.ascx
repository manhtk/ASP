<%@ Master Language="C#" AutoEventWireup="true" CodeBehind="Seach.master.cs" Inherits="QuanLyGiaoVien.Page.Seach" %>

<table width="200px">
<tr>
<td align="center" style="background-color:yellowgreen; color:White;font-weight:bold">
Tìm kiếm
</td>
</tr>
<tr>
<td>
Vào tên sản phẩm cần tìm: <br />
<asp:TextBox runat="server" ID="txtten" Width="92%"> </asp:TextBox> <br />
</td>
</tr>
<tr>
<td align="center">
<asp:Button runat="server" ID="cmdTim" Text="Tìm kiếm" onclick="cmdTim_Click" 
        style="height: 26px" />
</td>
</tr>
</table>