using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Model
{
    public class MSugestao
    {
        public int ID { get; set; }
        public MTipoSugestao FKTipoSugestaoID { get; set; }
        public string Texto { get; set; }
        public DateTime DataEnvio { get; set; }
        public MUsuario FKUsuarioID { get; set; }
    }
}