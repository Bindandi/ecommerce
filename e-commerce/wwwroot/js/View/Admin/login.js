var index = {
    init: function () {

        
        document.getElementById("btn-loginAdm").onclick = index.logar;


        //document.getElementById("checkMestre").addEventListener("change", index.selecao);

    },


    logar: function () {


        var dados = {

            usuario: document.getElementById("inputEmailAdmn").value,
            senha: document.getElementById("inputPasswordAdmn").value
        }

        var config = {
            method: "POST",
            headers: {
                "Content-Type": "application/json; charset=utf-8"
            },
            body: JSON.stringify(dados)
        }

        fetch("Logar", config)
            .then(function (res) {
                return res.json();

            })
            .then(function (res) {
                if (res.operacao == false)
                    //document.getElementById("divMsgs").innerHTML = "<p style='color:red'>Verifique o Usuario e Senha</p>"
                    alert("Verifique o Usuario e Senha");
                else
                    alert("logou");

            })
            .catch(function () {
                alert("Sua requisição não pode ser atendida.");

            });
    },
    


}

index.init();