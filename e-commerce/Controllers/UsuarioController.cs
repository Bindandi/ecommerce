using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using e_commerce.CamadaNegocio;
using e_commerce.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace e_commerce.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: /<controller>/
        public IActionResult Cadastrar()
        {
            return View();
        }

        public JsonResult CadastrarUsuario([FromBody]Dictionary<string,string> usuario)
        {
            ClienteBL clienteBL = new ClienteBL();
            Boolean val = clienteBL.Gravar(new Cliente(usuario["nome"], usuario["cpf"], usuario["usuario"], usuario["senha"]));

            if (val)
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
                    msg = "Esse nome de usuario já existe!"
                }); 
            }

        
        } 
    }
}
