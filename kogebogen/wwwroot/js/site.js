var profile = document.getElementById("theProfile");

document.getElementById("back").addEventListener('click', function () {
    if (profile.style.left = "0vw") {
        profile.style.left = "-70vw";
        profile.style.animationName = "out";
        profile.style.boxShadow = "none";
    }
});

var search = document.getElementById("searchModal");
search.style.display = "none";
document.getElementById("searchButtonNav").addEventListener('click', function () {
    if (search.style.display == "none") {
        search.style.display = "block";
    } else {
        search.style.display = "none";
    }
});

//Swipe functions - så der er mulighed for at trække profilen ind
document.getElementById("swipeField").addEventListener('swiped-right', function () {
    profile.style.left = "0vw";
    profile.style.animationName = "in";
    profile.style.boxShadow = "2px 0px 10px 0px";
});

document.addEventListener('swiped-left', function () {
    profile.style.left = "-70vw";
    profile.style.animationName = "out";
    profile.style.boxShadow = "none";
}) 