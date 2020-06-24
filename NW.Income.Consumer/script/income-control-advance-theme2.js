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

    $.get('http://localhost:50701/Dynamic/2', function (response) {
    currentScope.innerHTML = response;
  });
}
