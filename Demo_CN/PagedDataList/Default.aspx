<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="PagedDataList_Default"  MasterPageFile="~/navpage.master" Title="AspNetPager分页示例—DataList分页示例"%>

<asp:Content runat="server" ContentPlaceHolderID="main">
    <div>该示例演示如何使用AspNetPager分页控件对DataList控件进行分页
    </div><br />
        <asp:DataList ID="DataList1" runat="server"  RepeatDirection="Horizontal" RepeatColumns="2" Width="100%">
        <ItemStyle Width="50%"/>
<ItemTemplate>
订单编号：<%#DataBinder.Eval(Container.DataItem,"orderid")%>&nbsp;&nbsp;&nbsp;&nbsp;
订单日期：<font color="red"><%#DataBinder.Eval(Container.DataItem,"orderdate","{0:d}")%></font><br>
公司名称：<%#DataBinder.Eval(Container.DataItem,"companyname")%><br>
雇员姓名：<%#DataBinder.Eval(Container.DataItem,"employeename")%><br>
<hr>
</ItemTemplate>
        </asp:DataList>
    <webdiyer:aspnetpager id="AspNetPager1" runat="server" horizontalalign="Center" onpagechanged="AspNetPager1_PageChanged"
        width="100%"></webdiyer:aspnetpager>
</asp:Content>
