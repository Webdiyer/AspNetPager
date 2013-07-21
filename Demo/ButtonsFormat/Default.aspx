<%@ Page Language="C#" MasterPageFile="~/NavPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="ButtonsFormat_Default"%>
<asp:Content ID="Content1" ContentPlaceHolderID="main" Runat="Server">
    <div>This sample demonstrate how to customize the text format of navigation buttons.
    </div><br />
        <asp:DataList ID="DataList1" runat="server"  RepeatDirection="Horizontal" RepeatColumns="2" Width="100%">
        <ItemStyle Width="50%"/>
<ItemTemplate>
Order ID£º<%#DataBinder.Eval(Container.DataItem,"orderid")%>&nbsp;&nbsp;&nbsp;&nbsp;
Order Date£º<font color="blue"><%#DataBinder.Eval(Container.DataItem,"orderdate","{0:d}")%></font><br>
Company Name£º<%#DataBinder.Eval(Container.DataItem,"companyname")%><br>
Employee Name£º<%#DataBinder.Eval(Container.DataItem,"employeename")%><br>
<hr>
</ItemTemplate>
        </asp:DataList>
    <webdiyer:aspnetpager id="AspNetPager1" runat="server" horizontalalign="Center" onpagechanged="AspNetPager1_PageChanged"
        width="100%"  PageIndexBoxStyle="width:19px" FirstPageText="¡¾First¡¿" LastPageText="¡¾Last¡¿" NextPageText="¡¾Next¡¿" PrevPageText="¡¾Prev¡¿" NumericButtonTextFormatString="¡¾{0}¡¿"
        CustomInfoHTML="Page  <font color='red'><b>%CurrentPageIndex%</b></font> of  %PageCount%&nbsp;&nbsp;Order %StartRecordIndex%-%EndRecordIndex%"></webdiyer:aspnetpager>
</asp:Content>

