$(function(){

  // Toggle navigation - https://codepen.io/JoelSutherland/pen/DzbfE
  $('.c-header__nav').click(function() {
    $('.c-header__nav-list').toggleClass('c-header__nav-list--open');
    $('.c-header__nav').toggleClass('c-header__nav--open');
  });

  // Toggle header (on scroll) - https://jsfiddle.net/mariusc23/s6mLJ/31/
  var lastScrollTop = 0;
  $(window).scroll(function(event){
    var st = $(this).scrollTop();
    // Make sure they scroll more than 5 pixels to trigger toggle
    if(Math.abs(lastScrollTop - st) <= 5) { return; }
    // If they scrolled down and are past the header, lets go!
    if (st > lastScrollTop && st > $('.c-header').outerHeight()) {
      $('.c-header').addClass('c-header--hidden'); // Scroll down
    } else {
      if(st + $(window).height() < $(document).height()) {
        $('.c-header').removeClass('c-header--hidden'); // Scroll Up
      }
    }
    lastScrollTop = st;
  });

});


$("article").progressBar({
  progressBarHeight: 10
});
