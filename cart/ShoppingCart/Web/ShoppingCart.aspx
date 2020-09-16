<%@ Page Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeFile="ShoppingCart.aspx.cs" Inherits="ShoppingCart" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
    <asp:Label ID="messageLabel" runat="server"></asp:Label>
    
    <asp:Repeater ID="ShoppingCartRepeater" runat="server" OnItemCommand="ShoppingCartRepeater_ItemCommand">
    <HeaderTemplate>
        <table cellpadding="2" cellspacing="3" border="0">
        <tr>
            <td>Remove</td>
            <td>Name</td>
            <td>Category</td>
            <td>Price</td>
            <td>Qty</td>
            <td>Subtotal</td>
        </tr>
    </HeaderTemplate>
    <ItemTemplate>
        <tr>
            <td><asp:CheckBox ID="removeCheckBox" runat="server" /></td>
            <td><%# Eval("ProductName") %></td>
            <td><%# Eval("CategoryName") %></td>
            <td><%# Eval("Price", "{0:c}") %></td>
            <td><asp:TextBox ID='qtyTextBox' Text='<%# Eval("Quantity") %>' Columns="3" runat="server"></asp:TextBox></td>
            <td><%# Eval("Subtotal", "{0:c}")%></td>
        </tr>
        <asp:HiddenField ID='ProductIDHiddenField' Value='<%# Eval("ProductID") %>' runat='server' />
    </ItemTemplate>
    <FooterTemplate>
        <tr>
            <td colspan="6" align="right">Total: &nbsp;<%# cartTotal.ToString("c")%></td>
        </tr>
        <tr>
            <td colspan="6" align="center">
                <asp:Button ID="removeAllButton" CommandName="RemoveAll" Text="RemoveAll" runat="server" />&nbsp;
                <asp:Button ID="qtyButton" CommandName="ChangeQty" Text="Cahange Qty / Remove" runat="server" />&nbsp;
                <asp:Button ID="storeButton" CommandName="Store" Text="Back To Store" runat="server" />&nbsp;
                <asp:Button ID="checkoutButton" CommandName="Checkout" Text="Checkout" runat="server" />
            </td>
        </tr>
        </table>
    </FooterTemplate>
    </asp:Repeater>
</asp:Content>

