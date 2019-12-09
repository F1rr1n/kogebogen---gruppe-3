document.getElementById("searchModal").style.display = "none";
document.getElementById("searchButton").addEventListener('click', function () {
    var search = document.getElementById("searchModal");
    if (search.style.display == "none") {
        search.style.display = "block";
    } else {
        search.style.display = "none";
    }
});

var profile = document.getElementById("theProfile");

//Gode gammeldags click funktioner, der enten displayer none eller block på profil div
document.getElementById("openProfile").addEventListener('click', function () {
    if (profile.style.left = "-70w") {
        profile.style.left = "0vw";
        profile.style.animationName = "in";
        profile.style.boxShadow = "2px 0px 10px 0px";
    }
});