<%@ Page Title="" Language="C#" MasterPageFile="~/Page/FrontEnd.Master" AutoEventWireup="true" CodeBehind="MonHocFrontEnd.aspx.cs" Inherits="QuanLyGiaoVien.Page.MonHocFrontEnd" %>
<asp:Content ID="Content2" ContentPlaceHolderID="main_body" runat="server">
     <div style="padding-left:50px; text-align:center">
        <p style=" color:blue; font-size:large;font-weight:bold; text-align:center">Danh Sách Môn Học Khoa CNTT</p>
        <p >&nbsp;</p>
        <p >
           
            <asp:GridView ID="dtgDsMon" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical" Height="395px" Width="428px">
                <AlternatingRowStyle BackColor="#DCDCDC" />
                <Columns>
                    <asp:BoundField DataField="MaMon" HeaderText="Mã Môn" />
                    <asp:BoundField DataField="TenMon" HeaderText="Tên Môn" />
                    <asp:BoundField DataField="SoTinChi" HeaderText="Số Tín Chỉ" />
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
           
        </p>
         

    </div>
</asp:Content>
