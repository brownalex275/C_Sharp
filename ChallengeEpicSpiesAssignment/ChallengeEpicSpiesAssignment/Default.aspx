<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeEpicSpiesAssignment.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 180px;
            height: 190px;
        }
        .auto-style2 {
            font-family: Arial, Helvetica, sans-serif;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>
                <img class="auto-style1" src="epic-spies-logo.jpg" /><br />
                <br />
                <span class="auto-style2">Spy New Assignment Form</span></h2>
        </div>
        Spy Code Name:
        <asp:TextBox ID="spyTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        New Assignment Name:
        <asp:TextBox ID="assignTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        End of Previous Assignment:<asp:Calendar ID="prevCalendar" runat="server"></asp:Calendar>
        <br />
        Start Date of New Assignment:<asp:Calendar ID="startCalendar" runat="server"></asp:Calendar>
        <br />
        Projected End Date of New Assignment:<asp:Calendar ID="endCalendar" runat="server"></asp:Calendar>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Assign Spy" Width="96px" />
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
        <br />
        <br />
    </form>
</body>
</html>
