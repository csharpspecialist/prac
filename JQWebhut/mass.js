$(document).ready(function () {

    $("h3").mouseenter(function() {
		
		$(this).css("background-color", "orange");
	});

    $("h3").mouseleave(function () {

        $(this).css("background-color", "red");
    });

   $("#rev").click(function () {

        $("h3").css("background-color", "white");
    });


});
    
    