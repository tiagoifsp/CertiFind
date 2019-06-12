using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public static class CTipoAtividade
    {
        //INSERIR
        public static void Inserir(MTipoAtividade item)
        {
            if (item == null)
            {
                throw new ExcecaoPadrao(Erros.AtividadeNull);
            }

            if (item.Nome.Trim() == "" || item.Nome.Length > 100)
            {
                throw new ExcecaoPadrao(Erros.AtividadeNome);
            }

            MTipoAtividade pesquisa = new MTipoAtividade();
            pesquisa.Nome = item.Nome;

            List<MTipoAtividade> lista = Pesquisar(pesquisa);
            if (lista != null && lista.Count != 0)
            {
                for (int i = 0; i < lista.Count; i++)
                {
                    if (lista[i].Nome == item.Nome)
                    {
                        throw new ExcecaoPadrao(Erros.AtividadeNomeDuplicado);
                    }
                }
            }

            try
            {
                DTipoAtividade.Inserir(item);
            }
            catch
            {
                throw;
            }
        }

        //PESQUISAR
        public static List<MTipoAtividade> Pesquisar(MTipoAtividade item)
        {
            List<MTipoAtividade> retorno = null;

            if (item.Nome != null && item.Nome.Length <= 100)
            {
                retorno = DTipoAtividade.Pesquisar(item);
            }

            return retorno;
        }

        //PESQUISAR INSERIR
        public static List<MTipoAtividade> PesquisarInserir(MTipoAtividade item)
        {
            List<MTipoAtividade> retorno = null;

            if (item.Nome != null && item.Nome.Length <= 100)
            {
                retorno = DTipoAtividade.PesquisarInserir(item);
            }

            return retorno;
        }

        //OBTER
        public static MTipoAtividade Obter(MTipoAtividade item)
        {
            MTipoAtividade retorno = null;

            if (item != null)
            {
                retorno = DTipoAtividade.Obter(item);
            }

            return retorno;
        }

        //EDITAR
        public static void Editar(MTipoAtividade item)
        {
            if (item == null)
            {
                throw new ExcecaoPadrao(Erros.TipoDadoNull);
            }

            if (item.Nome.Trim() == "" || item.Nome.Length > 100)
            {
                throw new ExcecaoPadrao(Erros.TipoDadoNome);
            }

            MTipoAtividade pesquisa = new MTipoAtividade();
            pesquisa.Nome = item.Nome;

            List<MTipoAtividade> lista = Pesquisar(pesquisa);
            if (lista != null && lista.Count != 0)
            {
                for (int i = 0; i < lista.Count; i++)
                {
                    if (lista[i].Nome == item.Nome && lista[i].ID != item.ID)
                    {
                        throw new ExcecaoPadrao(Erros.AtividadeNomeDuplicado);
                    }
                }
            }

            try
            {
                DTipoAtividade.Editar(item);
            }
            catch
            {
                throw;
            }
        }

        //EXCLUIR
        public static void Excluir(MTipoAtividade item)
        {
            if (item == null)
            {
                throw new ExcecaoPadrao(Erros.TipoDadoNull);
            }

            MTipoAtividadeCampo pesquisa = new MTipoAtividadeCampo();
            pesquisa.CampoID = 0;
            pesquisa.TipoAtividadeID = item.ID;
            pesquisa.ValorInicial = "";
            pesquisa.ValorFinal = "";
            if (CTipoAtividadeCampo.Pesquisar(pesquisa) != null)
            {
                throw new ExcecaoPadrao(Erros.AtividadeChaveEstrangeira);
            }

            try
            {
                DTipoAtividade.Excluir(item);
            }
            catch
            {
                throw;
            }
        }
    }
}
