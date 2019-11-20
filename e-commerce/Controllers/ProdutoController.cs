using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using e_commerce.Models;
using Microsoft.AspNetCore.Mvc;

namespace e_commerce.Controllers
{
    public class ProdutoController : Controller
    {
        public IActionResult AdcProduto()
        {
            return View();
        }
        public JsonResult ObterCategorias()
        {
            //System.Threading.Thread.Sleep(5000);

            CamadaNegocio.CategoriaBL cbl = new CamadaNegocio.CategoriaBL();
            return Json(cbl.ObterTodos());
        }

        public JsonResult ObterProdutos()
        {
            /*List<Produto> list = new List<Produto>();
            list.Add(new Produto(0, "Produto1", 10, null));
            list.Add(new Produto(1, "Produto2", 16, null));
            list.Add(new Produto(2, "Produto3", 7, null));

            return Json(list);*/

            CamadaNegocio.ProdutoBL pbl = new CamadaNegocio.ProdutoBL();
            return Json(pbl.ObterTodos());
        }

        public IActionResult CatalogoProduto()
        {
            //System.Threading.Thread.Sleep(5000);

            return View();
        }

        public JsonResult Salvar([FromBody] Newtonsoft.Json.Linq.JObject dados)
        {

            /*
            Models.Produto p = new Models.Produto();
            p.Id = dados.Value<int>("id");
            p.Nome = dados.Value<string>("nome");
            p.Preco = dados.Value<decimal>("preco");

            p.Categorias = dados["categorias"].ToObject<List<Models.Categoria>>();
            */

            Models.Produto p = dados.ToObject<Models.Produto>();

            CamadaNegocio.ProdutoBL pbl = new CamadaNegocio.ProdutoBL();
            bool operacao = pbl.Salvar(p);


            return Json(new
            {
                operacao,
                produto = p
            }); 

        }

        public JsonResult SalvarImagem()
        {
            if (Request.Form.Files.Count > 0)
            {

                var arq = Request.Form.Files[0];
                int idProduto = Convert.ToInt32(Request.Form["idProduto"]);

                MemoryStream ms = new MemoryStream();
                arq.CopyTo(ms);

                byte[] imagem = ms.ToArray();

                CamadaNegocio.ProdutoBL pbl = new CamadaNegocio.ProdutoBL();
                bool operacao = pbl.SalvarImagem(idProduto, imagem);
            }

            return Json("ppp");

        }

    }
}