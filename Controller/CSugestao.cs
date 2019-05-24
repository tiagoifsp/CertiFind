using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public static class CSugestao
    {
        public static List<MTipoSugestao> BuscarTipo()
        {
            List<MTipoSugestao> retorno = DSugestao.BuscarTipo();
            //checagem retorno se necessário
            return retorno;
        }
    }
}
