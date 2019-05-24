using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;

namespace DAL
{
    public static class DSugestao
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

                SqlDataReader reader = command.ExecuteReader();
                if(reader.Read())
                {
                    LTipo = new List<MTipoSugestao>();

                    while(true)
                    {
                        MTipoSugestao tipoSugestao = new MTipoSugestao();
                        try
                        {
                            tipoSugestao.ID = reader.GetInt32(0);
                            tipoSugestao.Nome = reader.GetTextReader(1).ReadLine();
                            tipoSugestao.Descricao = reader.GetTextReader(2).ReadLine();

                            LTipo.Add(tipoSugestao);
                            reader.Read();
                        }
                        catch
                        {
                            break;
                        }
                    }                  
                    return LTipo;
                }
                else
                {
                    Conexao.Fechar();
                    return LTipo;
                }
            }
            else
            {
                return LTipo;
            }

        }
    }
}