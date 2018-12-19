<%@ Page Title="" Language="C#" MasterPageFile="~/Page/FrontEnd.Master" AutoEventWireup="true" CodeBehind="LichDayFrontEnd.aspx.cs" Inherits="QuanLyGiaoVien.Page.LichDayFrontEnd" %>

<asp:Content ID="Content2" ContentPlaceHolderID="main_body" runat="server">
    <div style="padding-left:10px; text-align:center">
        <p style=" color:blue; font-size:large;font-weight:bold; text-align:center">Lịch Giảng Dạy Khoa CNTT</p>
        <p >&nbsp;</p>
        <p >
    
        </p>
         
            <asp:GridView ID="dtgLichDay" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical" Height="353px" CssClass="auto-style1" Width="506px">
                <AlternatingRowStyle BackColor="#DCDCDC" />
                <Columns>
                    <asp:BoundField DataField="MaPhanCong" HeaderText="Mã Phân Công" />
                    <asp:BoundField DataField="TenLop" HeaderText="Tên Lớp" />
                    <asp:BoundField DataField="TenMon" HeaderText="Tên Môn Học" />
                    <asp:BoundField DataField="TenGiaoVien" HeaderText="Giáo Viên" />
                    <asp:BoundField DataField="Ngay" HeaderText="Ngày" />
                    <asp:BoundField DataField="TietHoc" HeaderText="Tiết Học" />
                    <asp:BoundField DataField="PhongHoc" HeaderText="Phòng" />
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


    </div>
</asp:Content>
<asp:Content ID="Content3" runat="server" contentplaceholderid="head">
    <style type="text/css">
        .auto-style1 {
            margin-left: 0;
        }
    </style>
</asp:Content>

