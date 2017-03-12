<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Thanks.aspx.cs" Inherits="WaffleTruck.Thanks" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">    <div style="text-align: center; font-weight: 700">
    
        <h1>Thank you for your order!</h1>

        <h3>Summary</h3>
    
        <asp:Label ID="lblName" runat="server" style="text-align: center" Text="Label"></asp:Label>
&nbsp;<br />
        <asp:Label ID="lblPhone" runat="server" Text="Label"></asp:Label>
        <br />
        <span class="auto-style1">Order</span><br />
        <asp:TextBox ID="txtReview" runat="server" Height="122px" ReadOnly="True" Rows="10" TextMode="MultiLine" Width="162px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnHome" runat="server" OnClick="btnHome_Click" Text="Home" />
    
    </div>
  </asp:Content>
