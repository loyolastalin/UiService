$(document).ready(function () {
    $("#OpenDialog").click(function () {
        var w = window.open("", "popupWindow", "width=1200, height=400, scrollbars=yes");
        var $w = $(w.document.body);
        $w.html(loadIncomeUI());
    });
});

function loadIncomeUI() {
    var localdata = '<h1>sdfsdf</h1>'
    $.ajax({
        url: 'http://localhost:50701/income',
        type: 'GET',
        async: false,
        success: function (data) {
            localdata = data;
        },
        error: function (data) {
            console.log('oops error occured!'); //or whatever
        }
    });
    return localdata;
}