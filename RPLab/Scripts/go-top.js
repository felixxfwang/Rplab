////////////////回到顶部代码 
$.fn.extend({
    goToTop: function (b) {
        var b = $.extend({
            pageWidth: 1016,//附着容器宽度
            pageWGap: 0,//按钮和容器的距离
            pageHGap: 60,//按钮和页面底部的距离
            startline: 20,//出现按钮时的滚动条滚动的距离
            duration: 200,//回到顶部的速度时间ms
            showBtntime: 100//显示\隐藏回到顶部按钮的速度时间
        },
        b);
        var e = $(this);
        var f = $(window);
        var d = (window.opera) ? (document.compatMode == "CSS1Compat" ? $("html") : $("body")) : $("html,body");
        var c = !($.browser.msie && parseFloat($.browser.version) < 7);
        var a = false;
        e.css({
            opacity: 0,
            position: (c ? "fixed" : "absolute")
        });
        e.click(function (g) {
            d.stop().animate({
                scrollTop: 0
            },
            b.duration);
            e.blur();
            g.preventDefault();
            g.stopPropagation()
        });
        f.bind("scroll resize",
        function (i) {
            var h;
            if (f.width() > b.pageHGap * 2 + b.pageWidth) {
                h = (f.width() - b.pageWidth) / 2 + b.pageWidth + b.pageWGap
            } else {
                h = f.width() - b.pageWGap - e.width()
            }
            var j = f.height() - e.height() - b.pageHGap;
            j = c ? j : f.scrollTop() + j;
            e.css({
                left: h + "px",
                top: j + "px"
            });
            var g = (f.scrollTop() >= b.startline) ? true : false;
            if (g && !a) {
                e.stop().animate({
                    opacity: 1
                },
                b.showBtntime);
                a = true
            } else {
                if (a && !g) {
                    e.stop().animate({
                        opacity: 0
                    },
                    b.showBtntime);
                    a = false
                }
            }
        })
    }
});

$(function () {
    $('<div class="go-top" title="点击返回顶部"><img src="Images/site/top.jpg"/></div>').appendTo("body");//将html代码放入页面
    $(".go-top").goToTop({});
    $(window).bind('scroll resize', function () {
        $(".go-top").goToTop({});
    });
});