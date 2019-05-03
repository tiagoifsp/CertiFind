using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace Controller
{
    public class CGrupoPesquisa
    {
        public static void Inserir(MGrupoPesquisa item)
        {
            DGrupoPesquisa.Inserir(item);
        }
    }
}
