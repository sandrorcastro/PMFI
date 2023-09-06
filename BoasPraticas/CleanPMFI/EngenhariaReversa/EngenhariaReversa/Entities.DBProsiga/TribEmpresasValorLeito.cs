using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class TribEmpresasValorLeito
    {
        public short LeitosId { get; set; }
        public int? LeitosDe { get; set; }
        public int? LeitosAte { get; set; }
        public decimal LeitosQtdeUfm { get; set; }
    }
}
