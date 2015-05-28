<%@ Page Language="C#" MasterPageFile="AspNetPager.master" MetaDescription="This sample demonstrates how to set the current page button position." AutoEventWireup="true" CodeFile="CurrentPageButtonPosition.aspx.cs" Inherits="CurrentPageButtonPosition_Default"%>
<asp:Content ID="Content1" ContentPlaceHolderID="main" Runat="Server">
<b>Default (CurrentPageButtonPosition=PagingButtonPosition.Fixed):</b><br />
        <br /><webdiyer:AspNetPager ID="AspNetPager1" runat="server" Width="100%" ShowPageIndexBox="Always" PageIndexBoxType="DropDownList" TextBeforePageIndexBox="Go To Page: " 
        PageSize="10" RecordCount="299" CurrentPageIndex="19" FirstPageText="First" LastPageText="Last" NextPageText="Next" PrevPageText="Prev">
        </webdiyer:AspNetPager><br />
        <hr /><b>CurrentPageButtonPosition=PagingButtonPosition.Beginning:</b><br />
        <br /><webdiyer:AspNetPager ID="AspNetPager2" runat="server" Width="100%" ShowPageIndexBox="Always" PageIndexBoxType="DropDownList" TextBeforePageIndexBox="Go To Page: " 
        PageSize="10" RecordCount="299" ShowDisabledButtons="false" CurrentPageButtonPosition="Beginning" FirstPageText="First" LastPageText="Last" NextPageText="Next" PrevPageText="Prev">
        </webdiyer:AspNetPager><br />
        <hr /><b>CurrentPageButtonPosition=PagingButtonPosition.Center:</b><br />
        <br /><webdiyer:AspNetPager ID="AspNetPager3" runat="server" Width="100%" ShowPageIndexBox="Always" PageIndexBoxType="DropDownList" TextBeforePageIndexBox="Go To Page: " 
        PageSize="10" RecordCount="299" CurrentPageButtonPosition="Center" CurrentPageIndex="15" NumericButtonCount="9" FirstPageText="First" LastPageText="Last" NextPageText="Next" PrevPageText="Prev">
        </webdiyer:AspNetPager><br />
        <hr /><b>CurrentPageButtonPosition=PagingButtonPosition.End</b>£º<br />
        <br /><webdiyer:AspNetPager ID="AspNetPager4" runat="server" Width="100%" ShowPageIndexBox="Always" PageIndexBoxType="DropDownList" TextBeforePageIndexBox="Go To Page: " 
        PageSize="10" RecordCount="299" CurrentPageButtonPosition="End" CurrentPageIndex="19" FirstPageText="First" LastPageText="Last" NextPageText="Next" PrevPageText="Prev">
        </webdiyer:AspNetPager>
</asp:Content>

