using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiscalizacao.Model
{
    public class Imovel
    {
		public long InscricaoImobiliaria { get; set; }
		public string conNome { get; set; }
        public string ConEMail { get; set; }
        public string ConTelefoneCelular { get; set; }
        public string idDocumento { get; set; }
        public string dsTipoDocumento { get; set; }
        public string EdifCaracteristica { get; set; }

        public string EdifAreaCoberta { get; set; }

        public string EdifAreaConstruida { get; set; }
    }
}


