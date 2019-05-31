using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;

namespace DAL
{
    public static class DSugestao
    {
        public static void EnviarSugestao(MSugestao sugestao)
        {
            if(sugestao.FKUsuarioID == null)
            {
                if (Conexao.Abrir())
                {
                    SqlCommand command = new SqlCommand
                    {
                        Connection = Conexao.Connection,
                        CommandText = "INSERT into TBSugestao(FKTipoSugestaoID, Texto, DataEnvio) VALUES(@FKTipoSugestaoID, @Texto, @DataEnvio)"
                    };
                    SqlParameter parameter;

                    parameter = new SqlParameter("@FKTipoSugestaoID", SqlDbType.Int);
                    parameter.Value = sugestao.FKTipoSugestaoID;
                    command.Parameters.Add(parameter);

                    parameter = new SqlParameter("@Texto", SqlDbType.Text);
                    parameter.Value = sugestao.Texto;
                    command.Parameters.Add(parameter);

                    parameter = new SqlParameter("@DataEnvio", SqlDbType.DateTime);
                    parameter.Value = sugestao.DataEnvio;
                    command.Parameters.Add(parameter);

                    command.ExecuteNonQuery();
                    Conexao.Fechar();
                }
            }
            else
            {
                if (Conexao.Abrir())
                {
                    SqlCommand command = new SqlCommand
                    {
                        Connection = Conexao.Connection,
                        CommandText = "INSERT into TBSugestao(FKTipoSugestaoID, Texto, DataEnvio, FKUsuarioID) VALUES(@FKTipoSugestaoID, @Texto, @DataEnvio, @FKUsuarioID)"
                    };
                    SqlParameter parameter;

                    parameter = new SqlParameter("@FKTipoSugestaoID", SqlDbType.Int);
                    parameter.Value = sugestao.FKTipoSugestaoID;
                    command.Parameters.Add(parameter);

                    parameter = new SqlParameter("@Texto", SqlDbType.Text);
                    parameter.Value = sugestao.Texto;
                    command.Parameters.Add(parameter);

                    parameter = new SqlParameter("@DataEnvio", SqlDbType.DateTime);
                    parameter.Value = sugestao.DataEnvio;
                    command.Parameters.Add(parameter);

                    parameter = new SqlParameter("@FKUsuarioID", SqlDbType.Int);
                    parameter.Value = sugestao.FKUsuarioID;
                    command.Parameters.Add(parameter);

                    command.ExecuteNonQuery();
                    Conexao.Fechar();
                }
            }
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
                    "select s.ID, t.ID [TipoID], s.DataEnvio, s.FKTipoSugestaoID,  u.ID [FKUsuarioID] from TBSugestao s join TBTipoSugestao t on (t.ID = s.FKTipoSugestaoID) join TBUsuario u on (u.ID = s.FKUsuarioID)"
                };
                
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if (retorno == null)
                        retorno = new List<MSugestao>();

                    MSugestao sugestao = new MSugestao();

                    sugestao.ID = (int)reader["ID"];
                    sugestao.FKTipoSugestaoID = (int)reader["FKTipoSugestaoID"];
                    sugestao.DataEnvio = (DateTime)reader["DataEnvio"];
                    sugestao.FKUsuarioID = (int)reader["FKUsuarioID"];

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
