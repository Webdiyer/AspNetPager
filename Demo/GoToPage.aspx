<%@ Page Language="C#" MasterPageFile="AspNetPager.master" MetaDescription="This sample demonstrate how to use GoToPage method to jump to specified page and fire PageChanging and PageChanged events."  AutoEventWireup="true" CodeFile="GoToPage.aspx.cs" Inherits="CurrentPageIndex_Default" %>

<asp:Content ID="Content2" ContentPlaceHolderID="main" Runat="Server">
         <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Width="100%" CssClass="table table-bordered table-striped">
            <Columns>
                <asp:BoundField DataField="orderid" HeaderText="Order ID" />
                <asp:BoundField DataField="orderdate" HeaderText="Order Date" DataFormatString="{0:d}" />
                <asp:BoundField DataField="companyname" HeaderText="Company Name" />
                <asp:BoundField DataField="employeename" HeaderText="Employee Name" />
            </Columns>
        </asp:GridView>
        <webdiyer:AspNetPager ID="AspNetPager1" runat="server" Width="100%" ShowPageIndexBox="Always" TextBeforePageIndexBox="Go to page:"
        PageSize="10" CurrentPageIndex="39" FirstPageText="First" LastPageText="Last" PrevPageText="Prev" NextPageText="Next" OnPageChanged="AspNetPager1_PageChanged">
        </webdiyer:AspNetPager><br />
    Enter new page index:<asp:TextBox ID="tb_pageindex" runat="server" Width="60px" Text="8"></asp:TextBox><asp:Button ID="Button1"
        runat="server" Text="Go to page" OnClick="Button1_Click" /><asp:RequiredFieldValidator
        ID="RequiredFieldValidator1" runat="server" Text="required" ControlToValidate="tb_pageindex"/><asp:CompareValidator
            ID="CompareValidator1" runat="server" ControlToValidate="tb_pageindex" Operator="DataTypeCheck" Type="Integer" Text="page index must be an integer value"/><asp:Label ID="lbl_error" runat="server" ForeColor="Red" EnableViewState="false"></asp:Label>
</asp:Content>

