<%@ Page Title="" Language="C#" MasterPageFile="~/NavPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="CurrentPageIndex_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="header" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" Runat="Server">
本示例演示如何以编程方式动态指定要跳转的页面的索引，使用GoToPage方法引发分页事件并跳转到指定页面。<br /><br />
         <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Width="100%">
            <Columns>
                <asp:BoundField DataField="orderid" HeaderText="订单编号" />
                <asp:BoundField DataField="orderdate" HeaderText="订单日期" DataFormatString="{0:d}" />
                <asp:BoundField DataField="companyname" HeaderText="公司名称" />
                <asp:BoundField DataField="employeename" HeaderText="雇员姓名" />
            </Columns>
        </asp:GridView>
        <webdiyer:AspNetPager ID="AspNetPager1" runat="server" Width="100%" ShowPageIndexBox="Always" TextBeforePageIndexBox="跳转到第" TextAfterPageIndexBox="页" 
        PageSize="10" CurrentPageIndex="39" FirstPageText="首页" LastPageText="尾页" PrevPageText="上页" NextPageText="下页" OnPageChanged="AspNetPager1_PageChanged">
        </webdiyer:AspNetPager><br />
    请输入要跳转到的页索引：<asp:TextBox ID="tb_pageindex" runat="server" Width="60px" Text="8"></asp:TextBox><asp:Button ID="Button1"
        runat="server" Text="转到" OnClick="Button1_Click" /><asp:RequiredFieldValidator
        ID="RequiredFieldValidator1" runat="server" Text="必须输入页索引" ControlToValidate="tb_pageindex"/><asp:CompareValidator
            ID="CompareValidator1" runat="server" ControlToValidate="tb_pageindex" Operator="DataTypeCheck" Type="Integer" Text="页索引必须是整数"/><asp:Label ID="lbl_error" runat="server" ForeColor="Red" EnableViewState="false"></asp:Label>
</asp:Content>

