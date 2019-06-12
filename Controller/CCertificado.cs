using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class CCertificado
    {
        //INSERIR
        public static void Inserir(MCertificado item)
        {
            if (item == null)
            {
                throw new ExcecaoPadrao(Erros.AtividadeCampoNull);
            }

            if (item.TipoAtividadeID == 0)
            {
                throw new ExcecaoPadrao(Erros.CertificadoCampoTipoAtividade);
            }

            if (item.UsuarioID == -1)
            {
                throw new ExcecaoPadrao(Erros.CertificadoCampoUsuario);
            }

            try
            {
                DCertificado.Inserir(item);
            }
            catch
            {
                throw;
            }
        }

        //PESQUISAR
        public static List<MCertificado> Pesquisar(MCertificado item)
        {
            List<MCertificado> retorno = null;

            if (item.UsuarioID != -1)
            {
                retorno = DCertificado.Pesquisar(item);
            }

            return retorno;
        }

        //OBTER
        public static MCertificado Obter(MCertificado item)
        {
            MCertificado retorno = null;

            if (item != null)
            {
                retorno = DCertificado.Obter(item);
            }

            return retorno;
        }

        //EDITAR
        public static void Editar(MCertificado item)
        {
            if (item == null)
            {
                throw new ExcecaoPadrao(Erros.CertificadoCampoNull);
            }

            if (item.TipoAtividadeID == 0)
            {
                throw new ExcecaoPadrao(Erros.CertificadoCampoTipoAtividade);
            }

            if (item.UsuarioID == 0)
            {
                throw new ExcecaoPadrao(Erros.CertificadoCampoUsuario);
            }

            try
            {
                DCertificado.Editar(item);
            }
            catch
            {
                throw;
            }
        }

        //EXCLUIR
        public static void Excluir(MCertificado item)
        {
            if (item == null)
            {
                throw new ExcecaoPadrao(Erros.CertificadoCampoNull);
            }

            try
            {
                DCertificado.Excluir(item);
            }
            catch
            {
                throw;
            }
        }
    }
}
