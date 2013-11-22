<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="RPLab.Admin.Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="adminHead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="adminContent" runat="server">
    <div class="content">
        <div id="account-header">
            <h1>管理员登录</h1>
        </div>
        <div id="account">
            <div class="item">
                <div class="label">
                    <asp:Label ID="Label1" runat="server">用户名</asp:Label>
                </div>
                <div class="input">
                    <asp:TextBox runat="server" ID="userName"></asp:TextBox>
                </div>
                <div class="validator">
                    <span><%=ViewState["errorMsg"] %></span>
                </div>
            </div>

            <div class="item">
                <div class="label">
                    <asp:Label ID="Label3" runat="server">密码</asp:Label>
                </div>
                <div class="input">
                    <asp:TextBox TextMode="Password" runat="server" ID="password"></asp:TextBox>
                </div>
            </div>

            <div class="item">
                <div class="label"></div>
                <div class="input">
                    <asp:Button runat="server" CssClass="form-button" ID="btnLogin" Text="登录" OnClick="btnLogin_Click" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>
