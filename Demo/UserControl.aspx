<%@ Page Language="C#" MasterPageFile="AspNetPager.master" AutoEventWireup="true"  MetaDescription="This sample demonstrates how to use AspNetPager control within the user control." CodeFile="UserControl.aspx.cs" Inherits="UserControl_Default"%>

<%@ Register Src="PagerControl.ascx" TagName="PagerControl" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="main" Runat="Server">
    <uc1:PagerControl ID="PagerControl1" runat="server" />
    <asp:Button ID="Button1" runat="server" Text="PostBack" OnClick="Button1_Click" />
    <asp:Label ID="Label1" runat="server" EnableViewState="False"></asp:Label>
</asp:Content>

