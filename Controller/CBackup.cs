using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;

namespace Controller
{
    public static class CBackup
    {
        public static void Restaurar(String caminho)
        {
            /*if(caminho == "")
            {

            }*/

            DBackup.Restaurar(caminho);
        }
    }
}
