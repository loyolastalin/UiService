$(document).ready(function () {
    $("#OpenDialog").click(function () {
        var w = window.open("", "popupWindow", "width=1200, height=400, scrollbars=yes");
        var $w = $(w.document.body);
        $w.html(`
  <p>Place holder for the Income View</p>
    <ul>
        <li>First Question<ol><li>First Answer</li><li>Second Answer</li></ol></li>
        <li>Second Question<ol><li>First Answer</li><li>Second Answer</li></ol></li>
        <li>Thrid Question<ol><li>First Answer</li><li>Second Answer</li></ol></li>
    </ul>
`);
    });
});

function loadIncomeUI() {
    var localdata = '<h1>Default Data</h1>'
    $.ajax({
        url: POPUP_LOCAL_URL,
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