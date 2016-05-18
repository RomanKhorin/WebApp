<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Bag.aspx.cs" Inherits="WebApp.Bag" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
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
            <br />
            <asp:GridView ID="GridView1" runat="server">
                <Columns>
                    <asp:TemplateField HeaderText="Quantity">
                        <ItemTemplate>
                            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>

            </asp:GridView>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Заказать" Width="105px" OnClick="Button1_Click" />
            <br />

        </div>
    </form>
</body>
</html>
