<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Autentificare.aspx.cs" Inherits="Tema8.Autentificare" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Autentificare</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div>


                <h1 style="text-align: center;">Autentificare</h1>
                <br />
                <br />


                <table style="width: 50%; text-align: center; margin-left: auto; margin-right: auto;">
                    
                    <tr>
                        <td style="text-align: right; width: 50%;">
                            <label>Utilizator</label>&emsp;
                        </td>

                        <td style="text-align: left;">
                            <asp:DropDownList ID="ddlUtilizatori" runat="server"></asp:DropDownList>
                        </td>
                    </tr>


                    <tr>
                        <td style="text-align: right">
                            <label>Parola</label>&emsp;
                        </td>

                        <td style="text-align:left;">
                            <asp:TextBox ID="txtParola" runat="server" TextMode="Password"></asp:TextBox>
                        </td>
                    </tr>


                    <tr>
                        <td colspan="2">
                            <asp:Button ID="btnAutentificare" Text="Autentificare" runat="server" OnClick="btnAutentificare_Click" />
                        </td>
                    </tr>


                    <tr>
                        <td colspan="2">
                            <asp:Label ID="lblMesajEroare" Text="mesaj eroare" runat="server" ForeColor="Red"></asp:Label>
                        </td>
                    </tr>
                </table>
            </div>
        </div>
    </form>
</body>
</html>
