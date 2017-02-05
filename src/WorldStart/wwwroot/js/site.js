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

    $("#sideBarToggle").on("click", function () {
        $sidebarAndMain.toggleClass("hide-sidebar");
        if ($sidebarAndMain.hasClass("hide-sidebar")) {
            $(this).text("Show Menu");
        }
        else {
            $(this).text("Hide Menu");
        }
    });
})();