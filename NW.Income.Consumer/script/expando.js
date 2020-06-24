function deselect(e) {
    $('.pop').slideFadeToggle(function() {
      e.removeClass('selected');
    });    
  }
  
  $(function() {
    $('#contact').on('click', function() {
      if($(this).hasClass('selected')) {
        deselect($(this));               
      } else {
        $(this).addClass('selected');
        $('.pop').slideFadeToggle();
      }
      return false;
    });
  
    $('.close').on('click', function() {
      deselect($('#contact'));
      return false;
    });
  });
  
  $.fn.slideFadeToggle = function(easing, callback) {
    return this.animate({ opacity: 'toggle', height: 'toggle' }, 'fast', easing, callback);
};

$(document).ready(function () {
    loadExpando();
});
function loadExpando() {
    var expando = document.getElementById('loadexpando');
    expando.innerHTML = `<style>
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