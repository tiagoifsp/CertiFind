using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;
using System.Text.RegularExpressions;
using System.Security.Cryptography;

namespace Controller
{
    public class CUsuario
    {
        public static string Encriptar(String t)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(t);
            SHA256Managed hash = new SHA256Managed();
            return BitConverter.ToString(hash.ComputeHash(bytes)).Replace("-", "");
        }

        public static MUsuario Login(MUsuario u)
        {
            Regex rg = new Regex(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");

            if ((!rg.IsMatch(u.Email)))
            {
                throw new ExcecaoPadrao(Erros.EmailInvalido);
            }

            if (u.Senha.Trim() == "")
            {
                throw new ExcecaoPadrao(Erros.SenhaVazio);
            }

            return DUsuario.Login(u);
        }

        public static List<MUsuario> Pesquisar(MUsuario item)
        {
            List<MUsuario> retorno = null;        
                retorno = DUsuario.Pesquisar(item);
            
            return retorno;
        }

        public static MUsuario Obter(MUsuario u)
        {
            //todo: verificar se ID foi inicializado

            return DUsuario.Obter(u);
        }

        public static void Inserir(MUsuario u)
        {
            if(u == null)
            {
                throw new ExcecaoPadrao(Erros.ErroGeral);
            }

            if(u.Nome.Trim() == "")
            {
                throw new ExcecaoPadrao(Erros.NomeVazio);
            }

            if(u.Nome.Length < 100)
            {
                throw new ExcecaoPadrao(Erros.NomeInvalido);
            }

            if(u.Senha.Trim() == "")
            {
                throw new ExcecaoPadrao(Erros.SenhaVazio);
            }

            if(u.Email.Trim() == "")
            {
                throw new ExcecaoPadrao(Erros.EmailVazio);
            }

            if(u.Email.Length < 100)
            {
                throw new ExcecaoPadrao(Erros.EmailInvalido);
            }

            if(u.Situacao.Trim() == null)
            {
                throw new ExcecaoPadrao(Erros.SituacaoInvalida);
            }

            if(u.FKTipoUsuarioID.ToString().Trim() == null)
            {
                throw new ExcecaoPadrao(Erros.TipodeUsuarioInvalido);
            }

            try
            {
                DUsuario.Inserir(u);
            }

            catch
            {
                throw;
            }



        }
    }
}
