<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApp.Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<script type="text/javascript" src="Scripts/jquery-1.6.2.js"></script>
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem></asp:ListItem>
            <asp:ListItem>Valor 1</asp:ListItem>
            <asp:ListItem>Valor 2</asp:ListItem>
            <asp:ListItem>Valor 3</asp:ListItem>
        </asp:DropDownList>
        <br/>
        <asp:CheckBox ID="CheckBox1" runat="server"  Text="Checkbox 1"/><asp:CheckBox ID="CheckBox2" runat="server" Text="Checkbox 3"/><asp:CheckBox ID="CheckBox3" runat="server" Text="Checkbox 3" />
        <br/>
        <asp:RadioButton ID="RadioButton1" runat="server" Text="Radio 1" GroupName="Rdo" /><asp:RadioButton ID="RadioButton2" runat="server" Text="Radio 2"  GroupName="Rdo" /><asp:RadioButton ID="RadioButton3" runat="server" Text="Radio 3" GroupName="Rdo" />

        <br />
        <br />
        <ul id="minhaul">
            <li id="minhali1">Minha Li 1</li>
            <li>Minha Li 2</li>
            <li>Minha Li 3</li>
            <li>Minha Li 4</li>
        </ul>
        <div id="app"></div>
    </form>
    <script type="text/javascript">
        $(function () {
            $("#minhali1").click(function () {
                $("#app").append("Você clicou na " + $("#minhali1").text());
            });
        });
    </script>
</body>
</html>
