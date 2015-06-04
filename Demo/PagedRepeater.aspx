<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="PagedRepeater.aspx.cs" MetaDescription="This sample demonstrate how to use AspNetPager control to add paging functionality to the Repeater control." Inherits="PagedRepeater_Default" MasterPageFile="AspNetPager.master"%>

<asp:Content runat="server" ContentPlaceHolderID="main">
    <webdiyer:AspNetPager ID="AspNetPager1" runat="server" Width="100%" UrlPaging="true" ShowPageIndexBox="Always" PageIndexBoxType="DropDownList" TextBeforePageIndexBox="Go To Page: " HorizontalAlign="right" PageSize="12" OnPageChanged="AspNetPager1_PageChanged" EnableTheming="true">
        </webdiyer:AspNetPager>
        <asp:Repeater ID="Repeater1" runat="server">
        <HeaderTemplate>
        <table width="100%" class="table table-bordered table-striped">
        <tr><th style="width:15%">Order ID</th><th style="width:15%">Order Date</th><th style="width:30%">Company Name</th><th style="width:20%">Customer ID</th><th style="width:20%">Employee Name</th></tr>
        </HeaderTemplate>
        <ItemTemplate>
        <tr>
        <td><%#DataBinder.Eval(Container.DataItem,"orderid")%></td>
        <td><%#DataBinder.Eval(Container.DataItem,"orderdate","{0:d}")%></td>
        <td><%#DataBinder.Eval(Container.DataItem, "companyname")%></td>
        <td><%#DataBinder.Eval(Container.DataItem,"customerid")%></td>
        <td><%#DataBinder.Eval(Container.DataItem,"employeename")%></td>
        </tr>
        </ItemTemplate>
        <FooterTemplate>
        </table>
        </FooterTemplate>
        </asp:Repeater>
        <webdiyer:AspNetPager ID="AspNetPager2" runat="server" CloneFrom="AspNetPager1">
        </webdiyer:AspNetPager>
</asp:Content>