$(function () {
    $("#account").children(":not(:first-child)").hide();
});
function preview() {
    var data = {
        url: "Preview.ashx",
        secureuri: false,
        fileElementId: "picture",
        dataType: "xml",
        success: function (result, status) {
            var root = $('root', result);
            var type = root.children('type').text();
            if (type == 'success') {
                var src = root.children('content').text();
                var photoId = root.children('photoId').text();
                var photoExt = root.children('photoExt').text();
                $("#uploader").hide();
                $("#preview").html("<img src='" + src + "' /><input type='hidden' name='photoId' value='" + photoId + "' /><input type='hidden' name='photoExt' value='" + photoExt + "' />");
                $("#account").children(":not(:first-child)").show();
            } else {
                var error = root.children('content').text();
                alert(error);
            }
        },
        error: function (result, status, e) {
            alert(e);
        }
    };
    $.ajaxFileUpload(data);
}