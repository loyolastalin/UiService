class IncomeComponent extends HTMLElement {
    connectedCallback() {
 this.innerHTML = `<p>Loding Income View</p>
      <ul>
         <li>First Question<ol><li>First Answer</li><li>Second Answer</li></ol></li>
        <li>Second Question<ol><li>First Answer</li><li>Second Answer</li></ol></li>
        <li>Thrid Question<ol><li>First Answer</li><li>Second Answer</li></ol></li>
      </ul>
      `;
  }
}

customElements.define('income-component', IncomeComponent);

