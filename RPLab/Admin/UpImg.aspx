<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpImg.aspx.cs" Inherits="RPLab.UpImg" %>

<html>
<head>
    <title></title>
    <link href="Css/upimg.css" type="text/css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:FileUpload ID="Uploader" CssClass="uploader" runat="server" />
            <br />
            <asp:RegularExpressionValidator ID="Validater" runat="server" ControlToValidate="Uploader" ErrorMessage="必须是jpg,png,gif,bmp图片" ForeColor="Red"
                ValidationExpression="^([a-zA-Z]:\\)[0-9a-zA-Z\u4e00-\u9fa5\w\s\\!@#\$%^&\*\(\)_\+\-=\[\]{};'\,\.]*(.jpg|.JPG|.gif|.GIF|.bmp|.BMP|.png|.PNG)$" />
            <br />
            <asp:Button ID="UploadButton" runat="server" CssClass="button" Text="上传" OnClick="Button1_Click" />
            <asp:Button ID="CancelButton" runat="server" CssClass="button" Text="取消" OnClick="Button2_Click" />
        </div>
    </form>
</body>
</html>
