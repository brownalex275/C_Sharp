<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PapaBobs.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Papa Bob's Pizza</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="col-md-8 col-sm-6 col-xs-4">
            <div class="page-header">
                <h2>Papa Bob's Pizza</h2>
                <p class="lead">Pizza to Code By</p>
            </div>
                <div class="form-group">
                    <label>Size:</label>
                    <asp:DropDownList ID ="pizzaDropDownList" runat="server" CssClass="form-control" AutoPostBack="True">
                        <asp:ListItem Text="Choose One.." Value ="none" />
                        <asp:ListItem Text="Small (12 inch - $12)" Value ="12.0" />
                        <asp:ListItem Text="Medium (14 inch - $14)" Value ="14.0" />
                        <asp:ListItem Text="Large (16 inch - $16)" Value ="16.0" />
                    </asp:DropDownList> 
                </div>
         
                <div class="form-group">
                    <label>Crust:</label>
                    <asp:DropDownList ID ="crustDropDownList" runat="server" CssClass="form-control" AutoPostBack="True">
                        <asp:ListItem Text="Choose One.." Value ="none" />
                        <asp:ListItem Text="Regular" Value ="0" />
                        <asp:ListItem Text="Thin" Value ="0" />
                        <asp:ListItem Text="Thick (+2$)" Value ="2" />
                    </asp:DropDownList> 
                </div>
        
                <div class="checkbox"><label><asp:CheckBox ID="sausage" runat="server" AutoPostBack="True"  />Sausage</label></div>
                <div class="checkbox"><label><asp:CheckBox ID="pepperoni" runat="server" AutoPostBack="True" />Pepperoni</label></div>
                <div class="checkbox"><label><asp:CheckBox ID="onions" runat="server" AutoPostBack="True" />Onions</label></div>
                <div class="checkbox"><label><asp:CheckBox ID="greenpeppers" runat="server" AutoPostBack="True" />Green Peppers</label></div>
        
                <h4>Deliver To:</h4>
       
                <div class="form-group">
                    <label>Name:</label>
                    <asp:TextBox ID="nameTextBox" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label>Address:</label>
                    <asp:TextBox ID="addressTextBox" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label>Zip:</label>
                    <asp:TextBox ID="zipTextBox" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label>Phone:</label>
                    <asp:TextBox ID="phoneTextBox" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
        
                <h4>Payment:</h4>
        
                <div class="radio"><label><asp:RadioButton ID="cash" runat="server" GroupName="pay" />Cash</label> </div>
                <div class="radio"><label><asp:RadioButton ID="credit" runat="server" GroupName="pay" />Credit</label> </div>
        
                <div><asp:Button ID="orderButton" runat="server" Text="Order" CssClass="btn btn-lg btn-primary" OnClick="orderButton_Click"/>
                    <p> <asp:Label ID="resultLabel" runat="server" style="background-color: #FF5050"></asp:Label></p></div>

                <div><h4>Total Cost: <asp:Label ID="costLabel" runat="server"></asp:Label></h4>
                    </div>
        </div>

    </form>
    <script src="Content/Scripts/jquery-3.1.1.min.js"></script>
    <script src="Content/Scripts/bootstrap.min.js"></script>
</body>
</html>
