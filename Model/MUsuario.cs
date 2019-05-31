using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class MUsuario
    {
        public int? ID { get; set; }
        public String Nome { get; set; }
        public String Email { get; set; }
        public String Senha { get; set; }
        public String Situacao { get; set; }
        public int? FKTipoUsuarioID { get; set; }
    }
}
