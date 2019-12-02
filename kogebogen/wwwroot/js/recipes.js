var coll = document.getElementsByClassName("collapsible");

for (var i = 0; i < coll.length; i++) {
    coll[i].addEventListener("click", function () {
        this.classList.toggle("active");
        var content = this.nextElementSibling;
        if (content.style.display === "block") {
            content.style.display = "none";
        } else {
            content.style.display = "block";
        }
    });
}

var ranges = document.getElementsByClassName("slider");
var filterPrice = document.getElementById("filterPrice");
var filterTime = document.getElementById("filterTime");

for (var i = 0; i < ranges.length; i++) {
    filterPrice.innerHTML = "Max pris: " + ranges[i].value + " kr";
    filterTime.innerHTML = "Tid i alt: " + ranges[i].value + " min";
    ranges[i].addEventListener("input", function () {
        filterPrice.innerHTML = "Max pris: " + ranges[0].value + " kr";
        filterTime.innerHTML = "Tid i alt: " + ranges[1].value + " min";
    }, false);
}