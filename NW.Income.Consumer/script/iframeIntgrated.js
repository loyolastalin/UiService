$(document).ready(function () {
    loadIncomeService();
});

function loadIncomeService() {
    var localdata = '<h1>Defulat Content</h1>'
    $.ajax({
        url: POPUP_SERVICEUIURL,
        type: 'GET',
        async: false,
        success: function (data) {
            var iframe = document.getElementById('myIframe');//.src = 'IncomeService.htm';
            iframedoc = iframe.contentDocument || iframe.contentWindow.document;
            iframedoc.body.innerHTML = data;
        },
        error: function (data) {
            console.log('oops error occured!'); //or whatever
        }
    });
    return localdata;
}