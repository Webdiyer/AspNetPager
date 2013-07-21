<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="UrlRewriting_Default" MasterPageFile="~/navpage.master" Title="AspNetPager samples-Url rewriting"%>

<asp:Content runat="server" ID="content1" ContentPlaceHolderID="main">
<div>This sample demonstrate how to enable url rewriting using AspNetPager in url paging mode.<br />
Related properties:<br/><font color="red"><b>EnableUrlRewriting="true" UrlRewritePattern="./listpage_{0}.aspx" FirstPageUrlRewritePattern="default.aspx"</b></font>¡£
<br /><strong>Note: UrlPaging property will be automatically set to true when EnableUrlRewriting property is true.</strong>
    </div><br />
        <asp:DataList ID="DataList1" runat="server"  RepeatDirection="Horizontal" RepeatColumns="2" Width="100%">
        <ItemStyle Width="50%"/>
<ItemTemplate>
Order ID£º<%#DataBinder.Eval(Container.DataItem,"orderid")%>&nbsp;&nbsp;&nbsp;&nbsp;
Order Date£º<font color="red"><%#DataBinder.Eval(Container.DataItem,"orderdate","{0:d}")%></font><br>
Company Name£º<%#DataBinder.Eval(Container.DataItem,"companyname")%><br>
Employee Name£º<%#DataBinder.Eval(Container.DataItem,"employeename")%><br>
<hr>
</ItemTemplate>
        </asp:DataList>
        <webdiyer:aspnetpager id="AspNetPager1" runat="server" horizontalalign="Center" width="100%" ShowPageIndexBox="Always" PageIndexBoxType="DropDownList"
        EnableUrlRewriting="true" UrlRewritePattern="./listpage_{0}.aspx" FirstPageUrlRewritePattern="default.aspx" OnPageChanged="AspNetPager1_PageChanged" NumericButtonTextFormatString="-{0}-"></webdiyer:aspnetpager>
    
</asp:Content>