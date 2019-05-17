using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAL
{
    public static class DUsuario
    {

        public static MUsuario Login(MUsuario u)
        {
            MUsuario retorno = null;

            if (Conexao.Abrir())
            {
                SqlCommand command = new SqlCommand
                {
                    Connection = Conexao.Connection,
                    CommandText = "SELECT ID, EMAIL, SENHA FROM TBUSUARIO WHERE EMAIL = @EMAIL AND SITUACAO = 'A' "
                };

                SqlParameter param = new SqlParameter("@EMAIL", SqlDbType.VarChar)
                { Value = u.Email };
                command.Parameters.Add(param);

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    if (u.Senha == (reader["SENHA"].ToString()))
                    {
                        retorno = new MUsuario();
                        retorno.ID = (int)reader["ID"];
                    }
                }

                reader.Close();
                Conexao.Fechar();
            }

            return retorno;
        }

        public static MUsuario Obter(MUsuario u)
        {
            MUsuario retorno = null;

            if (Conexao.Abrir())
            {
                SqlCommand command = new SqlCommand
                {
                    Connection = Conexao.Connection,
                    CommandText = "SELECT ID, NOME, EMAIL, SITUACAO, FKTipoUsuarioID FROM TBUSUARIO WHERE ID = @ID "
                };

                SqlParameter param = new SqlParameter("@ID", SqlDbType.Int)
                { Value = u.ID };
                command.Parameters.Add(param);

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    retorno = new MUsuario();
                    retorno.ID = (int)reader["ID"];
                    retorno.Nome = reader["Nome"].ToString();
                    retorno.Situacao = reader["SITUACAO"].ToString();
                    retorno.Email = reader["EMAIL"].ToString();
                    retorno.FKTipoUsuarioID = (int)reader["FKTipoUsuarioID"];
                }

                reader.Close();
                Conexao.Fechar();
            }

            return retorno;
        }

        public static List<MUsuario> Pesquisar(MUsuario u)
        {
            if (u == null)
            {
                throw new ArgumentNullException(nameof(u));
            }

            throw new NotImplementedException();
        }

        public static void Inserir(MUsuario u)
        {
            if (u == null)
            {
                throw new ArgumentNullException(nameof(u));
            }

            throw new NotImplementedException();
        }

        public static void Atualizar(MUsuario u)
        {
            if (u == null)
            {
                throw new ArgumentNullException(nameof(u));
            }

            throw new NotImplementedException();
        }

        public static void Remover(MUsuario u)
        {
            if (u == null)
            {
                throw new ArgumentNullException(nameof(u));
            }

            throw new NotImplementedException();
        }
    }
}
