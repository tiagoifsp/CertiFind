using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Serializable]
    public class MTipoAtividadeCampo
    {
        public int ID { get; set; }
        public int? CampoID { get; set; }
        public int? TipoAtividadeID { get; set; }
        public int? Tamanho { get; set; }
        public string ValorInicial { get; set; }
        public string ValorFinal { get; set; }
        public string CampoNome { get; set; }
        public string TipoAtividadeNome { get; set; }
    }
}
