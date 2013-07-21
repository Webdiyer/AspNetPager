<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="ObjectDataSource_Default" MasterPageFile="~/navpage.master"%>

<asp:Content runat="server" ID="content1" ContentPlaceHolderID="main">
<div>This sample demonstrate how to use AspNetPager control to page through the OjbectDataSource.
    </div>
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" EnablePaging="True" SelectCountMethod="GetOrderCount" 
    SelectMethod="GetPagedOrders" StartRowIndexParameterName="startIndex" MaximumRowsParameterName="pageSize" 
    TypeName="OrderInfo" OnSelecting="ODS_Selecting">
    <SelectParameters>
    <asp:ControlParameter ControlID="AspNetPager1" PropertyName="StartRecordIndex" DefaultValue="1" Name="startIndex" Type="Int32" />
    <asp:ControlParameter ControlID="AspNetPager1" PropertyName="PageSize" DefaultValue="10" Name="pageSize" Type="Int32" />
    </SelectParameters>    
    </asp:ObjectDataSource>
    <br />
  <asp:Repeater ID="Repeater1" runat="server" DataSourceID="ObjectDataSource1">
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
    <webdiyer:aspnetpager id="AspNetPager1" runat="server" AlwaysShow="True" ShowCustomInfoSection="Left"></webdiyer:aspnetpager>

</asp:Content>