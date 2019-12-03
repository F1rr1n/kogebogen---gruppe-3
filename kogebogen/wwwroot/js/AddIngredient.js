function micro(event)
{
    event.preventDefault();
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

function test(event)
{
    event.preventDefault();
    let j = document.createElement("li");
    let k = '<input type="text" name="guide" required/>';
    j.innerHTML += k;
    document.getElementById("description_steps").appendChild(j);
}
function remove(event) {
    event.preventDefault();
    var r = document.getElementById("ingredients").lastElementChild;
    r.parentNode.removeChild(r);
}


function fjerntrin(event) {
    event.preventDefault();
    var f = document.getElementById("description_steps").lastElementChild;
    f.parentNode.removeChild(f)
}