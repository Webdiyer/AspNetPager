<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="DataSources_Default" MasterPageFile="~/navpage.master" Title="AspNetPager samples¡ªSqlDataSource"%>

<asp:Content runat="server" ID="content1" ContentPlaceHolderID="main">
    <div>
    This sample demonstrate how to use AspNetPager to page through SqlDataSource control.
    </div><br />
    <asp:Repeater ID="Repeater1" runat="server" DataSourceID="SqlDataSource1">
        <HeaderTemplate>
        <table width="100%" border="1" cellspacing="0" cellpadding="4" style="border-collapse:collapse">
        <tr style="backGround-color:#CCCCFF"><th style="width:15%">Order ID</th><th style="width:15%">Order Date</th><th style="width:30%">Company Name</th><th style="width:20%">Customer ID</th><th style="width:20%">Employee Name</th></tr>
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
        <webdiyer:aspnetpager id="AspNetPager1" runat="server" HorizontalAlign="Center" Width="100%"></webdiyer:aspnetpager>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:SqlConnection %>"
        SelectCommand="<%$ AppSettings:pagedSPName %>" SelectCommandType="StoredProcedure">
        <SelectParameters>
            <asp:ControlParameter ControlID="AspNetPager1" DefaultValue="1" Name="startIndex"
                PropertyName="StartRecordIndex" Type="Int32" />
            <asp:ControlParameter ControlID="AspNetPager1" DefaultValue="10" Name="endIndex"
                PropertyName="EndRecordIndex" Type="Int32" />
        </SelectParameters>
    </asp:SqlDataSource>
    </asp:Content>
