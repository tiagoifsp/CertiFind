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
        //INSERIR
        public static void Inserir(MTipoDado item)
        {
            if (item == null)
            {
                throw new ExcecaoPadrao(Erros.TipoDadoNull);
            }

            if (item.Nome.Trim() == "" || item.Nome.Length > 100)
            {
                throw new ExcecaoPadrao(Erros.TipoDadoNome);
            }

            if (item.Descricao.Length > 100)
            {
                throw new ExcecaoPadrao(Erros.TipoDadoDescricao);
            }

            List<MTipoDado> lista = Pesquisar(item);
            if (lista != null && lista.Count != 0)
            {
                throw new ExcecaoPadrao(Erros.TipoDadoNomeDuplicado);
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

        //PESQUISAR
        public static List<MTipoDado> Pesquisar(MTipoDado item)
        {
            List<MTipoDado> retorno = null;

            if (item.Nome != null && item.Nome.Length <= 100)
            {
                retorno = DTipoDado.Pesquisar(item);
            }

            return retorno;
        }

        //OBTER
        public static MTipoDado Obter(MTipoDado item)
        {
            MTipoDado retorno = null;

            if (item != null)
            {
                retorno = DTipoDado.Obter(item);
            }

            return retorno;
        }

        //EDITAR
        public static void Editar(MTipoDado item)
        {
            if (item == null)
            {
                throw new ExcecaoPadrao(Erros.TipoDadoNull);
            }

            if (item.Nome.Trim() == "" || item.Nome.Length > 100)
            {
                throw new ExcecaoPadrao(Erros.TipoDadoNome);
            }

            if (item.Descricao.Length > 100)
            {
                throw new ExcecaoPadrao(Erros.TipoDadoDescricao);
            }

            List<MTipoDado> lista = Pesquisar(item);
            if (lista != null && lista.Count != 0 && lista[0].ID != item.ID)
            {
                throw new ExcecaoPadrao(Erros.TipoDadoNomeDuplicado);
            }

            try
            {
                DTipoDado.Editar(item);
            }
            catch
            {
                throw;
            }
        }

        //EXCLUIR
        public static void Excluir(MTipoDado item)
        {
            if (item == null)
            {
                throw new ExcecaoPadrao(Erros.TipoDadoNull);
            }

            MCampo pesquisa = new MCampo();
            pesquisa.Nome = "";
            pesquisa.TipoDado = item.ID;
            if (CCampo.Pesquisar(pesquisa) != null)
            {
                throw new ExcecaoPadrao(Erros.TipoDadoChaveEstrangeira);
            }

            try
            {
                DTipoDado.Excluir(item);
            }
            catch
            {
                throw;
            }
        }
    }
}
