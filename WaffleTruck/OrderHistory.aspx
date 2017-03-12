<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="OrderHistory.aspx.cs" Inherits="WaffleTruck.WebForm1" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <asp:Label runat="server" id="dataLabel"></asp:Label>
    </div>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:WaffleDatabase %>" SelectCommand="SELECT orderTable.orderId, person.name, person.phone, food.foodName FROM food INNER JOIN orderTable ON food.foodId = orderTable.foodId INNER JOIN person ON orderTable.personId = person.personId" UpdateCommand="UPDATE person SET name = @name, phone = @phone FROM person INNER JOIN orderTable ON person.personId = orderTable.personId WHERE (orderTable.orderId = @orderId)" DeleteCommand="DELETE FROM [orderTable] WHERE [orderId] = @orderId">
            <DeleteParameters>
                <asp:Parameter Name="orderId" />
            </DeleteParameters>
            <UpdateParameters>
                <asp:Parameter Name="name" />
                <asp:Parameter Name="phone" />
                <asp:Parameter Name="orderId" />
            </UpdateParameters>
        </asp:SqlDataSource>
        <asp:GridView Style="margin-top:20px" ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#CC9966" BorderStyle="Ridge" BorderWidth="5px" CellPadding="4" DataSourceID="SqlDataSource1" Width="562px" DataKeyNames="orderId">
            <Columns>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                <asp:BoundField DataField="orderId" HeaderText="Order Number" InsertVisible="False" ReadOnly="True" SortExpression="orderId" />
                <asp:BoundField DataField="name" HeaderText="Name" SortExpression="name" />
                <asp:BoundField DataField="phone" HeaderText="Phone" SortExpression="phone" />
                <asp:BoundField DataField="foodName" HeaderText="Food Item" SortExpression="foodName" />
            </Columns>
            <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
            <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
            <RowStyle BackColor="White" ForeColor="#330099" />
            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
            <SortedAscendingCellStyle BackColor="#FEFCEB" />
            <SortedAscendingHeaderStyle BackColor="#AF0101" />
            <SortedDescendingCellStyle BackColor="#F6F0C0" />
            <SortedDescendingHeaderStyle BackColor="#7E0000" />
        </asp:GridView>
    </asp:Content>
