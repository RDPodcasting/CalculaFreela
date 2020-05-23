jQuery("#abrirModal").click(function () {
    jQuery("#calcFreela").addClass("is-active");
});
jQuery("#closeCancel").click(function () {
    fecharCalcFreela();

});
jQuery("#closeCanc").click(function () {
    fecharCalcFreela();
});

function fecharCalcFreela() {
    jQuery("#calcFreela")
        .removeClass("is-active");
}
