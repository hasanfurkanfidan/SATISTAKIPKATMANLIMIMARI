<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="MUSTERIEKLE.aspx.cs" Inherits="OOPSTOK.MUSTERIEKLE" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
     <form runat ="server" class ="form-group">
        <div>
<%--            <asp:Label ID="Label1" runat="server" Text="Departman Adı" Font-Bold ="true"></asp:Label>--%>
            
            <asp:TextBox ID="TextBox1" runat="server" CssClass ="form-control" placeholder ="MÜŞTERİ ADI... "></asp:TextBox>
            <br />
            <br />
              <asp:TextBox ID="TextBox2" runat="server" CssClass ="form-control" placeholder ="MÜŞTERİ SOYADI... "></asp:TextBox>

        </div>
        <div>
            <asp:button runat="server" text="MÜŞTERİ EKLE" cssclass ="btn btn-info " OnClick="Unnamed1_Click" />
        </div>


    </form>
       
</asp:Content>
