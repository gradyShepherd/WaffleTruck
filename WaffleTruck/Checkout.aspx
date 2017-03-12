<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Checkout.aspx.cs" Inherits="WaffleTruck.Checkout" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div>
    
        <strong>Enter Information</strong><br />
        <br />
        <br />
    
    </div>
        <asp:Label ID="Label1" AssociatedControlId="txtName" runat="server" Text="Name: "></asp:Label>
        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        <p>
            Phone #:
            <asp:TextBox ID="txtPhone" runat="server" ValidateRequestMode="Enabled"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="btnOrder" runat="server" OnClick="btnOrder_Click" Text="Submit Order" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            <strong>Order Review</strong></p>
       <div runat="server" id="orderDiv"></div>
        <p><a href="OrderHistory.aspx">Order History</a></p>
    </asp:Content>
