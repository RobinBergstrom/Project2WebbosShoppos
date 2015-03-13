<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="NetProject2WallMountainStar.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" runat="server" contentplaceholderid="ContentPlaceHolder1">
    <div class="wrapper"> <h1>Welcome <%:User.Identity.Name %></h1>
		<asp:GridView ID="GridView1" runat="server" Height="16px" style="margin-top: 5px" Width="405px" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" DataKeyNames="ArticleID" DataSourceID="SqlDataSource1" ForeColor="Black" GridLines="Vertical">
			<AlternatingRowStyle BackColor="#CCCCCC" />
			<Columns>
				<asp:CommandField ShowSelectButton="True" />
				<asp:BoundField DataField="ArticleID" HeaderText="ArticleID" InsertVisible="False" ReadOnly="True" SortExpression="ArticleID" />
				<asp:BoundField DataField="Text" HeaderText="Text" SortExpression="Text" />
				<asp:BoundField DataField="Unitprice" HeaderText="Unitprice" SortExpression="Unitprice" />
			</Columns>
			<FooterStyle BackColor="#CCCCCC" />
			<HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
			<PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
			<SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
			<SortedAscendingCellStyle BackColor="#F1F1F1" />
			<SortedAscendingHeaderStyle BackColor="#808080" />
			<SortedDescendingCellStyle BackColor="#CAC9C9" />
			<SortedDescendingHeaderStyle BackColor="#383838" />
		</asp:GridView>
		<asp:Button ID="Button_AddToCart" runat="server" OnClick="Button_AddToCart_Click" Text="Add to cart" />
		<asp:Button ID="Button_Checkout" runat="server" Height="28px" OnClick="Button_Checkout_Click" Text="Proceed to checkout" Width="200px" />
		<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:WebShopConnectionString %>" SelectCommand="SELECT * FROM [Articles]"></asp:SqlDataSource>
	    <asp:Button ID="Button_ClearCart" runat="server" OnClick="Button_ClearCart_Click" Text="Clear cart" />
	</div>
	</asp:Content>

