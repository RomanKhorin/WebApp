<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="WebApp.Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 178px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:HyperLink NavigateUrl="~/User.aspx" Text="Войти" ID="HyperLink1" runat="server">Войти</asp:HyperLink>
            <br />
            <br />

        <asp:Label ID="Label1" runat="server" Text="Введите свои данные:" Font-Bold="True" Font-Size="16pt"></asp:Label>

            <br />
            <br />
            <table style="width: 45%;">
                <tr>
                    <td class="auto-style1">Имя пользователя:</td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server" Width="184px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Пароль:</td>
                    <td>
                        <asp:TextBox ID="TextBox2" runat="server" Width="184px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Фамилия:</td>
                    <td>
                        <asp:TextBox ID="TextBox3" runat="server" Width="184px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Имя:</td>
                    <td>
                        <asp:TextBox ID="TextBox4" runat="server" Width="184px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Отчество:</td>
                    <td>
                        <asp:TextBox ID="TextBox5" runat="server" Width="184px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Дата рождения:</td>
                    <td>
                        <asp:TextBox ID="TextBox6" runat="server" Width="184px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Телефон:</td>
                    <td>
                        <asp:TextBox ID="TextBox7" runat="server" Width="184px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Адрес:</td>
                    <td>
                        <asp:TextBox ID="TextBox8" runat="server" Width="184px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td>
                        <asp:Button ID="Button1" runat="server" Text="Создать" OnClick="Button1_Click" Width="136px" />
                    </td>
                </tr>
            </table>

            <br />
            <asp:Label ID="Label2" runat="server" Text="Подтвердите действие"></asp:Label>

        </div>
    </form>
</body>
</html>
