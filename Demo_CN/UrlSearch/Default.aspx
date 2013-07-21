<%@ Page Language="C#" MasterPageFile="~/NavPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="UrlSearch_Default" Title="AspNetPager分页示例—动态查询示例" %>

<asp:Content ID="Content1" ContentPlaceHolderID="main" Runat="Server">
<div>该示例演示如何使用AspNetPager分页控件对动态查询的结果进行Url分页
    </div><br />
<div>Order ID >= <asp:TextBox ID="tb_orderid" runat="server" Width="90px"></asp:TextBox>
    <asp:Button ID="btn_search" runat="server" OnClick="btn_search_Click" Text="Search" />
    <asp:Button ID="btn_all" runat="server" OnClick="btn_all_Click" Text="Show All" Enabled="false"/>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="tb_orderid"
        Display="Dynamic" ErrorMessage="RequiredFieldValidator">必需</asp:RequiredFieldValidator>&nbsp;
    <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="tb_orderid"
        Display="Dynamic" ErrorMessage="CompareValidator" Operator="DataTypeCheck" SetFocusOnError="True"
        Type="Integer">必须是整数</asp:CompareValidator>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:SqlConnection %>">
    </asp:SqlDataSource>
</div>

   <asp:Repeater ID="Repeater1" runat="server" >
        <HeaderTemplate>
        <table width="100%" border="1" cellspacing="0" cellpadding="4" style="border-collapse:collapse">
        <tr style="backGround-color:#CCCCFF"><th style="width:15%">订单编号</th><th style="width:15%">订单日期</th><th style="width:30%">公司名称</th><th style="width:20%">客户编号</th><th style="width:20%">雇员姓名</th></tr>
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
    <webdiyer:aspnetpager id="AspNetPager1" runat="server" PageSize="12" AlwaysShow="True" ShowCustomInfoSection="Left" ShowDisabledButtons="false" ShowPageIndexBox="always" PageIndexBoxType="DropDownList"
    CustomInfoHTML="Page:<font color='red'><b>%currentPageIndex%</b></font>/%PageCount%&nbsp;%PageSize%/Page&nbsp;&nbsp;Order:%StartRecordIndex%-%EndRecordIndex% of %RecordCount%" UrlPaging="true" OnPageChanged="AspNetPager1_PageChanged"></webdiyer:aspnetpager>
</asp:Content>

