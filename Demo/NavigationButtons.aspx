<%@ Page Language="C#" MasterPageFile="AspNetPager.master" MetaDescription="This sample demonstrates how to show or hide paging buttons."  AutoEventWireup="true" CodeFile="NavigationButtons.aspx.cs" Inherits="NavigationButtons_Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="main" Runat="Server">
<div>Show or hide paging elements:
</div><br />
    <webdiyer:aspnetpager id="AspNetPager1" runat="server" RecordCount="288" CssClass="pagination" LayoutType="Ul" PagingButtonLayoutType="UnorderedList" PagingButtonSpacing="0" CurrentPageButtonClass="active"
    Width="100%"></webdiyer:aspnetpager>
    <p>Properties:</p>
    <asp:CheckBox ID="ck_disbtn" runat="server" Checked="True" Text="ShowDisabledButtons" AutoPostBack="True" /><br />
    <asp:CheckBox ID="ck_firstlast" runat="server" Checked="True" Text="ShowFirstLast" AutoPostBack="True" /><br />
    <asp:CheckBox ID="ck_prevnext" runat="server" Checked="True" Text="ShowPrevNext" AutoPostBack="True" /><br />
    <asp:CheckBox ID="ck_pageindex" runat="server" Checked="True" Text="ShowPageIndex" AutoPostBack="True" /><br />
    <asp:CheckBox ID="ck_more" runat="server" Checked="True" Text="ShowMoreButtons" AutoPostBack="True" />
</asp:Content>

