<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="URUN.aspx.cs" Inherits="OOPSTOK.URUN" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <table class ="table table-bordered ">
        <tr>
            <th>URUN ID</th>
                        <th>URUN AD</th>
                        
                        <th>URUN ADET</th>
            <th>URUN FIYAT</th>


             </tr>

            <tbody>

                <asp:Repeater ID="Repeater1" runat="server">  
                    <ItemTemplate>
                        <tr>
                            <td>
                         <%# Eval("URUNID") %>
                            </td>
                               <td>
                         <%# Eval("URUNAD") %>
                            </td>
                               <td>
                         <%# Eval("URUNADET") %>
                            </td>
                               <td>
                         <%# Eval("URUNFIYAT") %>
                            </td>





                        </tr>






                  </ItemTemplate>



            </asp:Repeater>
            </tbody>





       

    </table>
    <a href="URUNEKLE.aspx" Class="btn btn-info">Ürün eklemek için tıklayınız..</a>
</asp:Content>
