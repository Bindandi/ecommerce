using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace e_commerce.DAL
{

    public class CategoriaDAL
    {
        MySQLPersistencia _bd = new MySQLPersistencia();


        public List<Models.Categoria> ObterTodos()
        {
            List<Models.Categoria> lista = new List<Models.Categoria>();

            string select = @"select * 
                              from categoria";

            DataTable dt = _bd.ObterDados(select);

            foreach (DataRow row in dt.Rows)
            {
                Models.Categoria c = new Models.Categoria();
                c.Id = (int)row["id"];
                c.Nome = row["nome"].ToString();

                lista.Add(c);
            }

            return lista;

        }
    }
}
