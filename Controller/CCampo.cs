using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public static class CCampo
    {
        //INSERIR
        public static void Inserir(MCampo item)
        {
            if (item == null)
            {
                throw new ExcecaoPadrao(Erros.CampoNull);
            }

            if (item.Nome.Trim() == "" || item.Nome.Length > 100)
            {
                throw new ExcecaoPadrao(Erros.CampoNome);
            }

            if (item.TipoDado == 0)
            {
                throw new ExcecaoPadrao(Erros.CampoTipoDado);
            }

            MCampo pesquisa = new MCampo();
            pesquisa.Nome = item.Nome;
            pesquisa.TipoDado = 0;

            List<MCampo> lista = Pesquisar(pesquisa);
            if (lista != null && lista.Count != 0)
            {
                for (int i = 0; i < lista.Count; i++)
                {
                    if (lista[i].Nome == item.Nome)
                    {
                        throw new ExcecaoPadrao(Erros.CampoNomeDuplicado);
                    }
                }
            }

            try
            {
                DCampo.Inserir(item);
            }
            catch
            {
                throw;
            }
        }

        //PESQUISAR
        public static List<MCampo> Pesquisar(MCampo item)
        {
            List<MCampo> retorno = null;

            if (item.Nome != null && item.Nome.Length <= 100)
            {
                retorno = DCampo.Pesquisar(item);
            }

            return retorno;
        }

        //OBTER
        public static MCampo Obter(MCampo item)
        {
            MCampo retorno = null;

            if (item != null)
            {
                retorno = DCampo.Obter(item);
            }

            return retorno;
        }

        //EDITAR
        public static void Editar(MCampo item)
        {
            if (item == null)
            {
                throw new ExcecaoPadrao(Erros.CampoNull);
            }

            if (item.Nome.Trim() == "" || item.Nome.Length > 100)
            {
                throw new ExcecaoPadrao(Erros.CampoNome);
            }

            if (item.TipoDado == 0)
            {
                throw new ExcecaoPadrao(Erros.CampoTipoDado);
            }

            MCampo pesquisa = new MCampo();
            pesquisa.Nome = item.Nome;
            pesquisa.TipoDado = 0;

            List<MCampo> lista = Pesquisar(pesquisa);
            if (lista != null && lista.Count != 0)
            {
                for (int i = 0; i < lista.Count; i++)
                {
                    if (lista[i].Nome == item.Nome && lista[i].ID != item.ID)
                    {
                        throw new ExcecaoPadrao(Erros.CampoNomeDuplicado);
                    }
                }
            }

            try
            {
                DCampo.Editar(item);
            }
            catch
            {
                throw;
            }
        }

        //EXCLUIR
        public static void Excluir(MCampo item)
        {
            if (item == null)
            {
                throw new ExcecaoPadrao(Erros.CampoNull);
            }

            MTipoAtividadeCampo pesquisa = new MTipoAtividadeCampo();
            pesquisa.CampoID = item.ID;
            pesquisa.TipoAtividadeID = 0;
            pesquisa.ValorInicial = "";
            pesquisa.ValorFinal = "";
            if (CTipoAtividadeCampo.Pesquisar(pesquisa) != null)
            {
                throw new ExcecaoPadrao(Erros.CampoChaveEstrangeira);
            }

            try
            {
                DCampo.Excluir(item);
            }
            catch
            {
                throw;
            }
        }
    }
}
