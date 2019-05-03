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
                throw new ExcecaoPadrao(Erros.ErroTipoDeDado);
            }

            if(item.Nome.Trim() == "" || item.Nome.Length > 100)
            {
                throw new ExcecaoPadrao(Erros.ErroTipoDeDado);
            }

            if (item.Descricao.Trim() == "" || item.Descricao.Length > 100)
            {
                throw new ExcecaoPadrao(Erros.ErroTipoDeDado);
            }
        }
    }
}
