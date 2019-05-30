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
                    parameter.Value = sugestao.FKTipoSugestaoID.ID;
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
                    parameter.Value = sugestao.FKTipoSugestaoID.ID;
                    command.Parameters.Add(parameter);

                    parameter = new SqlParameter("@Texto", SqlDbType.Text);
                    parameter.Value = sugestao.Texto;
                    command.Parameters.Add(parameter);

                    parameter = new SqlParameter("@DataEnvio", SqlDbType.DateTime);
                    parameter.Value = sugestao.DataEnvio;
                    command.Parameters.Add(parameter);

                    parameter = new SqlParameter("@FKUsuarioID", SqlDbType.Int);
                    parameter.Value = sugestao.FKUsuarioID.ID;
                    command.Parameters.Add(parameter);

                    command.ExecuteNonQuery();
                    Conexao.Fechar();
                }
            }
        }
    }
}
