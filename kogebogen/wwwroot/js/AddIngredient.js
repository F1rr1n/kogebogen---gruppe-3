function micro()
{

    let k = document.createElement("p");
    var output = '<input type="text" required/>' + '<input type="number" value="amount" required/>' +
        '<select required>' +
        '<option value="stk">stk</option>' +
        '<option value="g">g</option>' +
        '<option value="dl">dl</option>' +
        '<option value="tsk">tsk</option>' +
        '<option value="spsk">spsk</option>' +
        '</select>';
    k.innerHTML += output;
    document.getElementById("ingredient").appendChild(k);
}

function test()
{

    var k = '<li><input type="text" required/></li>';
    var test = document.getElementById("description_steps");
    test.innerHTML += k;

}