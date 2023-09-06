using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbIpmEventoRubrica
    {
        public int IdMovimento { get; set; }
        public string? IdEnvento { get; set; }
        public string? NmEvento { get; set; }
        public int? NrLei { get; set; }
        public string? FlRemessaContribuinte { get; set; }
        public string? FlRemessaEfetivo { get; set; }
        public string? FlProporcionaliza { get; set; }
        public string? DsTipo { get; set; }
        public string? DsTipoCalculo { get; set; }
    }
}
