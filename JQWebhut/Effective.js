$(document).ready(function () {

    $("p, h3").hide();

    $("h1").click(function () {

        $(this).next().slideToggle(250);
    });

    $("h2").click(function () {

	 $("h3").next().slideToggle(250);
      //  $("h3").hide(2000);
    });
  


});
    
    



