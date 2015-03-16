<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ErrorPage.aspx.cs" Inherits="NetProject2WallMountainStar.ErrorPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="wrapper">
        <h1>Error page</h1>
        <p>
            Something went wrong! Please try again later...
            <%:(string)Session["ErrorMessage"] %>
        </p>
        <p>
            &nbsp;<asp:Button ID="Button_BackToLogin" runat="server" OnClick="Button_BackToLogin_Click" Text="Back to login page" />
        </p>
    </div>
</asp:Content>
