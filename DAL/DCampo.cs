using Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class DCampo
    {
        //INSERIR
        public static void Inserir(MCampo item)
        {
            if (!Conexao.Abrir())
                throw new Exception();

            SqlCommand comando = new SqlCommand();
            comando.Connection = Conexao.Connection;

            comando.CommandText = "INSERT INTO TBCampo(Nome, FKTipoDadosID) VALUES(@Nome, @FKTipoDadosID)";

            SqlParameter parametro = new SqlParameter("@Nome", SqlDbType.VarChar);
            parametro.Value = item.Nome;
            comando.Parameters.Add(parametro);

            parametro = new SqlParameter("@FKTipoDadosID", SqlDbType.Int);
            parametro.Value = item.TipoDado;
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
        public static List<MCampo> Pesquisar(MCampo item)
        {
            if (!Conexao.Abrir())
                throw new Exception();

            SqlCommand comando = new SqlCommand();
            comando.Connection = Conexao.Connection;

            comando.CommandText = "SELECT C.ID, C.Nome, TD.Nome AS NomeTipoDado, C.FKTipoDadosID FROM TBCampo AS C JOIN TBTipoDados AS TD ON C.FKTipoDadosID = TD.ID WHERE 1=1";

            if (item.Nome.Trim() != "")
            {
                comando.CommandText += " AND C.Nome LIKE @Nome";

                SqlParameter parametro = new SqlParameter("@Nome", SqlDbType.VarChar);
                parametro.Value = "%" + item.Nome + "%";
                comando.Parameters.Add(parametro);
            }

            if (item.TipoDado != 0)
            {
                comando.CommandText += " AND C.FKTipoDadosID = @FKTipoDadosID";

                SqlParameter parametro = new SqlParameter("@FKTipoDadosID", SqlDbType.Int);
                parametro.Value = item.TipoDado;
                comando.Parameters.Add(parametro);
            }

            comando.CommandText += " ORDER BY C.Nome ASC";

            SqlDataReader reader = comando.ExecuteReader();
            List<MCampo> retorno = null;

            try
            {
                while (reader.Read())
                {
                    if (retorno == null)
                        retorno = new List<MCampo>();

                    MCampo campo = new MCampo();
                    campo.ID = int.Parse(reader["ID"].ToString());
                    campo.Nome = reader["Nome"].ToString();
                    campo.TipoDado = int.Parse(reader["FKTipoDadosID"].ToString());
                    campo.NomeTipoDado = reader["NomeTipoDado"].ToString();

                    retorno.Add(campo);
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

        //PESQUISAR PARA INSERIR
        public static List<MCampo> PesquisarInserir(MCampo item)
        {
            if (!Conexao.Abrir())
                throw new Exception();

            SqlCommand comando = new SqlCommand();
            comando.Connection = Conexao.Connection;

            comando.CommandText = "SELECT C.ID, C.Nome, TD.Nome AS NomeTipoDado, C.FKTipoDadosID FROM TBCampo AS C JOIN TBTipoDados AS TD ON C.FKTipoDadosID = TD.ID WHERE 1=1";

            if (item.Nome.Trim() != "")
            {
                comando.CommandText += " AND C.Nome = @Nome";

                SqlParameter parametro = new SqlParameter("@Nome", SqlDbType.VarChar);
                parametro.Value = item.Nome;
                comando.Parameters.Add(parametro);
            }

            if (item.TipoDado != 0)
            {
                comando.CommandText += " AND C.FKTipoDadosID = @FKTipoDadosID";

                SqlParameter parametro = new SqlParameter("@FKTipoDadosID", SqlDbType.Int);
                parametro.Value = item.TipoDado;
                comando.Parameters.Add(parametro);
            }

            comando.CommandText += " ORDER BY C.Nome ASC";

            SqlDataReader reader = comando.ExecuteReader();
            List<MCampo> retorno = null;

            try
            {
                while (reader.Read())
                {
                    if (retorno == null)
                        retorno = new List<MCampo>();

                    MCampo campo = new MCampo();
                    campo.ID = int.Parse(reader["ID"].ToString());
                    campo.Nome = reader["Nome"].ToString();
                    campo.TipoDado = int.Parse(reader["FKTipoDadosID"].ToString());
                    campo.NomeTipoDado = reader["NomeTipoDado"].ToString();

                    retorno.Add(campo);
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

        //OBTER
        public static MCampo Obter(MCampo item)
        {
            if (!Conexao.Abrir())
                throw new Exception();

            SqlCommand comando = new SqlCommand();
            comando.Connection = Conexao.Connection;

            comando.CommandText = "SELECT ID, Nome, FKTipoDadosID FROM TBCampo WHERE ID = @ID";

            SqlParameter parametro = new SqlParameter("@ID", SqlDbType.Int);
            parametro.Value = item.ID;
            comando.Parameters.Add(parametro);

            SqlDataReader reader = comando.ExecuteReader();

            MCampo retorno = null;

            try
            {
                if (reader.Read())
                {
                    retorno = new MCampo();

                    retorno.ID = int.Parse(reader["ID"].ToString());
                    retorno.Nome = reader["Nome"].ToString();
                    retorno.TipoDado = int.Parse(reader["FKTipoDadosID"].ToString());
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
        public static void Editar(MCampo item)
        {
            if (!Conexao.Abrir())
                throw new Exception();

            SqlCommand comando = new SqlCommand();
            comando.Connection = Conexao.Connection;

            comando.CommandText = "UPDATE TBCampo SET Nome = @Nome, FKTipoDadosID = @FKTipoDadosID WHERE ID = @ID";

            SqlParameter parametro = new SqlParameter("@ID", SqlDbType.Int);
            parametro.Value = item.ID;
            comando.Parameters.Add(parametro);

            parametro = new SqlParameter("@Nome", SqlDbType.VarChar);
            parametro.Value = item.Nome;
            comando.Parameters.Add(parametro);

            parametro = new SqlParameter("@FKTipoDadosID", SqlDbType.Int);
            parametro.Value = item.TipoDado;
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

        //EXCLUIR
        public static void Excluir(MCampo item)
        {
            if (!Conexao.Abrir())
                throw new Exception();

            SqlCommand comando = new SqlCommand();
            comando.Connection = Conexao.Connection;

            comando.CommandText = "DELETE FROM TBCampo WHERE ID = @ID";

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
