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

        public static bool Login(MUsuario u)
        {
            if (u == null)
            {
                throw new ArgumentNullException(nameof(u));
            }

            bool retorno = false;

            try
            {
                Conexao.Abrir();
            }
            catch (Exception)
            {
                throw;
            }

            SqlCommand command = new SqlCommand
            {
                Connection = Conexao.Connection,
                CommandText = "SELECT EMAIL, SENHA FROM TBUSUARIO WHERE EMAIL = @EMAIL"
            };

            SqlParameter param = new SqlParameter("@EMAIL", SqlDbType.VarChar)
            { Value = u.Email };
            command.Parameters.Add(param);

            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                if (u.Email == reader["EMAIL"].ToString() && u.Senha == (reader["SENHA"].ToString().Trim()))
                    retorno = true;
            }

            Conexao.Fechar();
            return retorno;
        }

        public static MUsuario Obter(MUsuario u)
        {
            if (u == null)
            {
                throw new ArgumentNullException(nameof(u));
            }

            throw new NotImplementedException();
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
