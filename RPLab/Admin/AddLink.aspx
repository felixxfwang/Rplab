<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="AddLink.aspx.cs" Inherits="RPLab.Admin.AddLink" %>

<asp:Content ID="Content1" ContentPlaceHolderID="adminHead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="adminContent" runat="server">
    <div class="content">
        <div id="account-header">
            <h1>添加友情链接</h1>
        </div>
        <div id="account">
            <div class="item">
                <div class="label">
                    <asp:Label ID="Label1" runat="server">链接名称</asp:Label>
                </div>
                <div class="input">
                    <asp:TextBox runat="server" ID="linkName"></asp:TextBox>
                </div>
            </div>

            <div class="item">
                <div class="label">
                    <asp:Label ID="Label3" runat="server">链接地址</asp:Label>
                </div>
                <div class="input">
                    <asp:TextBox runat="server" ID="linkAddress"></asp:TextBox>
                </div>
            </div>

            <div class="item">
                <div class="label"></div>
                <div class="input">
                    <asp:Button runat="server" CssClass="form-button" ID="btnSubmit" Text="添加链接" OnClick="btnSubmit_Click" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>
