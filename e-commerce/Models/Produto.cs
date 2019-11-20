using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_commerce.Models
{
    public class Produto
    {
        int _id;
        string _nome;
        decimal _preco;
        byte[] _imagem;

        List<Categoria> _categorias;


        public int Id { get => _id; set => _id = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public decimal Preco { get => _preco; set => _preco = value; }

        public byte[] Imagem { get => _imagem; set => _imagem = value; }



        public List<Categoria> Categorias { get => _categorias; set => _categorias = value; }

        public Produto()
        {
            Categorias = new List<Categoria>();
        }

        public Produto(int id, String nome, decimal preco, List<Categoria> categorias)
        {
            this.Id = id;
            Nome = nome;
            Preco = preco;
            Categorias = categorias;

        }

        /// <summary>
        /// Obtem todos os produtos.
        /// </summary>
        /// <returns>Uma lista de produtos.</returns>
        public List<Produto> ObterProdutos()
        {
            List<Produto> prods = new List<Produto>();

            Produto p1 = new Produto();
            p1.Id = 1;
            p1.Nome = "Produto 1";

            Produto p2 = new Produto();
            p2.Id = 2;
            p2.Nome = "Produto 2";

            Produto p3 = new Produto();
            p3.Id = 3;
            p3.Nome = "Produto 3";

            Produto p4 = new Produto();
            p4.Id = 4;
            p4.Nome = "Produto 4";


            prods.Add(p1);
            prods.Add(p2);
            prods.Add(p3);
            prods.Add(p4);

            return prods;

        }

    }



}
