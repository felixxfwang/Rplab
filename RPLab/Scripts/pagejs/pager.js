$(function () {
    var totalPage = $("#totalPage").val();
    var type = $("#type").val();
    $('#next-page').click(function () {
        var page = $("#currentPage").val();
        ++page;
        if (page < totalPage) {
            var data = { page: page, type: type };
            $.post("Pager.ashx", data, function (result, status) {
                $('#content-list').html(result);
                $("#currentPage").val(page);
                pagersh(page);
            });
        }
    });
    $('#previous-page').click(function () {
        var page = $("#currentPage").val();
        --page;
        if (page > -1) {
            var data = { page: page, type: type };
            $.post("Pager.ashx", data, function (result) {
                $('#content-list').html(result);
                $("#currentPage").val(page);
                pagersh(page);
            });
        }
    });
    function pagersh(page) {
        if (page == totalPage - 1) {
            $("#next-page").hide();
        } else {
            $("#next-page").show();
        }
        if (page == 0) {
            $("#previous-page").hide();
        } else {
            $("#previous-page").show();
        }
    }
    $('#next-page').trigger("click");
});