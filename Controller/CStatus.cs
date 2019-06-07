using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using Model;

namespace Controller
{  //ALTERAÇÕES. "STATIC para PARTIAL".
    public partial class CStatus
    {
        private PerformanceCounter cpuCounter = new PerformanceCounter();
        private PerformanceCounter ramCounter = new PerformanceCounter("Memory", "Available MBytes");
        public string getCurrentCpuUsage;
        public string getAvailableRAM;

        public static bool VerificaConexao()
        {
            bool retorno = false;

            if (Conexao.Abrir())
            {
                retorno = true;
                Conexao.Fechar();
            }
            return retorno;
        }

        static long[] GetDirectorySize(string p)
        {
            // 1.
            // Cria um array com todos os nomes de arquivos.
            string[] a = Directory.GetFiles(p, "*.*");

            // 2.
            // Calcula o tamanho total de bytes de todos os arquivos no loop.
            long b = 0;

            long[] i = new long[2];
            foreach (string name in a)
            {
                // 3.
                // Usa as informações do arquivo para pegar o tamanho do arquivo
                FileInfo info = new FileInfo(name);
                i[0] += info.Length;
                i[1]++;
                //  MessageBox.Show(b.ToString());
            }
            // 4.
            // Retorna o tamanho total.
            return i;
        }

        public static long[] Pastas()
        {
            long[] teste = new long[2];

            teste = GetDirectorySize("C:\\TESTE\\");
            return teste;
        }

        public static string Banco()
        {
          

            string n = DStatus.Obter().NomeBanco.ToString();
            
            return n;

        }


    }
    }