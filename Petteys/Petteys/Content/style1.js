var contents = $(".contents").eq(0);
var fixed = $(".fixed").eq(0);
$(window).scroll(function () {
    var top = $(window).scrollTop();
    var opacity = (top - 100) / 100;
    fixed.html(top + " # " + opacity);
    fixed.css("opacity", opacity);
});