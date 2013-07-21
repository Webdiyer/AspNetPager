<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Basic_Default" MasterPageFile="~/navpage.master" Title="AspNetPager samples-basic" %>

<asp:Content runat="server" ID="content1" ContentPlaceHolderID="main">
<div>This sample demonstrate the basic functionality of AspNetPager, help you understand how it works.
<p>In order to paging use AspNetPager,you only need to set its <font color="red"><b>RecordCount</b></font> property value and handle <font color="red"><b>PageChanged</b></font> event,you can show or bind data in this event handler¡£</p>
<p>Click paging buttons below to view paging effect:</p>
</div>
<p><asp:Label runat="server" ID="label1" ForeColor="red" EnableViewState="false"></asp:Label>
<br /><asp:Label runat="server" ID="label2" ForeColor="red" EnableViewState="false"></asp:Label></p>
    <asp:CheckBox ID="CheckBox1" runat="server" Text="Cancel Paging" />£¨check this checkbox will only fire PageChanging event£¬PageChanged event will not be triggered£©
    <p>AspNetPager running affect£º</p>
    <webdiyer:aspnetpager id="AspNetPager1" runat="server" CurrentPageButtonPosition="Center"
        OnPageChanging="AspNetPager1_PageChanging" onpagechanged="AspNetPager1_PageChanged" 
    Width="100%" HorizontalAlign="center" AlwaysShowFirstLastPageNumber="true" PagingButtonSpacing="10" UrlPaging="true"></webdiyer:aspnetpager>

    <p>Cloned AspNetPager£º</p>
    <div><webdiyer:aspnetpager id="AspNetPager2" runat="server" CloneFrom="AspNetPager1"></webdiyer:aspnetpager></div>
</asp:Content>