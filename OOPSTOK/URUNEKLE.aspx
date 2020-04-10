<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="URUNEKLE.aspx.cs" Inherits="OOPSTOK.URUNEKLE" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form runat ="server" class ="form-group">
        <div>
<%--            <asp:Label ID="Label1" runat="server" Text="Departman Adı" Font-Bold ="true"></asp:Label>--%>
            
            <asp:TextBox ID="TextBox1" runat="server" CssClass ="form-control" placeholder ="Ürün Adını Giriniz.."></asp:TextBox>
            <br />
            <br />
              <asp:TextBox ID="TextBox2" runat="server" CssClass ="form-control" placeholder ="Ürünün Adeti... "></asp:TextBox>
            <br />
            <br />
                          <asp:TextBox ID="TextBox3" runat="server" CssClass ="form-control" placeholder ="Ürünün Fiyatı "></asp:TextBox>

        </div>
        <div>
            <asp:button runat="server" text="Ürün Ekle" cssclass="btn btn-info " OnClick="Unnamed1_Click" />
        </div>


    </form>
</asp:Content>
