<%@ Page Language="C#" MasterPageFile="~/NavPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="CenterCurrentPageButton_Default" Title="AspNetPager示例—居中当前页索引按钮" %>
<asp:Content ID="Content1" ContentPlaceHolderID="main" Runat="Server">

    <div>该示例演示如何设置AspNetPager 分页控个把当前页索引按钮在所有数字页索引按钮中的位置：
    <br />（<font color="red">注：上一版本中通过设置CenterCurrentPageButton="true"使当前页按钮居中的方法仍然起作用，但CenterCurrentPageButton属性已被标记为废止，以后的版本中将不再可用。</font>）
       </div><br />
        <hr /><b>默认值（当前页索引按钮位置固定不变）</b>：<br />
        <br /><webdiyer:AspNetPager ID="AspNetPager1" runat="server" Width="100%" ShowPageIndexBox="Always" PageIndexBoxType="DropDownList" TextBeforePageIndexBox="Go To Page: " 
        PageSize="10" RecordCount="299" CurrentPageIndex="19" FirstPageText="首页" LastPageText="尾页" PrevPageText="上页" NextPageText="下页">
        </webdiyer:AspNetPager><br />
        <hr /><b>当前页索引按钮总是在所有数字页索引按钮的开头</b>：<br />
        声明方式设置：&lt;webdiyer:AspNetPager ID="AspNetPager2" runat="server" <font color="blue"><b>CurrentPageButtonPosition="Beginning"</b></font> ... <br />编程方式设置：AspNetPager2.CurrentPageButtonPosition=<font color="blue"><b>Wuqi.Webdiyer.PagingButtonPosition.Beginning</b></font><br />
        <br /><webdiyer:AspNetPager ID="AspNetPager2" runat="server" Width="100%" ShowPageIndexBox="Always" PageIndexBoxType="DropDownList" TextBeforePageIndexBox="Go To Page: " 
        PageSize="10" RecordCount="299" ShowDisabledButtons="false" CurrentPageButtonPosition="Beginning" FirstPageText="首页" LastPageText="尾页" PrevPageText="上页" NextPageText="下页">
        </webdiyer:AspNetPager><br />
        <hr /><b>当前页索引按钮总是在所有数字页索引按钮的中间</b>：<br />
        声明方式设置：&lt;webdiyer:AspNetPager ID="AspNetPager3" runat="server" <font color="blue"><b>CurrentPageButtonPosition="Center"</b></font><br />编程方式设置：AspNetPager3.CurrentPageButtonPosition=<font color="blue"><b>Wuqi.Webdiyer.PagingButtonPosition.Center</b></font><br />
        <br /><webdiyer:AspNetPager ID="AspNetPager3" runat="server" Width="100%" ShowPageIndexBox="Always" PageIndexBoxType="DropDownList" TextBeforePageIndexBox="Go To Page: " 
        PageSize="10" RecordCount="299" CurrentPageButtonPosition="Center" CurrentPageIndex="15" NumericButtonCount="9" FirstPageText="首页" LastPageText="尾页" PrevPageText="上页" NextPageText="下页">
        </webdiyer:AspNetPager><br />
        <hr /><b>当前页索引按钮总是在所有数字页索引按钮的结尾</b>：<br />
        声明方式设置：&lt;webdiyer:AspNetPager ID="AspNetPager4" runat="server" <font color="blue"><b>CurrentPageButtonPosition="End"</b></font><br />编程方式设置：AspNetPager4.CurrentPageButtonPosition=<font color="blue"><b>Wuqi.Webdiyer.PagingButtonPosition.End</b></font><br />
        <br /><webdiyer:AspNetPager ID="AspNetPager4" runat="server" Width="100%" ShowPageIndexBox="Always" PageIndexBoxType="DropDownList" TextBeforePageIndexBox="Go To Page: " 
        PageSize="10" RecordCount="299" CurrentPageButtonPosition="End" CurrentPageIndex="19" FirstPageText="首页" LastPageText="尾页" PrevPageText="上页" NextPageText="下页">
        </webdiyer:AspNetPager>
</asp:Content>

