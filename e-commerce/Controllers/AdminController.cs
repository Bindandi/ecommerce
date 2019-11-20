using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using e_commerce.CamadaNegocio;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace e_commerce.Controllers
{
    public class AdminController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        //GET : Admin/Login
        public IActionResult Login()
        {
            return View();
        }

        [HttpGet("Admin/PesquisarAlunos/{nome}")]
        public JsonResult PesquisarAlunos(string nome)
        {
            //String nome = Request.QueryString[0];
            List<Models.Cliente> clientes = new List<Models.Cliente>();

            ClienteBL clienteBL = new ClienteBL();
            clientes = clienteBL.findByNome(nome);

            return Json(clientes);
        }

        [HttpPost]
        public JsonResult Logar([FromBody]Dictionary<string, string> usuario)
        {
            ClienteBL clienteBL = new ClienteBL();
            Boolean val = clienteBL.validarAdm(usuario["usuario"], usuario["senha"]);

            if (!val)
            {
                //objeto anônimo
                return Json(new
                {
                    operacao = val
                });
            }
            else
            {
                return Json(new
                {
                    operacao = val,
                    msg = "Dados inválidos"
                });
            }


        }
    }
}
