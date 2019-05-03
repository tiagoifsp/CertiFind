using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Model
{
    public class MSugestao
    {
        public MTipoSugestao tipoSugestao;
        public string texto;
        public DateTime dataEnvio;
        public MUsuario usuario;
    }
}