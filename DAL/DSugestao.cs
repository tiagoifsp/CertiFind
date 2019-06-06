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
                    
                    try
                    {
                        command.ExecuteNonQuery();
                    }
                    catch
                    {

                    }
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

                    try
                    {
                        command.ExecuteNonQuery();
                    }
                    catch
                    {

                    }
                    Conexao.Fechar();
                }
            }
        }

        public static List<MSugestao> Pesquisar(int tipo, bool opcao, string date)
        {
            List<MSugestao> retorno = null;

            if (Conexao.Abrir())
            {
                SqlCommand command;
                if(opcao == true)
                {
                    command = new SqlCommand
                    {
                        Connection = Conexao.Connection,
                        CommandText =
                    "select ID, FKTipoSugestaoID, DataEnvio, FKUsuarioID from TBSugestao where FKTipoSugestaoID = @tipo and DataEnvio >= @data"
                    };
                }
                else
                {
                    command = new SqlCommand
                    {
                        Connection = Conexao.Connection,
                        CommandText =
                    "select ID, FKTipoSugestaoID, DataEnvio, FKUsuarioID from TBSugestao where FKTipoSugestaoID = @tipo and DataEnvio <= @data"
                    };
                }
                

                SqlParameter parameter;
                SqlDataReader reader = null;
                parameter = new SqlParameter("@tipo", SqlDbType.Int);
                parameter.Value = tipo;
                command.Parameters.Add(parameter);

                parameter = new SqlParameter("@data", SqlDbType.DateTime);
                parameter.Value = date;
                command.Parameters.Add(parameter);

                try
                {
                    reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        if (retorno == null)
                            retorno = new List<MSugestao>();

                        MSugestao sugestao = new MSugestao();

                        sugestao.ID = (int)reader["ID"];
                        sugestao.FKTipoSugestaoID = (int)reader["FKTipoSugestaoID"];
                        sugestao.DataEnvio = (DateTime)reader["DataEnvio"];
                        try
                        {
                            sugestao.FKUsuarioID = (int)reader["FKUsuarioID"];
                        }
                        catch { }

                        retorno.Add(sugestao);
                    }
                }
                finally
                {
                    if (reader != null)
                        reader.Close();

                    Conexao.Fechar();
                }
            }

            return retorno;
        }

        public static List<MSugestao> Pesquisar(int tipo, String datainicial, String datafinal)
        {
            List<MSugestao> retorno = null;

            if (Conexao.Abrir())
            {
                SqlCommand command;
                SqlParameter parameter;
                SqlDataReader reader = null;

                command = new SqlCommand
                {
                    Connection = Conexao.Connection,
                    CommandText =
                    "select ID, FKTipoSugestaoID, DataEnvio, FKUsuarioID from TBSugestao where (FKTipoSugestaoID = @tipo) and (DataEnvio < @datafinal) and (DataEnvio > @datainicial)"
                };

                parameter = new SqlParameter("@tipo", SqlDbType.Int);
                parameter.Value = tipo;
                command.Parameters.Add(parameter);

                parameter = new SqlParameter("@datafinal", SqlDbType.DateTime);
                parameter.Value = datafinal;
                command.Parameters.Add(parameter);

                parameter = new SqlParameter("@datainicial", SqlDbType.DateTime);
                parameter.Value = datainicial;
                command.Parameters.Add(parameter);

                try
                {
                    reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        if (retorno == null)
                            retorno = new List<MSugestao>();

                        MSugestao sugestao = new MSugestao();

                        sugestao.ID = (int)reader["ID"];
                        sugestao.FKTipoSugestaoID = (int)reader["FKTipoSugestaoID"];
                        sugestao.DataEnvio = (DateTime)reader["DataEnvio"];
                        try
                        {
                            sugestao.FKUsuarioID = (int)reader["FKUsuarioID"];
                        }
                        catch { }

                        retorno.Add(sugestao);
                    }
                }
                finally
                {
                    if (reader != null)
                        reader.Close();

                    Conexao.Fechar();
                }
            }

            return retorno;
        }

        public static List<MSugestao> Pesquisar(int tipo)
        {
            List<MSugestao> retorno = null;

            if (Conexao.Abrir())
            {
                SqlCommand command = new SqlCommand
                {
                    Connection = Conexao.Connection,
                    CommandText =
                    "select ID, FKTipoSugestaoID, DataEnvio, FKUsuarioID from TBSugestao where FKTipoSugestaoID = @tipo"
                };                    

                SqlParameter parameter;

                parameter = new SqlParameter("@tipo", SqlDbType.Int);
                parameter.Value = tipo;
                command.Parameters.Add(parameter);

                SqlDataReader reader = null;

                try
                {
                    reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        if (retorno == null)
                            retorno = new List<MSugestao>();

                        MSugestao sugestao = new MSugestao();

                        sugestao.ID = (int)reader["ID"];
                        sugestao.FKTipoSugestaoID = (int)reader["FKTipoSugestaoID"];
                        sugestao.DataEnvio = (DateTime)reader["DataEnvio"];
                        try
                        {
                            sugestao.FKUsuarioID = (int)reader["FKUsuarioID"];
                        }
                        catch { }

                        retorno.Add(sugestao);
                    }

                }
                finally
                {
                    if(reader != null)
                        reader.Close();

                    Conexao.Fechar();
                }
            }

            return retorno;
        }

        public static string Obter(int id)
        {
            string retorno = "";

            if (Conexao.Abrir())
            {
                SqlCommand command = new SqlCommand
                {
                    Connection = Conexao.Connection,
                    CommandText =
                    "select Texto from TBSugestao where ID = @id"
                };

                SqlParameter param = new SqlParameter("@id", SqlDbType.Int);
                param.Value = id;
                command.Parameters.Add(param);

                SqlDataReader reader = null;

                try
                {
                    reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        retorno = reader["Texto"].ToString();
                    }
                }
                finally
                {
                    if (reader != null)
                        reader.Close();

                    Conexao.Fechar();
                }
            }

            return retorno;
        }
    }
}
