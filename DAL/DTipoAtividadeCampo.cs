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
    public static class DTipoAtividadeCampo
    {
        //INSERIR
        public static void Inserir(MTipoAtividadeCampo item)
        {
            if (!Conexao.Abrir())
                throw new Exception();

            SqlCommand comando = new SqlCommand();
            comando.Connection = Conexao.Connection;

            comando.CommandText = "INSERT INTO TBTipoAtividadeCampo(FKCampoID, FKTipoAtividadeID, Tamanho, ValorInicial, " +
                "ValorFinal) VALUES(@FKCampoID, @FKTipoAtividadeID, @Tamanho, @ValorInicial, @ValorFinal)";

            SqlParameter parametro = new SqlParameter("@FKCampoID", SqlDbType.Int);
            parametro.Value = item.CampoID;
            comando.Parameters.Add(parametro);

            parametro = new SqlParameter("@FKTipoAtividadeID", SqlDbType.Int);
            parametro.Value = item.TipoAtividadeID;
            comando.Parameters.Add(parametro);

            parametro = new SqlParameter("@Tamanho", SqlDbType.Int);
            parametro.Value = item.Tamanho;
            comando.Parameters.Add(parametro);

            parametro = new SqlParameter("@ValorInicial", SqlDbType.VarChar);
            parametro.Value = item.ValorFinal;
            comando.Parameters.Add(parametro);

            parametro = new SqlParameter("@ValorFinal", SqlDbType.VarChar);
            parametro.Value = item.ValorFinal;
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
        public static List<MTipoAtividadeCampo> Pesquisar(MTipoAtividadeCampo item)
        {
            if (!Conexao.Abrir())
                throw new Exception();

            SqlCommand comando = new SqlCommand();
            comando.Connection = Conexao.Connection;

            comando.CommandText = "SELECT TA.Tamanho, TA.ValorInicial, TA.ValorFinal, TC.Nome, TT.Nome" +
                "FROM TBTipoAtividadeCampo AS TA JOIN TBCampo AS TC ON TA.FKCampoID = TC.ID JOIN TBTipoAtividade " +
                "AS TT ON TA.FKTipoAtividadeID = TT.ID WHERE 1 = 1";

            if (item.CampoID != null)
            {
                comando.CommandText += " AND TA.FKCampoID = @FKCampoID";

                SqlParameter parametro = new SqlParameter("@FKCampoID", SqlDbType.VarChar);
                parametro.Value = item.CampoID;
                comando.Parameters.Add(parametro);
            }

            if (item.TipoAtividadeID != null)
            {
                comando.CommandText += " AND TA.FKTipoAtividadeID = @FKTipoAtividadeID";

                SqlParameter parametro = new SqlParameter("@FKTipoAtividadeID", SqlDbType.VarChar);
                parametro.Value = item.TipoAtividadeID;
                comando.Parameters.Add(parametro);
            }

            if (item.Tamanho != null)
            {
                comando.CommandText += " AND TA.Tamanho = @Tamanho";

                SqlParameter parametro = new SqlParameter("@Tamanho", SqlDbType.VarChar);
                parametro.Value = item.Tamanho;
                comando.Parameters.Add(parametro);
            }

            if (item.ValorInicial.Trim() != "")
            {
                comando.CommandText += " AND TA.ValorInicial LIKE @ValorInicial";

                SqlParameter parametro = new SqlParameter("@ValorInicial", SqlDbType.VarChar);
                parametro.Value = "%" + item.ValorInicial + "%";
                comando.Parameters.Add(parametro);
            }

            if (item.ValorFinal.Trim() != "")
            {
                comando.CommandText += " AND TA.ValorFinal LIKE @ValorFinal";

                SqlParameter parametro = new SqlParameter("@ValorFinal", SqlDbType.VarChar);
                parametro.Value = "%" + item.ValorFinal + "%";
                comando.Parameters.Add(parametro);
            }

            comando.CommandText += " ORDER BY TT.Nome ASC";

            SqlDataReader reader = comando.ExecuteReader();
            List<MTipoAtividadeCampo> retorno = null;

            try
            {
                while (reader.Read())
                {
                    if (retorno == null)
                        retorno = new List<MTipoAtividadeCampo>();

                    MTipoAtividadeCampo tipoAtividadeCampo = new MTipoAtividadeCampo();
                    tipoAtividadeCampo.ID = int.Parse(reader["ID"].ToString());
                    tipoAtividadeCampo.CampoID = int.Parse(reader["FKCampoID"].ToString());
                    tipoAtividadeCampo.TipoAtividadeID = int.Parse(reader["FKTipoAtividadeID"].ToString());
                    tipoAtividadeCampo.Tamanho = int.Parse(reader["NomeTipoDado"].ToString());
                    tipoAtividadeCampo.ValorInicial = reader["ValorInicial"].ToString();
                    tipoAtividadeCampo.ValorFinal = reader["ValorFinal"].ToString();

                    retorno.Add(tipoAtividadeCampo);
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
        public static void Editar(MTipoAtividadeCampo item)
        {
            if (!Conexao.Abrir())
                throw new Exception();

            SqlCommand comando = new SqlCommand();
            comando.Connection = Conexao.Connection;

            comando.CommandText = "UPDATE TBTipoAtividadeCampo SET ID = @ID, FKCampoID = @FKCampoID, " +
                "FKTipoAtividadeID = @FKTipoAtividadeID, Tamanho = @Tamanho, ValorInicial = @ValorInicial, " +
                "ValorFinal = @ValorFinal WHERE ID = @ID";

            SqlParameter parametro = new SqlParameter("@ID", SqlDbType.Int);
            parametro.Value = item.ID;
            comando.Parameters.Add(parametro);

            parametro = new SqlParameter("@FKCampoID", SqlDbType.Int);
            parametro.Value = item.CampoID;
            comando.Parameters.Add(parametro);

            parametro = new SqlParameter("@FKTipoAtividadeID", SqlDbType.Int);
            parametro.Value = item.TipoAtividadeID;
            comando.Parameters.Add(parametro);

            parametro = new SqlParameter("@Tamanho", SqlDbType.Int);
            parametro.Value = item.Tamanho;
            comando.Parameters.Add(parametro);

            parametro = new SqlParameter("@ValorInicial", SqlDbType.VarChar);
            parametro.Value = item.ValorFinal;
            comando.Parameters.Add(parametro);

            parametro = new SqlParameter("@ValorFinal", SqlDbType.VarChar);
            parametro.Value = item.ValorFinal;
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
        public static MTipoAtividadeCampo Obter(MTipoAtividadeCampo item)
        {
            if (!Conexao.Abrir())
                throw new Exception();

            SqlCommand comando = new SqlCommand();
            comando.Connection = Conexao.Connection;

            comando.CommandText = "SELECT ID, FKCampoID, FKTipoAtividadeID, Tamanho, " +
                "ValorInicial, ValorFinal FROM TBTipoAtividadeCampo WHERE ID = @ID";

            SqlParameter parametro = new SqlParameter("@ID", SqlDbType.Int);
            parametro.Value = item.ID;
            comando.Parameters.Add(parametro);

            SqlDataReader reader = comando.ExecuteReader();

            MTipoAtividadeCampo retorno = null;

            try
            {
                if (reader.Read())
                {
                    retorno = new MTipoAtividadeCampo();

                    retorno.ID = int.Parse(reader["ID"].ToString());
                    retorno.CampoID = int.Parse(reader["FKCampoID"].ToString());
                    retorno.TipoAtividadeID = int.Parse(reader["FKTipoAtividadeID"].ToString());
                    retorno.Tamanho = int.Parse(reader["NomeTipoDado"].ToString());
                    retorno.ValorInicial = reader["ValorInicial"].ToString();
                    retorno.ValorFinal = reader["ValorFinal"].ToString();
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
        public static void Excluir(MTipoAtividadeCampo item)
        {
            if (!Conexao.Abrir())
                throw new Exception();

            SqlCommand comando = new SqlCommand();
            comando.Connection = Conexao.Connection;

            comando.CommandText = "DELETE FROM TBTipoAtividadeCampo WHERE ID = @ID";

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
