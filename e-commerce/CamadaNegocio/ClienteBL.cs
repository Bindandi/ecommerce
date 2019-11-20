using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_commerce.CamadaNegocio
{
    public class ClienteBL
    {

        public bool Gravar(Models.Cliente cliente)
        {
            Boolean val = ValidarUsuario(cliente.Usuario);

            if (!val)
            {
                DAL.ClienteDAL dal = new DAL.ClienteDAL();
                bool ok = dal.Gravar(cliente);

                return ok;
            }

            return false;
            //regras de negócio

        }

        public Boolean validarAdm(String email, String senha)
        {
            if (email == "adm@gmail" && senha == "123456")
                return true;
            return false;
        }


        public Models.Cliente Obter(int id)
        {
            DAL.ClienteDAL dal = new DAL.ClienteDAL();
            return dal.Obter(id);
        }



        public bool ValidarUsuario(string usuario)
        {

            DAL.ClienteDAL dal = new DAL.ClienteDAL();
            return dal.ValidarUsuario(usuario);

        }
        public bool ValidarUsuario(string usuario, string senha)
        {

            DAL.ClienteDAL dal = new DAL.ClienteDAL();
            return dal.ValidarUsuario(usuario, senha);

        }

        
        public List<Models.Cliente> findByNome(String nome)
        {
            DAL.ClienteDAL dal = new DAL.ClienteDAL();
            return dal.findByNome(nome);

        }
    

        //public Pesquisar
    }
}
