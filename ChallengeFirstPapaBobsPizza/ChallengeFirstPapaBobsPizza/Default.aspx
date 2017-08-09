<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeFirstPapaBobsPizza.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 200px;
            height: 200px;
        }
        .auto-style2 {
            font-size: xx-large;
        }
        .auto-style3 {
            font-family: Arial, Helvetica, sans-serif;
        }
        .auto-style4 {
            color: #FF0000;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <strong><span class="auto-style2">
            <img class="auto-style1" src="PapaBob.png" /><span class="auto-style3">Papa Bob&#39;s Pizza and Software<br />
            <br />
            </span></span></strong>
        </div>
        <asp:RadioButton ID="babyRadioButton" runat="server" GroupName="size" Text="Baby Bob Size (10&quot;) - $10" />
        <br />
        <asp:RadioButton ID="mamaRadioButton" runat="server" GroupName="size" Text="Mama Bob Size (13&quot;) - $13" />
        <br />
        <asp:RadioButton ID="papaRadioButton" runat="server" GroupName="size" Text="Papa Bob Size (16&quot;) - $16" />
        <br />
        <br />
        <asp:RadioButton ID="thinRadioButton" runat="server" GroupName="crust" Text="Thin Crust" />
        <br />
        <asp:RadioButton ID="deepRadioButton" runat="server" GroupName="crust" Text="Deep Dish (+2$)" />
        <br />
        <br />
        <asp:CheckBox ID="pepperoniCheckBox" runat="server" Text="Pepperoni (+$1.50)" />
        <br />
        <asp:CheckBox ID="onionsCheckBox" runat="server" Text="Onions (+$0.75)" />
        <br />
        <asp:CheckBox ID="greenCheckBox" runat="server" Text="Green Peppers (+$0.50)" />
        <br />
        <asp:CheckBox ID="redCheckBox" runat="server" Text="Red Peppers (+$0.75)" />
        <br />
        <asp:CheckBox ID="anchoviesCheckBox" runat="server" Text="Anchovies (+$2)" />
        <br />
        <br />
        <h2 class="auto-style3">Papa Bob&#39;s <span class="auto-style4">Special Deal</span></h2>
        Save $2.00 when you add Pepperoni, Green Peppers and Anchovies OR Pepperoni, Red Peppers and Onions to your pizza.<br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Purchase" Width="97px" />
        <br />
        <br />
        Total: $<asp:Label ID="resultLabel" runat="server"></asp:Label>
        <br />
        <br />
        Sorry, at this time you can only order one pizza online, and pick-up only...we need a better website!<br />
        <br />
    </form>
</body>
</html>
