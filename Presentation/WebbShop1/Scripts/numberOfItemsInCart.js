var counter = 0;
var item = document.getElementsByClassName("addItemToCart");

item.addEventListener("click", function() {
   
      document.getElementById("numberOfItems").innerHTML = "<a>@Session['NumberOfItemsInBasket']</a>";
});
