<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Personel.aspx.cs" Inherits="OOPSTOK.Personel" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <table class ="table table-bordered"
        <tr>
            <th>
                PERSONEL ID
            </th>
            <th>
                PERSONEL AD
            </th>
            <th>PERSONEL SOYAD</th>
            <th>PERSONEL DEPARTMAN</th>
            <th>PERSONEL MAAŞ</th>
            <th>PERSONEL FOTOĞRAF</th>
        </tr>
            <tbody>
                <asp:Repeater ID="Repeater1" runat="server">
                    <ItemTemplate>
                        <tr>
                            <td>
                               <%# Eval("PERSONELID") %>
                                </td>
                            <td>
                                <%# Eval("PERSONELAD") %>
                                </td>
                            <td>
                                <%# Eval("PERSONELSOYAD") %>
                                </td>
                            <td>
                                <%# Eval("Perdep") %>
                                </td>
                            <td>
                                <%# Eval("PERSONELMAAS") %>
                                </td>
                              </td>
                                <%# Eval("PERSONELFOTOGRAF") %>
                            </td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </tbody>



        </table>
    <a href ="PERSONELEKLE.aspx" class ="btn btn-info ">YENİ PERSONEL EKLE</a>
</asp:Content>
