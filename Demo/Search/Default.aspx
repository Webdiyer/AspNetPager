<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Search_Default" MasterPageFile="~/navpage.master" Title="AspNetPager samples¡ªsearch result paging"%>

<asp:Content runat="server" ID="content1" ContentPlaceHolderID="main">
<div>Search result paging with AspNetPager.
    </div><br />
<div>Order ID:<asp:DropDownList ID="DropDownList1" runat="server">
        <asp:ListItem>&gt;=</asp:ListItem>
        <asp:ListItem>&lt;=</asp:ListItem>
        <asp:ListItem>=</asp:ListItem>
    </asp:DropDownList><asp:TextBox ID="tb_orderid" runat="server" Width="90px">11000</asp:TextBox>
    <asp:Button ID="btn_search" runat="server" OnClick="btn_search_Click" Text="Search" />
    <asp:Button ID="btn_all" runat="server" OnClick="btn_all_Click" Text="Show All" Enabled="false"/>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="tb_orderid"
        Display="Dynamic" ErrorMessage="RequiredFieldValidator">Required</asp:RequiredFieldValidator>&nbsp;
    <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="tb_orderid"
        Display="Dynamic" ErrorMessage="CompareValidator" Operator="DataTypeCheck" SetFocusOnError="True"
        Type="Integer">Must be an integer value</asp:CompareValidator>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:SqlConnection %>">
    </asp:SqlDataSource>
</div>

   <asp:Repeater ID="Repeater1" runat="server" >
        <HeaderTemplate>
        <table width="100%" border="1" cellspacing="0" cellpadding="4" style="border-collapse:collapse">
        <tr><th style="width:15%">Order ID</th><th style="width:15%">Order Date</th><th style="width:30%">Company Name</th><th style="width:20%">Customer ID</th><th style="width:20%">Employee Name</th></tr>
        </HeaderTemplate>
        <ItemTemplate>
        <tr style="background-color:#FAF3DC">
        <td><%#DataBinder.Eval(Container.DataItem,"orderid")%></td>
        <td><%#DataBinder.Eval(Container.DataItem,"orderdate","{0:d}")%></td>
        <td><%#DataBinder.Eval(Container.DataItem, "companyname")%></td>
        <td><%#DataBinder.Eval(Container.DataItem,"customerid")%></td>
        <td><%#DataBinder.Eval(Container.DataItem,"employeename")%></td>
        </tr>
        </ItemTemplate>
        <FooterTemplate>
        </table>
        </FooterTemplate>
        </asp:Repeater>
    <webdiyer:aspnetpager id="AspNetPager1" runat="server" PageSize="12" AlwaysShow="True" OnPageChanged="AspNetPager1_PageChanged" ShowCustomInfoSection="Left" CustomInfoSectionWidth="20%" ShowPageIndexBox="always" PageIndexBoxType="DropDownList"
    CustomInfoHTML="Page:<font color='red'><b>%currentPageIndex%</b></font> of %PageCount%,%PageSize% per page"></webdiyer:aspnetpager>

</asp:Content>
