<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Glasaj.aspx.cs" Inherits="labs1.Glasaj" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Image ID="Image1" runat="server" ImageUrl="https://upload.wikimedia.org/wikipedia/mk/6/60/%D0%9B%D0%BE%D0%B3%D0%BE-%D0%A4%D0%98%D0%9D%D0%9A%D0%98.jpg" Width="250px" />
        </div>

        <div>
            <asp:Label ID="displayName" runat="server" Text=""></asp:Label>        
        </div>

        <div>
            <asp:ListBox ID="subjectBox" runat="server" AutoPostBack="True" OnSelectedIndexChanged="subjectBox_SelectedIndexChanged"></asp:ListBox>
            <asp:ListBox ID="creditBox" runat="server" AutoPostBack="True"></asp:ListBox>    
        </div>

        <asp:Button ID="voteButton" runat="server" Text="Гласајте" OnClick="voteButton_Click" />

        <div>
            <asp:Label ID="Label1" runat="server" Text="Предмет:"></asp:Label>
            <br />
            <asp:TextBox ID="subjectInput" runat="server"></asp:TextBox>
        </div>

        <div>
            <asp:Label ID="Label2" runat="server" Text="Кредити:"></asp:Label>
            <br />
            <asp:TextBox ID="creditInput" runat="server"></asp:TextBox>
        </div>

        <asp:Button ID="addButton" runat="server" Text="Додади" OnClick="addButton_Click" />

        <asp:Button ID="deleteButton" runat="server" Text="Избриши" OnClick="deleteButton_Click" />

    </form>
</body>
</html>
