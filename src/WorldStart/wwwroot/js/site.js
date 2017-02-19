(function () {

    //var ele = $("#userName");
    //ele.text("Karolis");


    //var main = $("#main");
    //main.on("mouseenter", function () {
    //    main.style = "background-color: #888;";
    //});

    //main.on("mouseleave", function () {
    //    main.style = "";
    //});

    //var menuItems = $("ul.menu li a");
    //menuItems.on("click", function () {
    //    var me = $(this);
    //    alert(me.text());
    //});


    var $sidebarAndMain = $("#sidebar, #main");
    var $icon = $("#sideBarToggle i.fa");


    $("#sideBarToggle").on("click", function () {
        $sidebarAndMain.toggleClass("hide-sidebar");
        if ($sidebarAndMain.hasClass("hide-sidebar")) {
            $icon.removeClass("fa-angle-left");
            $icon.addClass("fa-angle-right");
        }
        else {
            $icon.removeClass("fa-angle-right");
            $icon.addClass("fa-angle-left");
        }
    });
})();