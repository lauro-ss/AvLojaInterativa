function getCategorias(url, id) {
    let idCategoria = document.getElementById("fabricante");
    if (idCategoria.value != null) {
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
}

function getProduto(url) {
    $.ajax({
        type: "GET",
        url: url,
        dataType: "HTML",

        success: function (result) {
            $("#produto").html(result);
        },
        error: function (jqXHR, textStatus, errorThrown) {
            //TODO::
        },
    });
}

function getFabricante(url) {
    $.ajax({
        type: "GET",
        url: url,
        dataType: "HTML",

        success: function (result) {
            $("#fabricante").html(result);
        },
        error: function (jqXHR, textStatus, errorThrown) {
            //TODO::
        },
    });
}

function getEdit(url, idProduto) {
    $.ajax({
        type: "GET",
        url: url,
        dataType: "HTML",
        data: { id: idProduto },

        success: function (result) {
            $("#modalBody").html(result);
        },
        error: function (jqXHR, textStatus, errorThrown) {
            //TODO::
        },
    });
}