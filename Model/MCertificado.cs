using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Serializable]
    public class MCertificado
    {
        public int ID { get; set; }
        public int? TipoAtividadeID { get; set; }
        public int? UsuarioID { get; set; }
        public string NomeAtividade { get; set; }
        public string NomeUsuario { get; set; }
    }
}
