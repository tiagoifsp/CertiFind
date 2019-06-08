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
    public static class DCertificado
    {

        //INSERIR
        public static void Inserir(MCertificado item)
        {
            if (!Conexao.Abrir())
                throw new Exception();

            SqlCommand comando = new SqlCommand();
            comando.Connection = Conexao.Connection;

            comando.CommandText = "INSERT INTO TBCertificado(FKTipoAtividade, FKUsuarioID) " +
                "VALUES (@FKTipoAtividade, @FKUsuarioID, @Tamanho)";

            SqlParameter parametro = new SqlParameter("@FKTipoAtividade", SqlDbType.Int);
            parametro.Value = item.TipoAtividadeID;
            comando.Parameters.Add(parametro);

            parametro = new SqlParameter("@FKUsuarioID", SqlDbType.Int);
            parametro.Value = item.UsuarioID;
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

        //PESQUISAR
        public static List<MCertificado> Pesquisar(MCertificado item)
        {
            if (!Conexao.Abrir())
                throw new Exception();

            SqlCommand comando = new SqlCommand();
            comando.Connection = Conexao.Connection;

            comando.CommandText = "SELECT TA.Nome, TU.Nome FROM TBCertificado AS TC JOIN TBTipoAtividade AS TA " +
                "ON TC.FKTipoAtividade = TA.ID JOIN TBUsuario AS TU ON TC.FKUsuarioID = TU.ID WHERE 1 = 1";

            if (item.TipoAtividadeID != 0)
            {
                comando.CommandText += " AND TC.FKTipoAtividade = @FKTipoAtividade";

                SqlParameter parametro = new SqlParameter("@FKTipoAtividade", SqlDbType.Int);
                parametro.Value = item.TipoAtividadeID;
                comando.Parameters.Add(parametro);
            }

            if (item.UsuarioID != 0)
            {
                comando.CommandText += " AND TC.FKUsuarioID = @FKUsuarioID";

                SqlParameter parametro = new SqlParameter("@FKUsuarioID", SqlDbType.Int);
                parametro.Value = item.UsuarioID;
                comando.Parameters.Add(parametro);
            }

            comando.CommandText += " ORDER BY TU.Nome ASC";

            SqlDataReader reader = comando.ExecuteReader();
            List<MCertificado> retorno = null;

            try
            {
                while (reader.Read())
                {
                    if (retorno == null)
                        retorno = new List<MCertificado>();

                    MCertificado certificado = new MCertificado();
                    certificado.ID = int.Parse(reader["ID"].ToString());
                    certificado.TipoAtividadeID = int.Parse(reader["TipoAtividadeID"].ToString());
                    certificado.UsuarioID = int.Parse(reader["UsuarioID"].ToString());

                    retorno.Add(certificado);
                }
            }
            catch
            {
                throw;
            }
            finally
            {
                reader.Close();
                Conexao.Fechar();
            }
            return retorno;
        }

        //EDITAR
        public static void Editar(MCertificado item)
        {
            if (!Conexao.Abrir())
                throw new Exception();

            SqlCommand comando = new SqlCommand();
            comando.Connection = Conexao.Connection;

            comando.CommandText = "UPDATE TBCertificado SET FKTipoAtividade = @FKTipoAtividade, " +
                " FKUsuarioID = @FKUsuarioID WHERE ID = @ID";

            SqlParameter parametro = new SqlParameter("@ID", SqlDbType.Int);
            parametro.Value = item.ID;
            comando.Parameters.Add(parametro);

            parametro = new SqlParameter("@FKTipoAtividade", SqlDbType.Int);
            parametro.Value = item.TipoAtividadeID;
            comando.Parameters.Add(parametro);

            parametro = new SqlParameter("@FKUsuarioID", SqlDbType.Int);
            parametro.Value = item.UsuarioID;
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

        //OBTER
        public static MCertificado Obter(MCertificado item)
        {
            if (!Conexao.Abrir())
                throw new Exception();

            SqlCommand comando = new SqlCommand();
            comando.Connection = Conexao.Connection;

            comando.CommandText = "SELECT ID, FKTipoAtividade, FKUsuarioID FROM TBCertificado WHERE ID = @ID";

            SqlParameter parametro = new SqlParameter("@ID", SqlDbType.Int);
            parametro.Value = item.ID;
            comando.Parameters.Add(parametro);

            SqlDataReader reader = comando.ExecuteReader();

            MCertificado retorno = null;

            try
            {
                if (reader.Read())
                {
                    retorno = new MCertificado();

                    retorno.ID = int.Parse(reader["ID"].ToString());
                    retorno.TipoAtividadeID = int.Parse(reader["FKTipoAtividade"].ToString());
                    retorno.UsuarioID = int.Parse(reader["FKUsuarioID"].ToString());                    
                }
            }
            catch
            {
                throw;
            }
            finally
            {
                reader.Close();
                Conexao.Fechar();
            }

            return retorno;
        }

        //EXCLUIR
        public static void Excluir(MCertificado item)
        {
            if (!Conexao.Abrir())
                throw new Exception();

            SqlCommand comando = new SqlCommand();
            comando.Connection = Conexao.Connection;

            comando.CommandText = "DELETE FROM TBCertificado WHERE ID = @ID";

            SqlParameter parametro = new SqlParameter("@ID", SqlDbType.Int);
            parametro.Value = item.ID;
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
