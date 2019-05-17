using Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class DTipoDado
    {
        //INSERIR
        public static void Inserir(MTipoDado item)
        {
            if (!Conexao.Abrir())
                throw new Exception(); 

            SqlCommand comando = new SqlCommand();
            comando.Connection = Conexao.Connection;

            comando.CommandText = "INSERT INTO TBTipoDados(Nome, Descricao)" + " " + "VALUES(@Nome, @Descricao)";

            SqlParameter parametro = new SqlParameter("@Nome", SqlDbType.VarChar);
            parametro.Value = item.Nome;
            comando.Parameters.Add(parametro);

            parametro = new SqlParameter("@Descricao", SqlDbType.VarChar);
            parametro.Value = item.Descricao;
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
        public static List<MTipoDado> Pesquisar(MTipoDado item)
        {
            if (!Conexao.Abrir())
                throw new Exception();

            SqlCommand comando = new SqlCommand();
            comando.Connection = Conexao.Connection;

            comando.CommandText = "SELECT ID, Nome FROM TBTipoDados WHERE 1=1";

            if (item.Nome.Trim() != "")
            {
                comando.CommandText += " AND Nome LIKE @Nome ORDER BY Nome ASC";

                SqlParameter parametro = new SqlParameter("@Nome", SqlDbType.VarChar);
                parametro.Value = "%" + item.Nome + "%";
                comando.Parameters.Add(parametro);
            }

            SqlDataReader reader = comando.ExecuteReader();
            List<MTipoDado> retorno = null;

            try
            {
                while (reader.Read())
                {
                    if (retorno == null)
                        retorno = new List<MTipoDado>();

                    MTipoDado tipoDado = new MTipoDado();
                    tipoDado.ID = int.Parse(reader["ID"].ToString());
                    tipoDado.Nome = reader["Nome"].ToString();

                    retorno.Add(tipoDado);
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
        public static MTipoDado Obter(MTipoDado item)
        {
            if (!Conexao.Abrir())
                throw new Exception();

            SqlCommand comando = new SqlCommand();
            comando.Connection = Conexao.Connection;

            comando.CommandText = "SELECT ID, Nome, Descricao FROM TBTipoDados WHERE ID = @ID";

            SqlParameter parametro = new SqlParameter("@ID", SqlDbType.Int);
            parametro.Value = item.ID;
            comando.Parameters.Add(parametro);

            SqlDataReader reader = comando.ExecuteReader();

            MTipoDado retorno = null;

            try
            {
                if (reader.Read())
                {
                    retorno = new MTipoDado();

                    retorno.ID = int.Parse(reader["ID"].ToString());
                    retorno.Nome = reader["Nome"].ToString();
                    retorno.Descricao = reader["Descricao"].ToString();
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
        public static void Editar(MTipoDado item)
        {
            if (!Conexao.Abrir())
                throw new Exception();

            SqlCommand comando = new SqlCommand();
            comando.Connection = Conexao.Connection;

            comando.CommandText = "UPDATE TBTipoDados SET Nome = @Nome, Descricao = @Descricao WHERE ID = @ID";

            SqlParameter parametro = new SqlParameter("@ID", SqlDbType.Int);
            parametro.Value = item.ID;
            comando.Parameters.Add(parametro);

            parametro = new SqlParameter("@Nome", SqlDbType.VarChar);
            parametro.Value = item.Nome;
            comando.Parameters.Add(parametro);

            parametro = new SqlParameter("@Descricao", SqlDbType.VarChar);
            parametro.Value = item.Descricao;
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
        public static void Excluir(MTipoDado item)
        {
            if (!Conexao.Abrir())
                throw new Exception();

            SqlCommand comando = new SqlCommand();
            comando.Connection = Conexao.Connection;

            comando.CommandText = "DELETE FROM TBTipoDados where ID = @ID";

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
