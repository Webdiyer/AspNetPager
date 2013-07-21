<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="ImageButtons_Default" MasterPageFile="~/navpage.master" Title="AspNetPager分页示例—使用图片按钮"%>

<asp:Content runat="server" ID="content1" ContentPlaceHolderID="main">
    <div>该示例演示如何在AspNetPager分页控件中使用图片按钮
    </div><br />
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Width="100%" HeaderStyle-BackColor="#CCCCFF" AlternatingRowStyle-BackColor="#eaeaea" RowStyle-BackColor="#FAF3DC">
            <Columns>
                <asp:BoundField DataField="orderid" HeaderText="订单编号" />
                <asp:BoundField DataField="orderdate" HeaderText="订单日期" DataFormatString="{0:d}" />
                <asp:BoundField DataField="companyname" HeaderText="公司名称" />
                <asp:BoundField DataField="employeename" HeaderText="雇员姓名" />
            </Columns>
    </asp:GridView>
    <webdiyer:aspnetpager id="AspNetPager1" runat="server" horizontalalign="Center"
        pagingbuttontype="Image" width="100%" ImagePath="../images/" ButtonImageNameExtension="n" ButtonImageExtension=".gif" 
        DisabledButtonImageNameExtension="g" CpiButtonImageNameExtension="r" PagingButtonSpacing="10px" ButtonImageAlign="left"
        OnPageChanged="AspNetPager1_PageChanged"></webdiyer:aspnetpager>
</asp:Content>