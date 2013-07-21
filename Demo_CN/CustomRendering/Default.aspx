<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="CustomRendering_Default" MasterPageFile="~/navpage.master" Title="AspNetPager分页示例—自定义数据显示逻辑"%>

<asp:Content runat="server" ID="content1" ContentPlaceHolderID="main">
    <div>该示例演示如何在自定义数据呈现逻辑而不使用数据绑定控件时使用AspNetPager分页控件
    </div><br />
    <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
    <webdiyer:AspNetPager ID="AspNetPager1" runat="server" OnPageChanged="AspNetPager1_PageChanged">
    </webdiyer:AspNetPager>

</asp:Content>
