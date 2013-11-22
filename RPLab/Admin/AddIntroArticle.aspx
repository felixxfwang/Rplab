<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="AddIntroArticle.aspx.cs" Inherits="RPLab.Admin.AddIntroAirticle" %>

<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="adminHead" runat="server">
    <link type="text/css" rel="stylesheet" href="Css/poplayer.css" />
    <script type="text/javascript" src="Scripts/add-article.js"></script>
    <script type="text/javascript" src="Scripts/popup_layer.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="adminContent" runat="server">
    <div class="content">
        <div id="account-header">
            <h1>添加文章</h1>
        </div>
        <div id="account">
            <div class="item">
                <div class="label">
                    <asp:Label ID="Label1" runat="server">题目</asp:Label>
                </div>
                <div class="input">
                    <asp:TextBox runat="server" ID="title"></asp:TextBox>
                </div>
            </div>
            <div class="item">
                <div class="label">
                    <asp:Label ID="Label3" runat="server">类别</asp:Label>
                </div>
                <div class="input">
                    <asp:DropDownList runat="server" ID="category">
                        <asp:ListItem Value="LabIntroPage">实验室介绍</asp:ListItem>
                        <asp:ListItem Value="TeachersPage">学术梯队</asp:ListItem>
                        <asp:ListItem Value="StudentsPage">人才培养</asp:ListItem>
                        <asp:ListItem Value="ResearchPage">科学研究</asp:ListItem>
                        <asp:ListItem Value="StudentWorkPage">学生工作</asp:ListItem>
                        <asp:ListItem Value="ExchangePage">交流合作</asp:ListItem>
                    </asp:DropDownList>
                </div>
            </div>
            <div class="item">
                <div class="label" style="vertical-align: top">
                    <label>内容</label>
                </div>
                <div class="input">
                    <CKEditor:CKEditorControl ID="TextEditor" BasePath="../ckeditor/" runat="server" />
                </div>
            </div>

            <div class="item">
                <div class="label"></div>
                <div class="input" style="text-align: right">
                    <asp:Button ID="Submit" CssClass="form-button" Text="提交" runat="server" OnClick="Submit_Click" />
                </div>
            </div>
        </div>

        <div id="imageUploader">
            <div id="upload_trigger" style="cursor: pointer; color: blue; display: none;"></div>
            <div id="blk" class="blk" style="display: none;">
                <div class="main">
                    <h2>上传图片</h2>
                    <a href="javascript:void(0)" id="close_button" class="closeBtn">关闭</a>
                    <iframe src="UpImg.aspx" class="popup_iframe" style="border: none"></iframe>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
