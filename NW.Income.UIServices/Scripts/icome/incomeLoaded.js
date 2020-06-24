$(document).ready(function () {
    load();
});

function load() {
    $.ajax({
        url: INCOME_API_URL,
        type: 'GET',
        dataType: "json",
        success: function (data) {
            var container = document.getElementsByClassName('incomeContainer')[0];
            createSublist(container, data);
        },
        error: function (data) {
            console.log('oops error occured!'); //or whatever
        }
    });
}

var createSublist = function (container, args) {
    var ul = document.createElement('ul');

    for (var j = 0; j < args.length; j++) {
        var data = args[j];

        var li = document.createElement('li');
        li.innerText = data.question;
      
        var ol = document.createElement('ol');
        for (var k = 0; k < data.answer.length; k++) {
            var oli = document.createElement('li');
            oli.innerText = data.answer[k];
            ol.appendChild(oli);
        }
     
        li.appendChild(ol);
        ul.appendChild(li);
    }

    ul.appendChild(li);
    container.appendChild(ul);
}

