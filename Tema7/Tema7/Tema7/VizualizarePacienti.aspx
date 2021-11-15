<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="VizualizarePacienti.aspx.cs" Inherits="Tema7.VizualizarePacienti" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style1 {
        width: 100%;
    }
        .auto-style2 {
            height: 26px;
        }
    .auto-style3 {
        text-align: center;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
    <table align="center" class="auto-style1">
        <tr>
            <td class="auto-style3">
                <asp:Label ID="lblMedic" runat="server" Font-Bold="True" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="text-align: center">
                <asp:ListBox ID="ListBox1" runat="server" SelectionMode="Single" AutoPostBack="true" style="text-align: center" Height="105px" Width="199px" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged">

                </asp:ListBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2"></td>
        </tr>
        <tr>
            <td style="text-align: center">
                <asp:Button ID="btnAdaugarePacient" runat="server" Text="Adaugare nou pacient" OnClick="btnAdaugarePacient_Click" />
            </td>
        </tr>
    </table>
</form>
</asp:Content>
