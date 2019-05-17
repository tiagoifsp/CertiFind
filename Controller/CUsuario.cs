using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;
using System.Text.RegularExpressions;

namespace Controller
{
    public class CUsuario
    {
        public static bool Login(MUsuario u)
        {
            if(u.Email.Trim() == "")
            {
                throw new ExcecaoPadrao(Erros.EmailVazio);
            }
            if (u.Senha.Trim() == "")
            {
                throw new ExcecaoPadrao(Erros.SenhaVazio);
            }


            Regex rg = new Regex(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");

            if ((!rg.IsMatch(u.Email)))
            {
                throw new ExcecaoPadrao(Erros.EmailInvalido);
            }
         

            return DUsuario.Login(u);
        }
    }
}
