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
    public static class DTipoSugestao
    {
        public static List<MTipoSugestao> BuscarTipo()
        {
            List<MTipoSugestao> LTipo = null;

            if (Conexao.Abrir())
            {
                SqlCommand command = new SqlCommand
                {
                    Connection = Conexao.Connection,
                    CommandText =
                    "SELECT ID, Nome, Descricao FROM TBTipoSugestao"
                };

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (LTipo == null)
                        LTipo = new List<MTipoSugestao>();

                    MTipoSugestao tipoSugestao = new MTipoSugestao();
                    tipoSugestao.ID = (int)reader["ID"];
                    tipoSugestao.Nome = reader["Nome"].ToString();
                    tipoSugestao.Descricao = reader["Descricao"].ToString();

                    LTipo.Add(tipoSugestao);
                }

                reader.Close();
                Conexao.Fechar();

            }

            return LTipo;
        }

        public static List<MSugestao> Pesquisar()
        {
            List<MSugestao> retorno = null;

            if (Conexao.Abrir())
            {
                SqlCommand command = new SqlCommand
                {
                    Connection = Conexao.Connection,
                    CommandText =
                    "select s.ID, s.DataEnvio from TBSugestao s join TBTipoSugestao t on s.FKTipoSugestaoID = t.ID"
                };

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if (retorno == null)
                        retorno = new List<MSugestao>();

                    MSugestao sugestao = new MSugestao();

                    sugestao.ID = (int)reader["ID"];
                    sugestao.DataEnvio = (DateTime)reader["DataEnvio"];

                    retorno.Add(sugestao);
                }

                reader.Close();
                Conexao.Fechar();
            }

            return retorno;
        }

        public static MSugestao Obter(MSugestao item)
        {
            MSugestao retorno = null;

            if (Conexao.Abrir())
            {
                SqlCommand command = new SqlCommand
                {
                    Connection = Conexao.Connection,
                    CommandText =
                    "select s.Texto from TBSugestao s where s.ID = @id"
                };

                SqlParameter param = new SqlParameter("@id", SqlDbType.Int);
                param.Value = item.ID;
                command.Parameters.Add(param);

                SqlDataReader reader = command.ExecuteReader();


                if (reader.Read())
                {
                    retorno = new MSugestao();

                    retorno.ID = (int)reader["ID"];
                    retorno.DataEnvio = (DateTime)reader["DataEnvio"];
                    retorno.Texto = reader["Texto"].ToString();
                }

                reader.Close();
                Conexao.Fechar();
            }

            return retorno;
        }
    }
}
