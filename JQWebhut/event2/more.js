
$(document).ready(function () {

    $("h1").click(function () {
        $(this).css("background-color", "red");

    });

    $("#change").click(function () {
        $("#slow").css("background-color", "#7D0541");

    });

    $("#blu").click(function () {
        $("h1").css("background-color", "blue");

    });

    $("#red").click(function () {
        $("h1").css("background-color", "red");

    });

    $("#yel").click(function () {
        $("h1").css("background-color", "yellow");

    });

    $("#green").click(function () {
        $("h1").css("background-color", "green");

    });

    $("h2").mouseup(function () {
        $(this).css("background-color", "#F9966B");

    });

    $("h2").mousedown(function () {
        $(this).css("background-color", "#4FD0FF");

    });

    $("h3").mouseenter(function () {
        $(this).css("background-color", "#F9966B");

    });

    $("h3").mouseleave(function () {
        $(this).css("background-color", "#4FD0FF");

    });


    $("#revH3").click(function () {

        $("h3").css("background-color", "white");
    });

	  $("#revH2").click(function () {

        $("h2").css("background-color", "white");
    });
	
	  $("#revH1").click(function () {

        $("h1").css("background-color", "white");
    });


});
