<%@ Page Language="C#" AutoEventWireup="true" MetaDescription="This sample demonstrate how to enable url paging mode instead of default PostBack paging." CodeFile="UrlPaging.aspx.cs" Inherits="UrlPaging_Default" MasterPageFile="AspNetPager.master" Title="AspNetPager samples¡ªUrl paging"%>

<asp:Content runat="server" ContentPlaceHolderID="desc">Property and value to be set:<b>UrlPaging="true"</b>
 </asp:Content>
<asp:Content runat="server" ContentPlaceHolderID="main">
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Width="100%" CssClass="table table-bordered table-striped">
            <Columns>
                <asp:BoundField DataField="orderid" HeaderText="Order ID" />
                <asp:BoundField DataField="orderdate" HeaderText="Order Date" DataFormatString="{0:d}" />
                <asp:BoundField DataField="companyname" HeaderText="Company Name" />
                <asp:BoundField DataField="employeename" HeaderText="Employee Name" />
            </Columns>
        </asp:GridView>
        <webdiyer:aspnetpager id="AspNetPager1" runat="server" horizontalalign="Center" PagingButtonSpacing="8px" onpagechanged="AspNetPager1_PageChanged"
            showcustominfosection="Right" urlpaging="True" width="100%" ImagePath="~/images" PagingButtonType="Image" NumericButtonType="Text" NavigationButtonType="image" 
            ButtonImageExtension="gif" ButtonImageNameExtension="n" DisabledButtonImageNameExtension="g" ShowNavigationToolTip="true" UrlPageIndexName="pageIndex"></webdiyer:aspnetpager>
        
    </asp:Content>
