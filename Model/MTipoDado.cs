using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Serializable]

    public class MTipoDado
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
    }
}
