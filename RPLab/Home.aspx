<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="RPLab.Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript" src="Scripts/pagejs/banner.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div id="banner" class="float-left">
        <div class="banner-list">
            <%Response.Write(newsImageHtml); %>
        </div>
        <div class="banner-bg"></div>
        <div class="banner-title"></div>
        <ul>
            <%Response.Write(newsImagePreHtml); %>
        </ul>
    </div>
    <div class="notice-box float-left">
        <div class="box-title">
            <span class="float-left">通知公告</span>
            <span class="float-right"><a href="More.aspx?type=notice">More>></a></span>
        </div>
        <div class="box-list">
            <ul>
                <%Response.Write(noticeHtml); %>
            </ul>
        </div>

    </div>
    <div class="news-box float-left">
        <div class="box-title">
            <span class="float-left">新闻</span>
            <span class="float-right"><a href="More.aspx?type=news">More>></a></span>
        </div>
        <div class="box-list">
            <ul>
                <%Response.Write(newsHtml); %>
            </ul>
        </div>
    </div>
    <div class="link-box float-left">
        <div class="box-title">
            <span class="float-left">友情链接</span>
        </div>
        <div class="box-list">
            <ul>
                <%Response.Write(linkHtml); %>
            </ul>
        </div>
    </div>
</asp:Content>
