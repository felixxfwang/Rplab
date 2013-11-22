<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="Center.aspx.cs" Inherits="RPLab.Admin.Center" %>

<asp:Content ID="Content1" ContentPlaceHolderID="adminHead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="adminContent" runat="server">
    <div id="changePassword" class="metro-box">
        <div id="account">
            <div class="item">
                <div class="label">
                    <label>旧密码</label>
                </div>
                <div class="input">
                    <input type="password" name="oldPassword" />
                </div>
            </div>
            <div class="item">
                <div class="label">
                    <label>新密码</label>
                </div>
                <div class="input">
                    <input type="password" name="newPassword" />
                </div>
            </div>
            <div class="item">
                <div class="label">
                    <label>确认新密码</label>
                </div>
                <div class="input">
                    <input type="password" name="confirmPassword" />
                </div>
            </div>
            <div class="item">
                <div class="label">
                </div>
                <div class="input">
                    <asp:Button ID="Submit" CssClass="form-button" runat="server" Text="确认修改" OnClick="Submit_Click"/>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
