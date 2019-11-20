var index = {

    categorias: [],


    init: function () {

        index.obterProdutos();
        document.getElementById("btnAdicionarCategoria").onclick = index.adicionarCategoria;

        document.getElementById("btnSalvar").onclick = index.salvar;

    },

    obterProdutos: function () {

        

        var config = {
            method: "GET",
            headers: {
                "Content-Type": "application/json; charset=utf-8"
            }
        }

        fetch("ObterProdutos", config)
            .then(function (resposta) {
                return resposta.json();
            })
            .then(function (obj) {
                var produtos = document.getElementById("produtos");


               
                   
                    
                

                var aux = "<div class=\"d-flex flex-column bd-highlight mb-3\">";
                obj.forEach(function (c, index) {

                    //var path;

                    var opt = "<div style=\"width: 500px; margin-top:10px; background-color: #e8e8e8\">" +
                        "<div style=\"width: 500px; height: 200px;\" class=\"d-flex bd-highlight\">" +
                        "<div class=\"p-2 flex-shrink-1 bd-highlight\">" +
                        "<img style=\"height:100%; width:200px\" src=\"{2}\"/>" +
                        "</div>" +
                        "<div class=\"p-2 w-100 bd-highlight\">" +
                        "<div style=\"height:50%;\">" +
                        "<a>{0}</a>" +
                        "</div>" +
                        "<div style=\"height:50%;\">" +
                        "<a>{1}</a>" +
                        "</div>" +
                        "</div>"+
                        "</div>"+
                        "</div >";
                    opt = opt.replace("{0}", c.nome);
                    opt = opt.replace("{1}", "Preço: R$ " + c.preco);
                    if(c.imagem == null)
                        opt = opt.replace("{2}","../images/sem_imagem.jpg");
                    else
                        opt = opt.replace("{2}", "data:image/png;base64,"+c.imagem);
                    aux += opt;
                });
                aux = aux + "</div>";

                produtos.innerHTML = aux;
                
            })
            .catch(function () {
               alert("Sua requisição não pode ser atendida.");
            });

    }


}

index.init();
