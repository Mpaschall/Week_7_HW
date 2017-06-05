<%@ Page src="SessionOrder.aspx.cs" 
Inherits="SessionOrder"%>
<html>
<head>
<title>Session Order</title>
</head>
<body>
<form method="post" runat="server">
<strong>
<h3>Choose the items you would like to order.</h3>
</strong>
<p/>
<asp:checkboxlist id="order" runat="server">
<asp:listitem value="C# Book"/>
<asp:listitem value="Baseball"/>
<asp:listitem 
value="Bicycle"/>
<asp:listitem value="Dress"/>
<asp:listitem value="Shirt"/>
<asp:listitem value="Shoes"/>
<asp:listitem value="Theater tickets"/>
<asp:listitem value="Compact disc"/>
<asp:listitem value="Cellular phone"/>
<asp:listitem value="Computer"/>
</asp:checkboxlist><asp:button id="submit" Text="Order" runat="server" />
<asp:button id="reset" Text="Reset" runat="server" />
<p/><asp:label id="output" runat="server" />
</form>
</body>
</html> 