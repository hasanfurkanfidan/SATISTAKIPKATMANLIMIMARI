<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="MUSTERILER.aspx.cs" Inherits="OOPSTOK.MUSTERILER" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <table class ="table table-bordered">
        <tr>
            <th>MUSTERI ID</th>
            <th>MUSTERI AD</th>
            <th>MUSTERI SOYAD</th>
        </tr>
        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
          <tr>
                       <td>
                           <%# Eval("MUSTERIID") %>
                           
                       </td>
                       <td>
                            <%# Eval("MUSTERIAD") %>
                       </td>
               <td>
                            <%# Eval("MUSTERISOYAD") %>
                       </td>    
                   </tr>
            </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
<a href ="MUSTERIEKLE.aspx" class ="btn btn-info ">YENİ MÜŞTERİ EKLE</a>
</asp:Content>
