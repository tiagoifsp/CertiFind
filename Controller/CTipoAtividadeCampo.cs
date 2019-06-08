using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public static class CTipoAtividadeCampo
    {
        //INSERIR
        public static void Inserir(MTipoAtividadeCampo item)
        {
            if (item == null)
            {
                throw new ExcecaoPadrao(Erros.AtividadeCampoNull);
            }

            if (item.CampoID == 0)
            {
                throw new ExcecaoPadrao(Erros.AtividadeCampoCampo);
            }

            if (item.Tamanho == -1)
            {
                throw new ExcecaoPadrao(Erros.AtividadeCampoTamanho);
            }

            if (item.TipoAtividadeID == 0)
            {
                throw new ExcecaoPadrao(Erros.AtividadeCampoTipoAtividade);
            }

            if (item.ValorInicial.Length > 100)
            {
                throw new ExcecaoPadrao(Erros.AtividadeCampoValorInicial);
            }

            if (item.ValorFinal.Length > 100)
            {
                throw new ExcecaoPadrao(Erros.AtividadeCampoValorFinal);
            }

            try
            {
                DTipoAtividadeCampo.Inserir(item);
            }
            catch
            {
                throw;
            }
        }

        //PESQUISAR
        public static List<MTipoAtividadeCampo> Pesquisar(MTipoAtividadeCampo item)
        {
            List<MTipoAtividadeCampo> retorno = null;

            if (item.ValorInicial.Length <= 100 && item.ValorFinal.Length <= 100)
            {
                retorno = DTipoAtividadeCampo.Pesquisar(item);
            }

            return retorno;
        }

        //OBTER
        public static MTipoAtividadeCampo Obter(MTipoAtividadeCampo item)
        {
            MTipoAtividadeCampo retorno = null;

            if (item != null)
            {
                retorno = DTipoAtividadeCampo.Obter(item);
            }

            return retorno;
        }

        //EDITAR
        public static void Editar(MTipoAtividadeCampo item)
        {
            if (item == null)
            {
                throw new ExcecaoPadrao(Erros.AtividadeCampoNull);
            }

            if (item.CampoID == 0)
            {
                throw new ExcecaoPadrao(Erros.AtividadeCampoCampo);
            }

            if (item.Tamanho == -1)
            {
                throw new ExcecaoPadrao(Erros.AtividadeCampoTamanho);
            }

            if (item.TipoAtividadeID == 0)
            {
                throw new ExcecaoPadrao(Erros.AtividadeCampoTipoAtividade);
            }

            if (item.ValorInicial.Length > 100)
            {
                throw new ExcecaoPadrao(Erros.AtividadeCampoValorInicial);
            }

            if (item.ValorFinal.Length > 100)
            {
                throw new ExcecaoPadrao(Erros.AtividadeCampoValorFinal);
            }

            try
            {
                DTipoAtividadeCampo.Editar(item);
            }
            catch
            {
                throw;
            }
        }

        //EXCLUIR
        public static void Excluir(MTipoAtividadeCampo item)
        {
            if (item == null)
            {
                throw new ExcecaoPadrao(Erros.AtividadeCampoNull);
            }

            try
            {
                DTipoAtividadeCampo.Excluir(item);
            }
            catch
            {
                throw;
            }
        }

    }
}
