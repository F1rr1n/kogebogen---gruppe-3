document.getElementById("searchModal").style.display = "none";
document.getElementById("searchButton").addEventListener('click', function () {
    var search = document.getElementById("searchModal");
    if (search.style.display == "none") {
        search.style.display = "block";
    } else {
        search.style.display = "none";
    }
});