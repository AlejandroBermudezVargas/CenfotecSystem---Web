$(function () {
    $(".selectable").selectable();
});

$(document).ready(function () {
    $("#MainContent_btnGuardar").click(function () {
        var ids = "";
        $('.ui-selected').each(function(){
            ids=$(this).attr("id")+","+ids;
        });
        $("#MainContent_HiddenFieldPreguntas").val(ids);
    });
});

