var profile = document.getElementById("theProfile");

//Gode gammeldags click funktioner, der enten displayer none eller block på profil div
document.getElementById("openProfile").addEventListener('click', function () {
    if (profile.style.left = "-70w") {
        profile.style.left = "0vw";
        profile.style.animationName = "in";
    }
});

document.getElementById("back").addEventListener('click', function () {
    if (profile.style.left = "0vw") {
        profile.style.left = "-70vw";
        profile.style.animationName = "out";
    }
});


//Swipe functions - så der er mulighed for at trække profilen ind
document.addEventListener('swiped-right', function () {
    document.getElementById("theProfile").style.left = "0vw";
    document.getElementById("theProfile").style.animationName = "in";
});

document.addEventListener('swiped-left', function () {
    document.getElementById("theProfile").style.left = "-70vw";
    document.getElementById("theProfile").style.animationName = "out";
})