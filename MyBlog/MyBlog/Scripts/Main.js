$(document).ready(function () {

    //show and hide the comments
    $('.showComments').on('click', function () {

        var parent = $(this).parent();
        var commentsToShowOrHide = parent.find('.commentsdiv');
        commentsToShowOrHide.slideToggle();

    });

});