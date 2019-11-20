using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_commerce.Models
{
    public class Cliente
    {
        int _id;
        string _nome;
        string _usuario;
        string _senha;
        string _cpf;

        public Cliente()
        {

        }
        public Cliente(string nome, string cpf, string usuario, string senha)
        {
            _nome = nome;
            _cpf = cpf;
            _usuario = usuario;
            _senha = senha;
        }

        public int Id { get => _id; set => _id = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public string Usuario { get => _usuario; set => _usuario = value; }
        public string Senha { get => _senha; set => _senha = value; }
        public string Cpf { get => _cpf; set => _cpf = value; }


       
        //public void Gravar(string nomeUsuario, string senha)
        //{
        //    //Usuario u = new Usuario();
        //    //u.Nome = "andre";
        //    //string x = u.NomeUsuario;


        //}



    }
}
