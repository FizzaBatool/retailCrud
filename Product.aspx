<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Product.aspx.cs" Inherits="retailCrud.Product" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>product form</title>
</head>
<body>
    <form id="prodform" runat="server">
         
     
        <div style="margin-left: 320px">
            <asp:Label ID="Label1" runat="server" Text="Product Data Form"></asp:Label>
        </div>
        <p>
            Product ID&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
            <asp:TextBox ID="txtid" runat="server" Width="75px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="BTNsearch" runat="server" Text="Search" OnClick="BTNsearch_Click" />
        </p>
        <p>
            Product Name&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtpname" runat="server" Width="115px"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</p>
        <p>
            Quantity&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtquan" runat="server"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </p>
        <p>
            Price&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:TextBox ID="txtprice" runat="server" OnTextChanged="txtquan_TextChanged"></asp:TextBox>
        </p>
        <p>
            Expiry Date&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtexp" runat="server" OnTextChanged="txtquan_TextChanged"></asp:TextBox>
        </p>
        <p>
            &nbsp;Supplier ID&nbsp;&nbsp; <asp:TextBox ID="txtsppID" runat="server"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </p>
            <p>
                <asp:Label ID="testlabel" runat="server" Text="Test Connections"></asp:Label>
        </p>
            <p style="margin-left: 120px">
                <asp:Button ID="BTNinsert" runat="server" Text="Insert" OnClick="Button1_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="BTNupdate" runat="server" Text="Update" OnClick="BTNupdate_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="BTNdelete" runat="server" Text="Delete" OnClick="BTNdelete_Click" />
        </p>
&nbsp;&nbsp;&nbsp;
            <br />
        
            <asp:GridView ID="GridView1" runat="server" Width="664px">
            </asp:GridView>
        </form>
 
</body>
</html>
