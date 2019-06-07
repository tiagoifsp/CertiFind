using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;

namespace Controller
{
   public class CTipoUsuario
    {


        public static List<MTipoUsuario> PesquisaLista(MTipoUsuario item)
        {
            List<MTipoUsuario> retorno = null;
            
                retorno = DTipoUsuario.PesquisaLista(item);
            

            return retorno;
        }

        public static MTipoUsuario Obter(MTipoUsuario u)
        {
            //todo: verificar se ID foi inicializado

            return DTipoUsuario.Obter(u);
        }

        public static void Inserir(MTipoUsuario u)
        {
            if (u == null)
            {
                throw new ExcecaoPadrao(Erros.ErroGeral);
            }

            if (u.Nome.Trim() == "")
            {
                throw new ExcecaoPadrao(Erros.NomeVazio);
            }

            if (u.Nome.Length > 51)
            {
                throw new ExcecaoPadrao(Erros.NomeInvalido);
            }

            if (u.Descricao.Trim() == "")
            {
                throw new ExcecaoPadrao(Erros.DescricaoVazia);
            }

          try
            {
                DTipoUsuario.Inserir(u);
            }

            catch
            {
                throw;
            }
        }



    }
}
