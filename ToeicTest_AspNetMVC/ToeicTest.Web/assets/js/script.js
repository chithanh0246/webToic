(
    function ($) {
        "use strict"; var $wrapper = $('.main-wrapper'); var $pageWrapper = $('.page-wrapper');
        var $slimScrolls = $('.slimscroll');
        var Sidemenu = function () {
            this.$menuItem = $('#sidebar-menu a');
        };
        function init() {
            var $this = Sidemenu; $('#sidebar-menu a').on('click', function (e) {
                if ($(this).parent().hasClass('submenu')) { e.preventDefault(); }
                if (!$(this).hasClass('subdrop')) { $('ul', $(this).parents('ul:first')).slideUp(350); $('a', $(this).parents('ul:first')).removeClass('subdrop'); $(this).next('ul').slideDown(350); $(this).addClass('subdrop'); } else if ($(this).hasClass('subdrop')) { $(this).removeClass('subdrop'); $(this).next('ul').slideUp(350); }
            }); $('#sidebar-menu ul li.submenu a.active').parents('li:last').children('a:first').addClass('active').trigger('click');
        }
        init();
        $('body').append('<div class="sidebar-overlay"></div>');
        $(document).on('click', '#mobile_btn', function () {
            $wrapper.toggleClass('slide-nav'); $('.sidebar-overlay').toggleClass('opened');
            $('html').addClass('menu-opened');
            return false;
        });
        $(".sidebar-overlay").on("click", function () {
            $wrapper.removeClass('slide-nav');
            $(".sidebar-overlay").removeClass("opened"); $('html').removeClass('menu-opened');
        });

        if ($('.page-wrapper').length > 0) { var height = $(window).height(); $(".page-wrapper").css("min-height", height); }

        $(window).resize(function () {
            if ($('.page-wrapper').length > 0) { var height = $(window).height(); $(".page-wrapper").css("min-height", height); }
        }); if ($('.select').length > 0) {
            $('.select').select2({ minimumResultsForSearch: -1, width: '100%' });
        }


        if ($('[data-toggle="tooltip"]').length > 0) { $('[data-toggle="tooltip"]').tooltip(); }

        $(document).on('click', '.mail-important', function () {
            $(this).find('i.fa').toggleClass('fa-star').toggleClass('fa-star-o');
        }); if ($('.summernote').length > 0) {
            $('.summernote').summernote({ height: 200, minHeight: null, maxHeight: null, focus: false });
        }
        if ($slimScrolls.length > 0) {
            $slimScrolls.slimScroll({ height: 'auto', width: '100%', position: 'right', size: '7px', color: '#ccc', allowPageScroll: false, wheelStep: 10, touchScrollStep: 100 }); var wHeight = $(window).height() - 60; $slimScrolls.height(wHeight); $('.sidebar .slimScrollDiv').height(wHeight); $(window).resize(function () { var rHeight = $(window).height() - 60; $slimScrolls.height(rHeight); $('.sidebar .slimScrollDiv').height(rHeight); });
        }
        $(document).on('click', '#toggle_btn', function () {
            if ($('body').hasClass('mini-sidebar')) { $('body').removeClass('mini-sidebar'); $('.subdrop + ul').slideDown(); } else { $('body').addClass('mini-sidebar'); $('.subdrop + ul').slideUp(); }
            return false;
        }); $(document).on('mouseover', function (e) {
            e.stopPropagation(); if ($('body').hasClass('mini-sidebar') && $('#toggle_btn').is(':visible')) {
                var targ = $(e.target).closest('.sidebar').length; if (targ) { $('body').addClass('expand-menu'); $('.subdrop + ul').slideDown(); } else { $('body').removeClass('expand-menu'); $('.subdrop + ul').slideUp(); }
                return false;
            }
        });
    })(jQuery);