<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="UrlRewriting_Default" MasterPageFile="~/navpage.master" Title="AspNetPager分页示例-Url重写"%>

<asp:Content runat="server" ID="content1" ContentPlaceHolderID="main">
<div>该示例演示在使用AspNetPager的url分页方式时重写url。<br />需要设置的相关属性有：<font color="red"><b>EnableUrlRewriting="true" UrlRewritePattern="../Url重写/第{0}页.aspx"</b></font>。
<br /><strong>注意：设置EnableUrlRewriting="true"将自动设置UrlPaging="true"（默认为false），无需再单独设置该属性的值。</strong>
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
        <webdiyer:aspnetpager id="AspNetPager1" runat="server" horizontalalign="Center" width="100%" ShowPageIndexBox="Always"
        EnableUrlRewriting="true" UrlRewritePattern="../Url重写/第{0}页.aspx" OnPageChanged="AspNetPager1_PageChanged" NumericButtonTextFormatString="-{0}-"></webdiyer:aspnetpager>
    
</asp:Content>