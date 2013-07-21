<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="NTier_Default" MasterPageFile="~/navpage.master" Title="AspNetPager分页示例—N层结构分页示例"%>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<asp:Content ID="content1" ContentPlaceHolderID="main" runat="server">
    <div>该示例演示如何在N层结构的web应用程序中使用AspNetPager分页控件</div>
    <br />
    <asp:DataList ID="DataList1" runat="server" Width="100%"  RepeatDirection="Horizontal" RepeatColumns="2">
        <ItemStyle Width="50%"/>
<ItemTemplate>
订单编号：<%#DataBinder.Eval(Container.DataItem,"orderid")%>&nbsp;&nbsp;&nbsp;&nbsp;
订单日期：<font color="red"><%#DataBinder.Eval(Container.DataItem,"orderdate","{0:d}")%></font><br>
公司名称：<%#DataBinder.Eval(Container.DataItem,"companyname")%><br>
雇员姓名：<%#DataBinder.Eval(Container.DataItem,"employeename")%><br>
<hr>
</ItemTemplate>
    </asp:DataList>
    <webdiyer:AspNetPager ID="AspNetPager1" runat="server" HorizontalAlign="Center" Width="100%" PageIndexBoxType="DropDownList" OnPageChanged="AspNetPager1_PageChanged" NumericButtonTextFormatString="<{0}>">
    </webdiyer:AspNetPager>
</asp:Content>