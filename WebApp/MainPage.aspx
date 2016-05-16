<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainPage.aspx.cs" Inherits="WebApp.MainPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:HyperLink NavigateUrl="~/User.aspx" Text="Войти" ID="HyperLink1" runat="server">Войти</asp:HyperLink>
        &nbsp;&nbsp;&nbsp;
        <asp:HyperLink NavigateUrl="~/Bag.aspx" Text="Корзина" ID="HyperLink2" runat="server">Корзина</asp:HyperLink>
        &nbsp;&nbsp;&nbsp;
        <asp:HyperLink NavigateUrl="~/MainPage.aspx" Text="Товары" ID="HyperLink3" runat="server">Товары</asp:HyperLink>
        <br />
        <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
            <Columns>
                <asp:CommandField SelectText="Добавить" ShowSelectButton="true" />
            </Columns>
        </asp:GridView>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Оформить пополнение" OnClick="Button1_Click" />
    </form>
</body>
</html>
