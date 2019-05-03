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
            if(!Conexao.Abrir())
                throw new ExcecaoPadrao(Erros.ErroFalhaConexaoSGBD);
            
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
    }
}
