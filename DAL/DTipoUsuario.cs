using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DTipoUsuario
    {
        public static MTipoUsuario Obter(MTipoUsuario u)
        {
            if (u == null)
            {
                throw new ArgumentNullException(Erros.ErroGeral);
            }

            MTipoUsuario retorno = null;

            if (Conexao.Abrir())
            {
                SqlCommand command = new SqlCommand
                {
                    Connection = Conexao.Connection,
                    CommandText = "SELECT ID, NOME, Descricao, SITUACAO FROM TBTIPOUSUARIO WHERE ID = @ID "
                };

                SqlParameter param = new SqlParameter("@ID", SqlDbType.Int)
                { Value = u.ID };
                command.Parameters.Add(param);

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    retorno = new MTipoUsuario
                    {
                        ID = (int)reader["ID"],
                        Nome = reader["Nome"].ToString(),
                        Situacao = reader["SITUACAO"].ToString(),
                        Descricao = reader["Descricao"].ToString()
                    };
                }

                reader.Close();
                Conexao.Fechar();
            }

            return retorno;
        }

        public static List<MTipoUsuario> Pesquisar(MTipoUsuario u)
        {
            List<MTipoUsuario> usuarios = null;

            if (u == null)
            {
                throw new ArgumentNullException(Erros.ErroGeral);
            }

            if (Conexao.Abrir())
            {
                SqlCommand comando = new SqlCommand
                {
                    CommandText = "SELECT ID, NOME, Descricao, SITUACAO FROM TBTipoUsuario WHERE 1=1 ",
                    Connection = Conexao.Connection
                };

                if (!"".Equals(u.Nome))
                {
                    comando.CommandText += "AND NOME LIKE %@NOME% ";
                   SqlParameter param = new SqlParameter("@NOME", SqlDbType.VarChar) { Value = u.Nome };
                    param.Value = u.Nome;
                   comando.Parameters.Add(param);

               }

                if (u.Situacao != null && u.Situacao != "")
                {
                    comando.CommandText += "AND SITUACAO = @SITUACAO ";
                    SqlParameter param = new SqlParameter("@SITUACAO", SqlDbType.Char) { Value = u.Situacao };
                    param.Value = u.Situacao;
                    comando.Parameters.Add(param);

                }

                SqlDataReader reader = comando.ExecuteReader();

                MTipoUsuario usuario;

                while (reader.Read())
                {
                    if (usuarios == null)
                        usuarios = new List<MTipoUsuario>();

                    usuario = new MTipoUsuario
                    {
                        ID = (int)reader["ID"],
                        Nome = reader["NOME"].ToString(),
                        Situacao = reader["SITUACAO"].ToString(),
                        Descricao = reader["Descricao"].ToString()
                       
                    };

                    usuarios.Add(usuario);
                }
            }

            return usuarios;

        }

        public static void Inserir(MTipoUsuario u)
        {
            if (u == null)
                throw new ArgumentNullException(nameof(u));

            try {
                Conexao.Abrir();


                SqlCommand comando = new SqlCommand
                {
                    CommandText = "" +
                    "INSERT INTO " +
                    "TBTIPOUSUARIO " +
                    "(NOME,  SITUACAO, Descricao) " +
                    "VALUES " +
                    "(@NOME, @SITUACAO, @DESCRICAO) ",
                    Connection = Conexao.Connection,
                };

                SqlParameter param = new SqlParameter("@NOME", SqlDbType.VarChar) { Value = u.Nome };
                comando.Parameters.Add(param);

                param = new SqlParameter("@DESCRICAO ", SqlDbType.VarChar) { Value = u.Descricao };
                comando.Parameters.Add(param);

                param = new SqlParameter("@SITUACAO ", SqlDbType.Char) { Value = u.Situacao };
                comando.Parameters.Add(param);

                if (0 < comando.ExecuteNonQuery())
                    throw new Exception(Erros.ErroGeral);
            }
            catch {

                Conexao.Fechar();
            }
        }

        public static void Atualizar(MTipoUsuario u)
        {
            if (u == null)
                throw new ArgumentNullException(nameof(u));

            try { 
                Conexao.Abrir();
            
                SqlCommand comando = new SqlCommand
                {
                    CommandText = "" +
                    "UPDATE TBTIPOUSUARIO " +
                    "SET" +
                    "(ID, NOME, SITUACAO, DESCRICAO) " +
                    "VALUES " +
                    "(@ID, @NOME,@SITUACAO, @Descricao) WHERE ID = @ID",
                    Connection = Conexao.Connection,
                };

                SqlParameter param = new SqlParameter("@ID", SqlDbType.Int) { Value = u.ID };
                comando.Parameters.Add(param);

                param = new SqlParameter("@NOME", SqlDbType.VarChar) { Value = u.Nome };
                comando.Parameters.Add(param);

                param = new SqlParameter("@DESCRICAO", SqlDbType.VarChar) { Value = u.Descricao };
                comando.Parameters.Add(param);

                param = new SqlParameter("@SITUACAO", SqlDbType.Char) { Value = u.Situacao };
                comando.Parameters.Add(param);

                if (0 < comando.ExecuteNonQuery())
                    throw new Exception(Erros.ErroGeral);

            }catch
            {
                Conexao.Fechar();
            }
        }

        public static List<MTipoUsuario> PesquisaLista(MTipoUsuario u)
        {
            List<MTipoUsuario> usuarios = null;

            if (u == null)
            {
                throw new ArgumentNullException(Erros.ErroGeral);
            }
            try { 
            Conexao.Abrir();
            
                SqlCommand comando = new SqlCommand
                {
                    CommandText = "SELECT ID, NOME, Descricao, SITUACAO FROM TBTipoUsuario WHERE 1=1 ",
                    Connection = Conexao.Connection
                };

                SqlDataReader reader = comando.ExecuteReader();

                MTipoUsuario usuario;

                while (reader.Read())
                {
                    if (usuarios == null)
                        usuarios = new List<MTipoUsuario>();

                    usuario = new MTipoUsuario
                    {
                        ID = (int)reader["ID"],
                        Nome = reader["NOME"].ToString(),
                        Situacao = reader["SITUACAO"].ToString(),
                        Descricao = reader["Descricao"].ToString()

                    };

                    usuarios.Add(usuario);
                }
            }
            catch
            {
                Conexao.Fechar();
            }

            return usuarios;

        }






        public static void Remover(MTipoUsuario u)
        {
            if (u == null)
                throw new ArgumentNullException(nameof(u));

            if (Conexao.Abrir())
            {
                SqlCommand comando = new SqlCommand
                {
                    CommandText = "DELETE FROM TBTIPOUSUARIO WHERE ID = @ID",
                    Connection = Conexao.Connection,
                };

                SqlParameter param = new SqlParameter("@ID", SqlDbType.Int) { Value = u.ID };
                comando.Parameters.Add(param);

                if (0 < comando.ExecuteNonQuery())
                    throw new Exception(Erros.ErroGeral);
            }
        }

        

    }
 }
