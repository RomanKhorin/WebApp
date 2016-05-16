<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="User.aspx.cs" Inherits="WebApp.User" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 160px;
        }
        #Button1 {}
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:HyperLink NavigateUrl="~/User.aspx" Text="Войти" ID="HyperLink1" runat="server">Войти</asp:HyperLink>
        &nbsp;&nbsp;&nbsp;
        <asp:HyperLink NavigateUrl="~/Bag.aspx" Text="Корзина" ID="HyperLink2" runat="server">Корзина</asp:HyperLink>
        &nbsp;&nbsp;&nbsp;
        <asp:HyperLink NavigateUrl="~/MainPage.aspx" Text="Товары" ID="HyperLink3" runat="server">Товары</asp:HyperLink>
        <br />
    </div>
        <asp:Label ID="Label1" runat="server" Text="Авторизуйтесь:" Font-Size="22pt"></asp:Label>
        <br />
        <br />
        <table style="width:57%;">
            <tr>
                <td class="auto-style1">Введите Имя</td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server" Width="163px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Введите Пароль</td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server" Width="164px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Button ID="Button1" runat="server" Text="Новый пользователь" Width="219px" OnClick="Button1_Click" />
                </td>
                <td>
                    <asp:Button ID="Button2" runat="server" Text="Войти" Width="173px" OnClick="Button2_Click" />
                </td>
            </tr>
        </table>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Требуется ввести регистрационные данные"></asp:Label>
    </form>
    </body>
</html>
