<%@ Page Title="AspNetPager samples - Url page size name" Language="C#" MasterPageFile="AspNetPager.master" AutoEventWireup="true"  MetaDescription="This sample demonstrate how to enable url paging and specify page size in the url." CodeFile="UrlPageSizeName.aspx.cs" Inherits="UrlPageSizeName_Default" %>

<asp:Content runat="server" ContentPlaceHolderID="desc">Properties and values to be set:<font color="red"><b>UrlPaging="True" UrlPageSizeName="page size parameter name in url"</b></font></asp:Content>
<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="main">
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Width="100%" CssClass="table table-bordered table-striped">
            <Columns>
                <asp:BoundField DataField="orderid" HeaderText="Order ID" />
                <asp:BoundField DataField="orderdate" HeaderText="Order Date" DataFormatString="{0:d}" />
                <asp:BoundField DataField="companyname" HeaderText="Company Name" />
                <asp:BoundField DataField="employeename" HeaderText="Employee Name" />
            </Columns>
        </asp:GridView>
        <webdiyer:aspnetpager id="AspNetPager1" runat="server" horizontalalign="Center" PagingButtonSpacing="8px" onpagechanged="AspNetPager1_PageChanged"
        urlpaging="True" UrlPageSizeName="pagesize" UrlPageIndexName="pageindex" width="100%" LayoutType="Table" ShowNavigationToolTip="true"></webdiyer:aspnetpager>
        
        <div style="width:100%;text-align:right">
        Page size:<a href="Default.aspx?pagesize=10">10</a>&nbsp;&nbsp;
        <a href="Default.aspx?pagesize=20">20</a>&nbsp;&nbsp;
        <a href="Default.aspx?pagesize=50">50</a>
        </div>
            
    </asp:Content>
