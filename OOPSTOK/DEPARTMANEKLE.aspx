<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="DEPARTMANEKLE.aspx.cs" Inherits="OOPSTOK.DEPARTMANEKLE" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form runat ="server" class ="form-group">
        <div>
<%--            <asp:Label ID="Label1" runat="server" Text="Departman Adı" Font-Bold ="true"></asp:Label>--%>
            
            <asp:TextBox ID="TextBox1" runat="server" CssClass ="form-control" placeholder ="Deparman adını giriniz... "></asp:TextBox>
        </div>
        <div>
            <asp:Button ID="Button1" runat="server" Text="Departman Kaydet" CssClass ="btn btn-info" OnClick="Button1_Click" />
        </div>


    </form>
</asp:Content>
