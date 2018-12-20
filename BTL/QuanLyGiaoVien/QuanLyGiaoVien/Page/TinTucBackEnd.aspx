<%@ Page Title="" Language="C#" MasterPageFile="~/Page/BackEnd.Master" AutoEventWireup="true" CodeBehind="TinTucBackEnd.aspx.cs" Inherits="QuanLyGiaoVien.Page.TinTucBackEnd" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style2 {
            height: 24px;
            width: 520px;
        }
        .auto-style3 {
            height: 25px;
        }
        .auto-style4 {
            height: 26px;
        }
        .auto-style7 {
            height: 29px;
        }
        .auto-style8 {
            height: 30px;
        }
        .auto-style9 {
            height: 31px;
        }
        .auto-style10 {
            height: 100px;
        }
        .auto-style11 {
            height: 60px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main_backEnd" runat="server">
    <p>
        <table class="auto-style2" style="border:solid 1px">
            <tr>
                <td colspan="2"><h2>Thêm tin tức</h2></td>
            </tr>
            <tr>
                <td class="auto-style9">Mã tin tức</td>
                <td class="auto-style9">
                    <asp:TextBox ID="txtMaTinTuc" required="true" runat="server" Width="376px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style11">Tiêu đề:</td>
                <td class="auto-style11">
                    <asp:TextBox ID="txtTieuDe" TextMode="MultiLine" runat="server" Width="379px" Height="55px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style11">Tóm tắt</td>
                <td class="auto-style11">
                    <asp:TextBox ID="txtTomTat" TextMode="MultiLine" runat="server" Height="55px" Width="379px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style10">Nội dung:</td>
                <td class="auto-style10">
                    <asp:TextBox ID="txtNoiDung"  runat="server" TextMode="MultiLine" Height="96px" Width="380px" ></asp:TextBox>

                </td>
            </tr>
            <tr>
                <td class="auto-style8">Hình ảnh</td>
                <td class="auto-style8">
                    <asp:FileUpload ID="fileHinhAnh" runat="server" Width="275px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style7">Ngày viết</td>
                <td class="auto-style4">
                    <asp:TextBox ID="txtNgayViet" runat="server" placeholder="Date/Month/Year" TextMode="DateTimeLocal" Width="189px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3" colspan="2" style="text-align:center">
                    <asp:Button ID="btnAdd" runat="server" Text="Thêm" OnClick="btnAdd_Click" />
                    <asp:Button ID="btnClear" runat="server" Text="Nhập lại" OnClick="btnClear_Click"/>
                    <asp:Button ID="btnUpdate" runat="server" Text="Xóa" OnClick="btnUpdate_Click" />
                </td>
            </tr>
            </table>
    </p>
    <p>
        &nbsp;</p>
    <p>
        <h2 style="text-align:center">Danh sách tin tức</h2>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="MaTinTuc" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:TemplateField HeaderText="Hình ảnh" SortExpression="MaTinTuc">
                    <EditItemTemplate>
                        <asp:Image ID="image1" runat="server" Width="100px" Height="100px" ImageUrl='<%# Eval("HinhAnh") %>'></asp:Image>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Image ID="image1" runat="server" Width="100px" Height="100px"  ImageUrl='<%# Eval("HinhAnh") %>'></asp:Image>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Tin tức" SortExpression="TieuDe">
                    <EditItemTemplate>
                        <a>Tiêu Đề</a><br />
                        <asp:TextBox ID="TextBox1" Width="300px" Height="200px" TextMode="MultiLine" runat="server" Text='<%# Bind("TieuDe") %>'></asp:TextBox>
                        <br />
                        <a>Tóm tắt</a>
                        <br />
                        <asp:TextBox ID="TextBox2" Width="300px" Height="200px" TextMode="MultiLine" runat="server" Text='<%# Bind("TomTat") %>'></asp:TextBox>
                        <a>Nội dung</a>
                        <br />
                        <asp:TextBox ID="TextBox5" Width="300px" Height="200px" TextMode="MultiLine" runat="server" Text='<%# Bind("NoiDung") %>'></asp:TextBox>
                        <a>Ngày viết</a>
                        <br />
                        <asp:TextBox ID="TextBox6" TextMode="DateTime" runat="server" Text='<%# string.Format("dd/MM/yyyy HH:mm",Bind("NgayViet")) %>'></asp:TextBox>

                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label2" runat="server" Text='<%# Bind("TieuDe") %>'></asp:Label>
                        <br />
                        <asp:Label ID="Label3" runat="server" Text='<%# Bind("TomTat") %>'></asp:Label>
                        <br />
                        <asp:Label ID="Label6" runat="server" Text='<%# Bind("NoiDung") %>'></asp:Label>
                        <br />
                        <asp:Label ID="Label7" runat="server" Text='<%# string.Format("dd/MM/yyyy HH:mm",Bind("NgayViet"))%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" CancelText="Hủy" DeleteText="Xóa" EditText="Sửa" InsertText="Thêm" SelectText="Chọn dòng" UpdateText="Cập nhật" HeaderText="Sửa/Xóa" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:QuanLyGiaoVienConnectionString12 %>" DeleteCommand="DELETE FROM [TinTuc] WHERE [MaTinTuc] = @MaTinTuc" InsertCommand="INSERT INTO [TinTuc] ([MaTinTuc], [TieuDe], [TomTat], [NoiDung], [HinhAnh], [NgayViet]) VALUES (@MaTinTuc, @TieuDe, @TomTat, @NoiDung, @HinhAnh, @NgayViet)" SelectCommand="SELECT * FROM [TinTuc]" UpdateCommand="UPDATE [TinTuc] SET [TieuDe] = @TieuDe, [TomTat] = @TomTat, [NoiDung] = @NoiDung, [HinhAnh] = @HinhAnh, [NgayViet] = @NgayViet WHERE [MaTinTuc] = @MaTinTuc">
            <DeleteParameters>
                <asp:Parameter Name="MaTinTuc" Type="String" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="MaTinTuc" Type="String" />
                <asp:Parameter Name="TieuDe" Type="String" />
                <asp:Parameter Name="TomTat" Type="String" />
                <asp:Parameter Name="NoiDung" Type="String" />
                <asp:Parameter Name="HinhAnh" Type="String" />
                <asp:Parameter Name="NgayViet" Type="DateTime" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="TieuDe" Type="String" />
                <asp:Parameter Name="TomTat" Type="String" />
                <asp:Parameter Name="NoiDung" Type="String" />
                <asp:Parameter Name="HinhAnh" Type="String" />
                <asp:Parameter Name="NgayViet" Type="DateTime" />
                <asp:Parameter Name="MaTinTuc" Type="String" />
            </UpdateParameters>
        </asp:SqlDataSource>
    </p>
    <p>
        &nbsp;</p>
    </asp:Content>
