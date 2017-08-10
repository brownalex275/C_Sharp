<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeEpicSpiesAssetTracker.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 150px;
            height: 150px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="font-family: Arial, Helvetica, sans-serif">
            <h2>
                <img class="auto-style1" src="epic-spies-logo.jpg" /><br />
                <br />
                Asset Performance Tracker</h2>
            Asset Name:&nbsp;
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <p>
                Elections Rigged:
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </p>
            <p>
                Acts of Subterfuge Performed: <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            </p>
            <p>
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add Asset" Width="93px" />
            </p>
            <p>
                <asp:Label ID="resultLabel" runat="server"></asp:Label>
            </p>
            <p>
                &nbsp;</p>
        </div>
    </form>
    <p>
        &nbsp;</p>
</body>
</html>
