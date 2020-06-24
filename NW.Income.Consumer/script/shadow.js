$(document).ready(function () {
    showShadow();
});
function showShadow() {
    const shadowRoot = document.getElementById('example').attachShadow({ mode: 'open' });
    shadowRoot.innerHTML = `<style>
button {
      background: tomato;
      color: white;
}
</style>
<p>Place holder for the Income View</p>
    <ul>
       <li>First Question<ol><li>First Answer</li><li>Second Answer</li></ol></li>
        <li>Second Question<ol><li>First Answer</li><li>Second Answer</li></ol></li>
        <li>Thrid Question<ol><li>First Answer</li><li>Second Answer</li></ol></li>
    </ul>
        }`
}
