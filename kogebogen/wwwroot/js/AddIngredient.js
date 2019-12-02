function micro()
{

    let k = document.createElement("p");
    var output = '<input type="text" name="ingredients" required/>' + '<input type="number" value="amount" name="amount" required/>' +
        '<select name="unit" required>' +
        '<option value="stk">stk</option>' +
        '<option value="g">g</option>' +
        '<option value="dl">dl</option>' +
        '<option value="tsk">tsk</option>' +
        '<option value="spsk">spsk</option>' +
        '</select>';
    k.innerHTML += output;
    document.getElementById("ingredients").appendChild(k);
}

function test()
{
    let j = document.createElement("li");
    let k = '<input type="text" name="guide" required/>';
    j.innerHTML += k;
    document.getElementById("description_steps").appendChild(j);
}
function remove() {
    var r = document.getElementById("ingredients").lastChild;
    r.parentNode.removeChild(r)
}


function fjerntrin() {
    var f = document.getElementById("description_steps").lastChild;
    f.parentNode.removeChild(f)
}