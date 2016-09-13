

$(document).ready(function() {

    $("#colorButton").click(function() {
        $("div").css("background-color", "red"); 

    });       

    $("#backButton").click(function() {
        $("div").css("background-color", "white");
    });

    $("#nowButton").click(function () {
        $("#three").css("background-color", "blue");
    });

    $("#clearButton").click(function () {
        $("#three").css("background-color", "white");
    });

    $("#greenButton").click(function () {
        $("#strong,h2,span").css("background-color", "green");
    });

    $("#whiteButton").click(function () {
        $("#strong, h2, span").css("background-color", "white");//effects multiple in-line types
    });//make sure there are not "" between each selector in line 27 or it won't work correctly!!!


    $("#moveButton").click(function () {
        $("div > p:first-child").css("background-color", "yellow");
    });//above in line 32...changes the first child element inside of the div tag

    $("#drunkButton").click(function () {
        $("div > p:first-child").css("background-color", "white");
    });

    $("#closeButton").click(function () {
        $("div strong").css("background-color", "black");
    });//above in line 40...changes the strong element inside of the div tag

    $("#masterButton").click(function () {
        $("div strong").css("background-color", "white");
    });

    $("#smartButton").click(function () {
        $("p:even").css("background-color", "black");
    });//above in line 48...changes the even p tags to black

    $("#cleverButton").click(function () {
        $("p:even").css("background-color", "white");
    });

    $("#tallButton").click(function () {
        $("p:odd").css("background-color", "#BCC6CC");
    });//above in line 56...changes the odd p tags to grey

    $("#smallButton").click(function () {
        $("p:odd").css("background-color", "white");
    });

    $("#rightButton").click(function () {
        $("#mult").css("background-color", "#2554C7");
    });//above in line 64...changes the mult id tags to sapphire blue

    $("#leftButton").click(function () {
        $("#mult").css("background-color", "white");
    });

    $("#flightButton, strong").click(function () {
        $("strong.goal, .goal").css("background-color", "#7D0552");
    });//above in line 64...changes the mult id tags to plum/purple

    $("#spaceButton, strong").click(function () {
        $("strong.goal, .goal").css("background-color", "white");
    });

    $("#dayButton, h2").click(function () {
        $(this).css("background-color", "#FF7F50");
    });//This code does not work!!!!.  adding the h2 tag makes it not work!!!!

    $("#nightButton, h2").click(function () {
        $(this).css("background-color", "white");
    });

 

});






