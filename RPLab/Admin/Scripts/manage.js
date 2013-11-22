$(function () {
    var url = "AdminPager.ashx";
    var deleteUrl = "Manage.ashx";
    $('.page-next').click(function () {
        var type = $(this).attr('data-type');
        var totalPage = $(this).siblings("[name='total-page']").val();
        var page = $(this).siblings("[name='current-page']").val();
        var list = $(this).parent().siblings('.article-list');
        var pageInput = $(this).siblings("[name='current-page']");
        var next = $(this);
        var prev = $(this).siblings('.page-prev');
        ++page;
        if (page < totalPage) {
            var data = { page: page, type: type };
            $.post(url, data, function (result, status) {
                list.html(result);
            });
            pageInput.val(page);
            pagersh(page, totalPage, prev, next);
        }
    });
    $('.page-prev').click(function () {
        var type = $(this).attr('data-type');
        var totalPage = $(this).siblings("[name='total-page']").val();
        var page = $(this).siblings("[name='current-page']").val();
        var list = $(this).parent().siblings('.article-list');
        var pageInput = $(this).siblings("[name='current-page']");
        var prev = $(this);
        var next = $(this).siblings('.page-next');
        --page;
        if (page > -1) {
            var data = { page: page, type: type };
            $.post(url, data, function (result) {
                list.html(result);
            });
            pageInput.val(page);
            pagersh(page, totalPage, prev, next);
        }
    });
    function pagersh(page, totalPage, pagePrev, pageNext) {
        if (page == totalPage - 1) {
            pageNext.hide();
        } else {
            pageNext.show();
        }
        if (page == 0) {
            pagePrev.hide();
        } else {
            pagePrev.show();
        }
    }
    $(".btn-delete").on('click', function () {
        var list = $(this).parent().siblings('.article-list').find("[name='checkbox']");
        var type = $(this).attr("data-type");
        var pageInput = $(this).parent().siblings('.pager').children("[name='current-page']");
        var next = $(this).parent().siblings('.pager').children(".page-next");
        var json = "";
        list.each(function () {
            if ($(this).attr('checked')) {
                json += $(this).val() + "|";
            }
        });
        var data = { type: type, ids: json };
        $.post(deleteUrl, data, function (success) {
            if (success) {
                pageInput.val(-1);
                next.trigger('click');
            }
        });
    });

    $('.btn-switcher').click(function () {
        $(this).addClass('manage-button-click');
        $(this).siblings().each(function () {
            $(this).removeClass('manage-button-click');
        });
        var id = $(this).attr('data-id');
        $('#' + id).show();
        $('#' + id).siblings().each(function () { $(this).hide(); });
    });

    $('.btn-switcher').first().trigger('click');
    $('.page-next').trigger("click");
});