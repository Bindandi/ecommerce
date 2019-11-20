using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_commerce.CamadaNegocio
{
    public class CategoriaBL
    {

        public List<Models.Categoria> ObterTodos()
        {
            DAL.CategoriaDAL cal = new DAL.CategoriaDAL();
            return cal.ObterTodos();
        }
    }
}
