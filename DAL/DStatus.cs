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
    public static class DStatus
    {
        public static MStatus Obter()
        {
            MStatus retorno = null;
            if (Conexao.Abrir())
            {
                
                SqlCommand command = new SqlCommand
                {
                    Connection = Conexao.Connection,
                    CommandText = "SELECT DB_NAME() AS Nome"
                                  
                    
                };

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    retorno = new MStatus();
                   
                    retorno.NomeBanco = reader["Nome"].ToString();
                    
                }

                reader.Close();
                Conexao.Fechar();
                
            }
            return retorno;
        }

        }
    }


