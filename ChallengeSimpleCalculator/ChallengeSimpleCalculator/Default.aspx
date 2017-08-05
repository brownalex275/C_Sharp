<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeSimpleCalculator.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: medium;
        }
        .auto-style2 {
            font-family: Arial, Helvetica, sans-serif;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Simple Calculator</h2>
        </div>
        <span class="auto-style1">First Value:</span>
        <asp:TextBox ID="firstValueTextBox" runat="server" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
        <br />
        <span class="auto-style2">Second Value:</span><asp:TextBox ID="secondValueTextBox" runat="server" style="margin-left: 6px" Width="132px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="add_btn" runat="server" Height="25px" OnClick="add_btn_Click" Text="+" Width="30px" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="sub_btn" runat="server" Height="25px" OnClick="sub_btn_Click" Text="-" Width="30px" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="mult_btn" runat="server" Height="25px" OnClick="mult_btn_Click" Text="*" Width="30px" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="div_btn" runat="server" Height="25px" OnClick="div_btn_Click" Text="/" Width="30px" />
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server" BackColor="#6699FF"></asp:Label>
    </form>
</body>
</html>
