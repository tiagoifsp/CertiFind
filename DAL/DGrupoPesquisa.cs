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
    public class DGrupoPesquisa
    {
        public static void Inserir(MGrupoPesquisa item)
        {

            bool conect = Conexao.Abrir();

            if (!conect)
            {
                throw new Exception("Falha na conexão com o SGBD");
            }

            SqlCommand comando = new SqlCommand();
            comando.Connection = Conexao.Connection;

            comando.CommandText = "insert into TBGrupoPesquisa (Nome, DataInicio, DataTermino, FKUsuarioID) Values (@NOME, @DATAINICIO,@DATATERMINO, @FKUSUARIOID)";

            SqlParameter param = new SqlParameter("@NOME", SqlDbType.VarChar);
            param.Value = item.Nome;
            comando.Parameters.Add(param);

            param = new SqlParameter("@DATAINICIO", SqlDbType.DateTime);
            param.Value = item.DataInicio;
            comando.Parameters.Add(param);

            param = new SqlParameter("@DATATERMINO", SqlDbType.DateTime);

            if(item.DataTermino != null)
                param.Value = item.DataTermino;
            else
                param.Value = DBNull.Value;

            comando.Parameters.Add(param);

            param = new SqlParameter("@FKUSUARIOID", SqlDbType.Int);
            param.Value = item.FKUsuarioID;
            comando.Parameters.Add(param);


            try
            {
                comando.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                //throw new Exception("O comando não pode ser executado");
                throw ex;
            }
            finally
            {
                Conexao.Fechar();
            }
        }
    }
}
