using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_commerce.CamadaNegocio
{
    public class ProdutoBL
    {


        public List<Models.Produto> ObterTodos()
        {
            DAL.ProdutoDAL cal = new DAL.ProdutoDAL();
            return cal.ObterTodos();
        }
        public bool Salvar(Models.Produto produto)
        {

            //regras de negócio

            DAL.ProdutoDAL dal = new DAL.ProdutoDAL();
            bool ok = dal.Salvar(produto);

            return ok;
        }


        public Models.Cliente Obter(int id)
        {
            DAL.ClienteDAL dal = new DAL.ClienteDAL();
            return dal.Obter(id);
        }


        public bool SalvarImagem(int idProduto, byte[] imagem)
        {
            DAL.ProdutoDAL dal = new DAL.ProdutoDAL();

            bool ok = dal.SalvarImagem(idProduto, imagem);
            return ok;
        }

        //public Pesquisar
    }
}
