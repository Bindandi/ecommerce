using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace e_commerce.DAL
{
    public class ClienteDAL
    {
        MySQLPersistencia _bd = new MySQLPersistencia();

        public bool Gravar(Models.Cliente cliente)
        {
            string sql = @"insert into cliente (nome, cpf, usuario, senha)
                            values(@nome, @cpf, @usuario, @senha)";


            Dictionary<string, object> ps = new Dictionary<string, object>();
            ps.Add("@nome", cliente.Nome);
            ps.Add("@cpf", cliente.Cpf);
            ps.Add("@usuario", cliente.Usuario);
            ps.Add("@senha", cliente.Senha);

            if (_bd.Executar(sql, ps) > 0)
            {
                cliente.Id = (int)_bd.UltimoId;
                return true;
            }

            return false;

        }

        public Models.Cliente Obter(int id)
        {
            Models.Cliente cliente = null;

            string select = @"select * 
                              from cliente
                              where id = " + id;

            DataTable dt = _bd.ObterDados(select);

            if (dt.Rows.Count == 1)
            {
                cliente = new Models.Cliente();
                cliente.Id = (int)dt.Rows[0]["id"];
                cliente.Nome = dt.Rows[0]["nome"].ToString(); ;
                cliente.Senha = dt.Rows[0]["senha"].ToString(); ;
                cliente.Cpf = dt.Rows[0]["cpf"].ToString(); ;
                cliente.Usuario = dt.Rows[0]["usuario"].ToString(); ;
            }

            return cliente;



        }

        public List<Models.Cliente> findByNome(String nome)
        {
            Models.Cliente cliente = null;
            List<Models.Cliente> clientes = new List<Models.Cliente>();

            string select = @"select * 
                              from cliente
                              where nome like '%"+nome+"%'";

            DataTable dt = _bd.ObterDados(select);


            /*if (dt.Rows.Count == 1)
            {
                cliente = new Models.Cliente();
                cliente.Id = (int)dt.Rows[0]["id"];
                cliente.Nome = dt.Rows[0]["nome"].ToString(); ;
                cliente.Senha = dt.Rows[0]["senha"].ToString(); ;
                cliente.Cpf = dt.Rows[0]["cpf"].ToString(); ;
                cliente.Usuario = dt.Rows[0]["usuario"].ToString(); ;
            }

            return cliente;*/
            int i = 0;
            while(dt.Rows.Count > i)
            {
                cliente = new Models.Cliente();
                cliente.Id = (int)dt.Rows[i]["id"];
                cliente.Nome = dt.Rows[i]["nome"].ToString(); ;
                cliente.Senha = dt.Rows[i]["senha"].ToString(); ;
                cliente.Cpf = dt.Rows[i]["cpf"].ToString(); ;
                cliente.Usuario = dt.Rows[i]["usuario"].ToString();
                i++;
                clientes.Add(cliente);
            }
            return clientes;



        }

        public bool ValidarUsuario(string usuario)
        {
            string select = @"select count(*) as conta
                              from cliente 
                               where usuario = @usuario";

            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("@usuario", usuario);
            
            DataTable dt = _bd.ObterDados(select, parametros);

            if (Convert.ToInt32(dt.Rows[0]["conta"]) == 0)
            {
                return false;
            }
            else return true;
        }

        public bool ValidarUsuario(string usuario, string senha)
        {
            string select = @"select count(*) as conta
                              from cliente 
                               where usuario = @usuario and
                                     senha = @senha";

            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("@usuario", usuario);
            parametros.Add("@senha", senha);
            DataTable dt = _bd.ObterDados(select, parametros);

            if (Convert.ToInt32(dt.Rows[0]["conta"]) == 0)
            {
                return false;
            }
            else return true;
        }


    }
}
