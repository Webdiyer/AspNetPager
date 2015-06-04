<%@ Page Language="C#" MasterPageFile="AspNetPager.master" MetaDescription="This sample demonstrate how to apply styles to AspNetPager control." AutoEventWireup="true" CodeFile="ApplyStyles.aspx.cs" Inherits="Styles1_Default" %>

<asp:Content ID="Content2" ContentPlaceHolderID="main" Runat="Server">
    
   <h4>Bootstrap pagination:</h4>
    <webdiyer:AspNetPager CssClass="pagination" LayoutType="Ul" PagingButtonLayoutType="UnorderedList" PagingButtonSpacing="0" CurrentPageButtonClass="active" UrlPaging="true"  ID="AspNetPager1" runat="server" RecordCount="228">
    </webdiyer:AspNetPager>
   <h4>Style 1:</h4>
    <webdiyer:AspNetPager CssClass="anpager" CurrentPageButtonClass="cpb"  ID="AspNetPager2" runat="server" RecordCount="228">
    </webdiyer:AspNetPager>
    <br /> CSS styles:<br />
    <textarea rows="4" style="width:98%">
.anpager .cpb {background:#1F3A87 none repeat scroll 0 0;border:1px solid #CCCCCC;color:#FFFFFF;font-weight:bold;margin:5px 4px 0 0;padding:4px 5px 0;}
.anpager a {background:#FFFFFF none repeat scroll 0 0;border:1px solid #CCCCCC;color:#1F3A87;margin:5px 4px 0 0;padding:4px 5px 0;text-decoration:none}
.anpager a:hover{background:#1F3A87 none repeat scroll 0 0;border:1px solid #1F3A87;color:#FFFFFF;}</textarea>
   <br />Properties:<span class="code">CssClass="anpager" CurrentPageButtonClass="cpb" </span>
   
   <hr />
    <h4>style 2:</h4>
    <webdiyer:AspNetPager CssClass="paginator" CurrentPageButtonClass="cpb"  ID="AspNetPager3" runat="server" RecordCount="228"
        FirstPageText="First" LastPageText="Last" NextPageText="Next" PrevPageText="Prev">
    </webdiyer:AspNetPager>
    <br />CSS styles:<br />
    <textarea rows="4" style="width:98%">
.paginator { font: 11px Arial, Helvetica, sans-serif;padding:10px 20px 10px 0; margin: 0px;}
.paginator a {padding: 1px 6px; border: solid 1px #ddd; background: #fff; text-decoration: none;margin-right:2px}
.paginator a:visited {padding: 1px 6px; border: solid 1px #ddd; background: #fff; text-decoration: none;}
.paginator .cpb {padding: 1px 6px;font-weight: bold; font-size: 13px;border:none}
.paginator a:hover {color: #fff; background: #ffa501;border-color:#ffa501;text-decoration: none;}</textarea>
<br />Properties:<span class="code">CssClass="paginator" CurrentPageButtonClass="cpb"</span>
    <hr />
    <h4>Style 3:</h4>
    <webdiyer:AspNetPager CssClass="pages" CurrentPageButtonClass="cpb"  ID="AspNetPager4" runat="server" RecordCount="228"
        FirstPageText="First" LastPageText="Last" NextPageText="Next" PrevPageText="Prev">
    </webdiyer:AspNetPager>
    <br />CSS styles:<br />    
    <textarea rows="4" style="width:98%">
.pages {  color: #999; }
.pages a, .pages .cpb { text-decoration:none;float: left; padding: 0 5px; border: 1px solid #ddd;background: #ffff;margin:0 2px; font-size:11px; color:#000;}
.pages a:hover { background-color: #E61636; color:#fff;border:1px solid #E61636; text-decoration:none;}
.pages .cpb { font-weight: bold; color: #fff; background: #E61636; border:1px solid #E61636;}</textarea>
<br />Properties:<span class="code">CssClass="pages" CurrentPageButtonClass="cpb"</span>
    </asp:Content>

