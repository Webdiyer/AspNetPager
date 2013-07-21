<%@ Page Language="C#" MasterPageFile="~/NavPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="CustomInfoSection_Default" Title="AspNetPager示例—使用自定义信息区" %>
<asp:Content ID="Content1" ContentPlaceHolderID="main" Runat="Server">
    <div>该示例演示如何使用AspNetPager分页控件的自定义信息区显示自定义分页信息
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
    <webdiyer:aspnetpager id="AspNetPager1" runat="server" onpagechanged="AspNetPager1_PageChanged"
        showcustominfosection="Left" width="100%" CustomInfoHTML="第%CurrentPageIndex%页，共%PageCount%页，第页显示%PageSize%条" PageIndexBoxStyle="width:19px"></webdiyer:aspnetpager>
</asp:Content>

