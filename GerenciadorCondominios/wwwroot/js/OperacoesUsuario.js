﻿function AprovarUsuario(usuarioId, nome) {
    
    const url = "/Usuarios/AprovarUsuario";

    $.ajax({
        method: 'POST',
        url: url,
        data: { usuarioId: usuarioId },
        success: function (data) {

            if (data === true) {
                $('#' + usuarioId).removeClass("purple darken-3").addClass("green dark-3").text("Aprovado");

                $("." + usuarioId).children("a").remove();
                $("." + usuarioId).append('<a class="btn-floating blue darken-4" href="Usuarios/GerenciarUsuarios?usuarioId=' + usuarioId + ' '
                    + ' & nome=' + nome + '" asp-controller="Usuarios" asp-action="GerenciarUsuario" asp-route-usuarioId=' + usuarioId + ' asp-route-nome' + nome + '>'
                    + '<i class="material-icons">group</i></a>');

                M.toast({
                    html: "Usuario aprovado",
                    classes: "green darken-3"
                });
            }
            else {
                M.toast({
                    html: "Não foi possivel aprovar o usuario"
                });
            }
        }
    })
}

function ReprovarUsuario(usuarioId, nome) {
    const url = "/Usuarios/ReprovarUsuario";

    $.ajax({
        method: 'POST',
        url: url,
        data: { usuarioId: usuarioId },
        success: function (data) {

            if (data === true) {
                $('#' + usuarioId).removeClass("purple darken-3").addClass("orange dark-3").text("Reprovado");

               
                M.toast({
                    html: "Usuario reprovado",
                    classes: "orange darken-3"
                });
            }
            else {
                M.toast({
                    html: "Não foi possivel reprovar o usuario"
                });
            }
        }
    })
}