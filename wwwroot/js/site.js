$(document).ready(function () {
    $("h1.display-4").click(function () {
        $(".margin-bottom").toggle();
    });
    $("img").click(function () {
        $(".text-justify").animate({
            height: 'toggle'
        });
    });
    $("h2").click(function () {
        let text = $("h2").text();
        $("h2").after("<p>" + text + "</p>");
        $("div.text-center").css({ "background-color": "yellow", "font-size": "200%" });
    });

});
