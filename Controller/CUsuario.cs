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

        public static MUsuario Obter(MUsuario u)
        {
            //todo: verificar se ID foi inicializado

            return DUsuario.Obter(u);
        }
    }
}
