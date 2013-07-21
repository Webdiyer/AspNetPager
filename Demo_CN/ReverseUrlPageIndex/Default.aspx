<%@ Page Language="C#" MasterPageFile="~/NavPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="ReverseUrlPageIndex_Default" Title="AspNetPager分页示例—Url逆向分页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="main" Runat="Server">
    <div>该示例演示如何使用AspNetPager分页控件进行Url逆向分页。<br/>相关属性设置：<font color="red"><b>UrlPaging="true" ReverseUrlPageIndex="true"</b></font>
    <p><strong>注：</strong>此示例中还举例说明了如何使最后一页与其它页显示相同的记录数，如共有101条数据，每页显示10条，则默认最后一页会只有一条数据，使用该示例中的方法，可以使最后一页同样显示十条记录，即部分记录与前一页重复。</p>
    </div><br />
        
        <webdiyer:aspnetpager id="AspNetPager1" runat="server" horizontalalign="Center" PagingButtonSpacing="8px" onpagechanged="AspNetPager1_PageChanged"
            showcustominfosection="Right" urlpaging="True" width="100%" ImagePath="~/images" PagingButtonType="Image" NumericButtonType="Text" NavigationButtonType="image" 
            ButtonImageExtension="gif" ButtonImageNameExtension="n" DisabledButtonImageNameExtension="g" ShowNavigationToolTip="true" UrlPageIndexName="page" ReverseUrlPageIndex="true"></webdiyer:aspnetpager>
        <br /><asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Width="100%">
            <Columns>
                <asp:BoundField DataField="orderid" HeaderText="订单编号" />
                <asp:BoundField DataField="orderdate" HeaderText="订单日期" DataFormatString="{0:d}" />
                <asp:BoundField DataField="companyname" HeaderText="公司名称" />
                <asp:BoundField DataField="employeename" HeaderText="雇员姓名" />
            </Columns>
        </asp:GridView>
        <br />
        <webdiyer:AspNetPager runat="server" ID="AspNetPager2" CloneFrom="aspnetpager1"></webdiyer:AspNetPager>
</asp:Content>

