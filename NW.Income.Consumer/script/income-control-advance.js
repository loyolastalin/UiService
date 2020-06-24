/* Responsible to create an HTML element, supports only for i.e 
   and get the value from the ServiceUI and render the control
*/
class IncomeComponent extends HTMLElement {
  connectedCallback() {
    loadIncomeUI(this);
  }
}

customElements.define(COMPONENT_NAME, IncomeComponent);

function loadIncomeUI(currentScope) {

    $.get(POPUP_SERVICEUIURL, function (response) {
    currentScope.innerHTML = response;
  });

  $.ajax({
      url: POPUP_SERVICEUIURL,
    type: 'GET',
    success: function (data) {
      currentScope.innerHTML = data;
    },
    error: function (data) {
      console.log('oops error occured!'); //or whatever
      var defaultHtml = `<p>Place holder for the Income View</p>
<ul>
    <li>First Question</li>
    <li>Second Question</li>
    <li>Thrid Question</li>
</ul>
`
      currentScope.innerHTML = defaultHtml;

    }
  });


}
