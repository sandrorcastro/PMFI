using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class TribCalcInf
    {
        public short AnoCalculo { get; set; }
        public long EdificacaoId { get; set; }
        public decimal? Aliquota { get; set; }
        public string? Vigesimo { get; set; }
        public string? UsuarioInclusao { get; set; }
    }
}
