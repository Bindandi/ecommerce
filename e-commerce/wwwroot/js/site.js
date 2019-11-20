var header = {
    init: function () {

        document.getElementById("btn-entrar").onclick = header.entrar;
        document.getElementById("btn-sair").onclick = header.sair;
        document.getElementById("btn-login").onclick = header.logar;


    },

    logar: function () {

        
        var dados = {

            usuario: document.getElementById("inputUsuario").value,
            senha: document.getElementById("inputSenha").value
        }

        var config = {
            method: "POST",
            headers: {
                "Content-Type": "application/json; charset=utf-8"
            },
            body: JSON.stringify(dados)
        }

        fetch("Home/Logar", config)
            .then(function (res) {
                return res.json();

            })
            .then(function (res) {
                if (res.operacao == false)
                    document.getElementById("divMsgs").innerHTML = "<p style='color:red'>Verifique o Usuario e Senha</p>"
                else
                    alert("logou");

            })
            .catch(function () {
                alert("Sua requisição não pode ser atendida.");

            });
    },

    entrar: function () {
        $("#modalLogin").modal("show");
    },

    sair: function () {
        $("#btnEntrar").css("display", 'flex');
        $("#btnSair").css("display", 'none');
        $("#usuLogado").css("display", 'none');

        $("#inputEmail").val("");
        $("#inputPassword").val("");
    }

}

header.init();







