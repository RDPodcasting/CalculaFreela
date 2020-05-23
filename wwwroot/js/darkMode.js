jQuery(".modoDark").hide();
var xx = "corPreta";
jQuery("#modoWhite").click(function () {
    mudandoCor();
})
jQuery("#modoDark").click(function () {
    mudandoCor();
})
function mudandoCor() {
    if (xx == "corBranca") {
        jQuery("#corpo").addClass("is-black");
        xx = "corPreta";
        jQuery(".modoDark").hide();
        jQuery(".modoWhite").show();

    } else {
        jQuery("#corpo").removeClass("is-black");
        xx = "corBranca";
        jQuery(".modoDark").show();
        jQuery(".modoWhite").hide();
    }
}