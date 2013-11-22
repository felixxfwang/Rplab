var n, t = 0, count;
$(document).ready(function () {
    count = $(".banner-list").children().length;
    $(".banner-list a:not(:first-child)").hide();
    $("#banner ul li").click(function () {
        var i = $(this).find("img").attr('alt') - 1;
        n = i;
        if (i >= count) return;
        $(".banner-title").html(
            $(".banner-list").children().eq(i).find("img").attr('alt')
        );
        $(".banner-list a").filter(":visible").fadeOut(0)
            .parent().children().eq(i).fadeIn(1000);
        $(this).find("img").toggleClass("focus");
        $(this).siblings().each(function () {
            $(this).find("img").removeAttr("class");
        });
    });
    t = setInterval(bannerSwitch, 8000);
    $("#banner ul li").eq(0).trigger('click');

    function bannerSwitch() {
        n = n >= count - 1 ? 0 : ++n;
        $("#banner ul li").eq(n).trigger('click');
    }
});