<%@ Page Title="AspNetPager分页控件示例—通过url参数获取每页显示记录数" Language="C#" MasterPageFile="~/NavPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="UrlPageSizeName_Default" %>


<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="main">
    <div>该示例演示如何通过url参数来指定AspNetPager分页控件每页显示的记录数<br/>相关属性设置：<font color="red"><b>UrlPaging="True" UrlPageSizeName="Url中用于传递每页显示的记录数的参数名"</b></font>
    </div><br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Width="100%">
            <Columns>
                <asp:BoundField DataField="orderid" HeaderText="订单编号" />
                <asp:BoundField DataField="orderdate" HeaderText="订单日期" DataFormatString="{0:d}" />
                <asp:BoundField DataField="companyname" HeaderText="公司名称" />
                <asp:BoundField DataField="employeename" HeaderText="雇员姓名" />
            </Columns>
        </asp:GridView>
        <webdiyer:aspnetpager id="AspNetPager1" runat="server" horizontalalign="Center" PagingButtonSpacing="8px" onpagechanged="AspNetPager1_PageChanged"
        urlpaging="True" UrlPageSizeName="pagesize" UrlPageIndexName="pageindex" width="100%" LayoutType="Table" ShowNavigationToolTip="true"></webdiyer:aspnetpager>
        
        <div style="width:100%;text-align:right">
        每页显示记录数：<a href="Default.aspx?pagesize=10">10条</a>&nbsp;&nbsp;
        <a href="Default.aspx?pagesize=20">20条</a>&nbsp;&nbsp;
        <a href="Default.aspx?pagesize=50">50条</a>
        </div>
            
    </asp:Content>
