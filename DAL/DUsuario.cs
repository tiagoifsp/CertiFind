using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Model;

namespace DAL
{
    public static class DUsuario
    {

        public static MUsuario Login(MUsuario u)
        {
            if(u == null)
            {
                throw new ArgumentNullException(Erros.ErroGeral);
            }

            MUsuario retorno = null;
            try { 
            Conexao.Abrir();
            
                SqlCommand command = new SqlCommand
                {
                    Connection = Conexao.Connection,
                    CommandText = "" +
                    "SELECT " +
                    "ID, EMAIL, SENHA " +
                    "FROM " +
                    "TBUSUARIO " +
                    "WHERE EMAIL = @EMAIL AND SITUACAO = 'A' "
                };

                SqlParameter param = new SqlParameter("@EMAIL", SqlDbType.VarChar)
                { Value = u.Email };
                command.Parameters.Add(param);

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    if (u.Senha == (reader["SENHA"].ToString()))
                    {
                        retorno = new MUsuario
                        {
                            ID = (int)reader["ID"]
                        };
                    }
                }

                reader.Close();
             
            }
            catch
            {
                Conexao.Fechar();
            }

            return retorno;
        }

        public static MUsuario Obter(MUsuario u)
        {
            if (u == null)
            {
                throw new ArgumentNullException(Erros.ErroGeral);
            }

            MUsuario retorno = null;

            try
            { 
            Conexao.Abrir();
            
                SqlCommand command = new SqlCommand
                {
                    Connection = Conexao.Connection,
                    CommandText = "SELECT ID, NOME, EMAIL, SITUACAO, FKTipoUsuarioID FROM TBUSUARIO WHERE ID = @ID "
                };

                SqlParameter param = new SqlParameter("@ID", SqlDbType.Int)
                { Value = u.ID };
                command.Parameters.Add(param);

                SqlDataReader reader = command.ExecuteReader();
                try
                {
                    reader.Read();

                    retorno = new MUsuario
                    {
                        ID = (int)reader["ID"],
                        Nome = reader["Nome"].ToString(),
                        Situacao = reader["SITUACAO"].ToString(),
                        Email = reader["EMAIL"].ToString(),
                        FKTipoUsuarioID = (int)reader["FKTipoUsuarioID"]
                    };
                }
                catch
                {
                    reader.Close();
                }
            }
            catch
            {
                
                Conexao.Fechar();
            }

            return retorno;
        }

        public static List<MUsuario> Pesquisar(MUsuario u)
        {
            List<MUsuario> usuarios = null;
            try { 
            Conexao.Abrir();
            
                SqlCommand comando = new SqlCommand
                {
                    CommandText = "SELECT ID, NOME, EMAIL, SITUACAO, FKTipoUsuarioID FROM TBUsuario  ",
                    Connection = Conexao.Connection
                };

                //if(0 != u.ID)
                //{
                //    comando.CommandText += "AND ID LIKE %@ID% ";
                //    SqlParameter param = new SqlParameter("@ID", SqlDbType.Int) { Value = u.ID };
                //    comando.Parameters.Add(param);
                //}

                if (u.Nome !="")
                {
                    comando.CommandText += "AND NOME LIKE  @NOME ";
                    SqlParameter param = new SqlParameter("@NOME", SqlDbType.VarChar) { Value = u.Nome };
                    param.Value = u.Nome;
                    comando.Parameters.Add(param);

                }

                if (u.Situacao != "")
                {
                    comando.CommandText += "AND SITUACAO = @SITUACAO ";
                    SqlParameter param = new SqlParameter("@SITUACAO", SqlDbType.Char) { Value = u.Situacao };
                    param.Value = u.Situacao;
                    comando.Parameters.Add(param);
                 
                }

                SqlDataReader reader = comando.ExecuteReader();


                while (reader.Read())
                {
                    if (usuarios == null)
                        usuarios = new List<MUsuario>();

                  MUsuario  usuario = new MUsuario
                    {
                        ID = (int)reader["ID"],
                        Nome = reader["NOME"].ToString(),
                        Situacao = reader["SITUACAO"].ToString(),
                        Email = reader["EMAIL"].ToString(),
                        FKTipoUsuarioID = (int)reader["FKTipoUsuarioID"]
                    };

                    usuarios.Add(usuario);
                }
                reader.Close();
            }
            catch
            {
                Conexao.Fechar();
                
            }

            return usuarios;

        }

        public static void Inserir(MUsuario u)
        {
            if (u == null)
                throw new ArgumentNullException(nameof(u));

            try {
                Conexao.Abrir();
            
                SqlCommand comando = new SqlCommand
                {
                    CommandText = "" +
                    "INSERT INTO " +
                    "TBUSUARIO " +
                    "VALUES " +
                    "(@NOME, @EMAIL,CONVERT(CHAR(64), HASHBYTES('SHA2_256', '@SENHA'), 2), @SITUACAO, @FKTIPOUSUARIOID)",
                    Connection = Conexao.Connection
                };

                SqlParameter param = new SqlParameter("@NOME", SqlDbType.VarChar) { Value = u.Nome };
                comando.Parameters.Add(param);
                
                param = new SqlParameter("@EMAIL", SqlDbType.VarChar) { Value = u.Email };
                comando.Parameters.Add(param);
                
                param = new SqlParameter("@SITUACAO", SqlDbType.Char) { Value = u.Situacao };
                comando.Parameters.Add(param);

                param = new SqlParameter("@FKTIPOUSUARIOID ", SqlDbType.Int) { Value = u.FKTipoUsuarioID };
                comando.Parameters.Add(param);

                param = new SqlParameter("@SENHA ", SqlDbType.Int) { Value = u.Senha};
                comando.Parameters.Add(param);


                if (0 < comando.ExecuteNonQuery())
                    throw new Exception(Erros.ErroGeral);
            }
            catch
            {
                Conexao.Fechar();
            }
        }


        public static void Atualizar(MUsuario u)
        {
            if (u == null)
                throw new ArgumentNullException(nameof(u));


            try
            { 

                     Conexao.Abrir();
            
                SqlCommand comando = new SqlCommand
                {
                    CommandText = "" +
                    "UPDATE TBUSUARIO " +
                    "SET" +
                    "NOME = @NOME , EMAIL = @EMAIL, SITUACAO = @SITUACAO, FKTIPOUSUARIOID = @FKTIPOUSUARIOID, Senha = @SENHA WHERE ID = @ID",
                    Connection = Conexao.Connection,
                };

                SqlParameter param = new SqlParameter("@ID", SqlDbType.Int);
                param.Value = u.ID;
                comando.Parameters.Add(param);

                param = new SqlParameter("@NOME", SqlDbType.VarChar) { Value = u.Nome };
                comando.Parameters.Add(param);

                param = new SqlParameter("@EMAIL", SqlDbType.VarChar) { Value = u.Email };
                comando.Parameters.Add(param);

                param = new SqlParameter("@SITUACAO", SqlDbType.Char) { Value = u.Situacao };
                comando.Parameters.Add(param);

                param = new SqlParameter("@FKTIPOUSUARIOID ", SqlDbType.Int) { Value = u.FKTipoUsuarioID };
                comando.Parameters.Add(param);

                param = new SqlParameter("@SENHA", SqlDbType.VarChar) { Value = u.Senha };
                comando.Parameters.Add(param);

                if (0 < comando.ExecuteNonQuery())
                    throw new Exception(Erros.ErroGeral);

            }
            catch
            {
                Conexao.Fechar();
            }
        }

        public static void Remover(MUsuario u)
        {
            if (u == null)
                throw new ArgumentNullException(nameof(u));

            try {
                Conexao.Abrir();
            
                SqlCommand comando = new SqlCommand
                {
                    CommandText = "DELETE FROM TBUSUARIO WHERE ID = @ID",
                    Connection = Conexao.Connection,
                };

                SqlParameter param = new SqlParameter("@ID", SqlDbType.Int) { Value = u.ID };
                comando.Parameters.Add(param);

                if (0 < comando.ExecuteNonQuery())
                    throw new Exception(Erros.ErroGeral);
            }
            catch
            {
                Conexao.Fechar();
            }
        }
    }
}
