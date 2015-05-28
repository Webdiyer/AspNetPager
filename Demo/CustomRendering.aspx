<%@ Page Language="C#" AutoEventWireup="true" MetaDescription="This sample demonstrate how to customize data rendering logic without data bound control." CodeFile="CustomRendering.aspx.cs" Inherits="CustomRendering_Default" MasterPageFile="AspNetPager.master"%>

<asp:Content runat="server" ID="content1" ContentPlaceHolderID="main">
    <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
    <webdiyer:AspNetPager ID="AspNetPager1" runat="server" OnPageChanged="AspNetPager1_PageChanged">
    </webdiyer:AspNetPager>

</asp:Content>
