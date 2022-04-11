
var btn = document.getElementById("btn");
var menu = document.getElementById("menu");
var closeBtn = document.getElementById("close-btn");
var container = document.getElementById("container");


// OPEN OVERLAY
btn.addEventListener("click", function() {
    menu.classList.remove("fade-out");
    menu.classList.add("fade-in");
    container.classList.add("animation-overlay");
  
    setTimeout(function(){container.classList.remove("animation-overlay");}, 500);

});

// CLOSE OVERLAY
closeBtn.addEventListener('click', function() {
    menu.classList.remove("fade-in");
    menu.classList.add("fade-out");
});