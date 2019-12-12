var coll = document.getElementsByClassName("collapsible");

for (var i = 0; i < coll.length; i++) {
    coll[i].addEventListener("click", function () {
        this.classList.toggle("active");
        var content = this.nextElementSibling;
        if (content.style.display === "block") {
            content.style.display = "none";
            this.style.animationName = "";
        } else {
            content.style.display = "block";
            this.style.animationName = "buttonOpen";
        }
    });
}

var ranges = document.getElementsByClassName("slider");
var filterPrice = document.getElementById("filterPrice");
var filterTime = document.getElementById("filterTime");

var recipes = document.getElementsByClassName("recipes");
var prices = document.getElementsByClassName("totalPrice");
var times = document.getElementsByClassName("totalTime");

/* Laver disse variabler for at ændre value og innerHTML fra prices, times og recipes til int, så vi kan sorterer over en value i range sliderne på 100 */
var priceRange = document.getElementById("priceRange");
var timeRange = document.getElementById("timeRange");
var priceRangeInteger = parseInt(priceRange.value, 10);
var timeRangeInteger = parseInt(timeRange.value, 10);

for (var i = 0; i < ranges.length; i++) {
    filterPrice.innerHTML = "Max pris: " + ranges[0].value + " kr";
    filterTime.innerHTML = "Tid i alt: " + ranges[1].value + " min";
    ranges[i].addEventListener("input", function () {
        filterPrice.innerHTML = "Max pris: " + ranges[0].value + " kr";
        filterTime.innerHTML = "Tid i alt: " + ranges[1].value + " min";
    }, false);
    ranges[i].addEventListener("change", function () {
        var priceRangeInteger = parseInt(ranges[0].value, 10);
        var timeRangeInteger = parseInt(ranges[1].value, 10);
        for (var x = 0; x < recipes.length; x++) {
            var pricesInteger = parseInt(prices[x].innerHTML, 10);
            var timesInteger = parseInt(times[x].innerHTML, 10);
            if (pricesInteger > priceRangeInteger || timesInteger > timeRangeInteger) {
                recipes[x].style.display = "none";
            } else {
                recipes[x].style.display = "block";
            }
        }
    });
}
var favorite = document.getElementsByClassName("love");

for (var i = 0; i < favorite.length; i++) {
    favorite[i].addEventListener('click', function () {
        this.style.color = "#960525";
    });
}