/*$(function(){
  $('.dt-line-item-content').click(function(){
    var lineNumber = $(this).attr("data-line");
    $('tr:not(tr[data-line="' + lineNumber + '"])').removeClass('js-actions-expanded');  
    $('tr[data-line="' + lineNumber + '"]').addClass('js-actions-expanded');
  });
});*/
function showQuickActions(clicked) {
  var quickactionsContainer = clicked.next('tr.dt-line-item-actions');
  var quickactions = quickactionsContainer.find('quick-action-wrapper');
  quickactionsContainer.addClass('js-actions-expanded');
  clicked.addClass('js-actions-expanded');
  quickactions.slideDown();
}

$(function(){
  $('.dt-line-item-content').click(function(){
    var clicked = $(this)
    showQuickActions(clicked);
  });
});