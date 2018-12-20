<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ThongKe.ascx.cs" Inherits="QuanLyGiaoVien.Page.ThongKe" %>
<table width="200px">
    <tr>
        <td align="center" style="background-color: yellowgreen; color: White; font-weight: bold">Thống Kê
        </td>

    </tr>
    <tr>
        <td>Số Lượng Truy Cập: 

        <asp:Literal ID="TruyCap" runat="server"></asp:Literal>
            <br />
        </td>

    </tr>
    <tb>
         <td>Số Lượng Online: 
        
        <asp:Literal ID="Online" runat="server"></asp:Literal>
        <br />
    </td>
    </tb>
</table>
