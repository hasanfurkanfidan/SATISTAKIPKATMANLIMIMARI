<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="PERSONELEKLE.aspx.cs" Inherits="OOPSTOK.PERSONELEKLE" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form runat ="server" class ="form-group">
        <div>
<%--            <asp:Label ID="Label1" runat="server" Text="Departman Adı" Font-Bold ="true"></asp:Label>--%>
            
            <asp:TextBox ID="TextBox1" runat="server" CssClass ="form-control" placeholder ="PERSONEL ADI.."></asp:TextBox>
            <br />
            <br />
              <asp:TextBox ID="TextBox2" runat="server" CssClass ="form-control" placeholder ="PERSONEL SOYADI.."></asp:TextBox>
            <br />
            <br />
                          <asp:TextBox ID="TextBox3" runat="server" CssClass ="form-control" placeholder ="PERSONEL MAAŞI... "></asp:TextBox>
            <br />
            <br />
            <asp:DropDownList ID="DropDownList1" runat="server" CssClass ="form form-control"></asp:DropDownList>
        </div>
        <div>
            <asp:button runat="server" text="Personel Ekle" cssclass="btn btn-info " OnClick="Unnamed1_Click"  />
        </div>


    </form>
</asp:Content>
