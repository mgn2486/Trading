$(function () {
    $('img').hide();

    function anim() {
        $("#wrap img").first().appendTo('#wrap').fadeOut(3500).addClass('transition').addClass('scaleme');
        $("#wrap img").first().fadeIn(3500).removeClass('scaleme');
        setTimeout(anim, 3700);
    }
    anim();
});