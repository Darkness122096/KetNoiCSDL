<%@ Page Language="C#" MasterPageFile="~/admin/admin.master" AutoEventWireup="true" CodeFile="LoaiSanPham.aspx.cs" Inherits="admin_LoaiSanPham" %>

<asp:Content ID="cHead" runat="server"  ContentPlaceHolderID="head">

</asp:Content>

<asp:Content ID="cBody" runat="server"  ContentPlaceHolderID="admin_body">
   
     <asp:GridView ID="gvSp" runat="server" AutoGenerateColumns="False" Width="94px">
         <Columns>
             <asp:BoundField DataField="TenLoai" HeaderText="Tên Sản Phẩm" />
         </Columns>

    
     </asp:GridView>

</asp:Content>