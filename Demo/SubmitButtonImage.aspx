<%@ Page Language="C#" MasterPageFile="AspNetPager.master" AutoEventWireup="true"  MetaDescription="This sample demonstrate how to set submit button image when page index box is displayed." CodeFile="SubmitButtonImage.aspx.cs" Inherits="SubmitButtonImage_Default" %>

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
         ShowPageIndexBox="Always" SubmitButtonImageUrl="images/go.jpg" ShowCustomInfoSection="Left" CustomInfoHTML="Total Pages:%PageCount% Total Records:%RecordCount%"
         SubmitButtonStyle="width:32px;height:22px;vertical-align:bottom" CustomInfoTextAlign="Left" urlpaging="True" width="100%" LayoutType="Table" ShowNavigationToolTip="true" UrlPageIndexName="pageindex"></webdiyer:aspnetpager>
        
    </asp:Content>

