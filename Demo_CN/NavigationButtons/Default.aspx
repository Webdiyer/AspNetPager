<%@ Page Language="C#" MasterPageFile="~/NavPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="NavigationButtons_Default" Title="AspNetPager分页示例—分页按钮属性效果" %>
<asp:Content ID="Content1" ContentPlaceHolderID="main" Runat="Server">
<div>该示例演示AspNetPager部分按钮属性，通过设置这些属性可以控制AspNetPager 显示或不显示哪些分页导航按钮。
</div><br />
    <webdiyer:aspnetpager id="AspNetPager1" runat="server" RecordCount="288"
    Width="100%"></webdiyer:aspnetpager>
    <p>属性：</p>
    <asp:CheckBox ID="ck_disbtn" runat="server" Checked="True" Text="ShowDisabledButtons" AutoPostBack="True" /><br />
    <asp:CheckBox ID="ck_firstlast" runat="server" Checked="True" Text="ShowFirstLast" AutoPostBack="True" /><br />
    <asp:CheckBox ID="ck_prevnext" runat="server" Checked="True" Text="ShowPrevNext" AutoPostBack="True" /><br />
    <asp:CheckBox ID="ck_pageindex" runat="server" Checked="True" Text="ShowPageIndex" AutoPostBack="True" />
</asp:Content>

