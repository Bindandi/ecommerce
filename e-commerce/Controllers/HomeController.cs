using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using e_commerce.Models;
using e_commerce.CamadaNegocio;

namespace e_commerce.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public JsonResult Logar([FromBody]Dictionary<string,string> usuario)
        {
            ClienteBL clienteBL = new ClienteBL();
            Boolean val = clienteBL.ValidarUsuario(usuario["usuario"], usuario["senha"]);
            

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
