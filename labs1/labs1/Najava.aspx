<%@ Page Language="C#" AutoEventWireup="true"
    CodeBehind="Najava.aspx.cs"
    Inherits="labs1.Najava" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Најава</title>
</head>
<body>
    <form id="form1" runat="server">

        <div>
            <asp:Label ID="lblName" runat="server" Text="Име:" />
            <br />
            <asp:TextBox ID="txtName" runat="server" />
            <asp:RequiredFieldValidator
                ID="rfvName"
                runat="server"
                ControlToValidate="txtName"
                ErrorMessage="Внесете име"
                ForeColor="#990000"
                Display="Dynamic" />
        </div>

        <div>
            <asp:Label ID="lblPassword" runat="server" Text="Лозинка:" />
            <br />
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" />
            <asp:RequiredFieldValidator
                ID="rfvPassword"
                runat="server"
                ControlToValidate="txtPassword"
                ErrorMessage="Внесете лозинка"
                ForeColor="#990000"
                Display="Dynamic" />
        </div>

        <div>
            <asp:Label ID="lblEmail" runat="server" Text="Е-маил адреса:" />
            <br />
            <asp:TextBox ID="txtEmail" runat="server" />

            <asp:RequiredFieldValidator
                ID="rfvEmail"
                runat="server"
                ControlToValidate="txtEmail"
                ErrorMessage="Внесете е-маил адреса"
                ForeColor="#990000"
                Display="Dynamic" />

            <asp:RegularExpressionValidator
                ID="revEmail"
                runat="server"
                ControlToValidate="txtEmail"
                ErrorMessage="Невалиден формат"
                ForeColor="#990000"
                Display="Dynamic"
                ValidationExpression="^[^@\s]+@[^@\s]+\.[^@\s]+$" />
        </div>

        <asp:Button ID="btnLogin" runat="server" Text="Најавете се" OnClick="btnLogin_Click" />

    </form>
</body>
</html>