var index = {

    categorias: [],


    init: function () {

        index.obterCategorias();
        document.getElementById("btnAdicionarCategoria").onclick = index.adicionarCategoria;

        document.getElementById("btnSalvar").onclick = index.salvar;

    },

    obterCategorias: function () {

        var categorias = document.getElementById("categorias");
        categorias.classList.add("fakeDisabled");
        categorias.innerHTML = "<option>carregando...</option>";

        var config = {
            method: "GET",
            headers: {
                "Content-Type": "application/json; charset=utf-8"
            }
        }

        fetch("ObterCategorias", config)
            .then(function (resposta) {
                return resposta.json();
            })
            .then(function (obj) {

                var categorias = document.getElementById("categorias");
                var aux = "<option value=\"-1\">selecione</option>";
                obj.forEach(function (c, index) {

                    var opt = "<option value=\"{0}\">{1}</option>";
                    opt = opt.replace("{0}", c.id);
                    opt = opt.replace("{1}", c.nome);

                    aux += opt;
                });

                categorias.innerHTML = aux;
                categorias.classList.remove("fakeDisabled");


            })
            .catch(function () {
                categorias.remove("fakeDisabled");
                categorias.classList.innerHTML = "";
                alert("Sua requisição não pode ser atendida.");
            });

    },

    verificaCategoria: function (idCategoria) {
        var existe = false;

        let pos = index.categorias.findIndex((c) => {
            if (c.id == idCategoria)
                existe = true;
            
        });
        return existe;
    },

    adicionarCategoria: function () {

        var categorias = document.getElementById("categorias");

        if (categorias.value == "-1")
            return;

        var existe = index.verificaCategoria(categorias.value);
        if (!existe) {
            var aux = {
                id: categorias.value,
                nome: categorias.options[categorias.selectedIndex].innerHTML
            }

            index.categorias.push(aux);

            index.montarChipCategoria();
        }

    },

    montarChipCategoria: function () {

        var divChipCategoria = document.getElementById("divChipCategoria");
        divChipCategoria.innerHTML = "";

        /*index.categorias.forEach(function (c, index) {
        });*/

        var aux = "";
        index.categorias.forEach((c, index) => {

            //<div class="d-flex justify-content-between">...</div>
            aux += "<div class=\"card-categoria d-flex justify-content-between\"><a>" +
                c.nome +
                "</a><input type=\"button\" class=\"excluir btn btnHeader\" value=\"Remover\" onclick=\"index.excluirCategoria(" + c.id + ")\" ></a>" +
                "</div> ";
        });

        divChipCategoria.innerHTML = aux;

    },

    excluirCategoria: function (idCategoria) {

        let pos = index.categorias.findIndex((c) => {
            return c.id == idCategoria;
        });

        index.categorias.splice(pos, 1);

        index.montarChipCategoria();

    },

    salvar: function () {

        if (index.categorias.length == 0) {

            alert("Selecione um categoria.");
            return;
        }
        var dados = {
            id: document.getElementById("id").value,
            nome: document.getElementById("nome").value,
            preco: document.getElementById("preco").value,
            categorias: index.categorias
        }

        var config = {
            method: "POST",
            headers: {
                "Accept": "application/json",
                "Content-Type": "application/json; charset=utf-8"
            },
            body: JSON.stringify(dados)
        }

        fetch("/Produto/Salvar", config)
            .then(function (resposta) {
                return resposta.json();
            })
            .then(function (obj) {

                if (obj.operacao) {
                    index.enviarImagem(obj.produto.id);
                }
                else {
                    alert("Não salvou...");
                }
            })
            .catch(function () {

                alert("Sua requisição não pode ser atendida.");
            });

    },

    enviarImagem: function (id) {

        var formData = new FormData();
        formData.append("imagem", document.getElementById("imagem").files[0]);
        formData.append("idProduto", id);

        var config = {
            method: "POST",
            headers: {
                "Accept": "application/json"
            },
            body: formData
        }

        fetch("/Produto/SalvarImagem", config)
            .then(function (resposta) {
                return resposta.json();
            })
            .then(function (obj) {
                //????????

            })
            .catch(function () {

                alert("Sua requisição não pode ser atendida.");
            });


    },

}

index.init();
