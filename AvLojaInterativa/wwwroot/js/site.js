function getCategorias(url, id) {
    let idCategoria = document.getElementById("fabricante");
    $.ajax({
        type: "GET",
        url: url,
        dataType: "HTML",
        data: { id: idCategoria.value },

        success: function (result) {
            $("#ajaxBox").html(result);
        },
        error: function (jqXHR, textStatus, errorThrown) {
            //TODO::
        },
    });
}