<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="PhotoViewer_Default" MasterPageFile="~/navpage.master" Title="AspNetPager示例—图片浏览程序"%>

<asp:Content runat="server" ID="content1" ContentPlaceHolderID="main">
<div>该示例演示如何使用AspNetPager分页控件制作图片浏览程序
    </div><br />
<div style="width:100%;text-align:center"><h3>古都西安欢迎您</h3></div>
<div style="width:100%;height:320px;text-align:center">
<asp:Image runat="server" ID="img1" /></div> 
<div style="width:100%;text-align:center">
    <webdiyer:aspnetpager id="AspNetPager1" runat="server" horizontalalign="Center" onpagechanged="AspNetPager1_PageChanged"
        pagesize="1" showpageindex="False" urlpageindexname="img"   urlpaging="True" width="500px"
        PagingButtonType="Image" ImagePath="../images/" ButtonImageNameExtension="n" ButtonImageExtension=".gif" 
        DisabledButtonImageNameExtension="g" PagingButtonSpacing="18px" ShowCustomInfoSection="Left" 
        CustomInfoHTML="西安图片：<font color='red'>%currentPageIndex%</font>/%pageCount%"></webdiyer:aspnetpager></div>
</asp:Content>