<%@ Page Language="C#" AutoEventWireup="true"  MetaDescription="This sample demonstrate how to use AspNetPager control within UpdatePanel to implement Ajax paging." CodeFile="UpdatePanel.aspx.cs" Inherits="Ajax_default" MasterPageFile="AspNetPager.master"%>
<asp:Content runat="server" ID="content1" ContentPlaceHolderID="main">
 <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate> <asp:Repeater ID="Repeater1" runat="server" DataSourceID="SqlDataSource1">
        <HeaderTemplate>
        <table width="100%" class="table table-bordered table-striped">
        <tr><th style="width:15%">Order ID</th><th style="width:15%">Order Date</th><th style="width:30%">Company Name</th><th style="width:20%">Customer ID</th><th style="width:20%">Employee Name</th></tr>
        </HeaderTemplate>
        <ItemTemplate>
        <tr>
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
        <webdiyer:aspnetpager id="AspNetPager1" runat="server" HorizontalAlign="Center" Width="100%" PageIndexBoxType="DropDownList"></webdiyer:aspnetpager>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:SqlConnection %>"
        SelectCommand="<%$ AppSettings:pagedSPName %>" SelectCommandType="StoredProcedure">
        <SelectParameters>
            <asp:ControlParameter ControlID="AspNetPager1" DefaultValue="10" Name="endIndex"
                PropertyName="EndRecordIndex" Type="Int32" />
            <asp:ControlParameter ControlID="AspNetPager1" DefaultValue="1" Name="startIndex"
                PropertyName="StartRecordIndex" Type="Int32" />
        </SelectParameters>
    </asp:SqlDataSource>      
        </ContentTemplate>
        </asp:UpdatePanel>
</asp:Content>