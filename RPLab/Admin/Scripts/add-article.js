function show() {
    $("#upload_trigger").click();
}
function upimg(str) {
    if (str == "undefined" || str == "") {
        return;
    }
    str = "<img src='" + str + "'</img>";
    CKEDITOR.instances.adminContent_TextEditor.insertHtml(str);
    close();
}
function close() {
    $("#close_button").click();
}
$(document).ready(function () {
    var windowWidth = $(document).width();
    var poplayerWidth = 500;
    new PopupLayer({ trigger: "#upload_trigger", popupBlk: "#blk", closeBtn: "#close_button", useOverlay: true, offsets: { x: (windowWidth - poplayerWidth) / 2, y: 300 } });
});