var index = {
    init: function () {
        
        document.getElementById("btnCadastrar").onclick = index.cadastrarUsuario;
       

        //document.getElementById("checkMestre").addEventListener("change", index.selecao);

    },

    cadastrarUsuario: function () {

        var dados = {
            nome: document.getElementById("inpNome").value,
            cpf: document.getElementById("inpCPF").value,
            usuario: document.getElementById("inpUsuario").value,
            senha: document.getElementById("inpSenha").value
        }
        


        var config = {
            method: "POST",
            headers: {
                "Content-Type": "application/json; charset=utf-8"
            },
            body: JSON.stringify(dados)
        }

        fetch("../Usuario/CadastrarUsuario", config)
            .then(function (res) {
                return res.json();

            })
            .then(function (res) {
                if (res.operacao == true)
                    alert("Cadastro Efetuado");
                else
                    alert(res.msg);

            })
            .catch(function () {
                alert("Sua requisição não pode ser atendida.");

            });
    },

    carregarAluno: function () {
        var config = {
            method: "GET",
            headers: {
                "Content-type": "application/json; charset=utf-8"
            }

        }
        fetch("Aluno/CarregarAlunos", config)
            .then(function (res) {
                return res.json();

            })
            .then(function (res) {
                index.listarAlunos(res);

            })
            .catch(function () {
                alert("Sua requisição não pode ser atendida.");

            });
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