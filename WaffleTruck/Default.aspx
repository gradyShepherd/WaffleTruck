<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WaffleTruck._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>
            <img src="http://d2gk7xgygi98cy.cloudfront.net/1873-3-large.jpg" />Fresh Waffles Daily</h1>
        <p class="lead">Walter&#39;s Waffle Truck has been open since 1948, serving the best waffles this side of the Mississippi. Hand made, freshly-pressed waffles with toppings to die for, made hot and fresh everyday for your enjoyment.</p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Hours</h2>
            <p>
                These are our hours of operation<asp:Table ID="Table1" runat="server" Height="288px" Width="509px">
                <asp:TableHeaderRow><asp:TableHeaderCell>Monday</asp:TableHeaderCell><asp:TableHeaderCell>Tuesday</asp:TableHeaderCell><asp:TableHeaderCell>Wednesday</asp:TableHeaderCell><asp:TableHeaderCell>Thursday</asp:TableHeaderCell><asp:TableHeaderCell>Friday</asp:TableHeaderCell><asp:TableHeaderCell>Saturday</asp:TableHeaderCell><asp:TableHeaderCell>Sunday</asp:TableHeaderCell></asp:TableHeaderRow>
               <asp:TableRow><asp:TableCell>8:00 AM - 5:00 PM</asp:TableCell><asp:TableCell>8:00 AM - 5:00 PM</asp:TableCell><asp:TableCell>8:00 AM - 5:00 PM</asp:TableCell><asp:TableCell>8:00 AM - 5:00 PM</asp:TableCell><asp:TableCell>8:00 AM - 5:00 PM</asp:TableCell><asp:TableCell>CLOSED</asp:TableCell><asp:TableCell>CLOSED</asp:TableCell></asp:TableRow>
                </asp:Table>
            </p>
            <p>
                &nbsp;</p>
        </div>
    </div>

</asp:Content>
