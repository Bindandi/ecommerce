
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace e_commerce.DAL
{
    public class MySQLPersistencia
    {
        MySqlConnection _conexao = null;
        MySqlCommand _cmd = null;
        bool _fecharConexao = true;
        bool _comTransacao = false;
        MySqlTransaction _transacao = null;

        Int64 _ultimoId;

        public long UltimoId { get => _ultimoId; set => _ultimoId = value; }

        public MySQLPersistencia(bool fecharConexao = true, bool comTransacao = false)
        {
            string strCon = @"Server=den1.mysql6.gear.host;
                              Database=fippaulabindandi;
                              Uid=fippaulabindandi;
                              Pwd=julio1997#;";

            _conexao = new MySqlConnection(strCon);

            _cmd = _conexao.CreateCommand();

            _fecharConexao = fecharConexao;
            _comTransacao = comTransacao;

            //_cmd = new MySqlCommand();
            //_cmd.Connection = _conexao;

        }

        public void Abrir()
        {
            if (_conexao.State != System.Data.ConnectionState.Open)
            {
                _conexao.Open();

                if (_comTransacao)
                {
                    _transacao = _conexao.BeginTransaction();
                }

            }
        }

        public void Fechar()
        {
            _conexao.Close();
        }

        public void Commit()
        {

            _transacao.Commit();
            _transacao = null;
        }

        public void Rollback()
        {
            _transacao.Rollback();
            _transacao = null;
        }

        public DataTable ObterDados(string select,
            Dictionary<string, object> parametros = null)
        {
            Abrir();
            _cmd.CommandText = select;

            if (parametros != null)
            {
                _cmd.Parameters.Clear();
                foreach (var item in parametros)
                {
                    _cmd.Parameters.AddWithValue(item.Key, item.Value);
                }

            }

            DataTable dt = new DataTable();
            dt.Load(_cmd.ExecuteReader());

            if (_fecharConexao)
                Fechar();

            return dt;
        }


        public int Executar(string instrucao,
           Dictionary<string, object> parametros = null)
        {
            Abrir();
            _cmd.CommandText = instrucao;

            if (parametros != null)
            {
                _cmd.Parameters.Clear();
                foreach (var item in parametros)
                {
                    _cmd.Parameters.AddWithValue(item.Key, item.Value);
                }
            }

            //insert, delete, update...
            int linhasAfetadas = _cmd.ExecuteNonQuery();

            _ultimoId = _cmd.LastInsertedId;

            if (_fecharConexao)
                Fechar();

            return linhasAfetadas;
        }

    }
}
