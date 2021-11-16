<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="retailCrud.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>index</title>
</head>
<body>
    <form id="index" runat="server">
        <div>

            HOME<br />
            <br />
            select any one:<br />
            <br />
            <br />
            <asp:Button ID="btnEmployee" runat="server" OnClick="btnEmployee_Click" Text="EMPLOYEES" />
            <br />
            <br />
            <br />
            <asp:Button ID="btnSupplier" runat="server" Text="SUPPLIERS" />
            <br />
            <br />
            <br />
            <asp:Button ID="btnProduct" runat="server" Text="PRODUCTS" />

        </div>
    </form>
</body>
</html>
