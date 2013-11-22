<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="More.aspx.cs" Inherits="RPLab.More" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript" src="Scripts/pagejs/pager.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <input id="currentPage" type="hidden" value="-1" />
    <input id="totalPage" type="hidden" value="<%=ViewState["totalPage"] %>" />
    <input id="type" type="hidden" value="<%=ViewState["type"] %>" />
    <div class="article-box">
        <div class="header">
            <div class="title"><%=ViewState["title"] %></div>
        </div>
        <div class="article-list">
            <ul id="content-list">
            </ul>
        </div>
        <div class="pager">
            <a id="previous-page" href="javascript:void();">上一页</a>
            <a id="next-page" href="javascript:void();">下一页</a>
        </div>
    </div>
</asp:Content>
