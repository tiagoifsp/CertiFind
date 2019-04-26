using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class Conexao
    {
#if DEBUG
        static readonly string ConnectionString = ConfigurationManager.ConnectionStrings["ConexaoLocal"].ConnectionString;
#else
        static readonly string ConnectionString = ConfigurationManager.ConnectionStrings["ConexaoProducao"].ConnectionString;
#endif

        static SqlConnection Connection = null;

        public static bool Abrir()
        {
            bool retorno = false;

            if (Connection != null && Connection.State != System.Data.ConnectionState.Closed)
                return false;

            if (Connection == null)
            {
                Connection = new SqlConnection(ConnectionString);
            }


            try
            {
                Connection.Open();
                retorno = true;
            }
            catch { }

            return retorno;
        }

        public static bool Fechar()
        {
            bool retorno = false;

            if(Connection != null && Connection.State == System.Data.ConnectionState.Open)
            {
                try
                {
                    Connection.Close();
                    retorno = true;
                }
                catch { }
            }

            return retorno;
        }
    }
}
