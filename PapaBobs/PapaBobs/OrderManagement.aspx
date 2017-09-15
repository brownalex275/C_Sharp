<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OrderManagement.aspx.cs" Inherits="PapaBobs.OrderManagement" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Order Management</h2>
        </div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Width="247px" OnRowCommand="GridView1_RowCommand">
            <Columns>
                <asp:ButtonField Text="Complete" />
                <asp:BoundField DataField="orderId" HeaderText="Order ID" />
                <asp:BoundField DataField="size" HeaderText="Size" />
                <asp:BoundField DataField="crust" HeaderText="Crust" SortExpression="crust" />
                <asp:BoundField DataField="toppings" HeaderText="Toppings" SortExpression="toppings" />
            </Columns>
        </asp:GridView>
    </form>
</body>
</html>
