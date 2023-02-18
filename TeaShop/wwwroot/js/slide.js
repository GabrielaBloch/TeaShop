'use strict';
$(document).ready(function () {

    // Accordion
    var all_panels = $('.index-accordion > li > ul').hide();

    $('.index-accordion > li > a').click(function () {
        var target = $(this).next();
        if (!target.hasClass('active')) {
            all_panels.removeClass('active').slideUp();
            target.addClass('active').slideDown();
        }
        return false;
    });
    // End accordion


});
