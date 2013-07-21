<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Search_Default" MasterPageFile="~/navpage.master" Title="AspNetPager分页示例—动态查询示例"%>

<asp:Content runat="server" ID="content1" ContentPlaceHolderID="main">
<div>该示例演示如何使用AspNetPager分页控件对动态查询的结果进行分页
    </div><br />
<div>Order ID:<asp:DropDownList ID="DropDownList1" runat="server">
        <asp:ListItem>&gt;=</asp:ListItem>
        <asp:ListItem>&lt;=</asp:ListItem>
        <asp:ListItem>=</asp:ListItem>
    </asp:DropDownList><asp:TextBox ID="tb_orderid" runat="server" Width="90px">11000</asp:TextBox>
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
        <tr><th style="width:15%">订单编号</th><th style="width:15%">订单日期</th><th style="width:30%">公司名称</th><th style="width:20%">客户编号</th><th style="width:20%">雇员姓名</th></tr>
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
    CustomInfoHTML="第<font color='red'><b>%currentPageIndex%</b></font>页，共%PageCount%页，每页显示%PageSize%条记录"></webdiyer:aspnetpager>

</asp:Content>
