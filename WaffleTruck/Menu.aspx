<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Menu.aspx.cs" Inherits="WaffleTruck.Menu" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <strong><span class="auto-style1">Waffle Menu</span></strong><br />
        <br />
        <strong>Select your waffles</strong></div>
        <asp:CheckBoxList ID="lstFood" runat="server">
            <asp:ListItem>Strawberry Waffle</asp:ListItem>
            <asp:ListItem>Belgian Waffle</asp:ListItem>
            <asp:ListItem>Peanut Butter Waffle</asp:ListItem>
            <asp:ListItem>Chocolate Waffle</asp:ListItem>
        </asp:CheckBoxList>
        <asp:Button ID="btnOrder" runat="server" OnClick="btnOrder_Click" Text="Add to Cart" />
        <p>
            &nbsp;</p>
   </asp:Content>
