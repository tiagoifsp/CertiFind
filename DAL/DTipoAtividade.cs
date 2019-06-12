using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class DTipoAtividade
    {
        //INSERIR
        public static void Inserir(MTipoAtividade item)
        {
            if (!Conexao.Abrir())
                throw new Exception();

            SqlCommand comando = new SqlCommand();
            comando.Connection = Conexao.Connection;

            comando.CommandText = "INSERT INTO TBTipoAtividade(Nome) VALUES(@Nome)";

            SqlParameter parametro = new SqlParameter("@Nome", SqlDbType.VarChar);
            parametro.Value = item.Nome;
            comando.Parameters.Add(parametro);

            try
            {
                comando.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            finally
            {
                Conexao.Fechar();
            }
        }

        //PESQUISAR
        public static List<MTipoAtividade> Pesquisar(MTipoAtividade item)
        {
            if (!Conexao.Abrir())
                throw new Exception();

            SqlCommand comando = new SqlCommand();
            comando.Connection = Conexao.Connection;

            comando.CommandText = "SELECT ID, Nome FROM TBTipoAtividade WHERE 1=1";

            if (item.Nome.Trim() != "")
            {
                comando.CommandText += " AND Nome LIKE @Nome";

                SqlParameter parametro = new SqlParameter("@Nome", SqlDbType.VarChar);
                parametro.Value = "%" + item.Nome + "%";
                comando.Parameters.Add(parametro);
            }

            comando.CommandText += " ORDER BY Nome ASC";

            SqlDataReader reader = comando.ExecuteReader();
            List<MTipoAtividade> retorno = null;

            try
            {
                while (reader.Read())
                {
                    if (retorno == null)
                        retorno = new List<MTipoAtividade>();

                    MTipoAtividade tipoAtividade = new MTipoAtividade();
                    tipoAtividade.ID = int.Parse(reader["ID"].ToString());
                    tipoAtividade.Nome = reader["Nome"].ToString();

                    retorno.Add(tipoAtividade);
                }
            }
            catch
            {
                throw;
            }
            finally
            {
                reader.Close();
                Conexao.Fechar();
            }

            return retorno;
        }

        //PESQUISAR PARA INSERIR
        public static List<MTipoAtividade> PesquisarInserir(MTipoAtividade item)
        {
            if (!Conexao.Abrir())
                throw new Exception();

            SqlCommand comando = new SqlCommand();
            comando.Connection = Conexao.Connection;

            comando.CommandText = "SELECT ID, Nome FROM TBTipoAtividade WHERE 1=1";

            if (item.Nome.Trim() != "")
            {
                comando.CommandText += " AND Nome = @Nome";

                SqlParameter parametro = new SqlParameter("@Nome", SqlDbType.VarChar);
                parametro.Value = item.Nome;
                comando.Parameters.Add(parametro);
            }

            comando.CommandText += " ORDER BY Nome ASC";

            SqlDataReader reader = comando.ExecuteReader();
            List<MTipoAtividade> retorno = null;

            try
            {
                while (reader.Read())
                {
                    if (retorno == null)
                        retorno = new List<MTipoAtividade>();

                    MTipoAtividade tipoAtividade = new MTipoAtividade();
                    tipoAtividade.ID = int.Parse(reader["ID"].ToString());
                    tipoAtividade.Nome = reader["Nome"].ToString();

                    retorno.Add(tipoAtividade);
                }
            }
            catch
            {
                throw;
            }
            finally
            {
                reader.Close();
                Conexao.Fechar();
            }

            return retorno;
        }

        //OBTER
        public static MTipoAtividade Obter(MTipoAtividade item)
        {
            if (!Conexao.Abrir())
                throw new Exception();

            SqlCommand comando = new SqlCommand();
            comando.Connection = Conexao.Connection;

            comando.CommandText = "SELECT ID, Nome FROM TBTipoAtividade WHERE ID = @ID";

            SqlParameter parametro = new SqlParameter("@ID", SqlDbType.Int);
            parametro.Value = item.ID;
            comando.Parameters.Add(parametro);

            SqlDataReader reader = comando.ExecuteReader();

            MTipoAtividade retorno = null;

            try
            {
                if (reader.Read())
                {
                    retorno = new MTipoAtividade();

                    retorno.ID = int.Parse(reader["ID"].ToString());
                    retorno.Nome = reader["Nome"].ToString();
                }
            }
            catch
            {
                throw;
            }
            finally
            {
                reader.Close();
                Conexao.Fechar();
            }

            return retorno;
        }

        //EDITAR
        public static void Editar(MTipoAtividade item)
        {
            if (!Conexao.Abrir())
                throw new Exception();

            SqlCommand comando = new SqlCommand();
            comando.Connection = Conexao.Connection;

            comando.CommandText = "UPDATE TBTipoAtividade SET Nome = @Nome WHERE ID = @ID";

            SqlParameter parametro = new SqlParameter("@ID", SqlDbType.Int);
            parametro.Value = item.ID;
            comando.Parameters.Add(parametro);

            parametro = new SqlParameter("@Nome", SqlDbType.VarChar);
            parametro.Value = item.Nome;
            comando.Parameters.Add(parametro);

            try
            {
                comando.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            finally
            {
                Conexao.Fechar();
            }
        }

        //EXCLUIR
        public static void Excluir(MTipoAtividade item)
        {
            if (!Conexao.Abrir())
                throw new Exception();

            SqlCommand comando = new SqlCommand();
            comando.Connection = Conexao.Connection;

            comando.CommandText = "DELETE FROM TBTipoAtividade WHERE ID = @ID";

            SqlParameter parametro = new SqlParameter("@ID", SqlDbType.Int);
            parametro.Value = item.ID;
            comando.Parameters.Add(parametro);

            try
            {
                comando.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            finally
            {
                Conexao.Fechar();
            }
        }


    }
}
