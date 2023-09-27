using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class TipoDocumento
    {
        public int IdTipoDocumento { get; set; }
        public string SiglaDoc { get; set; }
        public string Descricao { get; }


    }
}
