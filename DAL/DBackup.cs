using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class DBackup
    {
        public static void Restaurar(String caminho)
        {  
            if (Conexao.Abrir())
            {
                //dgvGerarRestaurarBackup.Rows[e.RowIndex].Cells[0].Value.ToString()
                string[] arquivos = Directory.GetFiles(caminho, "*.bak", SearchOption.AllDirectories);

                SqlCommand command = new SqlCommand
                {
                    Connection = Conexao.Connection,
                    CommandText = "use master; RESTORE DATABASE DBCertiFind FROM DISK = '" + arquivos[0] + "' with replace;"
                };

                try
                {
                    command.ExecuteNonQuery();
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
}
