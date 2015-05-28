<%@ Page Language="C#" AutoEventWireup="true"  MetaDescription="This sample demonstrate how to use AspNetPager to page through data that stored in XML file." CodeFile="XMLData.aspx.cs" Inherits="XMLData_Default" MasterPageFile="AspNetPager.master"%>
<asp:Content runat="server" ID="content1" ContentPlaceHolderID="main">
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
    <webdiyer:aspnetpager id="AspNetPager1" runat="server" horizontalalign="Center" onpagechanged="AspNetPager1_PageChanged"
       UrlPaging="true" width="100%"></webdiyer:aspnetpager>
    <asp:Label ID="Label1" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label>

</asp:Content>