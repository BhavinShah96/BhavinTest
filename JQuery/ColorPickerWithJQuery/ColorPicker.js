Clicked = true;
var hexcodes = ["#FF0000", "#0000FF", "00FF00", "FFFF00"];
// $("#selectColor").click(function () {
//     alert(hexcodes[$("#colors").prop("selectedIndex")]);
// });
// $("#selectColor").click(function () {
//     $("#xyz").css({ "background-color": $("#colors").val() });
// });
// $("#selectColor").click(function () {
//     $("#colors").css({ "background-color": $("#colors").val() });
// });
$("#selectColor").click(function () {
    $("#colors").css({ "color": $("#colors").val() });
});