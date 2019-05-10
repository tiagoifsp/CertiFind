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
        public static void Inserir(MTipoDado item)
        {
            if (!Conexao.Abrir())
                throw new Exception(); //Revisar

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

        public static List<MTipoDado> Pesquisar(MTipoDado item)
        {
            if (!Conexao.Abrir())
                throw new Exception();

            SqlCommand comando = new SqlCommand();
            comando.Connection = Conexao.Connection;

            comando.CommandText = "SELECT Nome FROM TBTipoDados WHERE 1=1";

            if (item.Nome.Trim() != "")
            {
                comando.CommandText += " AND Nome LIKE @Nome ";

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
    }
}
