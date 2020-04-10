<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="OOPSTOK.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
   <table class="table = table-bordered ">
       <tr>
           <th>DEPARTMANID</th>
                      <th>DEPARTMANAD</th>

       </tr>
       <tbody>
           <asp:Repeater ID="Repeater1" runat="server">
               <ItemTemplate>
                   <tr>
                       <td>
                           <%# Eval("DEPARTMANID") %>
                           
                       </td>
                       <td>
                            <%# Eval("DEPARTMANAD") %>
                       </td>
                   </tr>
               </ItemTemplate>
           </asp:Repeater>
       </tbody>
   </table>
    <a href ="DEPARTMANEKLE.aspx" class ="btn btn-info  ">Yeni Departman Ekle</a>



       
</asp:Content>
