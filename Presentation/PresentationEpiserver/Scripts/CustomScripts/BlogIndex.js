var uri = '/api/bloggs/Menu/en/100';

$(document).ready(function () {

    $.getJSON(uri)
          .done(function (data) {
              $.each(data, function (key, item) {
                  $.each(item, function (key, item) {
                      $("#years").append('<li data-year = "' + item.Year + '" class="yearLink"><h3>' + item.Year + '</h3></li>');
                      $.each(item.Bloggs, function (key, item) {
                          $("#blogs").append('<li class="blogItem ' + item.Year + '" data-p = "1" style="display: none"><a href="' + item.BlogUrl + '">' + item.Header + '</a></li>');
                      });
                  });
              });
              displayIndex();
          });
});

function displayIndex() {
    var itemsPerPage = 2;
    var filteredItems = "";
    var numberOfPages = 1;
    var numberOfItems = 3;
    var p = 0;
    var curentYear = 0;

    $(".yearLink").click(function () {
        curentYear = $(this).data("year");
        displayMenu(itemsPerPage, p, curentYear);
    });

    $("#leftBtn").click(function () {
        if (p > 0) {
            p--;
            console.log(p);
            displayMenu(itemsPerPage, p, curentYear);
        }
    });

    $("#rightBtn").click(function () {
        if (p < numberOfPages - 1) {
            p++;
            console.log(p);
            displayMenu(itemsPerPage, p, curentYear);
        }
    });

    function displayMenu(itemsPerPage, p, year) {

        $(".blogItem").hide();
        filteredItems = $("li").filter("[class~='" + year + "']");

        numberOfItems = filteredItems.length;
        numberOfPages = Math.ceil(numberOfItems / itemsPerPage);

        var bloggPageNumber = 0;
        for (var i = 0; i <= numberOfItems - 1; i++) {
            if (i && i % itemsPerPage === 0) {
                bloggPageNumber++;
            }
            filteredItems[i].dataset.p = bloggPageNumber.toString();
        }
        var itemsToDisplay = filteredItems.filter("[data-p~='" + p + "']");
        itemsToDisplay.toggle();

    }
}

