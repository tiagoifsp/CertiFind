using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;

namespace Controller
{
    public class CUsuario
    {
        public static bool Login(MUsuario u)
        {
            return DUsuario.Login(u);
        }
    }
}
