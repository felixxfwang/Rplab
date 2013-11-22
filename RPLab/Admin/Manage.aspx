<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="Manage.aspx.cs" Inherits="RPLab.Admin.Manage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="adminHead" runat="server">
    <script type="text/javascript" src="Scripts/manage.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="adminContent" runat="server">
    <div class="manage-nav">
        <a class="manage-button btn-switcher" data-id="notice">通知公告</a>
        <a class="manage-button btn-switcher" data-id="news">新闻</a>
        <a class="manage-button btn-switcher" data-id="link">友情链接</a>
        <a class="manage-button btn-switcher" data-id="news-pic">新闻图片</a>
        <a class="manage-button btn-switcher" data-id="intro-article">介绍</a>
    </div>
    <div class="manage-box">
        <div id="notice">
            <div class="article-box">
                <div class="article-list">
                </div>
                <div>
                    <a class="btn-delete" data-type="notice" >删除选中</a>
                </div>
                <div class="pager">
                    <a class="page-prev" data-type="notice" href="javascript:void();">上一页</a>
                    <a class="page-next" data-type="notice" href="javascript:void();">下一页</a>
                    <input name="total-page" type="hidden" value="<%=ViewState["noticeTotalPage"] %>" />
                    <input name="current-page" type="hidden" value="-1" />
                </div>
            </div>
        </div>
        <div id="news">
            <div class="article-box">
                <div class="article-list">
                </div>
                <div>
                    <a class="btn-delete" data-type="news" ">删除选中</a>
                </div>
                <div class="pager">
                    <a class="page-prev" data-type="news" href="javascript:void();">上一页</a>
                    <a class="page-next" data-type="news" href="javascript:void();">下一页</a>
                    <input name="total-page" type="hidden" value="<%=ViewState["newsTotalPage"] %>" />
                    <input name="current-page" type="hidden" value="-1" />
                </div>
            </div>
        </div>
        <div id="link">
            <div class="article-box">
                <div class="article-list">
                </div>
                <div>
                    <a class="btn-delete" data-type="link" >删除选中</a>
                </div>
                <div class="pager">
                    <a class="page-prev" data-type="link" href="javascript:void();">上一页</a>
                    <a class="page-next" data-type="link" href="javascript:void();">下一页</a>
                    <input name="total-page" type="hidden" value="<%=ViewState["linkTotalPage"] %>" />
                    <input name="current-page" type="hidden" value="-1" />
                </div>
            </div>
        </div>
        <div id="news-pic">
            <div class="article-box">
                <div class="article-list">
                </div>
                <div>
                    <a class="btn-delete" data-type="newsImage" >删除选中</a>
                </div>
                <div class="pager">
                    <a class="page-prev" data-type="newsImage" href="javascript:void();">上一页</a>
                    <a class="page-next" data-type="newsImage" href="javascript:void();">下一页</a>
                    <input name="total-page" type="hidden" value="<%=ViewState["newsPicTotalPage"] %>" />
                    <input name="current-page" type="hidden" value="-1" />
                </div>
            </div>
        </div>
        <div id="intro-article">
            <div class="article-box">
                <div class="article-list">
                </div>
                <div>
                    <a class="btn-delete" data-type="intro-article" >删除选中</a>
                </div>
                <div class="pager">
                    <a class="page-prev" data-type="intro-article" href="javascript:void();">上一页</a>
                    <a class="page-next" data-type="intro-article" href="javascript:void();">下一页</a>
                    <input name="total-page" type="hidden" value="<%=ViewState["introArticlePage"]%>" />
                    <input name="current-page" type="hidden" value="-1" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>
