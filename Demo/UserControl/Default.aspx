<%@ Page Language="C#" MasterPageFile="~/NavPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="UserControl_Default"%>

<%@ Register Src="PagerControl.ascx" TagName="PagerControl" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="main" Runat="Server">
    <div>Use AspNetPager in user control.</div><br />
    <uc1:PagerControl ID="PagerControl1" runat="server" />
    <asp:Button ID="Button1" runat="server" Text="PostBack" OnClick="Button1_Click" />
    <asp:Label ID="Label1" runat="server" EnableViewState="False"></asp:Label>
</asp:Content>

