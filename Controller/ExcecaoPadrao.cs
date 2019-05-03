using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    /// <summary>
    /// Classe que deve ser utilizada para disparar exceções esperadas pelo sistema
    /// </summary>
    public class ExcecaoPadrao : Exception
    {
        public ExcecaoPadrao(string Mensagem) : base(Mensagem) { }
    }
}
