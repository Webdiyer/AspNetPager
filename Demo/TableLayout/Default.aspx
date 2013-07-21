<%@ Page Language="C#" MasterPageFile="~/NavPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="TableLayout_Default" %>

<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="main">
    <div>Table layout type.
    </div><br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Width="100%">
            <Columns>
                <asp:BoundField DataField="orderid" HeaderText="Order ID" />
                <asp:BoundField DataField="orderdate" HeaderText="Order Date" DataFormatString="{0:d}" />
                <asp:BoundField DataField="companyname" HeaderText="Company Name" />
                <asp:BoundField DataField="employeename" HeaderText="Employee Name" />
            </Columns>
        </asp:GridView>
        <webdiyer:aspnetpager id="AspNetPager1" runat="server" PagingButtonSpacing="8px" onpagechanged="AspNetPager1_PageChanged"
            showcustominfosection="Right" CustomInfoHTML="Page:<font color='red'><b>%currentPageIndex%</b></font> of %PageCount%,%PageSize% per page" urlpaging="True" width="100%" LayoutType="Table" ShowNavigationToolTip="true" UrlPageIndexName="pageindex"></webdiyer:aspnetpager>
        
    </asp:Content>


