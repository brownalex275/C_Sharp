<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeConditionalRadioButton.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Your Note Taking Preferences<br />
            <br />
            <asp:RadioButton ID="pencilRadioButton" runat="server" Text="Pencil" GroupName="note" />
            <br />
            <asp:RadioButton ID="penRadioButton" runat="server" Text="Pen" GroupName="note" />
            <br />
            <asp:RadioButton ID="phoneRadioButton" runat="server" Text="Phone" GroupName="note" />
            <br />
            <asp:RadioButton ID="tabletRadioButton" runat="server" Text="Tablet" GroupName="note" />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="OK" Width="36px" />
            <br />
            <br />
            <asp:Image ID="noteImage" runat="server" />
            <br />
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
