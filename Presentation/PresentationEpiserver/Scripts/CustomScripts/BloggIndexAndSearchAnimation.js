$(document).ready(function () {
    console.log("1");
    if($("#searchWindow").hasClass("dispalySearch")) {
        $(".bloggSearch").toggle();
    }
    
    $("#displayIndex").click(function (e) {
        e.preventDefault();
        e.stopPropagation();
        $(".bloggIndex").toggle();
        $(".bloggSearch").hidden();
    });
    $("#displaySearch").click(function (e) {
        e.preventDefault();
        e.stopPropagation();
        $(".bloggSearch").fadeToggle("slow");
        $(".bloggIndex").hidden();
    });
    $(".goToTopp").click(function (e) {
        e.preventDefault();
        e.stopPropagation();

        $("html, body").animate({ scrollTop: 0 }, "slow");
        return false;
    });

});
