<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AdaugarePacient.aspx.cs" Inherits="Tema7.AdaugarePacient" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">

    .auto-style4 {
        height: 34px;
        text-align: center;
    }
    .auto-style5 {
        text-align: center;
    }
    .auto-style1 {
        width: 100%;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
    <table align="center" class="auto-style1">
        <tr>
            <td class="auto-style4">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style4">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="lblAdaugarePacient" runat="server" Font-Bold="True" Text="Datele pacientului"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style4">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="lblNume" runat="server" Text="Nume"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtNume" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style4">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Label ID="Label1" runat="server" Text="CNP"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtCNP" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label2" runat="server" Text="Sex"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:DropDownList ID="ddlSex" runat="server">
                    <asp:ListItem>feminin</asp:ListItem>
                    <asp:ListItem>masculin</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Label ID="Label3" runat="server" Text="Locul nasterii"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtLoculNasterii" runat="server"></asp:TextBox>
&nbsp;
                <asp:Label ID="Label4" runat="server" Text="Data nasterii"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtDataNasterii" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">&nbsp; <asp:Label ID="Label5" runat="server" Text="Varsta"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtVarsta" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label6" runat="server" Text="Asigurat"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:DropDownList ID="ddlAsigurat" runat="server">
                    <asp:ListItem>da</asp:ListItem>
                    <asp:ListItem>nu</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style5">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
        </tr>
        <tr>
            <td class="auto-style5">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnAdaugare" runat="server" Text="Adaugare pacient" OnClick="btnAdaugare_Click" style="height: 29px" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnBack" runat="server" OnClick="btnBack_Click" Text="Back" />
            </td>
        </tr>
    </table>
</form>
</asp:Content>
