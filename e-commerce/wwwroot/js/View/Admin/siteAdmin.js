var index = {
    init: function () {

        document.getElementById("btnFind").onclick = index.pesquisarUsuario;
        


        //document.getElementById("checkMestre").addEventListener("change", index.selecao);

    },


    logar: function () {
        alert("Clicou");

    },
    pesquisarUsuario: function () {
        var nome = document.getElementById("inpFind").value;

        var config = {
            method: "GET",
            headers: {
                "Content-type": "application/json; charset=utf-8"
            }

        }

        fetch("Admin/PesquisarAlunos/" + nome, config)

        //fetch("Admin/PesquisarAlunos?nome="+nome, config)
            .then(function (res) {
                return res.json();

            })
            .then(function (clientes) {
                //index.listarAlunos(clientes);
                var tr = "";
                for (i = 0; clientes.length > i; i++)
                    tr = tr + "<tr><td><input type='checkbox'/></td><td>" + clientes[i].nome + "</td><td>" + clientes[i].cpf + "</td><td>" + clientes[i].usuario + "</td><td>" + clientes[i].senha + "</td></tr>";

                document.getElementById("tbody_tabela").innerHTML = tr;

            })
            .catch(function () {
                alert("Sua requisição não pode ser atendida.");

            });
    },

    listarAlunos: function (clientes) {
        var tr = "";
        for (i = 0; clientes.length > i; i++)
            tr = tr + "<tr><td><input type='checkbox'/></td><td>" + clientes[i].nome + "</td><td>" + clientes[i].cpf + "</td><td>" + clientes[i].usuario + "</td><td>" + clientes[i].senha + "</td></tr>";

        document.getElementById("tbody_tabela").innerHTML = tr;
    },

    selecao: function () {
        var checkMestre = document.getElementById("checkMestre");
        var listCheckBox = document.getElementsByClassName("checkAluno");

        for (i = 0; i < listCheckBox.length; i++) {
            listCheckBox[i].checked = checkMestre.checked;

        }

        /*if ($(this).prop("checked") == true)
            alert("Marcar");

        else
            alert("Desmarcar");*/
    },



}

index.init();