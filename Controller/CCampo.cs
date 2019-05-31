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
                throw new ExcecaoPadrao(Erros.ErroCampoNull);
            }

            if (item.Nome.Trim() == "" || item.Nome.Length > 100)
            {
                throw new ExcecaoPadrao(Erros.ErroCampoNome);
            }

            if (item.TipoDado == 0)
            {
                throw new ExcecaoPadrao(Erros.ErroCampoTipoDado);
            }

            MCampo pesquisa = new MCampo();
            pesquisa.Nome = item.Nome;
            pesquisa.TipoDado = 0;

            List<MCampo> lista = Pesquisar(pesquisa);
            if (lista != null && lista.Count != 0)
            {
                throw new ExcecaoPadrao(Erros.ErroCampoNomeDuplicado);
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
                throw new ExcecaoPadrao(Erros.ErroCampoNull);
            }

            if (item.Nome.Trim() == "" || item.Nome.Length > 100)
            {
                throw new ExcecaoPadrao(Erros.ErroCampoNome);
            }

            if (item.TipoDado == 0)
            {
                throw new ExcecaoPadrao(Erros.ErroCampoTipoDado);
            }

            MCampo pesquisa = new MCampo();
            pesquisa.Nome = item.Nome;
            pesquisa.TipoDado = 0;

            List<MCampo> lista = Pesquisar(pesquisa);
            if (lista != null && lista.Count != 0 && lista[0].ID != item.ID)
            {
                throw new ExcecaoPadrao(Erros.ErroCampoNomeDuplicado);
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
                throw new ExcecaoPadrao(Erros.ErroCampoNull);
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
