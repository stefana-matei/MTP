<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Tema7.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 252px;
        }
        .auto-style2 {
            height: 26px;
            text-align: center;
        }
        .auto-style3 {
            height: 51px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
        <table align="center" class="auto-style1">
            <tr>
                <td class="auto-style2"></td>
            </tr>
            <tr>
                <td style="text-align: center">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Large" style="text-align: center" Text="Autentificare"></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="text-align: center">Medic&nbsp;
                    <asp:DropDownList ID="ddlMedici" runat="server" style="margin-left: 4px" Width="187px">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style3" style="text-align: center">
                    <asp:Label ID="Label2" runat="server" Text="Parola"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="txtParola" runat="server" style="margin-left: 0px" TextMode="Password" Width="185px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="text-align: center">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnAutentificare" runat="server" BorderColor="#00CC99" Text="Autentificare" OnClick="btnAutentificare_Click" />
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</asp:Content>
