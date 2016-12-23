$(document).ready(function () {
    animateMenuDown();
    $('.centerContent').fadeIn(1000).removeClass('hidden');
});

$("a").click(function (e) {
    if (!$(this).hasClass("animationExeption")) {
        var link = this;
        e.preventDefault();
        e.stopPropagation();
        animateMenuUpp();
        $(".centerContent").fadeOut("fast", function () { });
        setTimeout(function () { document.location = link.href; }, 1000);
   }
});

function animateMenuUpp() {
    console.log("animateMenuUpp");
    $(".navbar-fixed-top").animate({
         top: "-=100"
    });
}
function animateMenuDown() {
    console.log("animateMenuUpp");
    $(".navbar-fixed-top").animate({
        top: "+=100"
    });
}



