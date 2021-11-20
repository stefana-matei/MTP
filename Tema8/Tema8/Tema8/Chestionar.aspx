<%@ Page Title="Chestionar" Language="C#" MasterPageFile="~/PageMaster.Master" AutoEventWireup="true" CodeBehind="Chestionar.aspx.cs" Inherits="Tema8.Chestionar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style1 {
        width: 100%;
    }
    .auto-style2 {
        width: 558px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style2">
                <asp:Label ID="lblChestionar" runat="server"></asp:Label>
            </td>
            <td>
                <asp:Button ID="btnSalvareChestionar" runat="server" OnClick="btnSalvareChestionar_Click" Text="Salveaza chestionar" />
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>
                <asp:TextBox ID="txtRaspunsuriChestionar" runat="server" Height="92px" TextMode="MultiLine" Width="517px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</form>
</asp:Content>
