<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddIndex.aspx.cs" Inherits="WebApp.AddIndex" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 140px;
        }

        .auto-style2 {
            width: 76px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:HyperLink NavigateUrl="~/MainPage.aspx" Text="Товары" ID="HyperLink3" runat="server">Товары</asp:HyperLink>
            <br />

            <asp:Label ID="Label1" runat="server" Text="Введите данные товара:"></asp:Label>

            <br />
            <br />
            <table style="width: 25%;">
                <tr>
                    <td class="auto-style2">ID товара:</td>
                    <td class="auto-style1">
                        <asp:TextBox ID="TextBox1" runat="server" Width="154px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Количество:</td>
                    <td class="auto-style1">
                        <asp:TextBox ID="TextBox2" runat="server" Width="154px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style1">
                        <asp:Button ID="Button1" runat="server" Text="Пополнить" Width="140px" OnClick="Button1_Click" />
                    </td>
                </tr>
            </table>

        </div>
    </form>
</body>
</html>
