<%@ Page Title="" Language="C#" MasterPageFile="~/NavPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="PagingButtonLayoutType_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="header" Runat="Server">
<style type="text/css">
.code{color:Blue;font-weight:bold}
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" Runat="Server">

<div>This sample demonstrate how to set PagingButtonLayoutType property to wrap paging element in span or li tags in order to apply css styles.
    </div><br />
  <h4>PagingButtonLayoutType=PagingButtonLayoutType.None(default):</h4>
    <webdiyer:AspNetPager ID="AspNetPager3" runat="server" RecordCount="299">
    </webdiyer:AspNetPager>
  <hr />
  <h4>PagingButtonLayoutType=PagingButtonLayoutType.Span:</h4>
    <webdiyer:AspNetPager ID="AspNetPager2" runat="server" 
        PagingButtonLayoutType="Span" RecordCount="299" UrlPaging="true" UrlPageIndexName="pi">
    </webdiyer:AspNetPager>
    <hr />
    <h4>PagingButtonLayoutType=PagingButtonLayoutType.UnorderedList:</h4>
    <webdiyer:AspNetPager ID="AspNetPager1" runat="server" 
        PagingButtonLayoutType="UnorderedList" RecordCount="299" UrlPaging="true">
    </webdiyer:AspNetPager>
  
    </asp:Content>

