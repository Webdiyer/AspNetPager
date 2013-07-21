<%@ Page Language="C#" MasterPageFile="~/NavPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="ButtonsFormat_Default" Title="AspNetPager分页示例 — 自定义导航按钮" %>
<asp:Content ID="Content1" ContentPlaceHolderID="main" Runat="Server">
    <div>该示例演示如何使用自定义AspNetPager分页控件的分页导航按钮文本及样式
    </div><br />
        <asp:DataList ID="DataList1" runat="server"  RepeatDirection="Horizontal" RepeatColumns="2" Width="100%">
        <ItemStyle Width="50%"/>
<ItemTemplate>
订单编号：<%#DataBinder.Eval(Container.DataItem,"orderid")%>&nbsp;&nbsp;&nbsp;&nbsp;
订单日期：<font color="blue"><%#DataBinder.Eval(Container.DataItem,"orderdate","{0:d}")%></font><br>
公司名称：<%#DataBinder.Eval(Container.DataItem,"companyname")%><br>
雇员姓名：<%#DataBinder.Eval(Container.DataItem,"employeename")%><br>
<hr>
</ItemTemplate>
        </asp:DataList>
    <webdiyer:aspnetpager id="AspNetPager1" runat="server" horizontalalign="Center" onpagechanged="AspNetPager1_PageChanged"
        width="100%"  PageIndexBoxStyle="width:19px" FirstPageText="【首页】" LastPageText="【尾页】" NextPageText="【后页】" PrevPageText="【前页】" NumericButtonTextFormatString="【{0}】"
        TextAfterPageIndexBox="页" TextBeforePageIndexBox="转到第"  CustomInfoHTML="Page  <font color='red'><b>%CurrentPageIndex%</b></font> of  %PageCount%&nbsp;&nbsp;Order %StartRecordIndex%-%EndRecordIndex%"></webdiyer:aspnetpager>
</asp:Content>

