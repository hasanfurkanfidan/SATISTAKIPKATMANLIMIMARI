<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="SATISEKLE.aspx.cs" Inherits="OOPSTOK.SATISEKLE" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
     <form runat ="server" class ="form-group">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Ürünü Giriniz.." ></asp:Label>
            <asp:DropDownList ID="DropDownList1" runat="server" CssClass = "form form-control"></asp:DropDownList>
            </div>
         <br />
                  <br />


          <div>
            <asp:Label ID="Label2" runat="server" Text="PERSONEL:"></asp:Label>
            <asp:DropDownList ID="DropDownList2" runat="server" CssClass = "form form-control"></asp:DropDownList>
            </div>
                  <br />
         <br />

          <div>
            <asp:Label ID="Label3" runat="server" Text="Müşteri:"></asp:Label>
            <asp:DropDownList ID="DropDownList3" runat="server" CssClass = "form form-control"></asp:DropDownList>
            </div>
                  <br />
         <br />
         <div>
             <asp:TextBox ID="TextBox1" runat="server" CssClass ="form-control" placeholder ="TUTAR"></asp:TextBox>
            </div>

            <asp:button runat="server" text="Satış yap" cssclass="btn btn-info " OnClick="Unnamed1_Click"  />
          
     
    </form>
</asp:Content>
