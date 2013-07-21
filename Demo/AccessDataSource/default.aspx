<%@ Page Language="C#" AutoEventWireup="true" CodeFile="default.aspx.cs" Inherits="DataSources_PagedDataSrc" MasterPageFile="~/navpage.master" %>

<asp:Content runat="server" ID="content1" ContentPlaceHolderID="main">
    <div>This sample demonstrate how to use AspNetPager and AccessDataSource to page through records stored in Microsoft Office Access database.
    </div>
    <asp:AccessDataSource ID="AccessDataSource1" runat="server" DataFile="~/App_Data/NorthWnd.mdb"
        SelectCommand="select orderid,orderdate,customerid,employeeID from orders order by orderid desc" CacheKeyDependency="ADS_Orders" EnableCaching="True" OnSelected="AccessDataSource1_Selected"></asp:AccessDataSource>
    <br />
<asp:Repeater ID="Repeater1" runat="server">
        <HeaderTemplate>
        <table width="100%" border="1" cellspacing="0" cellpadding="4" style="border-collapse:collapse">
        <tr style="backGround-color:#CCCCFF"><th style="width:25%">Order ID</th><th style="width:25%">Order Date</th><th style="width:25%">Customer ID</th><th style="width:25%">Employee ID</th></tr>
        </HeaderTemplate>
        <ItemTemplate>
        <tr style="background-color:#FAF3DC">
        <td><%#DataBinder.Eval(Container.DataItem,"orderid")%></td>
        <td><%#DataBinder.Eval(Container.DataItem,"orderdate","{0:d}")%></td>
        <td><%#DataBinder.Eval(Container.DataItem,"customerid")%></td>
        <td><%#DataBinder.Eval(Container.DataItem,"employeeid")%></td>
        </tr>
        </ItemTemplate>
        <FooterTemplate>
        </table>
        </FooterTemplate>
    </asp:Repeater>
    <webdiyer:aspnetpager id="AspNetPager1" runat="server" horizontalalign="Center" onpagechanged="AspNetPager1_PageChanged"
        width="100%"></webdiyer:aspnetpager>   
</asp:Content>