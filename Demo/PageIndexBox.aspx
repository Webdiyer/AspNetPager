<%@ Page Language="C#" MasterPageFile="AspNetPager.master" AutoEventWireup="true"  MetaDescription="This sample demonstrate how to config AspNetPager control to allow users input or select page index they want to jump to." CodeFile="PageIndexBox.aspx.cs" Inherits="PageIndexBox_Default"%>
<asp:Content ID="Content1" ContentPlaceHolderID="main" Runat="Server">
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
    <webdiyer:aspnetpager id="AspNetPager1" runat="server" horizontalalign="Center" onpagechanged="AspNetPager1_PageChanged" ShowPageIndexBox="Always" PageIndexBoxType="DropDownList" TextBeforePageIndexBox="Go to page" PageSize="10"
        width="100%"></webdiyer:aspnetpager>
    <asp:RadioButtonList ID="rbl_boxtype" runat="server" AutoPostBack="True" OnSelectedIndexChanged="rbl_boxtype_SelectedIndexChanged" RepeatDirection="Horizontal" RepeatLayout="Flow">
    <asp:ListItem>TextBox</asp:ListItem>
    <asp:ListItem Selected="true">DropDownList</asp:ListItem>
    </asp:RadioButtonList>
</asp:Content>

