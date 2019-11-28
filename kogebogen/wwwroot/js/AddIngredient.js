

function meh()
{
    let k = document.getElementById("ingredient");
    var cln = k.cloneNode(true);
    document.getElementById("ingredients").appendChild(cln);
}