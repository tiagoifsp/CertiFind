using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class CGrupoPesquisa
    {
        public static void Inserir(MGrupoPesquisa item)
        {
            DGrupoPesquisa.Inserir(item);
        }

        public static List<MGrupoPesquisa> PesquisaGrupo(MGrupoPesquisa item)
        {
            List<MGrupoPesquisa> retorno = null;

            if (item != null && item.Nome != null && item.Nome.Length <= 200)
            {
                retorno = DGrupoPesquisa.PesquisarGrupo(item);
            }
            retorno = DGrupoPesquisa.PesquisarGrupo(item);

            return retorno;
        }
    }
}
