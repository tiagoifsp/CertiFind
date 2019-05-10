using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public static class CTipoDado
    {
        public static void Inserir(MTipoDado item)
        {
            if(item == null)
            {
                throw new ExcecaoPadrao(Erros.ErroTipoDadoNull);
            }

            if(item.Nome.Trim() == "" || item.Nome.Length > 100)
            {
                throw new ExcecaoPadrao(Erros.ErroTipoDadoNome);
            }

            if (item.Descricao.Length > 100)
            {
                throw new ExcecaoPadrao(Erros.ErroTipoDadoDescricao);
            }

            try
            {
                DTipoDado.Inserir(item);
            }
            catch
            {
                throw;
            }
        }

        public static List<MTipoDado> Pesquisar(MTipoDado item)
        {
            List<MTipoDado> retorno = null;

            if (item != null && item.Nome != null && item.Nome.Length <= 100)
            {
                retorno = DTipoDado.Pesquisar(item);
            }

            return retorno;
        }
    }
}
