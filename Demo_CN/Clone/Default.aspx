<%@ Page Language="C#" MasterPageFile="~/NavPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Clone_Default" Title="AspNetPager分页示例—克隆" %>
<asp:Content ID="Content1" ContentPlaceHolderID="main" Runat="Server">
    <div>该示例演示使用两个AspNetPager分页控件为同一数据绑定控件进行分页，只需设置一个AspNetPager分页控件的属性及事件处理程序，另一分页控件使用CloneFrom属性克隆此控件的属性及事件处理程序而无需重复设置属性及事件处理程序。<br/>相关属性设置：<font color="red"><b>CloneFrom="要克隆的AspNetPager分页控件的ID"</b></font>
    </div><br />
        
        <webdiyer:aspnetpager id="AspNetPager1" runat="server" horizontalalign="Center" PagingButtonSpacing="8px" onpagechanged="AspNetPager1_PageChanged"
            showcustominfosection="Left" urlpaging="True" width="100%" ImagePath="~/images" PagingButtonType="Image" NumericButtonType="Text" NavigationButtonType="image" 
            ButtonImageExtension="gif" ButtonImageNameExtension="n" DisabledButtonImageNameExtension="g" ShowNavigationToolTip="true" UrlPageIndexName="pageindex"></webdiyer:aspnetpager>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Width="100%">
            <Columns>
                <asp:BoundField DataField="orderid" HeaderText="订单编号" />
                <asp:BoundField DataField="orderdate" HeaderText="订单日期" DataFormatString="{0:d}" />
                <asp:BoundField DataField="companyname" HeaderText="公司名称" />
                <asp:BoundField DataField="employeename" HeaderText="雇员姓名" />
            </Columns>
        </asp:GridView>
        <webdiyer:AspNetPager runat="server" ID="AspNetPager2" CloneFrom="aspnetpager1"></webdiyer:AspNetPager>
</asp:Content>

