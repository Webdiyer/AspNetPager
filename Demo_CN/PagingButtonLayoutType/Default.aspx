<%@ Page Title="" Language="C#" MasterPageFile="~/NavPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="PagingButtonLayoutType_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="header" Runat="Server">
<style type="text/css">
.code{color:Blue;font-weight:bold}
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" Runat="Server">
  从7.2版起，可以将AspNetPager分页导航元素（上页、下页、首页、尾页和数字页索引）嵌套在无序列表&lt;li&gt;或&lt;span&gt;标签中，以方便应用一些比较流行的分页样式（可以查看本页面的html源文件对比PagingButtonLayoutType不同的属性值输出的不同结果）：<br />
  
  <h4>分页导航元素不嵌套在任务标签中（默认）：</h4>
    <webdiyer:AspNetPager ID="AspNetPager3" runat="server" RecordCount="299">
    </webdiyer:AspNetPager>
  <hr />
  <h4>将分页导航元素嵌套在&lt;span&gt;与&lt;/span&gt;标签中（未应用样式）：</h4>
  属性设置：<span class="code">PagingButtonLayoutType="Span"</span><br />
    <webdiyer:AspNetPager ID="AspNetPager2" runat="server" 
        PagingButtonLayoutType="Span" RecordCount="299" UrlPaging="True" UrlPageIndexName="pi" PageIndexBoxType="DropDownList">
    </webdiyer:AspNetPager>
    <hr />
    <h4>将分页导航元素嵌套在&lt;li&gt;与&lt;/li&gt;标签中（未应用样式）：</h4>
    属性设置：<span class="code">PagingButtonLayoutType="UnorderedList"</span><br />
    <webdiyer:AspNetPager ID="AspNetPager1" runat="server" 
        PagingButtonLayoutType="UnorderedList" RecordCount="299" UrlPaging="True">
    </webdiyer:AspNetPager>
  
    </asp:Content>

