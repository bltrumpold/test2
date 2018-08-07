window.addEventListener('load', init)
function init(e)
{
    var submit = document.querySelector('#submit');
    var name = document.querySelector('#name');

    submit.addEventListener('clcick', doStuff);
    //name.addEventListener('blur', doStuff2);

    function doStuff(e)
    {
        if(name.value === "")
        {
            name.style.backgroundColor = "red";
        }
        else 
        {
            name.style.backgroundColor = "white";
        }
    }
}