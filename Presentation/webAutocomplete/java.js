$(function () {
    var taggs = [
      "JavaScript",
      "MVC",
      "WebbForms"
      
    ];
    $("#tags").autocomplete({
        source: taggs
       
    });
});