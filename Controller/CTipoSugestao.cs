using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Controller
{
    public class CTipoSugestao
    {
        public static List<MTipoSugestao> BuscarTipo()
        {
            List<MTipoSugestao> retorno = DTipoSugestao.BuscarTipo();
            //checagem retorno se necessário
            return retorno;
        }
    }
}