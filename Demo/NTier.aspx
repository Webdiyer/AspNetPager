<%@ Page Language="C#" AutoEventWireup="true" MetaDescription="This sample demonstrate how to use AspNetPager control in a Ntier application."  CodeFile="NTier.aspx.cs" Inherits="NTier_Default" MasterPageFile="AspNetPager.master"%>
<asp:Content ID="content1" ContentPlaceHolderID="main" runat="server">
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