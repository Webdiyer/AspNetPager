<%@ Page Language="C#" AutoEventWireup="true" MetaDescription="This sample demonstrate how to use image buttons in AspNetPager control."  CodeFile="ImageButtons.aspx.cs" Inherits="ImageButtons_Default" MasterPageFile="AspNetPager.master"%>

<asp:Content runat="server" ID="content1" ContentPlaceHolderID="main">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Width="100%" CssClass="table table-bordered table-striped">
            <Columns>
                <asp:BoundField DataField="orderid" HeaderText="Order ID" />
                <asp:BoundField DataField="orderdate" HeaderText="Order Date" DataFormatString="{0:d}" />
                <asp:BoundField DataField="companyname" HeaderText="Company Name" />
                <asp:BoundField DataField="employeename" HeaderText="Employee Name" />
            </Columns>
    </asp:GridView>
    <webdiyer:aspnetpager id="AspNetPager1" runat="server" horizontalalign="Center"
        pagingbuttontype="Image" width="100%" ImagePath="images/" ButtonImageNameExtension="n" ButtonImageExtension=".gif" 
        DisabledButtonImageNameExtension="g" CpiButtonImageNameExtension="r" PagingButtonSpacing="10px" ButtonImageAlign="left"
        OnPageChanged="AspNetPager1_PageChanged"></webdiyer:aspnetpager>
</asp:Content>