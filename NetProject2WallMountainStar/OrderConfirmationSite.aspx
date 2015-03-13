<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="OrderConfirmationSite.aspx.cs" Inherits="NetProject2WallMountainStar.OrderConfirmationSite" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<div class="wrapper">
		<h1>Order Confirmation page</h1>
		<p>
			<% var email = (string) Session["Email"]; %>
	                   Thank you for your order!<br />
			An email with your receipt will be sent to <strong><%:email%></strong>
		</p>
		<p>
			&nbsp;<asp:Button ID="Button_BackToStart" runat="server" OnClick="Button1_Click" Text="Back to start" />
		</p>
	</div>
</asp:Content>
