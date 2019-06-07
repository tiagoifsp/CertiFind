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

            MTipoAtividadeCampo pesquisa = new MTipoAtividadeCampo();
            pesquisa.CampoID = item.CampoID;
            pesquisa.TipoAtividadeID = item.TipoAtividadeID;

            List<MTipoAtividadeCampo> lista = Pesquisar(pesquisa);
            if (lista != null && lista.Count != 0)
            {
                for (int i = 0; i < lista.Count; i++)
                {
                    if (lista[i].CampoID == item.CampoID && lista[i].TipoAtividadeID == item.TipoAtividadeID)
                    {
                        throw new ExcecaoPadrao(Erros.AtividadeCampoDuplicado);
                    }
                }
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
                throw new ExcecaoPadrao(Erros.CampoNull);
            }

            if (item.Tamanho == 0)
            {
                throw new ExcecaoPadrao(Erros.AtividadeCampoTamanho);
            }

            if (item.ValorInicial.Trim() == "" || item.ValorInicial.Length > 100)
            {
                throw new ExcecaoPadrao(Erros.AtividadeCampoValorInicial);
            }

            if (item.ValorFinal.Trim() == "" || item.ValorFinal.Length > 100)
            {
                throw new ExcecaoPadrao(Erros.AtividadeCampoValorFinal);
            }

            //MTipoAtividadeCampo pesquisa = new MTipoAtividadeCampo();
            //pesquisa.Nome = item.Nome;
            //pesquisa.TipoDado = 0;

            //List<MTipoAtividadeCampo> lista = Pesquisar(pesquisa);
            //if (lista != null && lista.Count != 0 && lista[0].ID != item.ID)
            //{
            //    throw new ExcecaoPadrao(Erros.CampoNomeDuplicado);
            //}

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
