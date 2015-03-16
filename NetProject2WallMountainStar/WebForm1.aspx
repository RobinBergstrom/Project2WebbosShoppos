<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="NetProject2WallMountainStar.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" runat="server" contentplaceholderid="ContentPlaceHolder1">
    <div class="wrapper"> <h1>Welcome <%:User.Identity.Name %></h1>
        	<asp:Button ID="Button_Checkout" runat="server" Height="28px" OnClick="Button_Checkout_Click" Text="Proceed to checkout" Width="200px" />
        <div id="labelEmptyCart">
        		<asp:Label ID="Label_EmptyCart" runat="server" Text="Your cart is empty"></asp:Label>
        </div>
		<asp:GridView ID="GridView1" runat="server" Height="16px" style="margin-top: 5px" Width="100%" AllowSorting="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="3" DataKeyNames="ArticleID" DataSourceID="SqlDataSource1" ForeColor="Black" GridLines="None" OnSelectedIndexChanged="Gridviewbutton_Buy" EnableViewState="False">
			<AlternatingRowStyle BackColor="#CCCCCC" />
			<Columns>
				<asp:ButtonField ButtonType="Image" ImageUrl="~/Images/lg-55ub950v(214306)_Small.jpg" Text="Button">
				<HeaderStyle Height="50px" Width="50px" />
				</asp:ButtonField>
				<asp:BoundField DataField="ArticleID" HeaderText="ArticleID" InsertVisible="False" ReadOnly="True" SortExpression="ArticleID" >
				<ControlStyle BackColor="#FF3300" BorderColor="#CC0000" />
                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                </asp:BoundField>
				<asp:BoundField DataField="Text" HeaderText="Product" SortExpression="Text" >
				<HeaderStyle Wrap="True" />
				<ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
				</asp:BoundField>
				<asp:BoundField DataField="Unitprice" HeaderText="Price" SortExpression="Unitprice" DataFormatString="{0:c0}" >
				<ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                </asp:BoundField>
				<asp:CommandField ShowSelectButton="True" ButtonType="Button" SelectText="Buy" >
			    <ControlStyle Height="75%" Width="75%" />
                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                </asp:CommandField>
			</Columns>
			<EditRowStyle HorizontalAlign="Center" VerticalAlign="Middle" />
			<FooterStyle BackColor="#CCCCCC" />
			<HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
			<PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
			<SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
			<SortedAscendingCellStyle BackColor="#F1F1F1" />
			<SortedAscendingHeaderStyle BackColor="#808080" />
			<SortedDescendingCellStyle BackColor="#CAC9C9" />
			<SortedDescendingHeaderStyle BackColor="#383838" />
		</asp:GridView>
	
		<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:WebShopConnectionString %>" SelectCommand="SELECT * FROM [Articles]"></asp:SqlDataSource>
	    
	</div>
	</asp:Content>

