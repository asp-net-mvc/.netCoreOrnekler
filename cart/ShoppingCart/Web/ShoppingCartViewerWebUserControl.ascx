<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ShoppingCartViewerWebUserControl.ascx.cs" Inherits="ShoppingCartViewerWebUserControl" %>

<asp:Repeater ID="ShoppingCartRepeater" runat="server">
    <HeaderTemplate>
        <table cellpadding="2" cellspacing="3" border="0">
        <tr>
            <td>Name</td>
            <td>Price</td>
            <td>Qty</td>
            <td>Subtotal</td>
        </tr>
    </HeaderTemplate>
    <ItemTemplate>
        <tr>
            <td><%# Eval("ProductName") %></td>
            <td><%# Eval("Price", "{0:c}") %></td>
            <td><%# Eval("Quantity") %></td>
            <td align="right"><%# Eval("Subtotal", "{0:c}")%></td>
        </tr>
    </ItemTemplate>
    <FooterTemplate>
        <tr>
            <td colspan="4" align="right">Total: &nbsp;<%# cartTotal.ToString("c") %></td>
        </tr>
        </table>
    </FooterTemplate>
    </asp:Repeater>
