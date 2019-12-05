//Udregning af total pris fra hver enkelte opskrift
var totalPrice = document.getElementsByClassName("price");
var total = 0;

for (var i = 0; i < totalPrice.length; i++) {
    var pricesInteger = parseInt(totalPrice[i].innerHTML, 10);
    total += pricesInteger
}

document.getElementById("totalPrice").innerHTML = total;