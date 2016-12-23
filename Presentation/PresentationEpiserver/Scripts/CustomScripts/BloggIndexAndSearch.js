$("#displayIndex").click(function (e) {
    e.preventDefault();
    e.stopPropagation();
    $(".bloggIndex").toggle();
    $(".bloggSearch").hidden();
});
$("#displaySearch").click(function (e) {
    e.preventDefault();
    e.stopPropagation();
    $(".bloggSearch").toggle();
    $(".bloggIndex").hidden();
});
$(".goToTopp").click(function (e) {
    e.preventDefault();
    e.stopPropagation();

    $("html, body").animate({ scrollTop: 0 }, "slow");
    return false;
});