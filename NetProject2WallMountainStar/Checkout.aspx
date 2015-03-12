<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Checkout.aspx.cs" Inherits="NetProject2WallMountainStar.Checkout" %>

<%@ Import Namespace="WebShopData" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
	<style type="text/css">
		.auto-style1 {
			width: 300px;
		}

		.auto-style2 {
			height: 69px;
		}

		.auto-style3 {
			width: 300px;
			height: 69px;
		}
	</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<div class="wrapper">
		<table class="auto-styleCheckOut">
			<tr>
				<td>
					<asp:Label ID="Label_Address" runat="server" Text="Address"></asp:Label>
				</td>
				<td>
					<asp:TextBox ID="TextBox_Address" runat="server"></asp:TextBox>
					<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox_Address" ErrorMessage="Enter address" ForeColor="Red">*</asp:RequiredFieldValidator>
				</td>
			</tr>
			<tr>
				<td>
					<asp:Label ID="Label_City" runat="server" Text="City"></asp:Label>
				</td>
				<td>
					<asp:TextBox ID="TextBox_City" runat="server"></asp:TextBox>
					<asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox_City" ErrorMessage="Enter city" ForeColor="Red">*</asp:RequiredFieldValidator>
				</td>
			</tr>
			<tr>
				<td>
					<asp:Label ID="Label_Zip" runat="server" Text="Zip"></asp:Label>
				</td>
				<td>
					<asp:TextBox ID="TextBox_Zip" runat="server"></asp:TextBox>
					<asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox_Zip" ErrorMessage="Enter a valid Zip-code ddd dd" ForeColor="Red" ValidationExpression="\d{5}">*</asp:RegularExpressionValidator>
					<asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="TextBox_Zip" ErrorMessage="Enter a Zip code" ForeColor="Red">*</asp:RequiredFieldValidator>
				</td>
			</tr>
			<tr>
				<td>
					<asp:Label ID="Label_Email" runat="server" Text="Email"></asp:Label>
				</td>
				<td>
					<asp:TextBox ID="TextBox_Email" runat="server"></asp:TextBox>
					<asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="TextBox_Email" ErrorMessage="Enter a valid email address" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>
					<asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TextBox_Email" ErrorMessage="Enter a email address" ForeColor="Red">*</asp:RequiredFieldValidator>
				</td>
			</tr>
			<tr>
				<td class="auto-style2">
					<asp:Button ID="Button_SubmitOrder" runat="server" OnClick="Button_SubmitOrder_Click" Text="Submit order" />
				</td>
			</tr>
		</table>
		<div id="receiptWrapper">
			<% decimal totalPrice = 0; %>
			<table>
				<th>Product</th>
				<th>Quantity</th>
				<th>Á Price</th>
				<th>Sum</th>
				<% foreach (var orderRow in ((Order)Session["CurrentOrder"]).OrderRows)
	   {
		   var articlePrice = GetPriceByArticleId(orderRow.ArticleID);
				%>


				<tr>
					<td>
						<%:GetProductNameByArticleId(orderRow.ArticleID) %>
					</td>
					<td>
						<%:orderRow.Quantity %>
					</td>
					<td>
						<%:articlePrice.ToString("C") %>
					</td>
					<td>
						<%:(orderRow.Quantity * articlePrice).ToString("C") %>						<% totalPrice += (orderRow.Quantity * articlePrice); %>
					</td>
				</tr>
				<% } %>
			</table>
			<table>
				<th>Total Price</th>
				<tr>
					<td><%:totalPrice.ToString("C") %></td>
				</tr>
			</table>
		</div>
	</div>

</asp:Content>
