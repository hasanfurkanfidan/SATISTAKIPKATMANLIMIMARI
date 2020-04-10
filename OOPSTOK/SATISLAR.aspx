<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="SATISLAR.aspx.cs" Inherits="OOPSTOK.SATISLAR" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <table class ="table table-bordered ">
        <tr>
            <th>SATIŞ ID</th>
                        <th>URUN AD</th>
                        
                        <th>PERSONEL</th>
            <th>MÜŞTERİ</th>
                        <th>TUTAR</th>


             </tr>

            <tbody>

                <asp:Repeater ID="Repeater1" runat="server">  
                    <ItemTemplate>
                        <tr>
                            <td>
                         <%# Eval("SATISID") %>
                            </td>
                               <td>
                         <%# Eval("URUNAD") %>
                            </td>
                               <td>
                         <%# Eval("PERSONELAD") %>
                            </td>
                               <td>
                         <%# Eval("MUSTERIAD") %>
                            </td>
                               <td>
                         <%# Eval("TUTAR") %>
                            </td>




                        </tr>






                  </ItemTemplate>



            </asp:Repeater>
            </tbody>





       

    </table>
        <a href ="SATISEKLE.aspx" class ="btn btn-info ">YENİ PERSONEL EKLE</a>

</asp:Content>
