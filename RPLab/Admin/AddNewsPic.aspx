<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="AddNewsPic.aspx.cs" Inherits="RPLab.Admin.AddNewsPic" %>

<asp:Content ID="Content1" ContentPlaceHolderID="adminHead" runat="server">
    <script type="text/javascript" src="Scripts/ajaxfileupload.js"></script>
    <script type="text/javascript" src="Scripts/add-pic.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="adminContent" runat="server">
    <div class="content">
        <div id="account-header">
            <h1>上传图片</h1>
        </div>
        <div id="preview">
        </div>
        <div id="account">
            <div id="uploader" class="item">
                <div class="label">
                    <asp:Label ID="Label1" runat="server">上传图片</asp:Label>
                </div>
                <div class="input">
                    <input type="file" id="picture" name="picture" onchange="preview()" />
                </div>
                <div class="validator">
                    <span><%=ViewState["errorMsg"] %></span>
                </div>
            </div>

            <div id="locationDiv" class="item">
                <div class="label">
                    <asp:Label ID="Label2" runat="server">文章链接地址</asp:Label>
                </div>
                <div class="input">
                    <asp:TextBox runat="server" ID="link"></asp:TextBox>
                </div>
            </div>

            <div class="item">
                <div class="label">
                    <asp:Label ID="Label4" runat="server">照片描述</asp:Label>
                </div>
                <div class="input">
                    <asp:TextBox runat="server" ID="description" Style="height: 80px" TextMode="MultiLine"></asp:TextBox>
                </div>
            </div>

            <div class="item">
                <div class="label">
                </div>
                <div class="input">
                    <asp:Button runat="server" ID="display" CssClass="form-button" Text="完成" OnClick="display_Click" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>
