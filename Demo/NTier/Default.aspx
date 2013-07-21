<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="NTier_Default" MasterPageFile="~/navpage.master"%>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<asp:Content ID="content1" ContentPlaceHolderID="main" runat="server">
    <div>This sample demonstrate how to use AspNetPager control in a Ntier application.</div>
    <br />
    <asp:DataList ID="DataList1" runat="server" Width="100%"  RepeatDirection="Horizontal" RepeatColumns="2">
        <ItemStyle Width="50%"/>
<ItemTemplate>
Order ID£º<%#DataBinder.Eval(Container.DataItem,"orderid")%>&nbsp;&nbsp;&nbsp;&nbsp;
Order Date£º<font color="red"><%#DataBinder.Eval(Container.DataItem,"orderdate","{0:d}")%></font><br>
Company Name£º<%#DataBinder.Eval(Container.DataItem,"companyname")%><br>
Employee Name£º<%#DataBinder.Eval(Container.DataItem,"employeename")%><br>
<hr>
</ItemTemplate>
    </asp:DataList>
    <webdiyer:AspNetPager ID="AspNetPager1" runat="server" HorizontalAlign="Center" Width="100%" PageIndexBoxType="DropDownList" OnPageChanged="AspNetPager1_PageChanged" NumericButtonTextFormatString="<{0}>">
    </webdiyer:AspNetPager>
</asp:Content>