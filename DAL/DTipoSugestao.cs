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
    public static class DTipoSugestao
    {
        public static List<MTipoSugestao> BuscarTipo()
        {
            List<MTipoSugestao> LTipo = null;

            if (Conexao.Abrir())
            {
                SqlCommand command = new SqlCommand
                {
                    Connection = Conexao.Connection,
                    CommandText =
                    "SELECT ID, Nome, Descricao FROM TBTipoSugestao"
                };

                SqlDataReader reader = null;

                try
                {
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        if (LTipo == null)
                            LTipo = new List<MTipoSugestao>();

                        MTipoSugestao tipoSugestao = new MTipoSugestao();
                        tipoSugestao.ID = (int)reader["ID"];
                        tipoSugestao.Nome = reader["Nome"].ToString();
                        tipoSugestao.Descricao = reader["Descricao"].ToString();

                        LTipo.Add(tipoSugestao);
                    }
                }
                finally
                {
                    if (reader != null)
                        reader.Close();

                    Conexao.Fechar();
                }
            }

            return LTipo;
        }
    }
}
