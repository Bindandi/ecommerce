using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace e_commerce.DAL
{
    public class ProdutoDAL
    {
        MySQLPersistencia _bd = new MySQLPersistencia();

        public bool Salvar(Models.Produto produto)
        {
            bool ok = false;
            MySQLPersistencia bd = new MySQLPersistencia(false, true);

            try
            {
                string sql = "INSERT INTO produto(nome,preco) VALUES(@nome, @preco)";
                Dictionary<string, object> ps = new Dictionary<string, object>();
                ps.Add("@nome", produto.Nome);
                ps.Add("@preco", produto.Preco);
                bd.Executar(sql, ps);

                int id = (int)bd.UltimoId;

                foreach (var cat in produto.Categorias)
                {
                    sql = "INSERT INTO produtocategoria(idProduto, idCategoria) VALUES(@idProduto, @idCategoria)";
                    Dictionary<string, object> ps2 = new Dictionary<string, object>();
                    ps2.Add("@idProduto", id);
                    ps2.Add("@idCategoria", cat.Id);
                    bd.Executar(sql, ps2);
                }

                //deu certo....

                bd.Commit();
                produto.Id = id;
                ok = true;

            }
            catch (Exception ex)
            {
                bd.Rollback();

            }
            finally
            {
                bd.Fechar();
            }


            return ok;

        }

        public List<Models.Produto> ObterTodos()
        {
            List<Models.Produto> lista = new List<Models.Produto>();

            string select = @"select * 
                              from produto";

            DataTable dt = _bd.ObterDados(select);

            foreach (DataRow row in dt.Rows)
            {
                Models.Produto c = new Models.Produto();
                c.Id = (int)row["id"];
                c.Nome = row["nome"].ToString();
                c.Preco = (decimal)row["preco"];

                if (row["imagem"] != DBNull.Value)
                    c.Imagem = (byte[])row["imagem"];

                lista.Add(c);
            }

            return lista;

        }


        public bool SalvarImagem(int idProduto, byte[] imagem)
        {
            MySQLPersistencia bd = new MySQLPersistencia();

            string sql = "update produto set imagem = @imagem where id = @id";

            Dictionary<string, object> ps = new Dictionary<string, object>();
            ps.Add("@imagem", imagem);
            ps.Add("@id", idProduto);
            int linhasAfetadas = bd.Executar(sql, ps);

            return linhasAfetadas == 1;

        }


    }
}
