using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Model
{
    public class MSugestao
    {
        public int? ID { get; set; }
        public int? FKTipoSugestaoID { get; set; }
        public string Texto { get; set; }
        public DateTime DataEnvio { get; set; }
        public int? FKUsuarioID { get; set; }

        public string NomeTipoSugestao { get; set; }
        public string NomeUsuario { get; set; }
    }
}