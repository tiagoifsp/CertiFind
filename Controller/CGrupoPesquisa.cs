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
            if(item.Nome == null || item.Nome.Trim().Equals(""))
            {
                throw new ExcecaoPadrao(Erros.NomeInvalido);
            }

            if(item.DataTermino < item.DataInicio)
            {
                throw new ExcecaoPadrao(Erros.DatasInvalidas);
            }
            DGrupoPesquisa.Inserir(item);
        }

        public static List<MUsuario> CarregaCombo()
        {
            List<MUsuario> retorno = null;
            retorno = DGrupoPesquisa.ObterUsuarioCombo();
            return retorno;
        }
    }
}
