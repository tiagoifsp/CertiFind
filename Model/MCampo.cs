using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Serializable]

    public class MCampo
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public int? TipoDado { get; set; }
        public string NomeTipoDado { get; set; }
    }
}

